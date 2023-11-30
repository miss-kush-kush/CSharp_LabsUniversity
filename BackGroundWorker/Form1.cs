using System.ComponentModel;
using System.Drawing.Drawing2D;
using static System.Net.Mime.MediaTypeNames;

namespace BackGroundWorker
{
    public partial class Form1 : Form
    {
        private bool isPaused = false;
        private int[,] matrixA;
        private int[,] matrixB;

        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int rowsMatrix1, colsMatrix1, rowsMatrix2, colsMatrix2;
            if (int.TryParse(txtRowsMatrix1.Text, out rowsMatrix1) &&
                int.TryParse(txtColsMatrix1.Text, out colsMatrix1) &&
                int.TryParse(txtRowsMatrix2.Text, out rowsMatrix2) &&
                int.TryParse(txtColsMatrix2.Text, out colsMatrix2))
            {
                if (colsMatrix1 != rowsMatrix2)
                {
                    MessageBox.Show("Invalid matrix dimensions. Columns of Matrix1 must be equal to Rows of Matrix2.");
                    return;
                }

                btnMultiply.Enabled = false;
                btnPause.Enabled = true;
                btnContinue.Enabled = false;
                btnStop.Enabled = true;

                matrixA = GenerateRandomMatrix(rowsMatrix1, colsMatrix1);
                DisplayMatrix(matrixA, txtMatrix1);
                matrixB = GenerateRandomMatrix(rowsMatrix2, colsMatrix2);
                DisplayMatrix(matrixB, txtMatrix2);

                backgroundWorker1.RunWorkerAsync(new MatrixDimensions(rowsMatrix1, colsMatrix1, rowsMatrix2, colsMatrix2));
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            isPaused = true;
            btnPause.Enabled = false;
            btnContinue.Enabled = true;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            isPaused = false;
            btnPause.Enabled = true;
            btnContinue.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            MatrixDimensions dimensions = (MatrixDimensions)e.Argument;

            int[,] resultMatrix = new int[dimensions.RowsMatrix1, dimensions.ColsMatrix2];

            int totalElements = dimensions.RowsMatrix1 * dimensions.ColsMatrix2;
            int processedElements = 0;

            for (int i = 0; i < dimensions.RowsMatrix1; i++)
            {
                for (int j = 0; j < dimensions.ColsMatrix2; j++)
                {
                    if (worker.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }

                    // Perform multiplication
                    resultMatrix[i, j] = 0;
                    for (int k = 0; k < dimensions.ColsMatrix1; k++)
                    {
                        resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                    }

                    processedElements++;

                    // Report progress
                    int progressPercentage = (int)((double)processedElements / totalElements * 100);
                    worker.ReportProgress(progressPercentage);

                    // Simulate some delay to see progress bar in action
                    Thread.Sleep(10);

                    // Check if paused
                    while (isPaused)
                    {
                        Thread.Sleep(100);
                    }
                }
            }

            // Assign the result to e.Result if needed
            e.Result = resultMatrix;
        }

        private int[,] GenerateRandomMatrix(int rows, int cols)
        {
            Random random = new Random();
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(0, 50); 
                }
            }
            
            return matrix;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Cancelled)
            {
                MessageBox.Show("Operation canceled");
            }
            else if(e.Error != null)
            {
                MessageBox.Show("Error occurred: " + e.Error.Message);
            }
            else
            {
                int[,] resultMatrix = (int[,])e.Result;
                DisplayMatrix(resultMatrix, txtResult);
                MessageBox.Show("Done");
            }
            btnMultiply.Enabled = true;
            btnPause.Enabled = false;
            btnContinue.Enabled = false;
            btnStop.Enabled = false;
        }

        private void DisplayMatrix(int[,]? matrix, TextBox textBox)
        {
            textBox.Clear();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    textBox.Text += matrix[i, j] + "\t";
                }
                textBox.Text += Environment.NewLine;
            }
        }
    }
}

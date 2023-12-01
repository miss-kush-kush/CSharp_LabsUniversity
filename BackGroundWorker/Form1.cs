using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace BackGroundWorker
{
    public partial class Form1 : Form
    {
        private bool isPaused = false;
        private readonly object lockObject = new object();
        private int[,] matrixA;
        private int[,] matrixB;

        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
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

                backgroundWorker1.RunWorkerAsync();
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
            progressBar1.Value = 0;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            int[,] resultMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

            worker.WorkerSupportsCancellation = true;
            int totalElements = matrixA.GetLength(0) * matrixB.GetLength(1);
            int processedElements = 0;

            Parallel.For(0, matrixA.GetLength(0), i =>
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    lock (lockObject)
                    {
                        if (worker.CancellationPending)
                        {
                            e.Cancel = true;
                            return;
                        }

                        // Perform multiplication
                        resultMatrix[i, j] = 0;
                        for (int k = 0; k < matrixA.GetLength(1); k++)
                        {
                            resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                        }

                        processedElements++;

                        // Report progress
                        int progressPercentage = (int)((double)processedElements / totalElements * 100);
                        worker.ReportProgress(progressPercentage);
                    }

                    // Check if paused
                    while (isPaused)
                    {
                        Thread.Sleep(100);
                    }
                }
            });

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
                    matrix[i, j] = random.Next(0, 5); 
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
            backgroundWorker1.WorkerSupportsCancellation = false;
        }

        private void DisplayMatrix(int[,]? matrix, TextBox textBox)
        {
            if (matrix == null) return;

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sb.Append(matrix[i, j] + "\t");
                }
                sb.AppendLine();
            }

            textBox.Invoke((Action)(() => textBox.Text = sb.ToString()));
        }
    }
}

namespace BackGroundWorker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMultiply = new Button();
            txtMatrix1 = new TextBox();
            txtMatrix2 = new TextBox();
            progressBar1 = new ProgressBar();
            btnPause = new Button();
            btnContinue = new Button();
            btnStop = new Button();
            label1 = new Label();
            label2 = new Label();
            txtResult = new TextBox();
            label3 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtRowsMatrix1 = new TextBox();
            txtColsMatrix1 = new TextBox();
            txtColsMatrix2 = new TextBox();
            txtRowsMatrix2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(893, 90);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(112, 34);
            btnMultiply.TabIndex = 0;
            btnMultiply.Text = "Multiply";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // txtMatrix1
            // 
            txtMatrix1.Location = new Point(22, 123);
            txtMatrix1.Multiline = true;
            txtMatrix1.Name = "txtMatrix1";
            txtMatrix1.Size = new Size(235, 235);
            txtMatrix1.TabIndex = 1;
            txtMatrix1.WordWrap = false;
            // 
            // txtMatrix2
            // 
            txtMatrix2.Location = new Point(306, 123);
            txtMatrix2.Multiline = true;
            txtMatrix2.Name = "txtMatrix2";
            txtMatrix2.Size = new Size(235, 235);
            txtMatrix2.TabIndex = 2;
            txtMatrix2.WordWrap = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(22, 382);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(983, 34);
            progressBar1.TabIndex = 3;
            // 
            // btnPause
            // 
            btnPause.Location = new Point(893, 159);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(112, 34);
            btnPause.TabIndex = 4;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // btnContinue
            // 
            btnContinue.Location = new Point(893, 227);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(112, 34);
            btnContinue.TabIndex = 5;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += btnContinue_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(893, 293);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(112, 34);
            btnStop.TabIndex = 6;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 46);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 7;
            label1.Text = "Matrix 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(380, 46);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 8;
            label2.Text = "Matrix 2";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(596, 123);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(235, 235);
            txtResult.TabIndex = 9;
            txtResult.WordWrap = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(670, 46);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 10;
            label3.Text = "Result";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // txtRowsMatrix1
            // 
            txtRowsMatrix1.Location = new Point(22, 86);
            txtRowsMatrix1.Name = "txtRowsMatrix1";
            txtRowsMatrix1.Size = new Size(107, 31);
            txtRowsMatrix1.TabIndex = 11;
            // 
            // txtColsMatrix1
            // 
            txtColsMatrix1.Location = new Point(150, 86);
            txtColsMatrix1.Name = "txtColsMatrix1";
            txtColsMatrix1.Size = new Size(107, 31);
            txtColsMatrix1.TabIndex = 12;
            // 
            // txtColsMatrix2
            // 
            txtColsMatrix2.Location = new Point(434, 86);
            txtColsMatrix2.Name = "txtColsMatrix2";
            txtColsMatrix2.Size = new Size(107, 31);
            txtColsMatrix2.TabIndex = 14;
            // 
            // txtRowsMatrix2
            // 
            txtRowsMatrix2.Location = new Point(306, 86);
            txtRowsMatrix2.Name = "txtRowsMatrix2";
            txtRowsMatrix2.Size = new Size(107, 31);
            txtRowsMatrix2.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 58);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 15;
            label4.Text = "rows";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(306, 58);
            label5.Name = "label5";
            label5.Size = new Size(50, 25);
            label5.TabIndex = 16;
            label5.Text = "rows";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(207, 58);
            label6.Name = "label6";
            label6.Size = new Size(43, 25);
            label6.TabIndex = 17;
            label6.Text = "cols";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(498, 58);
            label7.Name = "label7";
            label7.Size = new Size(43, 25);
            label7.TabIndex = 18;
            label7.Text = "cols";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtColsMatrix2);
            Controls.Add(txtRowsMatrix2);
            Controls.Add(txtColsMatrix1);
            Controls.Add(txtRowsMatrix1);
            Controls.Add(label3);
            Controls.Add(txtResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnStop);
            Controls.Add(btnContinue);
            Controls.Add(btnPause);
            Controls.Add(progressBar1);
            Controls.Add(txtMatrix2);
            Controls.Add(txtMatrix1);
            Controls.Add(btnMultiply);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMultiply;
        private TextBox txtMatrix1;
        private TextBox txtMatrix2;
        private ProgressBar progressBar1;
        private Button btnPause;
        private Button btnContinue;
        private Button btnStop;
        private Label label1;
        private Label label2;
        private TextBox txtResult;
        private Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtRowsMatrix1;
        private TextBox txtColsMatrix1;
        private TextBox txtColsMatrix2;
        private TextBox txtRowsMatrix2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}

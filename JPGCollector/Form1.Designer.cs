namespace JPGCollector
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
            folderBrowserDialog1 = new FolderBrowserDialog();
            label1 = new Label();
            txtBox_begin = new TextBox();
            txtBox_save = new TextBox();
            label2 = new Label();
            OpenSave_btn = new Button();
            OpenBegin_btn = new Button();
            Transfer_btn = new Button();
            folderBrowserDialog2 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 97);
            label1.Name = "label1";
            label1.Size = new Size(106, 75);
            label1.TabIndex = 0;
            label1.Text = "Directory \r\nto begin \r\nsearch from";
            // 
            // txtBox_begin
            // 
            txtBox_begin.Location = new Point(308, 119);
            txtBox_begin.Name = "txtBox_begin";
            txtBox_begin.Size = new Size(492, 31);
            txtBox_begin.TabIndex = 1;
            // 
            // txtBox_save
            // 
            txtBox_save.Location = new Point(308, 247);
            txtBox_save.Name = "txtBox_save";
            txtBox_save.Size = new Size(492, 31);
            txtBox_save.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 247);
            label2.Name = "label2";
            label2.Size = new Size(111, 50);
            label2.TabIndex = 3;
            label2.Text = "Directory to \r\nsave JPGs";
            // 
            // OpenSave_btn
            // 
            OpenSave_btn.Location = new Point(846, 247);
            OpenSave_btn.Name = "OpenSave_btn";
            OpenSave_btn.Size = new Size(112, 34);
            OpenSave_btn.TabIndex = 4;
            OpenSave_btn.Text = "Open";
            OpenSave_btn.UseVisualStyleBackColor = true;
            OpenSave_btn.Click += OpenSave_btn_Click;
            // 
            // OpenBegin_btn
            // 
            OpenBegin_btn.Location = new Point(846, 119);
            OpenBegin_btn.Name = "OpenBegin_btn";
            OpenBegin_btn.Size = new Size(112, 34);
            OpenBegin_btn.TabIndex = 5;
            OpenBegin_btn.Text = "Open";
            OpenBegin_btn.UseVisualStyleBackColor = true;
            OpenBegin_btn.Click += OpenBegin_btn_Click;
            // 
            // Transfer_btn
            // 
            Transfer_btn.Location = new Point(846, 371);
            Transfer_btn.Name = "Transfer_btn";
            Transfer_btn.Size = new Size(112, 34);
            Transfer_btn.TabIndex = 6;
            Transfer_btn.Text = "Transfer";
            Transfer_btn.UseVisualStyleBackColor = true;
            Transfer_btn.Click += Transfer_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 682);
            Controls.Add(Transfer_btn);
            Controls.Add(OpenBegin_btn);
            Controls.Add(OpenSave_btn);
            Controls.Add(label2);
            Controls.Add(txtBox_save);
            Controls.Add(txtBox_begin);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private Label label1;
        private TextBox txtBox_begin;
        private TextBox txtBox_save;
        private Label label2;
        private Button OpenSave_btn;
        private Button OpenBegin_btn;
        private Button Transfer_btn;
        private FolderBrowserDialog folderBrowserDialog2;
    }
}
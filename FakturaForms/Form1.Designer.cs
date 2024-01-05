namespace FakturaForms
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
            Print_btn = new Button();
            Add_btn = new Button();
            Update_btn = new Button();
            Delete_btn = new Button();
            SuspendLayout();
            // 
            // Print_btn
            // 
            Print_btn.Location = new Point(52, 45);
            Print_btn.Name = "Print_btn";
            Print_btn.Size = new Size(112, 34);
            Print_btn.TabIndex = 0;
            Print_btn.Text = "Print";
            Print_btn.UseVisualStyleBackColor = true;
            Print_btn.Click += Print_btn_Click;
            // 
            // Add_btn
            // 
            Add_btn.Location = new Point(52, 130);
            Add_btn.Name = "Add_btn";
            Add_btn.Size = new Size(112, 34);
            Add_btn.TabIndex = 1;
            Add_btn.Text = "Add";
            Add_btn.UseVisualStyleBackColor = true;
            Add_btn.Click += Add_btn_Click;
            // 
            // Update_btn
            // 
            Update_btn.Location = new Point(209, 45);
            Update_btn.Name = "Update_btn";
            Update_btn.Size = new Size(112, 34);
            Update_btn.TabIndex = 2;
            Update_btn.Text = "Update";
            Update_btn.UseVisualStyleBackColor = true;
            Update_btn.Click += Update_btn_Click;
            // 
            // Delete_btn
            // 
            Delete_btn.Location = new Point(209, 130);
            Delete_btn.Name = "Delete_btn";
            Delete_btn.Size = new Size(112, 34);
            Delete_btn.TabIndex = 3;
            Delete_btn.Text = "Delete";
            Delete_btn.UseVisualStyleBackColor = true;
            Delete_btn.Click += Delete_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 225);
            Controls.Add(Delete_btn);
            Controls.Add(Update_btn);
            Controls.Add(Add_btn);
            Controls.Add(Print_btn);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Print_btn;
        private Button Add_btn;
        private Button Update_btn;
        private Button Delete_btn;
    }
}

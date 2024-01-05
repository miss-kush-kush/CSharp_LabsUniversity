namespace FakturaForms
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            IdFak_txt = new TextBox();
            DeleteFak_btn = new Button();
            label2 = new Label();
            IdPoz_txt = new TextBox();
            DeletePoz_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 44);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 11;
            label1.Text = "Id";
            // 
            // IdFak_txt
            // 
            IdFak_txt.Location = new Point(101, 44);
            IdFak_txt.Name = "IdFak_txt";
            IdFak_txt.Size = new Size(66, 31);
            IdFak_txt.TabIndex = 8;
            // 
            // DeleteFak_btn
            // 
            DeleteFak_btn.Location = new Point(55, 132);
            DeleteFak_btn.Name = "DeleteFak_btn";
            DeleteFak_btn.Size = new Size(131, 34);
            DeleteFak_btn.TabIndex = 7;
            DeleteFak_btn.Text = "DeleteFaktura";
            DeleteFak_btn.UseVisualStyleBackColor = true;
            DeleteFak_btn.Click += Delete_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(365, 44);
            label2.Name = "label2";
            label2.Size = new Size(28, 25);
            label2.TabIndex = 14;
            label2.Text = "Id";
            // 
            // IdPoz_txt
            // 
            IdPoz_txt.Location = new Point(411, 44);
            IdPoz_txt.Name = "IdPoz_txt";
            IdPoz_txt.Size = new Size(66, 31);
            IdPoz_txt.TabIndex = 13;
            // 
            // DeletePoz_btn
            // 
            DeletePoz_btn.Location = new Point(365, 132);
            DeletePoz_btn.Name = "DeletePoz_btn";
            DeletePoz_btn.Size = new Size(136, 34);
            DeletePoz_btn.TabIndex = 12;
            DeletePoz_btn.Text = "DeletePozycja";
            DeletePoz_btn.UseVisualStyleBackColor = true;
            DeletePoz_btn.Click += DeletePoz_btn_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 268);
            Controls.Add(label2);
            Controls.Add(IdPoz_txt);
            Controls.Add(DeletePoz_btn);
            Controls.Add(label1);
            Controls.Add(IdFak_txt);
            Controls.Add(DeleteFak_btn);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox IdFak_txt;
        private Button DeleteFak_btn;
        private Label label2;
        private TextBox IdPoz_txt;
        private Button DeletePoz_btn;
    }
}
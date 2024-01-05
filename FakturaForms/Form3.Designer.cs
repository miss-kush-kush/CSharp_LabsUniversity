namespace FakturaForms
{
    partial class Form3
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
            FakUpdate_btn = new Button();
            Id_txt = new TextBox();
            Numer_txt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Nazwa_txt = new TextBox();
            PozId_txt = new TextBox();
            PozUpdate_btn = new Button();
            label5 = new Label();
            FakId_txt = new TextBox();
            label6 = new Label();
            Wartosc_txt = new TextBox();
            SuspendLayout();
            // 
            // FakUpdate_btn
            // 
            FakUpdate_btn.Location = new Point(161, 321);
            FakUpdate_btn.Name = "FakUpdate_btn";
            FakUpdate_btn.Size = new Size(112, 34);
            FakUpdate_btn.TabIndex = 0;
            FakUpdate_btn.Text = "Update";
            FakUpdate_btn.UseVisualStyleBackColor = true;
            FakUpdate_btn.Click += Update_btn_Click;
            // 
            // Id_txt
            // 
            Id_txt.Location = new Point(221, 37);
            Id_txt.Name = "Id_txt";
            Id_txt.Size = new Size(150, 31);
            Id_txt.TabIndex = 1;
            // 
            // Numer_txt
            // 
            Numer_txt.Location = new Point(221, 114);
            Numer_txt.Name = "Numer_txt";
            Numer_txt.Size = new Size(150, 31);
            Numer_txt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 37);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 4;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 114);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 5;
            label2.Text = "Numer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(490, 117);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 10;
            label3.Text = "Nazwa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(490, 40);
            label4.Name = "label4";
            label4.Size = new Size(28, 25);
            label4.TabIndex = 9;
            label4.Text = "Id";
            // 
            // Nazwa_txt
            // 
            Nazwa_txt.Location = new Point(615, 117);
            Nazwa_txt.Name = "Nazwa_txt";
            Nazwa_txt.Size = new Size(150, 31);
            Nazwa_txt.TabIndex = 8;
            // 
            // PozId_txt
            // 
            PozId_txt.Location = new Point(615, 40);
            PozId_txt.Name = "PozId_txt";
            PozId_txt.Size = new Size(150, 31);
            PozId_txt.TabIndex = 7;
            // 
            // PozUpdate_btn
            // 
            PozUpdate_btn.Location = new Point(555, 324);
            PozUpdate_btn.Name = "PozUpdate_btn";
            PozUpdate_btn.Size = new Size(112, 34);
            PozUpdate_btn.TabIndex = 6;
            PozUpdate_btn.Text = "Update";
            PozUpdate_btn.UseVisualStyleBackColor = true;
            PozUpdate_btn.Click += PozUpdate_btn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(490, 192);
            label5.Name = "label5";
            label5.Size = new Size(85, 25);
            label5.TabIndex = 12;
            label5.Text = "FakturaId";
            // 
            // FakId_txt
            // 
            FakId_txt.Location = new Point(615, 192);
            FakId_txt.Name = "FakId_txt";
            FakId_txt.Size = new Size(150, 31);
            FakId_txt.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(490, 263);
            label6.Name = "label6";
            label6.Size = new Size(76, 25);
            label6.TabIndex = 14;
            label6.Text = "Wartosc";
            // 
            // Wartosc_txt
            // 
            Wartosc_txt.Location = new Point(615, 263);
            Wartosc_txt.Name = "Wartosc_txt";
            Wartosc_txt.Size = new Size(150, 31);
            Wartosc_txt.TabIndex = 13;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 417);
            Controls.Add(label6);
            Controls.Add(Wartosc_txt);
            Controls.Add(label5);
            Controls.Add(FakId_txt);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(Nazwa_txt);
            Controls.Add(PozId_txt);
            Controls.Add(PozUpdate_btn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Numer_txt);
            Controls.Add(Id_txt);
            Controls.Add(FakUpdate_btn);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FakUpdate_btn;
        private TextBox Id_txt;
        private TextBox Numer_txt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Nazwa_txt;
        private TextBox PozId_txt;
        private Button PozUpdate_btn;
        private Label label5;
        private TextBox FakId_txt;
        private Label label6;
        private TextBox Wartosc_txt;
    }
}
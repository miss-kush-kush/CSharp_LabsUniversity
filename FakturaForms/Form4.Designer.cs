namespace FakturaForms
{
    partial class Form4
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
            label2 = new Label();
            Numer_txt = new TextBox();
            AddFaktura_btn = new Button();
            label1 = new Label();
            label4 = new Label();
            PozWartosc_txt = new TextBox();
            Nazwa_txt = new TextBox();
            AddPozycja_btn = new Button();
            label5 = new Label();
            FakId_txt = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 146);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 12;
            label2.Text = "Numer";
            // 
            // Numer_txt
            // 
            Numer_txt.Location = new Point(182, 146);
            Numer_txt.Name = "Numer_txt";
            Numer_txt.Size = new Size(150, 31);
            Numer_txt.TabIndex = 9;
            // 
            // AddFaktura_btn
            // 
            AddFaktura_btn.Location = new Point(120, 303);
            AddFaktura_btn.Name = "AddFaktura_btn";
            AddFaktura_btn.Size = new Size(112, 34);
            AddFaktura_btn.TabIndex = 7;
            AddFaktura_btn.Text = "AddFaktura";
            AddFaktura_btn.UseVisualStyleBackColor = true;
            AddFaktura_btn.Click += Add_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(425, 170);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 18;
            label1.Text = "Wartosc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(425, 96);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 17;
            label4.Text = "Nazwa";
            // 
            // PozWartosc_txt
            // 
            PozWartosc_txt.Location = new Point(550, 170);
            PozWartosc_txt.Name = "PozWartosc_txt";
            PozWartosc_txt.Size = new Size(150, 31);
            PozWartosc_txt.TabIndex = 16;
            // 
            // Nazwa_txt
            // 
            Nazwa_txt.Location = new Point(550, 96);
            Nazwa_txt.Name = "Nazwa_txt";
            Nazwa_txt.Size = new Size(150, 31);
            Nazwa_txt.TabIndex = 15;
            // 
            // AddPozycja_btn
            // 
            AddPozycja_btn.Location = new Point(490, 303);
            AddPozycja_btn.Name = "AddPozycja_btn";
            AddPozycja_btn.Size = new Size(112, 34);
            AddPozycja_btn.TabIndex = 14;
            AddPozycja_btn.Text = "AddPozycje";
            AddPozycja_btn.UseVisualStyleBackColor = true;
            AddPozycja_btn.Click += AddPozycja_btn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(425, 39);
            label5.Name = "label5";
            label5.Size = new Size(85, 25);
            label5.TabIndex = 20;
            label5.Text = "FakturaId";
            // 
            // FakId_txt
            // 
            FakId_txt.Location = new Point(550, 39);
            FakId_txt.Name = "FakId_txt";
            FakId_txt.Size = new Size(150, 31);
            FakId_txt.TabIndex = 19;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(FakId_txt);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(PozWartosc_txt);
            Controls.Add(Nazwa_txt);
            Controls.Add(AddPozycja_btn);
            Controls.Add(label2);
            Controls.Add(Numer_txt);
            Controls.Add(AddFaktura_btn);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox Numer_txt;
        private Button AddFaktura_btn;
        private Label label1;
        private Label label4;
        private TextBox PozWartosc_txt;
        private TextBox Nazwa_txt;
        private Button AddPozycja_btn;
        private Label label5;
        private TextBox FakId_txt;
    }
}
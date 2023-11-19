namespace DataBase
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
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbName = new TextBox();
            tbSurname = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnSubmit = new Button();
            btnDelete = new Button();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(437, 37);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(319, 354);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 24);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 113);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 2;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 205);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 3;
            label3.Text = "Date of Birth";
            // 
            // tbName
            // 
            tbName.Location = new Point(25, 63);
            tbName.Name = "tbName";
            tbName.Size = new Size(300, 31);
            tbName.TabIndex = 4;
            // 
            // tbSurname
            // 
            tbSurname.Location = new Point(25, 151);
            tbSurname.Name = "tbSurname";
            tbSurname.Size = new Size(300, 31);
            tbSurname.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(25, 249);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.Value = new DateTime(2023, 11, 16, 15, 2, 51, 0);
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(44, 463);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(206, 463);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(38, 48);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(93, 29);
            rbFemale.TabIndex = 10;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(181, 48);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(75, 29);
            rbMale.TabIndex = 11;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Controls.Add(rbMale);
            groupBox1.Location = new Point(25, 314);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 104);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gender";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 559);
            Controls.Add(groupBox1);
            Controls.Add(btnDelete);
            Controls.Add(btnSubmit);
            Controls.Add(dateTimePicker1);
            Controls.Add(tbSurname);
            Controls.Add(tbName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbName;
        private TextBox tbSurname;
        private DateTimePicker dateTimePicker1;
        private Button btnSubmit;
        private Button btnDelete;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private GroupBox groupBox1;
    }
}
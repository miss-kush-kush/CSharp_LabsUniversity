using System.Windows.Forms;

namespace JPGCollector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenBegin_btn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string folder_begin_path = folderBrowserDialog1.SelectedPath; 
                txtBox_begin.Text = folder_begin_path;
            }
        }

        private void OpenSave_btn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                string folder_save_path = folderBrowserDialog2.SelectedPath;
                txtBox_save.Text = folder_save_path;
            }
        }

        private void Transfer_btn_Click(object sender, EventArgs e)
        {
            string folder_begin_path = txtBox_begin.Text;
            string folder_save_path = txtBox_save.Text;

            Functions.MoveAndRenameJpgFiles(folder_begin_path, folder_save_path);
            MessageBox.Show("Files copied and renamed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
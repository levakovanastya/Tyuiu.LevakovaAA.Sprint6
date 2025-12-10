using System;
using System.Windows.Forms;
using Tyuiu.LevakovaAA.Sprint6.Task6.V10.Lib;
namespace Tyuiu.LevakovaAA.Sprint6.Task6.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string OpenFilePath;
        DataService ds = new DataService();

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialogTask.ShowDialog();
            OpenFilePath = OpenFileDialogTask.FileName;
            textBoxLoadFromFile.Text = File.ReadAllText(OpenFilePath);
            groupBoxOutPutData.Text = groupBoxOutPutData.Text + " " + OpenFileDialogTask.FileName;
            buttonDone.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            string str = "**";
            textBoxResult.Text = ds.CollectTextFromFile(OpenFilePath);
        }

        private void buttonSpravka_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void OpenFileDialogTask_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}

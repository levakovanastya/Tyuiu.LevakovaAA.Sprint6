using System;
using System.Windows.Forms;
using Tyuiu.LevakovaAA.Sprint6.Task1.V26.Lib;
namespace Tyuiu.LevakovaAA.Sprint6.Task1.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartValue.Text);
                int stopStep = Convert.ToInt32(textBoxStopValue.Text);
                string strline;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep,stopStep);
                textBoxResult.Text = "";
                textBoxResult.AppendText("+-------+-------+" + Environment.NewLine);
                textBoxResult.AppendText("|    X      |   F(x)    |" + Environment.NewLine);
                textBoxResult.AppendText("+-------+-------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strline = string.Format("| {0,5:d}    |   {1,5:f2}   |", startStep, valueArray[i]);
                    textBoxResult.AppendText(strline + Environment.NewLine);
                    startStep++;
                }
                textBoxResult.AppendText("+-------+-------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

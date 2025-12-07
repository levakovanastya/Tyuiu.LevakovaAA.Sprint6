using System;
using System.Windows.Forms;
using Tyuiu.LevakovaAA.Sprint6.Task2.V24.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.LevakovaAA.Sprint6.Task2.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonSpravka_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы СМАРТб-25-1 Левакова Анастасия Александровна", "Сообщение");
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartValue.Text);
                int stopStep = Convert.ToInt32(textBoxStopValue.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult.Text = "";
                textBoxResult.AppendText("+-------+-------+" + Environment.NewLine);
                textBoxResult.AppendText("|    X      |   F(x)    |" + Environment.NewLine);
                textBoxResult.AppendText("+-------+-------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    string strline = string.Format("| {0,5:d}    |   {1,5:f2}   |", startStep, valueArray[i]);
                    textBoxResult.AppendText(strline + Environment.NewLine);
                    startStep++;
                }
                textBoxResult.AppendText("+-------+-------+" + Environment.NewLine);

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone.BackColor = Color.Green;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.HotPink;
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Red;
        }
    }
}

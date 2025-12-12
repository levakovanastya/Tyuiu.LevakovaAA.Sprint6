using System;
using System.Windows.Forms;
using Tyuiu.LevakovaAA.Sprint6.Task5.V29.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.LevakovaAA.Sprint6.Task5.V29
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        string path = @"C:\Users\levak\Desktop\repos\Tyuiu.LevakovaAA.Sprint6\Tyuiu.LevakovaAA.Sprint6.Task5.V29\bin\Debug\net8.0-windows\InPutDataFileTask5V29.txt";
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path))
            {
                MessageBox.Show($"Файл не найден: {path}");
                return;
            }
            dataGridViewNums.ColumnCount = 2;
            dataGridViewNums.Columns[0].Width = 20;
            dataGridViewNums.Columns[1].Width = 50;
            this.ChartDiag.ChartAreas[0].AxisX.Title = "Ось X";
            this.ChartDiag.ChartAreas[0].AxisY.Title = "Ось Y";
            ChartDiag.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                ChartDiag.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonSpravka_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы СМАРТб-25-1 Левакова Анастасия Александровна", "Сообщение");
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void ChartDiag_Click(object sender, EventArgs e)
        {

        }
    }
}

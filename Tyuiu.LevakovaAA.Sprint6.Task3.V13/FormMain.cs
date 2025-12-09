using System;
using System.Windows.Forms;
using Tyuiu.LevakovaAA.Sprint6.Task3.V13.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.LevakovaAA.Sprint6.Task3.V13
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { -7, 34, -2, 25, 5 }, { -16, -12, 30, -3, 17 }, { 3, -15, 12, 5, -5 }, { 17, 22, -3, 32, -11 }, { 9, 28, 1, -9, -2 } };

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(ds.Calculate(mtrx));
        }
        private void buttonSpravka_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы СМАРТб-25-1 Левакова Анастасия Александровна", "Сообщение");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0)+1;
            int columns = mtrx.Length / rows;
            dataGridViewMatrix.ColumnCount = columns;
            dataGridViewMatrix.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 25;
            }
            for (int i = 0;i < rows; i++)
            {
                for (int j = 0;j < columns; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i,j]);
                }
                
            }
        }
    }
}

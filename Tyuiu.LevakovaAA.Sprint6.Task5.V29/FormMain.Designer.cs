
namespace Tyuiu.LevakovaAA.Sprint6.Task5.V29
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            buttonSpravka = new Button();
            buttonOpenFile = new Button();
            buttonDone = new Button();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            dataGridViewNums = new DataGridView();
            ChartDiag = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChartDiag).BeginInit();
            SuspendLayout();
            // 
            // buttonSpravka
            // 
            buttonSpravka.BackColor = Color.LightSkyBlue;
            buttonSpravka.Location = new Point(812, 12);
            buttonSpravka.Name = "buttonSpravka";
            buttonSpravka.Size = new Size(100, 62);
            buttonSpravka.TabIndex = 0;
            buttonSpravka.Text = "Справка";
            buttonSpravka.UseVisualStyleBackColor = false;
            buttonSpravka.Click += buttonSpravka_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.BackColor = Color.CornflowerBlue;
            buttonOpenFile.Location = new Point(695, 12);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(111, 62);
            buttonOpenFile.TabIndex = 1;
            buttonOpenFile.Text = "Открыть файл";
            buttonOpenFile.UseVisualStyleBackColor = false;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.LightGreen;
            buttonDone.Location = new Point(580, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(109, 60);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(14, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(557, 110);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 25);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(557, 85);
            textBox1.TabIndex = 0;
            textBox1.Text = "Прочитать данные из файла InPutFileTask5V29.txt. Вывести в dataGridView. Вывести все числа, больше или равные 10. Построить диаграмму по этим значениям. ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewNums);
            groupBox2.Location = new Point(14, 135);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(180, 369);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // dataGridViewNums
            // 
            dataGridViewNums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums.Location = new Point(0, 23);
            dataGridViewNums.Name = "dataGridViewNums";
            dataGridViewNums.RowHeadersWidth = 51;
            dataGridViewNums.Size = new Size(180, 350);
            dataGridViewNums.TabIndex = 0;
            // 
            // ChartDiag
            // 
            chartArea1.Name = "ChartArea1";
            ChartDiag.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            ChartDiag.Legends.Add(legend1);
            ChartDiag.Location = new Point(205, 135);
            ChartDiag.Name = "ChartDiag";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            ChartDiag.Series.Add(series1);
            ChartDiag.Size = new Size(697, 368);
            ChartDiag.TabIndex = 5;
            ChartDiag.Text = "chart1";
            ChartDiag.Click += ChartDiag_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 512);
            Controls.Add(ChartDiag);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(buttonDone);
            Controls.Add(buttonOpenFile);
            Controls.Add(buttonSpravka);
            Name = "FormMain";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 29 | Левакова А.А.";
            Load += FormMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChartDiag).EndInit();
            ResumeLayout(false);
        }

        private void buttonDone_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button buttonSpravka;
        private Button buttonOpenFile;
        private Button buttonDone;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridViewNums;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartDiag;
    }
}

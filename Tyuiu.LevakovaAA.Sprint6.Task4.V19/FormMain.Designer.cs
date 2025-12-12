namespace Tyuiu.LevakovaAA.Sprint6.Task4.V19
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            buttonSpravka = new Button();
            buttonSave = new Button();
            buttonDone = new Button();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            textBoxStopValue = new TextBox();
            groupBox3 = new GroupBox();
            textBoxStartValue = new TextBox();
            groupBox5 = new GroupBox();
            textBoxResult = new TextBox();
            ChartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            panel2 = new Panel();
            splitter1 = new Splitter();
            panel3 = new Panel();
            panel4 = new Panel();
            splitter2 = new Splitter();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ChartFunction).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSpravka
            // 
            buttonSpravka.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSpravka.BackColor = Color.CornflowerBlue;
            buttonSpravka.Location = new Point(1015, 33);
            buttonSpravka.Name = "buttonSpravka";
            buttonSpravka.Size = new Size(77, 55);
            buttonSpravka.TabIndex = 0;
            buttonSpravka.Text = "Справка";
            buttonSpravka.UseVisualStyleBackColor = false;
            buttonSpravka.Click += buttonSpravka_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.LightSkyBlue;
            buttonSave.Location = new Point(901, 33);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(96, 55);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.LightGreen;
            buttonDone.Location = new Point(779, 33);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(116, 55);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Location = new Point(0, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 139);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = " Условие";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(3, 23);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(445, 115);
            textBox3.TabIndex = 0;
            textBox3.Text = "Протабулировать функцию F(x) на заданном диапазоне [-5; 5].\r\nРезультат вывести в textBox, построить график функции и сохранить\r\nв файл OutPutFileTask4V19.txt по нажатию кнопки. \r\n";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(458, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(310, 107);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBoxStopValue);
            groupBox4.Location = new Point(167, 35);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(135, 61);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Конец шага";
            // 
            // textBoxStopValue
            // 
            textBoxStopValue.Location = new Point(0, 31);
            textBoxStopValue.Name = "textBoxStopValue";
            textBoxStopValue.Size = new Size(135, 27);
            textBoxStopValue.TabIndex = 0;
            textBoxStopValue.Text = "5";
            textBoxStopValue.TextChanged += textBox2_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxStartValue);
            groupBox3.Location = new Point(14, 35);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(142, 59);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Старт шага";
            // 
            // textBoxStartValue
            // 
            textBoxStartValue.Location = new Point(0, 31);
            textBoxStartValue.Name = "textBoxStartValue";
            textBoxStartValue.Size = new Size(142, 27);
            textBoxStartValue.TabIndex = 0;
            textBoxStartValue.Text = "-5";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBoxResult);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Location = new Point(0, 0);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(248, 409);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Вывод";
            // 
            // textBoxResult
            // 
            textBoxResult.Dock = DockStyle.Fill;
            textBoxResult.Location = new Point(3, 23);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(242, 383);
            textBoxResult.TabIndex = 0;
            // 
            // ChartFunction
            // 
            chartArea1.Name = "ChartArea1";
            ChartFunction.ChartAreas.Add(chartArea1);
            ChartFunction.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            ChartFunction.Legends.Add(legend1);
            ChartFunction.Location = new Point(0, 0);
            ChartFunction.Name = "ChartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            ChartFunction.Series.Add(series1);
            ChartFunction.Size = new Size(862, 409);
            ChartFunction.TabIndex = 6;
            ChartFunction.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "График функции F(x)";
            ChartFunction.Titles.Add(title1);
            ChartFunction.Click += ChartFunction_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(buttonDone);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonSpravka);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1114, 152);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Location = new Point(2, 150);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 401);
            panel2.TabIndex = 5;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 152);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 409);
            splitter1.TabIndex = 8;
            splitter1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox5);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(4, 152);
            panel3.Name = "panel3";
            panel3.Size = new Size(248, 409);
            panel3.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.Controls.Add(splitter2);
            panel4.Controls.Add(ChartFunction);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(252, 152);
            panel4.Name = "panel4";
            panel4.Size = new Size(862, 409);
            panel4.TabIndex = 10;
            // 
            // splitter2
            // 
            splitter2.Location = new Point(0, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(4, 409);
            splitter2.TabIndex = 7;
            splitter2.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 561);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(splitter1);
            Controls.Add(panel1);
            MinimumSize = new Size(1132, 608);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 19 | Левакова А.А.";
            Load += FormMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ChartFunction).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSpravka;
        private Button buttonSave;
        private Button buttonDone;
        private GroupBox groupBox1;
        private TextBox textBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private TextBox textBoxStopValue;
        private GroupBox groupBox3;
        private TextBox textBoxStartValue;
        private GroupBox groupBox5;
        private TextBox textBoxResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartFunction;
        private Panel panel1;
        private Panel panel2;
        private Splitter splitter1;
        private Panel panel3;
        private Panel panel4;
        private Splitter splitter2;
    }
}

using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.LevakovaAA.Sprint6.Task2.V24
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
            groupBoxCondition = new GroupBox();
            textBoxTask = new TextBox();
            groupBoxVivod = new GroupBox();
            groupBoxRes = new GroupBox();
            dataGridViewFunction = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ChartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxVvod = new GroupBox();
            groupBoxStop = new GroupBox();
            textBoxStopValue = new TextBox();
            textBoxStartValue = new TextBox();
            groupBoxStart = new GroupBox();
            buttonSpravka = new Button();
            buttonDone = new Button();
            groupBoxCondition.SuspendLayout();
            groupBoxVivod.SuspendLayout();
            groupBoxRes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChartFunction).BeginInit();
            groupBoxVvod.SuspendLayout();
            groupBoxStop.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(textBoxTask);
            groupBoxCondition.Location = new Point(27, 24);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(480, 294);
            groupBoxCondition.TabIndex = 2;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(0, 31);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(481, 264);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Протабулировать функцию F(x) на заданном диапазоне. Результат вывести в виде таблицы";
            // 
            // groupBoxVivod
            // 
            groupBoxVivod.Controls.Add(groupBoxRes);
            groupBoxVivod.Location = new Point(548, 32);
            groupBoxVivod.Name = "groupBoxVivod";
            groupBoxVivod.Size = new Size(618, 393);
            groupBoxVivod.TabIndex = 3;
            groupBoxVivod.TabStop = false;
            groupBoxVivod.Text = "Вывод данных";
            // 
            // groupBoxRes
            // 
            groupBoxRes.Controls.Add(dataGridViewFunction);
            groupBoxRes.Controls.Add(ChartFunction);
            groupBoxRes.Location = new Point(0, 27);
            groupBoxRes.Name = "groupBoxRes";
            groupBoxRes.Size = new Size(618, 366);
            groupBoxRes.TabIndex = 0;
            groupBoxRes.TabStop = false;
            groupBoxRes.Text = "Результат";
            // 
            // dataGridViewFunction
            // 
            dataGridViewFunction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewFunction.Location = new Point(18, 29);
            dataGridViewFunction.Name = "dataGridViewFunction";
            dataGridViewFunction.RowHeadersVisible = false;
            dataGridViewFunction.RowHeadersWidth = 51;
            dataGridViewFunction.Size = new Size(194, 324);
            dataGridViewFunction.TabIndex = 2;
            dataGridViewFunction.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 60;
            // 
            // Column2
            // 
            Column2.HeaderText = "F(X)";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 60;
            // 
            // ChartFunction
            // 
            chartArea1.Name = "ChartArea1";
            ChartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            ChartFunction.Legends.Add(legend1);
            ChartFunction.Location = new Point(224, 30);
            ChartFunction.Name = "ChartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            ChartFunction.Series.Add(series1);
            ChartFunction.Size = new Size(394, 323);
            ChartFunction.TabIndex = 1;
            ChartFunction.Text = "chart1";
            // 
            // groupBoxVvod
            // 
            groupBoxVvod.Controls.Add(groupBoxStop);
            groupBoxVvod.Controls.Add(textBoxStartValue);
            groupBoxVvod.Controls.Add(groupBoxStart);
            groupBoxVvod.Location = new Point(36, 337);
            groupBoxVvod.Name = "groupBoxVvod";
            groupBoxVvod.Size = new Size(287, 88);
            groupBoxVvod.TabIndex = 4;
            groupBoxVvod.TabStop = false;
            groupBoxVvod.Text = "Ввод данных";
            // 
            // groupBoxStop
            // 
            groupBoxStop.Controls.Add(textBoxStopValue);
            groupBoxStop.Location = new Point(149, 26);
            groupBoxStop.Name = "groupBoxStop";
            groupBoxStop.Size = new Size(138, 59);
            groupBoxStop.TabIndex = 3;
            groupBoxStop.TabStop = false;
            groupBoxStop.Text = "Конец шага";
            // 
            // textBoxStopValue
            // 
            textBoxStopValue.Location = new Point(0, 26);
            textBoxStopValue.Name = "textBoxStopValue";
            textBoxStopValue.ReadOnly = true;
            textBoxStopValue.Size = new Size(130, 27);
            textBoxStopValue.TabIndex = 1;
            textBoxStopValue.Text = "5";
            // 
            // textBoxStartValue
            // 
            textBoxStartValue.Location = new Point(6, 53);
            textBoxStartValue.Name = "textBoxStartValue";
            textBoxStartValue.ReadOnly = true;
            textBoxStartValue.Size = new Size(137, 27);
            textBoxStartValue.TabIndex = 0;
            textBoxStartValue.Text = "-5";
            // 
            // groupBoxStart
            // 
            groupBoxStart.Location = new Point(0, 26);
            groupBoxStart.Name = "groupBoxStart";
            groupBoxStart.Size = new Size(146, 59);
            groupBoxStart.TabIndex = 2;
            groupBoxStart.TabStop = false;
            groupBoxStart.Text = "Старт шага";
            // 
            // buttonSpravka
            // 
            buttonSpravka.BackColor = Color.LightPink;
            buttonSpravka.Location = new Point(340, 359);
            buttonSpravka.Name = "buttonSpravka";
            buttonSpravka.Size = new Size(90, 65);
            buttonSpravka.TabIndex = 5;
            buttonSpravka.Text = "Справка";
            buttonSpravka.UseVisualStyleBackColor = false;
            buttonSpravka.Click += buttonSpravka_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.HotPink;
            buttonDone.Location = new Point(436, 352);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(106, 70);
            buttonDone.TabIndex = 6;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseDown += buttonDone_MouseDown;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            buttonDone.MouseLeave += buttonDone_MouseLeave;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1198, 450);
            Controls.Add(buttonDone);
            Controls.Add(buttonSpravka);
            Controls.Add(groupBoxVvod);
            Controls.Add(groupBoxVivod);
            Controls.Add(groupBoxCondition);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 24 | Левакова А.А.";
            groupBoxCondition.ResumeLayout(false);
            groupBoxCondition.PerformLayout();
            groupBoxVivod.ResumeLayout(false);
            groupBoxRes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChartFunction).EndInit();
            groupBoxVvod.ResumeLayout(false);
            groupBoxVvod.PerformLayout();
            groupBoxStop.ResumeLayout(false);
            groupBoxStop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition;
        private TextBox textBoxTask;
        private GroupBox groupBoxVivod;
        private GroupBox groupBoxRes;
        private GroupBox groupBoxVvod;
        private TextBox textBoxStopValue;
        private TextBox textBoxStartValue;
        private GroupBox groupBoxStop;
        private GroupBox groupBoxStart;
        private Button buttonSpravka;
        private Button buttonDone;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartFunction;
        private DataGridView dataGridViewFunction;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}

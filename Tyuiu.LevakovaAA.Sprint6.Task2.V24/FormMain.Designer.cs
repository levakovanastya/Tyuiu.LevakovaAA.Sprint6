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
            groupBoxCondition = new GroupBox();
            textBoxTask = new TextBox();
            groupBoxVivod = new GroupBox();
            groupBoxRes = new GroupBox();
            textBoxResult = new TextBox();
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
            groupBoxVvod.SuspendLayout();
            groupBoxStop.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(textBoxTask);
            groupBoxCondition.Location = new Point(27, 24);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(572, 294);
            groupBoxCondition.TabIndex = 2;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(0, 31);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(574, 264);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Протабулировать функцию F(x) на заданном диапазоне. Результат вывести в виде таблицы";
            // 
            // groupBoxVivod
            // 
            groupBoxVivod.Controls.Add(groupBoxRes);
            groupBoxVivod.Location = new Point(630, 32);
            groupBoxVivod.Name = "groupBoxVivod";
            groupBoxVivod.Size = new Size(536, 393);
            groupBoxVivod.TabIndex = 3;
            groupBoxVivod.TabStop = false;
            groupBoxVivod.Text = "Вывод данных";
            // 
            // groupBoxRes
            // 
            groupBoxRes.Controls.Add(textBoxResult);
            groupBoxRes.Location = new Point(0, 27);
            groupBoxRes.Name = "groupBoxRes";
            groupBoxRes.Size = new Size(536, 366);
            groupBoxRes.TabIndex = 0;
            groupBoxRes.TabStop = false;
            groupBoxRes.Text = "Результат";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(3, 30);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(530, 340);
            textBoxResult.TabIndex = 0;
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
            buttonSpravka.Size = new Size(113, 65);
            buttonSpravka.TabIndex = 5;
            buttonSpravka.Text = "Справка";
            buttonSpravka.UseVisualStyleBackColor = false;
            buttonSpravka.Click += buttonSpravka_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.HotPink;
            buttonDone.Location = new Point(459, 352);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(142, 70);
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
            ClientSize = new Size(1178, 450);
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
            groupBoxRes.PerformLayout();
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
        private TextBox textBoxResult;
    }
}

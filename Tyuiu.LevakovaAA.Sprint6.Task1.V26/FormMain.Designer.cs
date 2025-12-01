namespace Tyuiu.LevakovaAA.Sprint6.Task1.V26
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
            buttonDone = new Button();
            buttonSpravka = new Button();
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
            groupBoxCondition.SuspendLayout();
            groupBoxVivod.SuspendLayout();
            groupBoxRes.SuspendLayout();
            groupBoxVvod.SuspendLayout();
            groupBoxStop.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.LightGreen;
            buttonDone.ForeColor = SystemColors.ActiveCaptionText;
            buttonDone.Location = new Point(445, 349);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(159, 76);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonSpravka
            // 
            buttonSpravka.BackColor = Color.SkyBlue;
            buttonSpravka.Location = new Point(339, 349);
            buttonSpravka.Name = "buttonSpravka";
            buttonSpravka.Size = new Size(87, 76);
            buttonSpravka.TabIndex = 1;
            buttonSpravka.Text = "Справка";
            buttonSpravka.UseVisualStyleBackColor = false;
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
            groupBoxVivod.Size = new Size(270, 393);
            groupBoxVivod.TabIndex = 3;
            groupBoxVivod.TabStop = false;
            groupBoxVivod.Text = "Вывод данных";
            // 
            // groupBoxRes
            // 
            groupBoxRes.Controls.Add(textBoxResult);
            groupBoxRes.Location = new Point(0, 27);
            groupBoxRes.Name = "groupBoxRes";
            groupBoxRes.Size = new Size(270, 366);
            groupBoxRes.TabIndex = 0;
            groupBoxRes.TabStop = false;
            groupBoxRes.Text = "Результат";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(0, 34);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(270, 332);
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
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 450);
            Controls.Add(groupBoxVvod);
            Controls.Add(groupBoxVivod);
            Controls.Add(groupBoxCondition);
            Controls.Add(buttonSpravka);
            Controls.Add(buttonDone);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 26 | Левакова А.А.";
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

        private Button buttonDone;
        private Button buttonSpravka;
        private GroupBox groupBoxCondition;
        private TextBox textBoxTask;
        private GroupBox groupBoxVivod;
        private GroupBox groupBoxRes;
        private TextBox textBoxResult;
        private GroupBox groupBoxVvod;
        private TextBox textBoxStopValue;
        private TextBox textBoxStartValue;
        private GroupBox groupBoxStop;
        private GroupBox groupBoxStart;
    }
}

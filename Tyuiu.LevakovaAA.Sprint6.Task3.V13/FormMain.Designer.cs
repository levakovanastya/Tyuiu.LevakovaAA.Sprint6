namespace Tyuiu.LevakovaAA.Sprint6.Task3.V13
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
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            buttonSpravka = new Button();
            buttonResult = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(21, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(252, 416);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(252, 390);
            textBox1.TabIndex = 0;
            textBox1.Text = "Дана матрица 5 на 5\r\n-7  34  -2  25   5\r\n -16 -12  30  -3  17\r\n   3 -15  12   5  -5\r\n17  22  -3  32 -11\r\n   9  28   1  -9  -2\r\nВыполнить сортировку по возрастанию во втором столбце.";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(611, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(341, 416);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonResult);
            groupBox3.Controls.Add(buttonSpravka);
            groupBox3.Location = new Point(0, 33);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(341, 383);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Результат";
            // 
            // buttonSpravka
            // 
            buttonSpravka.Location = new Point(171, 331);
            buttonSpravka.Name = "buttonSpravka";
            buttonSpravka.Size = new Size(49, 46);
            buttonSpravka.TabIndex = 0;
            buttonSpravka.Text = "?";
            buttonSpravka.UseVisualStyleBackColor = true;
            // 
            // buttonResult
            // 
            buttonResult.Location = new Point(226, 331);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(111, 44);
            buttonResult.TabIndex = 1;
            buttonResult.Text = "Выполнить";
            buttonResult.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 13 | Левакова А.А.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button buttonResult;
        private Button buttonSpravka;
    }
}

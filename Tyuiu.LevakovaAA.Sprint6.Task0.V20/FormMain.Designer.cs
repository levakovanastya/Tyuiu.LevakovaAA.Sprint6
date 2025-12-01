namespace Tyuiu.LevakovaAA.Sprint6.Task0.V20
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonDone = new Button();
            buttonHelp = new Button();
            pictureBox = new PictureBox();
            textBoxResult = new TextBox();
            textBoxVarX = new TextBox();
            textBoxTask = new TextBox();
            groupBoxCondition = new GroupBox();
            groupBoxBase = new GroupBox();
            groupBoxVarA = new GroupBox();
            groupBoxVvod = new GroupBox();
            groupBoxResult = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            groupBoxBase.SuspendLayout();
            groupBoxVvod.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(576, 358);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(192, 66);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Выполнить";
            buttonDone.TextImageRelation = TextImageRelation.TextAboveImage;
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(501, 358);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(69, 66);
            buttonHelp.TabIndex = 1;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // pictureBox
            // 
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(576, 63);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(132, 62);
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(19, 50);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(218, 27);
            textBoxResult.TabIndex = 3;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // textBoxVarX
            // 
            textBoxVarX.Location = new Point(68, 324);
            textBoxVarX.Name = "textBoxVarX";
            textBoxVarX.Size = new Size(156, 27);
            textBoxVarX.TabIndex = 5;
            textBoxVarX.KeyPress += textBoxVarX_KeyPress;
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(44, 33);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(700, 192);
            textBoxTask.TabIndex = 6;
            textBoxTask.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Location = new Point(44, 12);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(700, 213);
            groupBoxCondition.TabIndex = 7;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            groupBoxCondition.Enter += groupBoxCondition_Enter;
            // 
            // groupBoxBase
            // 
            groupBoxBase.Controls.Add(groupBoxVarA);
            groupBoxBase.Location = new Point(50, 250);
            groupBoxBase.Name = "groupBoxBase";
            groupBoxBase.Size = new Size(396, 174);
            groupBoxBase.TabIndex = 8;
            groupBoxBase.TabStop = false;
            groupBoxBase.Text = "База данных";
            // 
            // groupBoxVarA
            // 
            groupBoxVarA.Location = new Point(18, 50);
            groupBoxVarA.Name = "groupBoxVarA";
            groupBoxVarA.Size = new Size(156, 51);
            groupBoxVarA.TabIndex = 0;
            groupBoxVarA.TabStop = false;
            groupBoxVarA.Text = "Переменная Х";
            // 
            // groupBoxVvod
            // 
            groupBoxVvod.Controls.Add(textBoxResult);
            groupBoxVvod.Controls.Add(groupBoxResult);
            groupBoxVvod.Location = new Point(482, 250);
            groupBoxVvod.Name = "groupBoxVvod";
            groupBoxVvod.Size = new Size(295, 174);
            groupBoxVvod.TabIndex = 9;
            groupBoxVvod.TabStop = false;
            groupBoxVvod.Text = "Ввод данных";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Location = new Point(19, 26);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(218, 51);
            groupBoxResult.TabIndex = 4;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Результат";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox);
            Controls.Add(textBoxTask);
            Controls.Add(textBoxVarX);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxCondition);
            Controls.Add(groupBoxBase);
            Controls.Add(groupBoxVvod);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 0 | Левакова А.А.";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            groupBoxBase.ResumeLayout(false);
            groupBoxVvod.ResumeLayout(false);
            groupBoxVvod.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDone;
        private Button buttonHelp;
        private PictureBox pictureBox;
        private TextBox textBoxResult;
        private TextBox textBoxVarX;
        private TextBox textBoxTask;
        private GroupBox groupBoxCondition;
        private GroupBox groupBoxBase;
        private GroupBox groupBoxVarA;
        private GroupBox groupBoxVvod;
        private GroupBox groupBoxResult;
    }
}

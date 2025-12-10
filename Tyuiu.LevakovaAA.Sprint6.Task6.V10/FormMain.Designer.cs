namespace Tyuiu.LevakovaAA.Sprint6.Task6.V10
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox3 = new GroupBox();
            textBoxResult = new TextBox();
            groupBoxOutPutData = new GroupBox();
            textBoxLoadFromFile = new TextBox();
            buttonSpravka = new Button();
            buttonOpenFile = new Button();
            buttonDone = new Button();
            OpenFileDialogTask = new OpenFileDialog();
            toolTip = new ToolTip(components);
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBoxOutPutData.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(1, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1180, 137);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 23);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1184, 114);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxResult);
            groupBox3.Location = new Point(581, 217);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(603, 395);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(0, 23);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(600, 371);
            textBoxResult.TabIndex = 0;
            // 
            // groupBoxOutPutData
            // 
            groupBoxOutPutData.Controls.Add(textBoxLoadFromFile);
            groupBoxOutPutData.Location = new Point(9, 217);
            groupBoxOutPutData.Name = "groupBoxOutPutData";
            groupBoxOutPutData.Size = new Size(561, 394);
            groupBoxOutPutData.TabIndex = 3;
            groupBoxOutPutData.TabStop = false;
            groupBoxOutPutData.Text = "Ввод";
            // 
            // textBoxLoadFromFile
            // 
            textBoxLoadFromFile.Location = new Point(0, 24);
            textBoxLoadFromFile.Multiline = true;
            textBoxLoadFromFile.Name = "textBoxLoadFromFile";
            textBoxLoadFromFile.ReadOnly = true;
            textBoxLoadFromFile.Size = new Size(563, 372);
            textBoxLoadFromFile.TabIndex = 0;
            // 
            // buttonSpravka
            // 
            buttonSpravka.Image = Properties.Resources.help;
            buttonSpravka.Location = new Point(1083, 12);
            buttonSpravka.Name = "buttonSpravka";
            buttonSpravka.Size = new Size(88, 63);
            buttonSpravka.TabIndex = 4;
            buttonSpravka.UseVisualStyleBackColor = true;
            buttonSpravka.Click += buttonSpravka_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Image = Properties.Resources.folder_page;
            buttonOpenFile.Location = new Point(8, 8);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(91, 65);
            buttonOpenFile.TabIndex = 5;
            toolTip.SetToolTip(buttonOpenFile, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonDone
            // 
            buttonDone.Image = Properties.Resources.page_go;
            buttonDone.Location = new Point(105, 8);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(89, 65);
            buttonDone.TabIndex = 6;
            toolTip.SetToolTip(buttonDone, "Выводит слова в которых встречается w");
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // OpenFileDialogTask
            // 
            OpenFileDialogTask.FileName = "OpenFileDialogTask";
            OpenFileDialogTask.FileOk += OpenFileDialogTask_FileOk;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 614);
            Controls.Add(buttonDone);
            Controls.Add(buttonOpenFile);
            Controls.Add(buttonSpravka);
            Controls.Add(groupBoxOutPutData);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 10 | Левакова А.А.";
            Load += FormMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBoxOutPutData.ResumeLayout(false);
            groupBoxOutPutData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox3;
        private GroupBox groupBoxOutPutData;
        private Button buttonSpravka;
        private Button buttonOpenFile;
        private Button buttonDone;
        private OpenFileDialog OpenFileDialogTask;
        private ToolTip toolTip;
        private TextBox textBoxResult;
        private TextBox textBoxLoadFromFile;
    }
}

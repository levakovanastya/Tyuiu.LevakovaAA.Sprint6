namespace Tyuiu.LevakovaAA.Sprint6.Task7.V19
{
    partial class FormMain_LAA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_LAA));
            openFileDialogTask = new OpenFileDialog();
            saveFileDialogMatrix = new SaveFileDialog();
            buttonOpenFile_LAA = new Button();
            dataGridViewInMatrix_LAA = new DataGridView();
            dataGridViewOutMatrix_LAA = new DataGridView();
            buttonDone_LAA = new Button();
            groupBoxInput_LAA = new GroupBox();
            groupBoxOutput_LAA = new GroupBox();
            groupBoxCondition_LAA = new GroupBox();
            textBoxCondition_LAA = new TextBox();
            buttonSaveFile_LAA = new Button();
            buttonHelp_LAA = new Button();
            toolTipButton = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix_LAA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix_LAA).BeginInit();
            groupBoxCondition_LAA.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
            openFileDialogTask.FileOk += openFileDialogTask_FileOk;
            // 
            // saveFileDialogMatrix
            // 
            saveFileDialogMatrix.FileOk += saveFileDialogMatrix_FileOk;
            // 
            // buttonOpenFile_LAA
            // 
            buttonOpenFile_LAA.Image = Properties.Resources.folder_page;
            buttonOpenFile_LAA.Location = new Point(20, 19);
            buttonOpenFile_LAA.Name = "buttonOpenFile_LAA";
            buttonOpenFile_LAA.Size = new Size(112, 66);
            buttonOpenFile_LAA.TabIndex = 0;
            buttonOpenFile_LAA.UseVisualStyleBackColor = true;
            buttonOpenFile_LAA.Click += buttonOpenFile_Click;
            buttonOpenFile_LAA.MouseEnter += buttonOpenFile_LAA_MouseEnter;
            // 
            // dataGridViewInMatrix_LAA
            // 
            dataGridViewInMatrix_LAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInMatrix_LAA.Location = new Point(12, 248);
            dataGridViewInMatrix_LAA.Name = "dataGridViewInMatrix_LAA";
            dataGridViewInMatrix_LAA.RowHeadersWidth = 51;
            dataGridViewInMatrix_LAA.Size = new Size(530, 309);
            dataGridViewInMatrix_LAA.TabIndex = 1;
            // 
            // dataGridViewOutMatrix_LAA
            // 
            dataGridViewOutMatrix_LAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutMatrix_LAA.Location = new Point(555, 248);
            dataGridViewOutMatrix_LAA.Name = "dataGridViewOutMatrix_LAA";
            dataGridViewOutMatrix_LAA.RowHeadersWidth = 51;
            dataGridViewOutMatrix_LAA.Size = new Size(526, 309);
            dataGridViewOutMatrix_LAA.TabIndex = 2;
            // 
            // buttonDone_LAA
            // 
            buttonDone_LAA.Image = Properties.Resources.page_go;
            buttonDone_LAA.Location = new Point(138, 19);
            buttonDone_LAA.Name = "buttonDone_LAA";
            buttonDone_LAA.Size = new Size(113, 66);
            buttonDone_LAA.TabIndex = 3;
            buttonDone_LAA.UseVisualStyleBackColor = true;
            buttonDone_LAA.Click += buttonDone_LAA_Click;
            buttonDone_LAA.MouseEnter += buttonDone_LAA_MouseEnter;
            // 
            // groupBoxInput_LAA
            // 
            groupBoxInput_LAA.Location = new Point(9, 226);
            groupBoxInput_LAA.Name = "groupBoxInput_LAA";
            groupBoxInput_LAA.Size = new Size(532, 331);
            groupBoxInput_LAA.TabIndex = 4;
            groupBoxInput_LAA.TabStop = false;
            groupBoxInput_LAA.Text = "Ввод";
            // 
            // groupBoxOutput_LAA
            // 
            groupBoxOutput_LAA.Location = new Point(555, 226);
            groupBoxOutput_LAA.Name = "groupBoxOutput_LAA";
            groupBoxOutput_LAA.Size = new Size(528, 328);
            groupBoxOutput_LAA.TabIndex = 5;
            groupBoxOutput_LAA.TabStop = false;
            groupBoxOutput_LAA.Text = "Вывод";
            // 
            // groupBoxCondition_LAA
            // 
            groupBoxCondition_LAA.Controls.Add(textBoxCondition_LAA);
            groupBoxCondition_LAA.Location = new Point(12, 104);
            groupBoxCondition_LAA.Name = "groupBoxCondition_LAA";
            groupBoxCondition_LAA.Size = new Size(1065, 121);
            groupBoxCondition_LAA.TabIndex = 6;
            groupBoxCondition_LAA.TabStop = false;
            groupBoxCondition_LAA.Text = "Условие";
            // 
            // textBoxCondition_LAA
            // 
            textBoxCondition_LAA.Location = new Point(0, 26);
            textBoxCondition_LAA.Multiline = true;
            textBoxCondition_LAA.Name = "textBoxCondition_LAA";
            textBoxCondition_LAA.ReadOnly = true;
            textBoxCondition_LAA.Size = new Size(1065, 95);
            textBoxCondition_LAA.TabIndex = 0;
            textBoxCondition_LAA.Text = resources.GetString("textBoxCondition_LAA.Text");
            // 
            // buttonSaveFile_LAA
            // 
            buttonSaveFile_LAA.Image = Properties.Resources.page_save;
            buttonSaveFile_LAA.Location = new Point(257, 19);
            buttonSaveFile_LAA.Name = "buttonSaveFile_LAA";
            buttonSaveFile_LAA.Size = new Size(110, 66);
            buttonSaveFile_LAA.TabIndex = 7;
            buttonSaveFile_LAA.UseVisualStyleBackColor = true;
            buttonSaveFile_LAA.Click += buttonSaveFile_LAA_Click;
            // 
            // buttonHelp_LAA
            // 
            buttonHelp_LAA.Image = Properties.Resources.help;
            buttonHelp_LAA.Location = new Point(966, 19);
            buttonHelp_LAA.Name = "buttonHelp_LAA";
            buttonHelp_LAA.Size = new Size(97, 66);
            buttonHelp_LAA.TabIndex = 8;
            buttonHelp_LAA.UseVisualStyleBackColor = true;
            buttonHelp_LAA.Click += buttonHelp_LAA_Click;
            buttonHelp_LAA.MouseEnter += buttonHelp_LAA_MouseEnter;
            // 
            // toolTipButton
            // 
            toolTipButton.IsBalloon = true;
            toolTipButton.ToolTipTitle = "Подсказка";
            // 
            // FormMain_LAA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 568);
            Controls.Add(buttonHelp_LAA);
            Controls.Add(buttonSaveFile_LAA);
            Controls.Add(groupBoxCondition_LAA);
            Controls.Add(buttonDone_LAA);
            Controls.Add(dataGridViewOutMatrix_LAA);
            Controls.Add(dataGridViewInMatrix_LAA);
            Controls.Add(buttonOpenFile_LAA);
            Controls.Add(groupBoxInput_LAA);
            Controls.Add(groupBoxOutput_LAA);
            Name = "FormMain_LAA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 19 | Левакова А.А.";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix_LAA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix_LAA).EndInit();
            groupBoxCondition_LAA.ResumeLayout(false);
            groupBoxCondition_LAA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialogTask;
        private SaveFileDialog saveFileDialogMatrix;
        private Button buttonOpenFile_LAA;
        private DataGridView dataGridViewInMatrix_LAA;
        private DataGridView dataGridViewOutMatrix_LAA;
        private Button buttonDone_LAA;
        private GroupBox groupBoxInput_LAA;
        private GroupBox groupBoxOutput_LAA;
        private GroupBox groupBoxCondition_LAA;
        private TextBox textBoxCondition_LAA;
        private Button buttonSaveFile_LAA;
        private Button buttonHelp_LAA;
        private ToolTip toolTipButton;
    }
}

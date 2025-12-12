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
            buttonDone_LAA = new Button();
            groupBoxInput_LAA = new GroupBox();
            panel3 = new Panel();
            groupBoxOutput_LAA = new GroupBox();
            dataGridViewOutMatrix_LAA = new DataGridView();
            buttonSaveFile_LAA = new Button();
            buttonHelp_LAA = new Button();
            toolTipButton = new ToolTip(components);
            panel1 = new Panel();
            textBoxCondition_LAA = new TextBox();
            groupBoxCondition_LAA = new GroupBox();
            panel2 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix_LAA).BeginInit();
            groupBoxInput_LAA.SuspendLayout();
            panel3.SuspendLayout();
            groupBoxOutput_LAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix_LAA).BeginInit();
            panel1.SuspendLayout();
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
            toolTipButton.SetToolTip(buttonOpenFile_LAA, "Открыть файл");
            buttonOpenFile_LAA.UseVisualStyleBackColor = true;
            buttonOpenFile_LAA.Click += buttonOpenFile_Click;
            buttonOpenFile_LAA.MouseEnter += buttonOpenFile_LAA_MouseEnter;
            // 
            // dataGridViewInMatrix_LAA
            // 
            dataGridViewInMatrix_LAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInMatrix_LAA.Dock = DockStyle.Fill;
            dataGridViewInMatrix_LAA.Location = new Point(0, 0);
            dataGridViewInMatrix_LAA.Name = "dataGridViewInMatrix_LAA";
            dataGridViewInMatrix_LAA.RowHeadersWidth = 51;
            dataGridViewInMatrix_LAA.ScrollBars = ScrollBars.Vertical;
            dataGridViewInMatrix_LAA.Size = new Size(539, 341);
            dataGridViewInMatrix_LAA.TabIndex = 1;
            dataGridViewInMatrix_LAA.CellContentClick += dataGridViewInMatrix_LAA_CellContentClick;
            // 
            // buttonDone_LAA
            // 
            buttonDone_LAA.Image = Properties.Resources.page_go;
            buttonDone_LAA.Location = new Point(138, 19);
            buttonDone_LAA.Name = "buttonDone_LAA";
            buttonDone_LAA.Size = new Size(113, 66);
            buttonDone_LAA.TabIndex = 3;
            toolTipButton.SetToolTip(buttonDone_LAA, "Выполнить преобразования");
            buttonDone_LAA.UseVisualStyleBackColor = true;
            buttonDone_LAA.Click += buttonDone_LAA_Click;
            buttonDone_LAA.MouseEnter += buttonDone_LAA_MouseEnter;
            // 
            // groupBoxInput_LAA
            // 
            groupBoxInput_LAA.Controls.Add(panel3);
            groupBoxInput_LAA.Location = new Point(9, 226);
            groupBoxInput_LAA.Name = "groupBoxInput_LAA";
            groupBoxInput_LAA.Size = new Size(532, 331);
            groupBoxInput_LAA.TabIndex = 4;
            groupBoxInput_LAA.TabStop = false;
            groupBoxInput_LAA.Text = "Ввод";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridViewInMatrix_LAA);
            panel3.Location = new Point(3, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(539, 341);
            panel3.TabIndex = 0;
            // 
            // groupBoxOutput_LAA
            // 
            groupBoxOutput_LAA.Controls.Add(dataGridViewOutMatrix_LAA);
            groupBoxOutput_LAA.Location = new Point(555, 226);
            groupBoxOutput_LAA.Name = "groupBoxOutput_LAA";
            groupBoxOutput_LAA.Size = new Size(528, 328);
            groupBoxOutput_LAA.TabIndex = 5;
            groupBoxOutput_LAA.TabStop = false;
            groupBoxOutput_LAA.Text = "Вывод";
            // 
            // dataGridViewOutMatrix_LAA
            // 
            dataGridViewOutMatrix_LAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutMatrix_LAA.Dock = DockStyle.Fill;
            dataGridViewOutMatrix_LAA.Location = new Point(3, 23);
            dataGridViewOutMatrix_LAA.Name = "dataGridViewOutMatrix_LAA";
            dataGridViewOutMatrix_LAA.RowHeadersWidth = 51;
            dataGridViewOutMatrix_LAA.ScrollBars = ScrollBars.Vertical;
            dataGridViewOutMatrix_LAA.Size = new Size(522, 302);
            dataGridViewOutMatrix_LAA.TabIndex = 2;
            // 
            // buttonSaveFile_LAA
            // 
            buttonSaveFile_LAA.Image = Properties.Resources.page_save;
            buttonSaveFile_LAA.Location = new Point(257, 19);
            buttonSaveFile_LAA.Name = "buttonSaveFile_LAA";
            buttonSaveFile_LAA.Size = new Size(110, 66);
            buttonSaveFile_LAA.TabIndex = 7;
            toolTipButton.SetToolTip(buttonSaveFile_LAA, "Сохранить файл");
            buttonSaveFile_LAA.UseVisualStyleBackColor = true;
            buttonSaveFile_LAA.Click += buttonSaveFile_LAA_Click;
            // 
            // buttonHelp_LAA
            // 
            buttonHelp_LAA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_LAA.Image = Properties.Resources.help;
            buttonHelp_LAA.Location = new Point(966, 19);
            buttonHelp_LAA.Name = "buttonHelp_LAA";
            buttonHelp_LAA.Size = new Size(97, 66);
            buttonHelp_LAA.TabIndex = 8;
            toolTipButton.SetToolTip(buttonHelp_LAA, "Справка");
            buttonHelp_LAA.UseVisualStyleBackColor = true;
            buttonHelp_LAA.Click += buttonHelp_LAA_Click;
            buttonHelp_LAA.MouseEnter += buttonHelp_LAA_MouseEnter;
            // 
            // toolTipButton
            // 
            toolTipButton.ToolTipTitle = "Подсказка";
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonHelp_LAA);
            panel1.Controls.Add(buttonSaveFile_LAA);
            panel1.Controls.Add(buttonDone_LAA);
            panel1.Controls.Add(buttonOpenFile_LAA);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1093, 106);
            panel1.TabIndex = 9;
            // 
            // textBoxCondition_LAA
            // 
            textBoxCondition_LAA.Dock = DockStyle.Fill;
            textBoxCondition_LAA.Location = new Point(3, 23);
            textBoxCondition_LAA.Multiline = true;
            textBoxCondition_LAA.Name = "textBoxCondition_LAA";
            textBoxCondition_LAA.ReadOnly = true;
            textBoxCondition_LAA.Size = new Size(1059, 95);
            textBoxCondition_LAA.TabIndex = 0;
            textBoxCondition_LAA.Text = resources.GetString("textBoxCondition_LAA.Text");
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
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Location = new Point(0, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(1093, 134);
            panel2.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.Location = new Point(8, 226);
            panel5.Name = "panel5";
            panel5.Size = new Size(542, 339);
            panel5.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.Location = new Point(553, 232);
            panel4.Name = "panel4";
            panel4.Size = new Size(525, 341);
            panel4.TabIndex = 12;
            // 
            // FormMain_LAA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 568);
            Controls.Add(panel1);
            Controls.Add(groupBoxCondition_LAA);
            Controls.Add(groupBoxInput_LAA);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(groupBoxOutput_LAA);
            Controls.Add(panel4);
            Name = "FormMain_LAA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 19 | Левакова А.А.";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix_LAA).EndInit();
            groupBoxInput_LAA.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBoxOutput_LAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix_LAA).EndInit();
            panel1.ResumeLayout(false);
            groupBoxCondition_LAA.ResumeLayout(false);
            groupBoxCondition_LAA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialogTask;
        private SaveFileDialog saveFileDialogMatrix;
        private Button buttonOpenFile_LAA;
        private DataGridView dataGridViewInMatrix_LAA;
        private Button buttonDone_LAA;
        private GroupBox groupBoxInput_LAA;
        private GroupBox groupBoxOutput_LAA;
        private Button buttonSaveFile_LAA;
        private Button buttonHelp_LAA;
        private ToolTip toolTipButton;
        private Panel panel1;
        private TextBox textBoxCondition_LAA;
        private GroupBox groupBoxCondition_LAA;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private DataGridView dataGridViewOutMatrix_LAA;
        private Panel panel4;
    }
}

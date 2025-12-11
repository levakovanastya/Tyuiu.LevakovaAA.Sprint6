namespace Tyuiu.LevakovaAA.Sprint6.Task7.V19
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            labelInfo_LAA = new Label();
            buttonOk_LAA = new Button();
            SuspendLayout();
            // 
            // labelInfo_LAA
            // 
            labelInfo_LAA.Anchor = AnchorStyles.None;
            labelInfo_LAA.AutoSize = true;
            labelInfo_LAA.Location = new Point(12, 9);
            labelInfo_LAA.Name = "labelInfo_LAA";
            labelInfo_LAA.Size = new Size(387, 240);
            labelInfo_LAA.TabIndex = 0;
            labelInfo_LAA.Text = resources.GetString("labelInfo_LAA.Text");
            // 
            // buttonOk_LAA
            // 
            buttonOk_LAA.Location = new Point(318, 194);
            buttonOk_LAA.Name = "buttonOk_LAA";
            buttonOk_LAA.Size = new Size(107, 43);
            buttonOk_LAA.TabIndex = 1;
            buttonOk_LAA.Text = "Ok";
            buttonOk_LAA.UseVisualStyleBackColor = true;
            buttonOk_LAA.Click += buttonOk_LAA_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 262);
            Controls.Add(buttonOk_LAA);
            Controls.Add(labelInfo_LAA);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Справка";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInfo_LAA;
        private Button buttonOk_LAA;
    }
}
namespace Tyuiu.NovikovaVA.Sprint7.Project.V2
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
            labelInstruction_NVA = new Label();
            SuspendLayout();
            // 
            // labelInstruction_NVA
            // 
            labelInstruction_NVA.AutoSize = true;
            labelInstruction_NVA.BackColor = SystemColors.Menu;
            labelInstruction_NVA.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelInstruction_NVA.Location = new Point(3, 9);
            labelInstruction_NVA.Name = "labelInstruction_NVA";
            labelInstruction_NVA.Size = new Size(522, 160);
            labelInstruction_NVA.TabIndex = 0;
            labelInstruction_NVA.Text = resources.GetString("labelInstruction_NVA.Text");
            labelInstruction_NVA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 171);
            Controls.Add(labelInstruction_NVA);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Руководство пользователя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInstruction_NVA;
    }
}
namespace Tyuiu.NovikovaVA.Sprint7.Project.V2
{
    partial class FormInstruction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInstruction));
            pictureBox1 = new PictureBox();
            labelInfo_NVA = new Label();
            buttonOk_NVA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.DSC_0030_1___2_;
            pictureBox1.Location = new Point(22, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 136);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelInfo_NVA
            // 
            labelInfo_NVA.AutoSize = true;
            labelInfo_NVA.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelInfo_NVA.Location = new Point(159, 20);
            labelInfo_NVA.Name = "labelInfo_NVA";
            labelInfo_NVA.Size = new Size(309, 135);
            labelInfo_NVA.TabIndex = 2;
            labelInfo_NVA.Text = resources.GetString("labelInfo_NVA.Text");
            // 
            // buttonOk_NVA
            // 
            buttonOk_NVA.BackColor = Color.White;
            buttonOk_NVA.FlatStyle = FlatStyle.Flat;
            buttonOk_NVA.Location = new Point(354, 172);
            buttonOk_NVA.Name = "buttonOk_NVA";
            buttonOk_NVA.Size = new Size(84, 33);
            buttonOk_NVA.TabIndex = 3;
            buttonOk_NVA.Text = "OK";
            buttonOk_NVA.UseVisualStyleBackColor = false;
            buttonOk_NVA.Click += buttonOk_NVA_Click;
            // 
            // FormInstruction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(480, 217);
            Controls.Add(buttonOk_NVA);
            Controls.Add(labelInfo_NVA);
            Controls.Add(pictureBox1);
            Name = "FormInstruction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О разработчике";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelInfo_NVA;
        private Button buttonOk_NVA;
    }
}
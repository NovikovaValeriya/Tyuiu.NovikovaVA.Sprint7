namespace Tyuiu.NovikovaVA.Sprint7.Project.V2
{
    partial class FormHelp
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
            buttonOp_NVA = new Button();
            buttonOk2_NVA = new Button();
            textBoxQA_NVA = new TextBox();
            SuspendLayout();
            // 
            // buttonOp_NVA
            // 
            buttonOp_NVA.BackColor = Color.MediumPurple;
            buttonOp_NVA.Location = new Point(157, 113);
            buttonOp_NVA.Name = "buttonOp_NVA";
            buttonOp_NVA.Size = new Size(156, 40);
            buttonOp_NVA.TabIndex = 0;
            buttonOp_NVA.Text = "Открыть сайт";
            buttonOp_NVA.UseVisualStyleBackColor = false;
            buttonOp_NVA.Click += buttonOp_NVA_Click;
            // 
            // buttonOk2_NVA
            // 
            buttonOk2_NVA.BackColor = SystemColors.ControlDark;
            buttonOk2_NVA.Location = new Point(384, 177);
            buttonOk2_NVA.Name = "buttonOk2_NVA";
            buttonOk2_NVA.Size = new Size(75, 23);
            buttonOk2_NVA.TabIndex = 1;
            buttonOk2_NVA.Text = "Ok";
            buttonOk2_NVA.UseVisualStyleBackColor = false;
            buttonOk2_NVA.Click += buttonOk2_NVA_Click;
            // 
            // textBoxQA_NVA
            // 
            textBoxQA_NVA.BackColor = SystemColors.Menu;
            textBoxQA_NVA.Dock = DockStyle.Top;
            textBoxQA_NVA.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBoxQA_NVA.ForeColor = SystemColors.InfoText;
            textBoxQA_NVA.Location = new Point(0, 0);
            textBoxQA_NVA.Multiline = true;
            textBoxQA_NVA.Name = "textBoxQA_NVA";
            textBoxQA_NVA.Size = new Size(471, 98);
            textBoxQA_NVA.TabIndex = 2;
            textBoxQA_NVA.Text = "Если у вас появились замечания или предложения во время работы с приложением, то можете перейти на сайт и связаться с разработчиком:\r\n";
            // 
            // FormHelp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(471, 208);
            Controls.Add(textBoxQA_NVA);
            Controls.Add(buttonOk2_NVA);
            Controls.Add(buttonOp_NVA);
            Name = "FormHelp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Поддержка";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOp_NVA;
        private Button buttonOk2_NVA;
        private TextBox textBoxQA_NVA;
    }
}
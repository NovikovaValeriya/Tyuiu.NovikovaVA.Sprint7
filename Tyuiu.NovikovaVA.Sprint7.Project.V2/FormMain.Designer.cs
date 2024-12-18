namespace Tyuiu.NovikovaVA.Sprint7.Project.V2
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
            toolTip_NVA = new ToolTip(components);
            buttonDel_NVA = new Button();
            buttonDownload_NVA = new Button();
            buttonAdd_NVA = new Button();
            buttonOpen_NVA = new Button();
            openFileDialog_NVA = new OpenFileDialog();
            saveFileDialog_NVA = new SaveFileDialog();
            menuStrip1 = new MenuStrip();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            оРазработчикеToolStripMenuItem = new ToolStripMenuItem();
            groupBoxData_NVA = new GroupBox();
            groupBox1 = new GroupBox();
            groupBoxWorkData_NVA = new GroupBox();
            dataGridViewData_NVA = new DataGridView();
            Number_NVA = new DataGridViewTextBoxColumn();
            Name_NVA = new DataGridViewTextBoxColumn();
            Adress_NVA = new DataGridViewTextBoxColumn();
            Money_NVA = new DataGridViewTextBoxColumn();
            Phone_Nva = new DataGridViewTextBoxColumn();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            menuStrip1.SuspendLayout();
            groupBoxData_NVA.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBoxWorkData_NVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData_NVA).BeginInit();
            SuspendLayout();
            // 
            // toolTip_NVA
            // 
            toolTip_NVA.ToolTipIcon = ToolTipIcon.Info;
            // 
            // buttonDel_NVA
            // 
            buttonDel_NVA.Image = Properties.Resources.basket_put;
            buttonDel_NVA.Location = new Point(127, 38);
            buttonDel_NVA.Name = "buttonDel_NVA";
            buttonDel_NVA.Size = new Size(72, 53);
            buttonDel_NVA.TabIndex = 4;
            toolTip_NVA.SetToolTip(buttonDel_NVA, "Удалить данные о магазине");
            buttonDel_NVA.UseVisualStyleBackColor = true;
            buttonDel_NVA.Click += buttonDel_NVA_Click;
            // 
            // buttonDownload_NVA
            // 
            buttonDownload_NVA.Image = Properties.Resources.accept;
            buttonDownload_NVA.Location = new Point(126, 38);
            buttonDownload_NVA.Name = "buttonDownload_NVA";
            buttonDownload_NVA.Size = new Size(71, 54);
            buttonDownload_NVA.TabIndex = 2;
            toolTip_NVA.SetToolTip(buttonDownload_NVA, "Сохранить изменёную базу данных\r\n");
            buttonDownload_NVA.UseVisualStyleBackColor = true;
            buttonDownload_NVA.Click += buttonDownload_NVA_Click;
            // 
            // buttonAdd_NVA
            // 
            buttonAdd_NVA.Image = Properties.Resources.add1;
            buttonAdd_NVA.Location = new Point(31, 37);
            buttonAdd_NVA.Name = "buttonAdd_NVA";
            buttonAdd_NVA.Size = new Size(70, 54);
            buttonAdd_NVA.TabIndex = 3;
            toolTip_NVA.SetToolTip(buttonAdd_NVA, "Добавить данные о новом магазине");
            buttonAdd_NVA.UseVisualStyleBackColor = true;
            buttonAdd_NVA.Click += buttonAdd_NVA_Click;
            // 
            // buttonOpen_NVA
            // 
            buttonOpen_NVA.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            buttonOpen_NVA.Image = Properties.Resources.database_add;
            buttonOpen_NVA.Location = new Point(34, 38);
            buttonOpen_NVA.Name = "buttonOpen_NVA";
            buttonOpen_NVA.Size = new Size(77, 54);
            buttonOpen_NVA.TabIndex = 1;
            toolTip_NVA.SetToolTip(buttonOpen_NVA, "Загрузить исходную базу данных");
            buttonOpen_NVA.UseVisualStyleBackColor = true;
            buttonOpen_NVA.Click += Openbutton_NVA_Click;
            // 
            // openFileDialog_NVA
            // 
            openFileDialog_NVA.FileName = "openFileDialog_NVA";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1123, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem, оРазработчикеToolStripMenuItem });
            справкаToolStripMenuItem.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            справкаToolStripMenuItem.ImageAlign = ContentAlignment.TopCenter;
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(102, 29);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(233, 30);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += buttonInfo_NVA_Click;
            // 
            // оРазработчикеToolStripMenuItem
            // 
            оРазработчикеToolStripMenuItem.Name = "оРазработчикеToolStripMenuItem";
            оРазработчикеToolStripMenuItem.Size = new Size(233, 30);
            оРазработчикеToolStripMenuItem.Text = "О разработчике";
            оРазработчикеToolStripMenuItem.Click += toolStripMenuItemInstruction_NVA_Click;
            // 
            // groupBoxData_NVA
            // 
            groupBoxData_NVA.Controls.Add(groupBox1);
            groupBoxData_NVA.Controls.Add(groupBoxWorkData_NVA);
            groupBoxData_NVA.Controls.Add(dataGridViewData_NVA);
            groupBoxData_NVA.Dock = DockStyle.Top;
            groupBoxData_NVA.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxData_NVA.Location = new Point(0, 33);
            groupBoxData_NVA.Name = "groupBoxData_NVA";
            groupBoxData_NVA.Size = new Size(1123, 642);
            groupBoxData_NVA.TabIndex = 2;
            groupBoxData_NVA.TabStop = false;
            groupBoxData_NVA.Text = "База данных ИП Новикова В.А.";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonAdd_NVA);
            groupBox1.Controls.Add(buttonDel_NVA);
            groupBox1.Location = new Point(295, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(259, 98);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавление/удаление данных";
            // 
            // groupBoxWorkData_NVA
            // 
            groupBoxWorkData_NVA.Controls.Add(buttonOpen_NVA);
            groupBoxWorkData_NVA.Controls.Add(buttonDownload_NVA);
            groupBoxWorkData_NVA.Location = new Point(36, 39);
            groupBoxWorkData_NVA.Name = "groupBoxWorkData_NVA";
            groupBoxWorkData_NVA.Size = new Size(233, 98);
            groupBoxWorkData_NVA.TabIndex = 5;
            groupBoxWorkData_NVA.TabStop = false;
            groupBoxWorkData_NVA.Text = "Загрузка/Выгрузка файла";
            // 
            // dataGridViewData_NVA
            // 
            dataGridViewData_NVA.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewData_NVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData_NVA.Columns.AddRange(new DataGridViewColumn[] { Number_NVA, Name_NVA, Adress_NVA, Money_NVA, Phone_Nva });
            dataGridViewData_NVA.Location = new Point(24, 152);
            dataGridViewData_NVA.Name = "dataGridViewData_NVA";
            dataGridViewData_NVA.RowHeadersVisible = false;
            dataGridViewData_NVA.RowHeadersWidth = 50;
            dataGridViewData_NVA.RowTemplate.Height = 24;
            dataGridViewData_NVA.Size = new Size(1077, 484);
            dataGridViewData_NVA.TabIndex = 0;
            // 
            // Number_NVA
            // 
            Number_NVA.HeaderText = "Номер филиала";
            Number_NVA.MinimumWidth = 6;
            Number_NVA.Name = "Number_NVA";
            Number_NVA.SortMode = DataGridViewColumnSortMode.Programmatic;
            Number_NVA.Width = 214;
            // 
            // Name_NVA
            // 
            Name_NVA.HeaderText = "Название";
            Name_NVA.MinimumWidth = 6;
            Name_NVA.Name = "Name_NVA";
            Name_NVA.SortMode = DataGridViewColumnSortMode.NotSortable;
            Name_NVA.Width = 214;
            // 
            // Adress_NVA
            // 
            Adress_NVA.HeaderText = "Адрес";
            Adress_NVA.MinimumWidth = 6;
            Adress_NVA.Name = "Adress_NVA";
            Adress_NVA.SortMode = DataGridViewColumnSortMode.NotSortable;
            Adress_NVA.Width = 214;
            // 
            // Money_NVA
            // 
            Money_NVA.HeaderText = "Ежемесечная выручка";
            Money_NVA.MinimumWidth = 6;
            Money_NVA.Name = "Money_NVA";
            Money_NVA.SortMode = DataGridViewColumnSortMode.NotSortable;
            Money_NVA.Width = 214;
            // 
            // Phone_Nva
            // 
            Phone_Nva.HeaderText = "Контактный телефон";
            Phone_Nva.MinimumWidth = 6;
            Phone_Nva.Name = "Phone_Nva";
            Phone_Nva.SortMode = DataGridViewColumnSortMode.NotSortable;
            Phone_Nva.Width = 214;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1123, 677);
            Controls.Add(groupBoxData_NVA);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(1139, 720);
            MinimumSize = new Size(1139, 715);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сеть магазинов | Выполнила Новикова В. А.";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBoxData_NVA.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBoxWorkData_NVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewData_NVA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolTip toolTip_NVA;
        private OpenFileDialog openFileDialog_NVA;
        private SaveFileDialog saveFileDialog_NVA;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem оРазработчикеToolStripMenuItem;
        private GroupBox groupBoxData_NVA;
        private DataGridView dataGridViewData_NVA;
        private DataGridViewTextBoxColumn Number_NVA;
        private DataGridViewTextBoxColumn Name_NVA;
        private DataGridViewTextBoxColumn Adress_NVA;
        private DataGridViewTextBoxColumn Money_NVA;
        private DataGridViewTextBoxColumn Phone_Nva;
        private Button buttonOpen_NVA;
        private Button buttonDownload_NVA;
        private Button buttonDel_NVA;
        private Button buttonAdd_NVA;
        private GroupBox groupBox1;
        private GroupBox groupBoxWorkData_NVA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

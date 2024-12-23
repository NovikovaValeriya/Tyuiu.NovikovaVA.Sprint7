﻿namespace Tyuiu.NovikovaVA.Sprint7.Project.V2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            toolTip_NVA = new ToolTip(components);
            buttonDel_NVA = new Button();
            buttonDownload_NVA = new Button();
            buttonAdd_NVA = new Button();
            buttonOpen_NVA = new Button();
            buttonStats_NVA = new Button();
            buttonFilter_NVA = new Button();
            openFileDialog_NVA = new OpenFileDialog();
            saveFileDialog_NVA = new SaveFileDialog();
            menuStrip1 = new MenuStrip();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            оРазработчикеToolStripMenuItem = new ToolStripMenuItem();
            поддержкаToolStripMenuItem = new ToolStripMenuItem();
            groupBoxData_NVA = new GroupBox();
            tabControl_NVA = new TabControl();
            tabPage2 = new TabPage();
            splitter3 = new Splitter();
            splitter2 = new Splitter();
            splitter1 = new Splitter();
            groupBoxFilter_NVA = new GroupBox();
            label3 = new Label();
            textBoxSearch_NVA = new TextBox();
            label2 = new Label();
            label1 = new Label();
            comboBoxNames_NVA = new ComboBox();
            textBoxFilter_NVA = new TextBox();
            dataGridViewData_NVA = new DataGridView();
            groupBoxWorkData_NVA = new GroupBox();
            groupBox1 = new GroupBox();
            tabPage1 = new TabPage();
            chartMoney_NVA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Number_NVA = new DataGridViewTextBoxColumn();
            Name_NVA = new DataGridViewTextBoxColumn();
            Adress_NVA = new DataGridViewTextBoxColumn();
            Money_NVA = new DataGridViewTextBoxColumn();
            Phone_Nva = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            groupBoxData_NVA.SuspendLayout();
            tabControl_NVA.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBoxFilter_NVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData_NVA).BeginInit();
            groupBoxWorkData_NVA.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartMoney_NVA).BeginInit();
            SuspendLayout();
            // 
            // toolTip_NVA
            // 
            toolTip_NVA.ToolTipIcon = ToolTipIcon.Info;
            // 
            // buttonDel_NVA
            // 
            buttonDel_NVA.Image = Properties.Resources.basket_put;
            buttonDel_NVA.Location = new Point(144, 38);
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
            buttonDownload_NVA.Location = new Point(127, 38);
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
            buttonAdd_NVA.Location = new Point(39, 37);
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
            buttonOpen_NVA.Location = new Point(26, 38);
            buttonOpen_NVA.Name = "buttonOpen_NVA";
            buttonOpen_NVA.Size = new Size(77, 54);
            buttonOpen_NVA.TabIndex = 1;
            toolTip_NVA.SetToolTip(buttonOpen_NVA, "Загрузить исходную базу данных");
            buttonOpen_NVA.UseVisualStyleBackColor = true;
            buttonOpen_NVA.Click += Openbutton_NVA_Click;
            // 
            // buttonStats_NVA
            // 
            buttonStats_NVA.Location = new Point(489, 529);
            buttonStats_NVA.Name = "buttonStats_NVA";
            buttonStats_NVA.Size = new Size(103, 33);
            buttonStats_NVA.TabIndex = 1;
            buttonStats_NVA.Text = "Рассчитать";
            toolTip_NVA.SetToolTip(buttonStats_NVA, "Нажмите, чтобы получить диаграмму размеров выручки магазинов");
            buttonStats_NVA.UseVisualStyleBackColor = true;
            buttonStats_NVA.Click += buttonStats_NVA_Click;
            // 
            // buttonFilter_NVA
            // 
            buttonFilter_NVA.BackColor = SystemColors.AppWorkspace;
            buttonFilter_NVA.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonFilter_NVA.Location = new Point(440, 47);
            buttonFilter_NVA.Name = "buttonFilter_NVA";
            buttonFilter_NVA.Size = new Size(132, 45);
            buttonFilter_NVA.TabIndex = 7;
            buttonFilter_NVA.Text = "Отфильтровать";
            toolTip_NVA.SetToolTip(buttonFilter_NVA, "Нажмите для фильтрации");
            buttonFilter_NVA.UseVisualStyleBackColor = false;
            buttonFilter_NVA.Click += buttonFilter_NVA_Click;
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
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem, оРазработчикеToolStripMenuItem, поддержкаToolStripMenuItem });
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
            // поддержкаToolStripMenuItem
            // 
            поддержкаToolStripMenuItem.Name = "поддержкаToolStripMenuItem";
            поддержкаToolStripMenuItem.Size = new Size(233, 30);
            поддержкаToolStripMenuItem.Text = "Поддержка";
            поддержкаToolStripMenuItem.Click += поддержкаToolStripMenuItem_Click;
            // 
            // groupBoxData_NVA
            // 
            groupBoxData_NVA.Controls.Add(tabControl_NVA);
            groupBoxData_NVA.Dock = DockStyle.Top;
            groupBoxData_NVA.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxData_NVA.Location = new Point(0, 33);
            groupBoxData_NVA.Name = "groupBoxData_NVA";
            groupBoxData_NVA.Size = new Size(1123, 642);
            groupBoxData_NVA.TabIndex = 2;
            groupBoxData_NVA.TabStop = false;
            // 
            // tabControl_NVA
            // 
            tabControl_NVA.Controls.Add(tabPage2);
            tabControl_NVA.Controls.Add(tabPage1);
            tabControl_NVA.Location = new Point(6, 3);
            tabControl_NVA.Name = "tabControl_NVA";
            tabControl_NVA.SelectedIndex = 0;
            tabControl_NVA.Size = new Size(1105, 659);
            tabControl_NVA.TabIndex = 7;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(splitter3);
            tabPage2.Controls.Add(splitter2);
            tabPage2.Controls.Add(splitter1);
            tabPage2.Controls.Add(groupBoxFilter_NVA);
            tabPage2.Controls.Add(dataGridViewData_NVA);
            tabPage2.Controls.Add(groupBoxWorkData_NVA);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1097, 625);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "База данных";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitter3
            // 
            splitter3.Location = new Point(9, 3);
            splitter3.Name = "splitter3";
            splitter3.Size = new Size(3, 619);
            splitter3.TabIndex = 14;
            splitter3.TabStop = false;
            // 
            // splitter2
            // 
            splitter2.Location = new Point(6, 3);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(3, 619);
            splitter2.TabIndex = 13;
            splitter2.TabStop = false;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(3, 3);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 619);
            splitter1.TabIndex = 12;
            splitter1.TabStop = false;
            // 
            // groupBoxFilter_NVA
            // 
            groupBoxFilter_NVA.Controls.Add(label3);
            groupBoxFilter_NVA.Controls.Add(textBoxSearch_NVA);
            groupBoxFilter_NVA.Controls.Add(label2);
            groupBoxFilter_NVA.Controls.Add(label1);
            groupBoxFilter_NVA.Controls.Add(comboBoxNames_NVA);
            groupBoxFilter_NVA.Controls.Add(textBoxFilter_NVA);
            groupBoxFilter_NVA.Controls.Add(buttonFilter_NVA);
            groupBoxFilter_NVA.Location = new Point(522, 6);
            groupBoxFilter_NVA.Name = "groupBoxFilter_NVA";
            groupBoxFilter_NVA.Size = new Size(575, 113);
            groupBoxFilter_NVA.TabIndex = 11;
            groupBoxFilter_NVA.TabStop = false;
            groupBoxFilter_NVA.Text = "Фильтрация и поиск";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(6, 37);
            label3.Name = "label3";
            label3.Size = new Size(120, 17);
            label3.TabIndex = 14;
            label3.Text = "Ключ для поиска:";
            // 
            // textBoxSearch_NVA
            // 
            textBoxSearch_NVA.Location = new Point(6, 63);
            textBoxSearch_NVA.Name = "textBoxSearch_NVA";
            textBoxSearch_NVA.Size = new Size(145, 29);
            textBoxSearch_NVA.TabIndex = 13;
            textBoxSearch_NVA.TextChanged += textBoxSearch_NVA_TextChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(302, 37);
            label2.Name = "label2";
            label2.Size = new Size(128, 17);
            label2.TabIndex = 12;
            label2.Text = "Ключ для фильтра:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(157, 38);
            label1.Name = "label1";
            label1.Size = new Size(127, 17);
            label1.TabIndex = 11;
            label1.Text = "Выберите столбец:";
            // 
            // comboBoxNames_NVA
            // 
            comboBoxNames_NVA.FormattingEnabled = true;
            comboBoxNames_NVA.Items.AddRange(new object[] { "", "Номер филиала", "Название магазина", "Адрес", "Капитал владельца в данной точке", "Контактный телефон" });
            comboBoxNames_NVA.Location = new Point(157, 63);
            comboBoxNames_NVA.Name = "comboBoxNames_NVA";
            comboBoxNames_NVA.Size = new Size(130, 29);
            comboBoxNames_NVA.TabIndex = 10;
            // 
            // textBoxFilter_NVA
            // 
            textBoxFilter_NVA.Location = new Point(302, 62);
            textBoxFilter_NVA.Name = "textBoxFilter_NVA";
            textBoxFilter_NVA.Size = new Size(132, 29);
            textBoxFilter_NVA.TabIndex = 9;
            textBoxFilter_NVA.TextChanged += textBoxFilter_NVA_TextChanged;
            // 
            // dataGridViewData_NVA
            // 
            dataGridViewData_NVA.AllowUserToAddRows = false;
            dataGridViewData_NVA.BackgroundColor = SystemColors.ActiveBorder;
            dataGridViewData_NVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData_NVA.Columns.AddRange(new DataGridViewColumn[] { Number_NVA, Name_NVA, Adress_NVA, Money_NVA, Phone_Nva });
            dataGridViewData_NVA.Location = new Point(18, 125);
            dataGridViewData_NVA.Name = "dataGridViewData_NVA";
            dataGridViewData_NVA.RowHeadersVisible = false;
            dataGridViewData_NVA.RowHeadersWidth = 50;
            dataGridViewData_NVA.RowTemplate.Height = 24;
            dataGridViewData_NVA.Size = new Size(1073, 464);
            dataGridViewData_NVA.TabIndex = 0;
            dataGridViewData_NVA.RowPrePaint += dataGridViewData_NVA_RowPrePaint;
            // 
            // groupBoxWorkData_NVA
            // 
            groupBoxWorkData_NVA.Controls.Add(buttonOpen_NVA);
            groupBoxWorkData_NVA.Controls.Add(buttonDownload_NVA);
            groupBoxWorkData_NVA.Location = new Point(18, 6);
            groupBoxWorkData_NVA.Name = "groupBoxWorkData_NVA";
            groupBoxWorkData_NVA.Size = new Size(233, 113);
            groupBoxWorkData_NVA.TabIndex = 5;
            groupBoxWorkData_NVA.TabStop = false;
            groupBoxWorkData_NVA.Text = "Загрузка/Выгрузка файла";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonAdd_NVA);
            groupBox1.Controls.Add(buttonDel_NVA);
            groupBox1.Location = new Point(257, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(259, 113);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавление/удаление данных";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonStats_NVA);
            tabPage1.Controls.Add(chartMoney_NVA);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1097, 625);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Статистика";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // chartMoney_NVA
            // 
            chartArea1.Name = "Размер выручки";
            chartMoney_NVA.ChartAreas.Add(chartArea1);
            legend1.Name = "Сумма выручек";
            chartMoney_NVA.Legends.Add(legend1);
            chartMoney_NVA.Location = new Point(17, 20);
            chartMoney_NVA.Name = "chartMoney_NVA";
            chartMoney_NVA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "Размер выручки";
            series1.Legend = "Сумма выручек";
            series1.Name = "Сумма выручки в месяц";
            series1.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            chartMoney_NVA.Series.Add(series1);
            chartMoney_NVA.Size = new Size(1055, 486);
            chartMoney_NVA.TabIndex = 0;
            chartMoney_NVA.Text = "Сумма выручки";
            // 
            // Number_NVA
            // 
            Number_NVA.DataPropertyName = "1";
            Number_NVA.DividerWidth = 1;
            Number_NVA.HeaderText = "Номер филиала";
            Number_NVA.MinimumWidth = 6;
            Number_NVA.Name = "Number_NVA";
            Number_NVA.SortMode = DataGridViewColumnSortMode.Programmatic;
            Number_NVA.Width = 214;
            // 
            // Name_NVA
            // 
            Name_NVA.DataPropertyName = "2";
            Name_NVA.DividerWidth = 1;
            Name_NVA.HeaderText = "Название";
            Name_NVA.MinimumWidth = 6;
            Name_NVA.Name = "Name_NVA";
            Name_NVA.SortMode = DataGridViewColumnSortMode.NotSortable;
            Name_NVA.Width = 214;
            // 
            // Adress_NVA
            // 
            Adress_NVA.DataPropertyName = "3";
            Adress_NVA.DividerWidth = 1;
            Adress_NVA.HeaderText = "Адрес";
            Adress_NVA.MinimumWidth = 6;
            Adress_NVA.Name = "Adress_NVA";
            Adress_NVA.SortMode = DataGridViewColumnSortMode.NotSortable;
            Adress_NVA.Width = 214;
            // 
            // Money_NVA
            // 
            Money_NVA.DataPropertyName = "4";
            Money_NVA.DividerWidth = 1;
            Money_NVA.HeaderText = "Капитал владельца в данной точке";
            Money_NVA.MinimumWidth = 6;
            Money_NVA.Name = "Money_NVA";
            Money_NVA.SortMode = DataGridViewColumnSortMode.NotSortable;
            Money_NVA.Width = 214;
            // 
            // Phone_Nva
            // 
            Phone_Nva.DataPropertyName = "5";
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
            tabControl_NVA.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBoxFilter_NVA.ResumeLayout(false);
            groupBoxFilter_NVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData_NVA).EndInit();
            groupBoxWorkData_NVA.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartMoney_NVA).EndInit();
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
        private Button buttonOpen_NVA;
        private Button buttonDownload_NVA;
        private Button buttonDel_NVA;
        private Button buttonAdd_NVA;
        private GroupBox groupBox1;
        private GroupBox groupBoxWorkData_NVA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TabControl tabControl_NVA;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private Button buttonStats_NVA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMoney_NVA;
        private ComboBox comboBoxNames_NVA;
        private TextBox textBoxFilter_NVA;
        private GroupBox groupBoxFilter_NVA;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox textBoxSearch_NVA;
        private Splitter splitter1;
        private ToolStripMenuItem поддержкаToolStripMenuItem;
        private Button buttonFilter_NVA;
        private Splitter splitter2;
        private Splitter splitter3;
        private DataGridViewTextBoxColumn Number_NVA;
        private DataGridViewTextBoxColumn Name_NVA;
        private DataGridViewTextBoxColumn Adress_NVA;
        private DataGridViewTextBoxColumn Money_NVA;
        private DataGridViewTextBoxColumn Phone_Nva;
    }
}

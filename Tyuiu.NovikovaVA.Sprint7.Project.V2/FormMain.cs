using Tyuiu.NovikovaVA.Sprint7.Project.V2.Lib;
namespace Tyuiu.NovikovaVA.Sprint7.Project.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_NVA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            
        }
        
        DataService ds = new DataService();
        string openFilePath;
        int cols, rows;
        private void Openbutton_NVA_Click(object sender, EventArgs e)
        {
            openFileDialog_NVA.ShowDialog();
            openFilePath = openFileDialog_NVA.FileName;

            string[,] arrayValues = ds.LoadFromFileData(openFilePath);
            dataGridViewData_NVA.ColumnCount = cols = arrayValues.GetLength(1);
            dataGridViewData_NVA.RowCount = rows = arrayValues.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewData_NVA.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            if (dataGridViewData_NVA.Rows.Count != 0) { buttonDel_NVA.Enabled = true; }
        }
        private void buttonDownload_NVA_Click(object sender, EventArgs e)
        {
            saveFileDialog_NVA.FileName = "DataBase.csv";
            saveFileDialog_NVA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_NVA.ShowDialog();


            string path = saveFileDialog_NVA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewData_NVA.RowCount;
            int columns = dataGridViewData_NVA.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewData_NVA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewData_NVA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }

        }
        private void buttonAdd_NVA_Click(object sender, EventArgs e)
        {
            dataGridViewData_NVA.Rows.Add();
            buttonDel_NVA.Enabled = true;
        }

        private void buttonInfo_NVA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonDel_NVA_Click(object sender, EventArgs e)
        {
            if (dataGridViewData_NVA.SelectedCells.Count == 0)
            {
                MessageBox.Show("Пожалуйста выберите строку для удаления.", "Строка не выбрана", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Confirm deletion (optional, but highly recommended).
                if (MessageBox.Show("Вы уверены, что хотите удалить строчку?", "Подтвердить удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int rowIndex = dataGridViewData_NVA.SelectedCells[0].RowIndex;
                    dataGridViewData_NVA.Rows.RemoveAt(rowIndex);
                    dataGridViewData_NVA.ClearSelection(); // Clear selection.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления строки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (dataGridViewData_NVA.Rows.Count == 0)
            {
                buttonDel_NVA.Enabled = false;
            }
        }
        private void toolStripMenuItemInstruction_NVA_Click(object sender, EventArgs e)
        {
            FormInstruction formInstruction = new FormInstruction();
            formInstruction.ShowDialog();
        }
        private void comboBoxNames_NVA_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxFilter_NVA.Enabled = (comboBoxNames_NVA.SelectedIndex != 0);
            buttonFilter_NVA.Enabled = (comboBoxNames_NVA.SelectedIndex != 0);
        }
        private void buttonFilter_NVA_Click(object sender, EventArgs e)
        {
            int columnIndex = comboBoxNames_NVA.SelectedIndex;
            if (columnIndex < 0 || columnIndex >= dataGridViewData_NVA.ColumnCount) return;

            string filterText = textBoxFilter_NVA.Text.ToUpper();

            foreach (DataGridViewRow r in dataGridViewData_NVA.Rows)
            {
                string cellValue = r.Cells[columnIndex].Value?.ToString().ToUpper() ?? "";
                r.Visible = cellValue.Contains(filterText);
            }
            dataGridViewData_NVA.CurrentCell = null; 
        }
        private void textBoxFilter_NVA_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonStats_NVA_Click(object sender, EventArgs e)
        {
            chartMoney_NVA.Series.Clear();
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Ежемесячная выручка");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            foreach (DataGridViewRow row in this.dataGridViewData_NVA.Rows)
            {
                if (!row.IsNewRow && row.Cells[3] != null && row.Cells[3].Value != null)
                {
                    string label = row.Cells[0].Value.ToString();
                    double hours = Convert.ToDouble(row.Cells[3].Value);
                    series.Points.AddXY(label, hours);
                }
            }
            this.chartMoney_NVA.Series.Add(series);
        }
        private void dataGridViewData_NVA_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = e.RowIndex;
            string indexStr = (index).ToString();
            object header = this.dataGridViewData_NVA.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(indexStr))
                this.dataGridViewData_NVA.Rows[index].HeaderCell.Value = indexStr;
        }
        private void textBoxSearch_NVA_TextChanged_1(object sender, EventArgs e)
        {

            string currentText = textBoxSearch_NVA.Text;
            foreach (DataGridViewRow row in dataGridViewData_NVA.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && !string.IsNullOrEmpty(currentText) && cell.Value.ToString().ToUpper().Contains(currentText.ToUpper()))
                    {
                        cell.Style.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        cell.Style.BackColor = Color.White; 
                    }
                }
            }
        }

    }
}

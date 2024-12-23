using System.Data;
using System.Windows.Forms;
using Tyuiu.NovikovaVA.Sprint7.Project.V2.Lib;
namespace Tyuiu.NovikovaVA.Sprint7.Project.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_NVA.Filter = "��������, ���������� ��������(*.csv)|*.csv|��� �����(*.*)|*.*";

            
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

            try
            {
                int newRowIndex = dataGridViewData_NVA.Rows.Add();
                string numberColumnName = dataGridViewData_NVA.Columns.Count > 0 ? dataGridViewData_NVA.Columns[0].Name : null;

                if (!string.IsNullOrEmpty(numberColumnName))
                {
                    dataGridViewData_NVA.Rows[newRowIndex].Cells[numberColumnName].Value = newRowIndex + 1;
                }

                if (dataGridViewData_NVA.Rows.Count > 0)
                {
                    buttonDel_NVA.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ���������� ����� ������ {ex.Message}");
            }
        }

        private void buttonInfo_NVA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonDel_NVA_Click(object sender, EventArgs e)
        {
            dataGridViewData_NVA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dataGridViewData_NVA.SelectedRows.Count == 0)
            {
                MessageBox.Show("����������, �������� ������ ��� ��������.", "������ �� �������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("�� �������, ��� ������ ������� ��������� ������?", "����������� ��������", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {

                List<int> rowsToDelete = new List<int>();
                foreach (DataGridViewRow selectedRow in dataGridViewData_NVA.SelectedRows)
                    rowsToDelete.Add(selectedRow.Index);

                for (int i = rowsToDelete.Count - 1; i >= 0; i--)
                {
                    dataGridViewData_NVA.Rows.RemoveAt(rowsToDelete[i]);
                }

                dataGridViewData_NVA.ClearSelection();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ �������� ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
       

        private void textBoxFilter_NVA_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonFilter_NVA_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridViewData_NVA.Rows)
            {
                if ((r.Cells[comboBoxNames_NVA.SelectedIndex - 1].Value).ToString().ToUpper().Contains(textBoxFilter_NVA.Text.ToUpper()))
                {
                    dataGridViewData_NVA.Rows[r.Index].Visible = true;
                    dataGridViewData_NVA.Rows[r.Index].Selected = true;
                }
                else
                {
                    dataGridViewData_NVA.CurrentCell = null;
                    dataGridViewData_NVA.Rows[r.Index].Visible = false;
                }
            }
        }

        private void comboBoxColsNames_KEE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNames_NVA.SelectedIndex != 0)
            {
                textBoxFilter_NVA.Enabled = true;
                textBoxFilter_NVA.Enabled = true;
            }
            else
            {
                textBoxFilter_NVA.Enabled = false;
                textBoxFilter_NVA.Enabled = false;
            }
        }
        private void buttonStats_NVA_Click(object sender, EventArgs e)
        {
            chartMoney_NVA.Series.Clear();
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("����� ������� � �����");
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
        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp FormHelp = new FormHelp();
            FormHelp.ShowDialog();
        }
        


    }
}

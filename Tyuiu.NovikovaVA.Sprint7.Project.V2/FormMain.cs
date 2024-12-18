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
            int ind = dataGridViewData_NVA.SelectedCells[0].RowIndex;
            dataGridViewData_NVA.Rows.RemoveAt(ind);
            if (dataGridViewData_NVA.Rows.Count == 0) { buttonDel_NVA.Enabled = false; }
        }
        private void toolStripMenuItemInstruction_NVA_Click(object sender, EventArgs e)
        {
            FormInstruction formInstruction = new FormInstruction();
            formInstruction.ShowDialog();
        }


    }
}

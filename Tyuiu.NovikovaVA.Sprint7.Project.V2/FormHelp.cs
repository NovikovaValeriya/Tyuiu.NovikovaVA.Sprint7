using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.NovikovaVA.Sprint7.Project.V2
{
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
        }


        private void buttonOp_NVA_Click(object sender, EventArgs e)
        {
            string externalSourceUrl = "https://project11658909.tilda.ws/";

            try
            {
                // Use ProcessStartInfo for better control
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = externalSourceUrl,
                    UseShellExecute = true // Important for using default browser
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии внешнего источника: {ex.Message}");
                //Consider logging the exception for debugging
            }
        }
            private void buttonOk2_NVA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

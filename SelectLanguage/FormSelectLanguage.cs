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

namespace SelectLanguage
{
    public partial class FormSelectLanguage : Form
    {
        public FormSelectLanguage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Close dialog.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">A event <see cref="EventArgs"/> .</param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        /// <summary>
        /// Continue to install.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonContinue_Click(object sender, EventArgs e)
        {
            try
            {
                var pos = this.comboBoxLanguages.SelectedIndex;
                Process p = new Process();
                string path = string.Empty;

                switch (pos)
                {
                    case 0:
                        path = Path.Combine(Environment.CurrentDirectory, @"es-es\SetupProjectSincroniaLocalization.msi");
                        
                        p.StartInfo.FileName = "msiexec";
                        p.StartInfo.Arguments = $"/i \"{path}\"";
                        p.Start();

                        this.Dispose(true);
                        break;
                    case 1:
                        path = Path.Combine(Environment.CurrentDirectory, @"en-us\SetupProjectSincroniaLocalization.msi");

                        p = new Process();
                        p.StartInfo.FileName = "msiexec";
                        p.StartInfo.Arguments = $"/i \"{path}\"";
                        p.Start();

                        this.Dispose(true);
                        break;
                    case 2:
                        path = Path.Combine(Environment.CurrentDirectory, @"de-de\SetupProjectSincroniaLocalization.msi");

                        p = new Process();
                        p.StartInfo.FileName = "msiexec";
                        p.StartInfo.Arguments = $"/i \"{path}\"";
                        p.Start();

                        this.Dispose(true);
                        break;
                    case 3:
                        path = Path.Combine(Environment.CurrentDirectory, @"sk-sk\SetupProjectSincroniaLocalization.msi");

                        p = new Process();
                        p.StartInfo.FileName = "msiexec";
                        p.StartInfo.Arguments = $"/i \"{path}\"";
                        p.Start();

                        this.Dispose(true);
                        break;
                    default:
                        throw new Exception("Error selecting language.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", System.Windows.Forms.MessageBoxButtons.YesNo,System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}

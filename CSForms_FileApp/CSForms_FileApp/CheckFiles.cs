using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSForms_FileApp
{
    public partial class CheckFiles : Form
    {
        public CheckFiles(List<File> files)
        {
            InitializeComponent();

            foreach (File file in files)
            {
                dataGridView1.Rows.Add(file.Name, file.Content, file.Length, file.CreationTime);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
    public partial class EditFile : Form
    {
        private List<File> files1;

        public EditFile(List<File> files)
        {
            InitializeComponent();
            foreach(File file in files)
            {
                comboBox1.Items.Add(file.Name);
            }
            files1 = files;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex >= 0)
            {
                files1[comboBox1.SelectedIndex].AppendData(txtboxAddText.Text);
                txtboxAddText.Text = string.Empty;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
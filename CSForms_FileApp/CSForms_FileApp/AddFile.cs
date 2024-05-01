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
    public partial class AddFile : Form
    {
        private OperationSelect owner;
        public AddFile(OperationSelect owner)
        {
            InitializeComponent();
            this.owner = owner;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                owner.AddNewFile(new File(textBox1.Text, textBox3.Text));
                Close();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

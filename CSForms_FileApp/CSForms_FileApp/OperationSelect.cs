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
    public partial class OperationSelect : Form
    {
        private List<File> files = new List<File>();
        public OperationSelect()
        {
            InitializeComponent();

            files.Add(new File("Test_file1", "Something", new DateTime(2005, 05, 01)));
            files.Add(new File("LabSTL", "#include <vector>", new DateTime(2024, 04, 05)));
            files.Add(new File("MySchedule", "Monday..", new DateTime(2023, 11, 01)));
        }

        private void AddFile_Click(object sender, EventArgs e)
        {
            new AddFile(this).ShowDialog();
        }

        public void AddNewFile(File file)
        {
            files.Add(file);
        }

        private void CheckFiles_Click(object sender, EventArgs e)
        {
            new CheckFiles(files).ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           new EditFile(files).ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab14_files
{
    internal partial class AddEmployee : Form
    {
        private List<Employee> employees;
        public AddEmployee(List<Employee> employees)
        {
            InitializeComponent();
            this.employees = employees;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string fullName = txtFullName.Text;

                string department = txtDepartment.Text;

                string position = txtPosition.Text;

                double expYears;
                double salary;

                if (!double.TryParse(txtExperienceYears.Text, out expYears))
                {
                    throw new FormatException("Invalid experience years input. ");
                }

                if (!double.TryParse(txtSalary.Text, out salary))
                {
                    throw new FormatException("Invalid salary input. ");
                }
                
                Employee employee = new Employee(fullName, department, position, expYears, salary);
                
                employees.Add(employee);

                MessageBox.Show("New employee added to list. ");

                Close();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error while creating new employee", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

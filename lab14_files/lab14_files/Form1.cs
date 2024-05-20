using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab14_files
{
    internal partial class Form1 : Form
    {
        private List<Employee> employees = new List<Employee>();
        public Form1()
        {
            InitializeComponent();
            // HardcodedEmployees();
        }

        private void btnFindEmployees_Click(object sender, EventArgs e)
        {
            labelEnterPosition.Visible = true;
            txtPosition.Visible = true;
            btnFind.Visible = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Find();
        }

        private void txtPosition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Find();
            }
        }

        // ------ НЕ МОЖНА ЗМІШУВАТИ ЛОГІКУ ПРОГРАМИ І UserInterface!!!!!!!!!
        private void Find()
        {
            string positionToFind = txtPosition.Text;

            List<Employee> selectedEmployees = GetEmployeesByPosition(positionToFind);

            dataGridView1.Rows.Clear();


            if (selectedEmployees.Count > 0)
            {
                foreach (Employee employee in selectedEmployees)
                {
                    dataGridView1.Rows.Add(employee.FullName,
                                            employee.Department,
                                            employee.Position,
                                            employee.ExperienceYears,
                                            employee.Salary,
                                            employee.Bonus);
                }
            }
            else
            {
                MessageBox.Show($@"No employees with position ""{positionToFind}""", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddEmployee(employees).ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            try
            {
                employees.Sort();
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorting error: " + ex.Message);
            }
        }

        private void btnWriteToFile_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Data file (.dat)|*.dat|Text documents (.txt)|*.txt";

                saveFileDialog.ShowDialog();
                using (Stream stream = File.Open(saveFileDialog.FileName,
                    FileMode.OpenOrCreate))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, employees);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadFromFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Data file (.dat)|*.dat|Text documents (.txt)|*.txt";

                openFileDialog.ShowDialog();

                using (Stream stream = File.Open(openFileDialog.FileName,
                    FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    employees = formatter.Deserialize(stream) as List<Employee>;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ------------------ Methods -----------------

        private void HardcodedEmployees()
        {
            Employee employee1 = new Employee("Anthony Edwards", "Basketball", "just Dad", 5, 13000);
            Employee employee2 = new Employee("Alice Smith", "Marketing", "Coordinator", 3.5, 9000);
            Employee employee3 = new Employee("David Lee", "Finance", "Accountant", 6, 11000);
            Employee employee4 = new Employee("Emily Brown", "Human Resources", "Specialist", 2, 6000);
            Employee employee5 = new Employee("Bob Johnson", "Engineering", "Developer", 7, 20000);

            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);

            RefreshData();
        }

        private List<Employee> GetEmployeesByPosition(string positionToFind)
        {
            List<Employee> selectedEmployees = new List<Employee>();

            foreach(Employee employee in employees)
            {
                if (employee.Position != null 
                    && employee.Position.Contains(positionToFind))
                {
                    selectedEmployees.Add(employee);
                }
            }

            return selectedEmployees;
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        private void RefreshData()
        {
            dataGridView1.Rows.Clear();

            foreach (Employee employee in employees)
            {
                dataGridView1.Rows.Add(employee.FullName,
                                        employee.Department,
                                        employee.Position,
                                        employee.ExperienceYears,
                                        employee.Salary,
                                        employee.Bonus);
            }
        }
    }
}

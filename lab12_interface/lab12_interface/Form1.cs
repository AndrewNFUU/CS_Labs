using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab12_interface
{
    public partial class frmCalculator : Form
    {
        SimpleString[] strArr = new SimpleString[10];
        public frmCalculator()
        {
            InitializeComponent();

            AddStrings(strArr);
            FillDataGrid(strArr);
            textBoxInput.Text = "Innitial";
        }

        private void AddStrings(SimpleString[] strings)
        {
            try
            {
                strings[0] = new SimpleString("text text text");
                strings[1] = new SimpleString("Lab 12");
                strings[2] = new SimpleString("A is the first letter");
                strings[3] = new SimpleString("UUUwUUU");
                strings[4] = new SimpleString("Sssomething else");

                for (int i = 0; i < strings.Length / 2; i++)
                {
                    strings[strings.Length / 2 + i] = (SimpleString)strings[i].Clone();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filling array: " + ex.Message);
            }
        }

        private void FillDataGrid(SimpleString[] strings)
        {
            dataGridView1.Rows.Clear();

            foreach(SimpleString str in strings)
            {
                dataGridView1.Rows.Add(str.Str, str.ByteSize, str.IntSize);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            try
            {
                Array.Sort(strArr);
                FillDataGrid(strArr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorting error: " + ex.Message);
            }
        }

        private void btnMirror_Click(object sender, EventArgs e)
        {
            try
            {
                string txtInput = textBoxInput.Text;

                SimpleString inputStr = new SimpleString(txtInput);

                textBoxResult.Clear();

                string mirror = inputStr.MirrorString();

                textBoxResult.Text = mirror;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error mirroring strings: " + ex.Message);
            }
        }

        private void btnConcat_Click(object sender, EventArgs e)
        {
            try
            {
                string txtInput = textBoxInput.Text;

                SimpleString inputStr = new SimpleString(textBoxResult.Text);

                textBoxResult.Clear();

                string concat = inputStr.Concatenate(txtInput);

                textBoxResult.Text = concat;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error concatenating strings: " + ex.Message);
            }
        }


        private void frmCalculator_Load(object sender, EventArgs e)
        {
            cmbxAction.Items.Add("+");
            cmbxAction.Items.Add("-");
            cmbxAction.Items.Add("*");
            cmbxAction.Items.Add("/");
            cmbxAction.Items.Add(">");
            cmbxAction.Items.Add("<");

            cmbxAction.Text = "+";
        }

        private void btnCheckResult_Click(object sender, EventArgs e)
        {
            try
            {
                DecimalString firstNum = new DecimalString(txtFirstNum.Text);
                DecimalString secondNum = new DecimalString(txtSecondNum.Text);

                switch (cmbxAction.SelectedIndex)
                {
                    case 0:
                        txtResult.Text = (firstNum.Add(secondNum).ToString());
                        break;

                    case 1:
                        txtResult.Text = (firstNum.Subtract(secondNum).ToString());
                        break;

                    case 2:
                        txtResult.Text = (firstNum.Multiplication(secondNum).ToString());
                        break;

                    case 3:
                        txtResult.Text = (firstNum.Division(secondNum).ToString());
                        break;

                    case 4:
                        txtResult.Text = (firstNum.IsGreaterThan(secondNum).ToString());
                        break;

                    case 5:
                        txtResult.Text = (firstNum.IsLessThan(secondNum).ToString());
                        break;

                    default:
                        MessageBox.Show("Please select a valid operation.", "Invalid operation",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong..",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnShowLength_Click(object sender, EventArgs e)
        {
            try
            {
                SimpleString firstStr = new SimpleString(txtFirstNum.Text);
                SimpleString secondStr = new SimpleString(txtSecondNum.Text);

                int firstStrIntSize = firstStr.IntSize;
                byte firstStrByteSize = firstStr.ByteSize;

                int secondStrIntSize = secondStr.IntSize;
                byte secondStrByteSize = secondStr.ByteSize;

                MessageBox.Show($"first str size       | int: {firstStrIntSize},  byte: {firstStrByteSize}\n\n" +
                                $"second str size | int: {secondStrIntSize},  byte: {secondStrByteSize}",
                    "String sizes*", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab11_strings
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
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

                switch(cmbxAction.SelectedIndex)
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

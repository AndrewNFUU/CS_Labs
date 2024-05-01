using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Lab10_matrix
{
    public partial class Form1 : Form
    {
        MatrixProperties matrix;

        public Form1()
        {
            InitializeComponent();
            Width = 305;
        }

        private bool ValidDateInput()
        {
            if (string.IsNullOrEmpty(txtRows.Text)
                && string.IsNullOrEmpty(txtCols.Text)
                && string.IsNullOrEmpty(txtMinVal.Text)
                && string.IsNullOrEmpty(txtMaxVal.Text))
            {
                MessageBox.Show("Fill in all fields to create a matrix.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnGenerateMatrix_Click(object sender, EventArgs e)
        {
            try
            {
                // labelSumElements.Text = "";

                if (ValidDateInput())
                {
                    int rows = Convert.ToInt32(txtRows.Text);

                    if (rows > 8 || rows <= 1)
                    {
                        MessageBox.Show("                Хлопе спинисі! " +
                                        "\n\nДе стілько рядків пхати, постав від 2до 8!", 
                            "Помилка, а ти як си гадав", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int cols = Convert.ToInt32(txtCols.Text);

                    if (cols > 8 || cols <= 0)
                    {
                        MessageBox.Show("                Хлопе спинисі! " +
                                        "\n\nДе стілько колонок пхати, постав від 2 до 8!",
                            "Помилка, а ти як си гадав", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int min = Convert.ToInt32(txtMinVal.Text);

                    if (min < -99)
                    {
                        MessageBox.Show("               Хлопе спинисі! " +
                                        "\n\nДе такі цифри пхати, постав до -99!",
                            "Помилка, а ти як си гадав", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int max = Convert.ToInt32(txtMaxVal.Text);

                    if (max > 99)
                    {
                        MessageBox.Show("               Хлопе спинисі! " +
                                        "\n\nДе такі цифри пхати, постав до 99!",
                            "Помилка, а ти як си гадав", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Width = 630;
                    labelMatrix.Visible = true;
                    dataGridView.Visible = true;
                    btnSortMatrix.Visible = true;
                    matrix = new MatrixProperties(rows, cols);

                    matrix.FillMatrix(min, max);
                    PrintMatrix(matrix);
                    
                    label7.Visible = true;

                    int sum = matrix.SumElementsInColsWithNegativeNums();

                    if (sum > 0)
                    {
                        label7.Text += sum;
                    } 
                    else
                    {
                        label7.Text += "Ніц нема";
                    }
                } 
                else
                {
                    throw new Exception("Fill in all fields to create a matrix. ");
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintMatrix(MatrixProperties matrix)
        {
            DataTable dt = new DataTable();
            int cols = matrix.Cols;
            int rows = matrix.Rows; 

            for (int col = 0; col < cols; col++)
            {
                dt.Columns.Add(col.ToString(), typeof(double));

            }

            for (int row = 0; row < rows; row++)
            {
                DataRow dr = dt.NewRow();
                for (int col = 0; col < cols; col++)
                {
                    dr[col] = matrix[row, col];
                }
                dt.Rows.Add(dr);
            }

            dataGridView.DataSource = dt.DefaultView;

            dataGridView.ColumnHeadersVisible = false;
            dataGridView.RowHeadersVisible = false;
            dataGridView.AllowUserToAddRows = false;

            dataGridView.Font = new Font("Century Gothic", 10, FontStyle.Regular);

            for (int col = 0; col < cols; col++)
            {
                dataGridView.Columns[col].Width = 35;
            }

            for (int row = 0; row < rows; row++)
            {
                dataGridView.Rows[row].Height = 35;
            }
        }

        private void btnSortMatrix_Click(object sender, EventArgs e)
        {
            matrix.SortColsByCharacteristics();
            PrintMatrix(matrix);
        }
    }
}

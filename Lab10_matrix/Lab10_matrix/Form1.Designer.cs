namespace Lab10_matrix
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.txtCols = new System.Windows.Forms.TextBox();
            this.txtMinVal = new System.Windows.Forms.TextBox();
            this.txtMaxVal = new System.Windows.Forms.TextBox();
            this.btnGenerateMatrix = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnSortMatrix = new System.Windows.Forms.Button();
            this.labelMatrix = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelSumElements = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rows in matrix: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cols in matrix: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Min value in matrix: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(30, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Max value in matrix: ";
            // 
            // txtRows
            // 
            this.txtRows.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRows.Location = new System.Drawing.Point(269, 93);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(79, 28);
            this.txtRows.TabIndex = 4;
            // 
            // txtCols
            // 
            this.txtCols.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCols.Location = new System.Drawing.Point(269, 156);
            this.txtCols.Name = "txtCols";
            this.txtCols.Size = new System.Drawing.Size(79, 28);
            this.txtCols.TabIndex = 5;
            // 
            // txtMinVal
            // 
            this.txtMinVal.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMinVal.Location = new System.Drawing.Point(269, 219);
            this.txtMinVal.Name = "txtMinVal";
            this.txtMinVal.Size = new System.Drawing.Size(79, 28);
            this.txtMinVal.TabIndex = 6;
            // 
            // txtMaxVal
            // 
            this.txtMaxVal.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMaxVal.Location = new System.Drawing.Point(269, 284);
            this.txtMaxVal.Name = "txtMaxVal";
            this.txtMaxVal.Size = new System.Drawing.Size(79, 28);
            this.txtMaxVal.TabIndex = 7;
            // 
            // btnGenerateMatrix
            // 
            this.btnGenerateMatrix.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGenerateMatrix.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenerateMatrix.Location = new System.Drawing.Point(67, 409);
            this.btnGenerateMatrix.Name = "btnGenerateMatrix";
            this.btnGenerateMatrix.Size = new System.Drawing.Size(239, 66);
            this.btnGenerateMatrix.TabIndex = 8;
            this.btnGenerateMatrix.Text = "Generate Matrix";
            this.btnGenerateMatrix.UseVisualStyleBackColor = false;
            this.btnGenerateMatrix.Click += new System.EventHandler(this.btnGenerateMatrix_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "Set matrix parameters";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(387, 67);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(378, 348);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.Visible = false;
            // 
            // btnSortMatrix
            // 
            this.btnSortMatrix.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortMatrix.Location = new System.Drawing.Point(507, 429);
            this.btnSortMatrix.Name = "btnSortMatrix";
            this.btnSortMatrix.Size = new System.Drawing.Size(145, 46);
            this.btnSortMatrix.TabIndex = 1;
            this.btnSortMatrix.Text = "Sort matrix";
            this.btnSortMatrix.UseVisualStyleBackColor = true;
            this.btnSortMatrix.Visible = false;
            this.btnSortMatrix.Click += new System.EventHandler(this.btnSortMatrix_Click);
            // 
            // labelMatrix
            // 
            this.labelMatrix.AutoSize = true;
            this.labelMatrix.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatrix.Location = new System.Drawing.Point(465, 20);
            this.labelMatrix.Name = "labelMatrix";
            this.labelMatrix.Size = new System.Drawing.Size(214, 27);
            this.labelMatrix.TabIndex = 10;
            this.labelMatrix.Text = "Generated matrix";
            this.labelMatrix.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(31, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 42);
            this.label7.TabIndex = 12;
            this.label7.Text = "sum of elements in cols\r\nwith negative nums: ";
            // 
            // labelSumElements
            // 
            this.labelSumElements.AutoSize = true;
            this.labelSumElements.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumElements.Location = new System.Drawing.Point(209, 360);
            this.labelSumElements.Name = "labelSumElements";
            this.labelSumElements.Size = new System.Drawing.Size(0, 21);
            this.labelSumElements.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 502);
            this.Controls.Add(this.labelSumElements);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelMatrix);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSortMatrix);
            this.Controls.Add(this.btnGenerateMatrix);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txtMaxVal);
            this.Controls.Add(this.txtMinVal);
            this.Controls.Add(this.txtCols);
            this.Controls.Add(this.txtRows);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab10   |   Work with matrix";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.TextBox txtCols;
        private System.Windows.Forms.TextBox txtMinVal;
        private System.Windows.Forms.TextBox txtMaxVal;
        private System.Windows.Forms.Button btnGenerateMatrix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnSortMatrix;
        private System.Windows.Forms.Label labelMatrix;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelSumElements;
    }
}


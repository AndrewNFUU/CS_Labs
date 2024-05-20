namespace lab14_files
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnWriteToFile = new System.Windows.Forms.Button();
            this.btnReadFromFile = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expYears = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelEnterPosition = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnFindEmployees = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Linen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(660, 72);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(175, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add employee";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Linen;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefresh.Location = new System.Drawing.Point(660, 118);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(175, 40);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh data";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.Linen;
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSort.Location = new System.Drawing.Point(660, 164);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(175, 40);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Sort employees";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnWriteToFile
            // 
            this.btnWriteToFile.BackColor = System.Drawing.Color.MistyRose;
            this.btnWriteToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWriteToFile.Location = new System.Drawing.Point(660, 246);
            this.btnWriteToFile.Name = "btnWriteToFile";
            this.btnWriteToFile.Size = new System.Drawing.Size(175, 40);
            this.btnWriteToFile.TabIndex = 3;
            this.btnWriteToFile.Text = "Write to file";
            this.btnWriteToFile.UseVisualStyleBackColor = false;
            this.btnWriteToFile.Click += new System.EventHandler(this.btnWriteToFile_Click);
            // 
            // btnReadFromFile
            // 
            this.btnReadFromFile.BackColor = System.Drawing.Color.MistyRose;
            this.btnReadFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReadFromFile.Location = new System.Drawing.Point(660, 292);
            this.btnReadFromFile.Name = "btnReadFromFile";
            this.btnReadFromFile.Size = new System.Drawing.Size(175, 40);
            this.btnReadFromFile.TabIndex = 4;
            this.btnReadFromFile.Text = "Read from file";
            this.btnReadFromFile.UseVisualStyleBackColor = false;
            this.btnReadFromFile.Click += new System.EventHandler(this.btnReadFromFile_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullName,
            this.department,
            this.position,
            this.expYears,
            this.salary,
            this.bonus});
            this.dataGridView1.Location = new System.Drawing.Point(32, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(599, 260);
            this.dataGridView1.TabIndex = 5;
            // 
            // fullName
            // 
            this.fullName.HeaderText = "Full name";
            this.fullName.MinimumWidth = 6;
            this.fullName.Name = "fullName";
            this.fullName.Width = 95;
            // 
            // department
            // 
            this.department.HeaderText = "Department";
            this.department.MinimumWidth = 6;
            this.department.Name = "department";
            this.department.Width = 80;
            // 
            // position
            // 
            this.position.HeaderText = "Position";
            this.position.MinimumWidth = 6;
            this.position.Name = "position";
            this.position.Width = 80;
            // 
            // expYears
            // 
            this.expYears.HeaderText = "Experience y";
            this.expYears.MinimumWidth = 6;
            this.expYears.Name = "expYears";
            this.expYears.Width = 80;
            // 
            // salary
            // 
            this.salary.HeaderText = "Salary";
            this.salary.MinimumWidth = 6;
            this.salary.Name = "salary";
            this.salary.Width = 60;
            // 
            // bonus
            // 
            this.bonus.HeaderText = "Bonus";
            this.bonus.MinimumWidth = 6;
            this.bonus.Name = "bonus";
            this.bonus.Width = 50;
            // 
            // labelEnterPosition
            // 
            this.labelEnterPosition.AutoSize = true;
            this.labelEnterPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnterPosition.Location = new System.Drawing.Point(222, 32);
            this.labelEnterPosition.Name = "labelEnterPosition";
            this.labelEnterPosition.Size = new System.Drawing.Size(136, 25);
            this.labelEnterPosition.TabIndex = 6;
            this.labelEnterPosition.Text = "Enter position:";
            this.labelEnterPosition.Visible = false;
            // 
            // txtPosition
            // 
            this.txtPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPosition.Location = new System.Drawing.Point(373, 30);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(155, 27);
            this.txtPosition.TabIndex = 7;
            this.txtPosition.Visible = false;
            this.txtPosition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPosition_KeyDown);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFind.Location = new System.Drawing.Point(544, 26);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(87, 34);
            this.btnFind.TabIndex = 8;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Visible = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnFindEmployees
            // 
            this.btnFindEmployees.BackColor = System.Drawing.Color.Linen;
            this.btnFindEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFindEmployees.Location = new System.Drawing.Point(660, 26);
            this.btnFindEmployees.Name = "btnFindEmployees";
            this.btnFindEmployees.Size = new System.Drawing.Size(175, 40);
            this.btnFindEmployees.TabIndex = 9;
            this.btnFindEmployees.Text = "Find employees";
            this.btnFindEmployees.UseVisualStyleBackColor = false;
            this.btnFindEmployees.Click += new System.EventHandler(this.btnFindEmployees_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 365);
            this.Controls.Add(this.btnFindEmployees);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.labelEnterPosition);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnReadFromFile);
            this.Controls.Add(this.btnWriteToFile);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees info   |   Write & Read from file";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnWriteToFile;
        private System.Windows.Forms.Button btnReadFromFile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn expYears;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonus;
        private System.Windows.Forms.Label labelEnterPosition;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnFindEmployees;
    }
}


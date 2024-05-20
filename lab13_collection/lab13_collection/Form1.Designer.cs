namespace lab13_collection
{
    partial class frmStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStart));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnGenericQueue = new System.Windows.Forms.RadioButton();
            this.radioBtnQueue = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumOfElements = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtElement = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.btnFindPosition = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnGenericQueue);
            this.groupBox1.Controls.Add(this.radioBtnQueue);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Collection Option";
            // 
            // radioBtnGenericQueue
            // 
            this.radioBtnGenericQueue.AutoSize = true;
            this.radioBtnGenericQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioBtnGenericQueue.Location = new System.Drawing.Point(188, 34);
            this.radioBtnGenericQueue.Name = "radioBtnGenericQueue";
            this.radioBtnGenericQueue.Size = new System.Drawing.Size(211, 26);
            this.radioBtnGenericQueue.TabIndex = 1;
            this.radioBtnGenericQueue.TabStop = true;
            this.radioBtnGenericQueue.Text = "Queue<DecimalString>";
            this.radioBtnGenericQueue.UseVisualStyleBackColor = true;
            // 
            // radioBtnQueue
            // 
            this.radioBtnQueue.AutoSize = true;
            this.radioBtnQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioBtnQueue.Location = new System.Drawing.Point(48, 34);
            this.radioBtnQueue.Name = "radioBtnQueue";
            this.radioBtnQueue.Size = new System.Drawing.Size(81, 26);
            this.radioBtnQueue.TabIndex = 0;
            this.radioBtnQueue.TabStop = true;
            this.radioBtnQueue.Text = "Queue";
            this.radioBtnQueue.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.txtRemove);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnFindPosition);
            this.groupBox2.Controls.Add(this.txtPosition);
            this.groupBox2.Controls.Add(this.txtElement);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnCount);
            this.groupBox2.Controls.Add(this.txtCount);
            this.groupBox2.Controls.Add(this.labelCount);
            this.groupBox2.Controls.Add(this.txtOutput);
            this.groupBox2.Controls.Add(this.btnGenerate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtNumOfElements);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 356);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Working with collection";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(20, 198);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(53, 22);
            this.labelCount.TabIndex = 5;
            this.labelCount.Text = "Sum: ";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(176, 84);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(265, 29);
            this.txtOutput.TabIndex = 4;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(323, 22);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(118, 38);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Your collection: ";
            // 
            // txtNumOfElements
            // 
            this.txtNumOfElements.Location = new System.Drawing.Point(176, 27);
            this.txtNumOfElements.Name = "txtNumOfElements";
            this.txtNumOfElements.Size = new System.Drawing.Size(123, 29);
            this.txtNumOfElements.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size: ";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(176, 191);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(123, 29);
            this.txtCount.TabIndex = 6;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(323, 186);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(118, 38);
            this.btnCount.TabIndex = 7;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Element:";
            // 
            // txtElement
            // 
            this.txtElement.Location = new System.Drawing.Point(132, 244);
            this.txtElement.Name = "txtElement";
            this.txtElement.Size = new System.Drawing.Size(83, 29);
            this.txtElement.TabIndex = 9;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(346, 244);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.ReadOnly = true;
            this.txtPosition.Size = new System.Drawing.Size(95, 29);
            this.txtPosition.TabIndex = 10;
            // 
            // btnFindPosition
            // 
            this.btnFindPosition.Location = new System.Drawing.Point(292, 291);
            this.btnFindPosition.Name = "btnFindPosition";
            this.btnFindPosition.Size = new System.Drawing.Size(149, 38);
            this.btnFindPosition.TabIndex = 11;
            this.btnFindPosition.Text = "Find position";
            this.btnFindPosition.UseVisualStyleBackColor = true;
            this.btnFindPosition.Click += new System.EventHandler(this.btnFindPosition_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Position:";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(323, 134);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(118, 38);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(176, 139);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(123, 29);
            this.txtRemove.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Remove element:";
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(483, 492);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "start";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioBtnGenericQueue;
        private System.Windows.Forms.RadioButton radioBtnQueue;
        private System.Windows.Forms.TextBox txtNumOfElements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnFindPosition;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtElement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtRemove;
        private System.Windows.Forms.Label label5;
    }
}


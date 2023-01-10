namespace StoredProcedure_1
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
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnStp1 = new System.Windows.Forms.Button();
            this.btnStp2 = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnTransact = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(623, 206);
            this.dgvEmployees.TabIndex = 0;
            // 
            // btnStp1
            // 
            this.btnStp1.Location = new System.Drawing.Point(150, 266);
            this.btnStp1.Name = "btnStp1";
            this.btnStp1.Size = new System.Drawing.Size(110, 41);
            this.btnStp1.TabIndex = 1;
            this.btnStp1.Text = "Employees of Department";
            this.btnStp1.UseVisualStyleBackColor = true;
            this.btnStp1.Click += new System.EventHandler(this.btnStp1_Click);
            // 
            // btnStp2
            // 
            this.btnStp2.Location = new System.Drawing.Point(393, 266);
            this.btnStp2.Name = "btnStp2";
            this.btnStp2.Size = new System.Drawing.Size(99, 41);
            this.btnStp2.TabIndex = 2;
            this.btnStp2.Text = "Total Salary Of Department";
            this.btnStp2.UseVisualStyleBackColor = true;
            this.btnStp2.Click += new System.EventHandler(this.btnStp2_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(576, 266);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(91, 41);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnTransact
            // 
            this.btnTransact.Location = new System.Drawing.Point(659, 120);
            this.btnTransact.Name = "btnTransact";
            this.btnTransact.Size = new System.Drawing.Size(99, 41);
            this.btnTransact.TabIndex = 4;
            this.btnTransact.Text = "Transaction";
            this.btnTransact.UseVisualStyleBackColor = true;
            this.btnTransact.Click += new System.EventHandler(this.btnTransact_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTransact);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnStp2);
            this.Controls.Add(this.btnStp1);
            this.Controls.Add(this.dgvEmployees);
            this.Name = "Form1";
            this.Text = "StoredProcedure";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnStp1;
        private System.Windows.Forms.Button btnStp2;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnTransact;
    }
}


namespace File_Create_Copy_Delete
{
    partial class frmOperations
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
            this.txtCopyFile = new System.Windows.Forms.TextBox();
            this.txtDeleteFile = new System.Windows.Forms.TextBox();
            this.txtCreateFile = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCopyFile
            // 
            this.txtCopyFile.Location = new System.Drawing.Point(83, 238);
            this.txtCopyFile.Name = "txtCopyFile";
            this.txtCopyFile.Size = new System.Drawing.Size(178, 20);
            this.txtCopyFile.TabIndex = 0;
            // 
            // txtDeleteFile
            // 
            this.txtDeleteFile.Location = new System.Drawing.Point(83, 148);
            this.txtDeleteFile.Name = "txtDeleteFile";
            this.txtDeleteFile.Size = new System.Drawing.Size(178, 20);
            this.txtDeleteFile.TabIndex = 1;
            // 
            // txtCreateFile
            // 
            this.txtCreateFile.Location = new System.Drawing.Point(83, 61);
            this.txtCreateFile.Name = "txtCreateFile";
            this.txtCreateFile.Size = new System.Drawing.Size(178, 20);
            this.txtCreateFile.TabIndex = 2;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(464, 61);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(464, 145);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(464, 235);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // frmOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtCreateFile);
            this.Controls.Add(this.txtDeleteFile);
            this.Controls.Add(this.txtCopyFile);
            this.Name = "frmOperations";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCopyFile;
        private System.Windows.Forms.TextBox txtDeleteFile;
        private System.Windows.Forms.TextBox txtCreateFile;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCopy;
    }
}


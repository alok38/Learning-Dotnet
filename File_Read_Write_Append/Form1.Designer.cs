namespace File_Read_Write_Append
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
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtFileContents = new System.Windows.Forms.TextBox();
            this.txtNewText = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnAppend = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(380, 33);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(122, 20);
            this.txtFileName.TabIndex = 0;
            // 
            // txtFileContents
            // 
            this.txtFileContents.Location = new System.Drawing.Point(209, 167);
            this.txtFileContents.Name = "txtFileContents";
            this.txtFileContents.Size = new System.Drawing.Size(122, 20);
            this.txtFileContents.TabIndex = 1;
            // 
            // txtNewText
            // 
            this.txtNewText.Location = new System.Drawing.Point(209, 235);
            this.txtNewText.Name = "txtNewText";
            this.txtNewText.Size = new System.Drawing.Size(122, 20);
            this.txtNewText.TabIndex = 2;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(586, 101);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 3;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(586, 164);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 4;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnAppend
            // 
            this.btnAppend.Location = new System.Drawing.Point(586, 232);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(75, 23);
            this.btnAppend.TabIndex = 5;
            this.btnAppend.Text = "Append";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(414, 299);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(203, 101);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(128, 20);
            this.txtText.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "FileName";
            // 
            // frmOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAppend);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.txtNewText);
            this.Controls.Add(this.txtFileContents);
            this.Controls.Add(this.txtFileName);
            this.Name = "frmOperations";
            this.Text = "form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtFileContents;
        private System.Windows.Forms.TextBox txtNewText;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label label1;
    }
}


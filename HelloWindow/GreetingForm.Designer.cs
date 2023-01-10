namespace HelloWindow
{
    partial class frmGreeting
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
            this.btnHi = new System.Windows.Forms.Button();
            this.btnHello = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHi
            // 
            this.btnHi.Location = new System.Drawing.Point(142, 164);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(117, 49);
            this.btnHi.TabIndex = 0;
            this.btnHi.Text = "SayHi";
            this.btnHi.UseVisualStyleBackColor = true;
            this.btnHi.Click += new System.EventHandler(this.GreetMe);
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(448, 164);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(127, 49);
            this.btnHello.TabIndex = 1;
            this.btnHello.Text = "SayHello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.GreetMe);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(448, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(134, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(169, 84);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(92, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Enter Name Here:";
            // 
            // frmGreeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.btnHi);
            this.Name = "frmGreeting";
            this.Text = "MyGreetingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHi;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
    }
}


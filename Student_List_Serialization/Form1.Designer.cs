namespace Student_List_Serialization
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
            this.btnSerialize = new System.Windows.Forms.Button();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.btnXmlDeserialze = new System.Windows.Forms.Button();
            this.btnXmlSerialize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSerialize
            // 
            this.btnSerialize.Location = new System.Drawing.Point(242, 75);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(108, 39);
            this.btnSerialize.TabIndex = 0;
            this.btnSerialize.Text = "Serialize";
            this.btnSerialize.UseVisualStyleBackColor = true;
            this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.Location = new System.Drawing.Point(540, 75);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(110, 43);
            this.btnDeserialize.TabIndex = 1;
            this.btnDeserialize.Text = "Deserialize";
            this.btnDeserialize.UseVisualStyleBackColor = true;
            this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
            // 
            // btnXmlDeserialze
            // 
            this.btnXmlDeserialze.Location = new System.Drawing.Point(552, 137);
            this.btnXmlDeserialze.Name = "btnXmlDeserialze";
            this.btnXmlDeserialze.Size = new System.Drawing.Size(98, 49);
            this.btnXmlDeserialze.TabIndex = 3;
            this.btnXmlDeserialze.Text = "xml Deserialize";
            this.btnXmlDeserialze.UseVisualStyleBackColor = true;
            this.btnXmlDeserialze.Click += new System.EventHandler(this.btnXmlDeserialze_Click);
            // 
            // btnXmlSerialize
            // 
            this.btnXmlSerialize.Location = new System.Drawing.Point(242, 154);
            this.btnXmlSerialize.Name = "btnXmlSerialize";
            this.btnXmlSerialize.Size = new System.Drawing.Size(94, 49);
            this.btnXmlSerialize.TabIndex = 4;
            this.btnXmlSerialize.Text = "xml Serialize";
            this.btnXmlSerialize.UseVisualStyleBackColor = true;
            this.btnXmlSerialize.Click += new System.EventHandler(this.btnXmlSerialize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXmlSerialize);
            this.Controls.Add(this.btnXmlDeserialze);
            this.Controls.Add(this.btnDeserialize);
            this.Controls.Add(this.btnSerialize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.Button btnDeserialize;
        private System.Windows.Forms.Button btnXmlDeserialze;
        private System.Windows.Forms.Button btnXmlSerialize;
    }
}


namespace HelloGit
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
            this.btnBok = new System.Windows.Forms.Button();
            this.btnNb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBok
            // 
            this.btnBok.Location = new System.Drawing.Point(124, 115);
            this.btnBok.Name = "btnBok";
            this.btnBok.Size = new System.Drawing.Size(75, 23);
            this.btnBok.TabIndex = 0;
            this.btnBok.Text = "BOK";
            this.btnBok.UseVisualStyleBackColor = true;
            this.btnBok.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNb
            // 
            this.btnNb.Location = new System.Drawing.Point(89, 48);
            this.btnNb.Name = "btnNb";
            this.btnNb.Size = new System.Drawing.Size(75, 23);
            this.btnNb.TabIndex = 1;
            this.btnNb.Text = "novi_branch";
            this.btnNb.UseVisualStyleBackColor = true;
            this.btnNb.Click += new System.EventHandler(this.btnNb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnNb);
            this.Controls.Add(this.btnBok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBok;
        private System.Windows.Forms.Button btnNb;
    }
}


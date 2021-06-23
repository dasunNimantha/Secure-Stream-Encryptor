
namespace SSE
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
            this.btnChoose = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.checkNvidia = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(25, 83);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(146, 38);
            this.btnChoose.TabIndex = 0;
            this.btnChoose.Text = "Choose Video File";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(194, 85);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(382, 22);
            this.txtPath.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(232, 161);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            this.lblStatus.TabIndex = 2;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Enabled = false;
            this.btnEncrypt.Location = new System.Drawing.Point(217, 407);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(143, 43);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Encrypt Now";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Output Directory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(194, 167);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(382, 22);
            this.txtOutput.TabIndex = 5;
            // 
            // lblPass
            // 
            this.lblPass.BackColor = System.Drawing.Color.SpringGreen;
            this.lblPass.Location = new System.Drawing.Point(25, 243);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(146, 37);
            this.lblPass.TabIndex = 6;
            this.lblPass.Text = "Password";
            this.lblPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(194, 250);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(249, 22);
            this.txtPass.TabIndex = 7;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // checkNvidia
            // 
            this.checkNvidia.AutoSize = true;
            this.checkNvidia.Location = new System.Drawing.Point(325, 341);
            this.checkNvidia.Name = "checkNvidia";
            this.checkNvidia.Size = new System.Drawing.Size(274, 21);
            this.checkNvidia.TabIndex = 8;
            this.checkNvidia.Text = "Enable Hardware Acceleration (Nvidia)";
            this.checkNvidia.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 494);
            this.Controls.Add(this.checkNvidia);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnChoose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secure Stream Encryptor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.CheckBox checkNvidia;
    }
}


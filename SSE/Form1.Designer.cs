
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
            this.lblStatLable = new System.Windows.Forms.Label();
            this.lblStat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSessionName = new System.Windows.Forms.TextBox();
            this.checkLow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnChoose
            // 
            this.btnChoose.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose.Location = new System.Drawing.Point(24, 51);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(146, 40);
            this.btnChoose.TabIndex = 0;
            this.btnChoose.Text = "Choose Video File";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Font = new System.Drawing.Font("Segoe UI", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(193, 58);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(356, 26);
            this.txtPath.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(231, 129);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            this.lblStatus.TabIndex = 2;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Enabled = false;
            this.btnEncrypt.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(218, 500);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(143, 43);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Encrypt Now";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(24, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Output Directory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // txtOutput
            // 
            this.txtOutput.Enabled = false;
            this.txtOutput.Font = new System.Drawing.Font("Segoe UI", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(193, 135);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(356, 26);
            this.txtOutput.TabIndex = 5;
            // 
            // lblPass
            // 
            this.lblPass.BackColor = System.Drawing.Color.SpringGreen;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(24, 272);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(146, 40);
            this.lblPass.TabIndex = 6;
            this.lblPass.Text = "Password";
            this.lblPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(193, 281);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(249, 25);
            this.txtPass.TabIndex = 7;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // checkNvidia
            // 
            this.checkNvidia.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNvidia.Location = new System.Drawing.Point(264, 354);
            this.checkNvidia.Name = "checkNvidia";
            this.checkNvidia.Size = new System.Drawing.Size(336, 21);
            this.checkNvidia.TabIndex = 8;
            this.checkNvidia.Text = "Enable Hardware Acceleration (Nvidia)";
            this.checkNvidia.UseVisualStyleBackColor = true;
            this.checkNvidia.CheckedChanged += new System.EventHandler(this.checkNvidia_CheckedChanged);
            // 
            // lblStatLable
            // 
            this.lblStatLable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatLable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatLable.Location = new System.Drawing.Point(119, 425);
            this.lblStatLable.Name = "lblStatLable";
            this.lblStatLable.Size = new System.Drawing.Size(183, 39);
            this.lblStatLable.TabIndex = 9;
            this.lblStatLable.Text = "Encryption Status   :";
            this.lblStatLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStat
            // 
            this.lblStat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStat.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblStat.Location = new System.Drawing.Point(282, 425);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(207, 39);
            this.lblStat.TabIndex = 10;
            this.lblStat.Text = "IDLE";
            this.lblStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 40);
            this.label1.TabIndex = 11;
            this.label1.Text = "Session Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSessionName
            // 
            this.txtSessionName.Font = new System.Drawing.Font("Segoe UI", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSessionName.Location = new System.Drawing.Point(193, 205);
            this.txtSessionName.Name = "txtSessionName";
            this.txtSessionName.Size = new System.Drawing.Size(356, 26);
            this.txtSessionName.TabIndex = 12;
            // 
            // checkLow
            // 
            this.checkLow.AutoSize = true;
            this.checkLow.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLow.Location = new System.Drawing.Point(39, 354);
            this.checkLow.Name = "checkLow";
            this.checkLow.Size = new System.Drawing.Size(176, 23);
            this.checkLow.TabIndex = 13;
            this.checkLow.Text = "Low Performance Mode";
            this.checkLow.UseVisualStyleBackColor = true;
            this.checkLow.CheckedChanged += new System.EventHandler(this.checkLow_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(573, 568);
            this.Controls.Add(this.checkLow);
            this.Controls.Add(this.txtSessionName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStat);
            this.Controls.Add(this.lblStatLable);
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
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Label lblStatLable;
        private System.Windows.Forms.Label lblStat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSessionName;
        private System.Windows.Forms.CheckBox checkLow;
    }
}


namespace PowerPinger
{
    partial class frmDetails
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
            this.lbxLoggedOnUsers = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSendPing = new System.Windows.Forms.Button();
            this.lblMac = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRoundtrip = new System.Windows.Forms.Label();
            this.lblBufferSize = new System.Windows.Forms.Label();
            this.lblIpv4 = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxLoggedOnUsers
            // 
            this.lbxLoggedOnUsers.FormattingEnabled = true;
            this.lbxLoggedOnUsers.Location = new System.Drawing.Point(6, 19);
            this.lbxLoggedOnUsers.Name = "lbxLoggedOnUsers";
            this.lbxLoggedOnUsers.Size = new System.Drawing.Size(285, 121);
            this.lbxLoggedOnUsers.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxLoggedOnUsers);
            this.groupBox1.Location = new System.Drawing.Point(316, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 144);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logon Session List";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSendPing);
            this.groupBox2.Controls.Add(this.lblMac);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.lblRoundtrip);
            this.groupBox2.Controls.Add(this.lblBufferSize);
            this.groupBox2.Controls.Add(this.lblIpv4);
            this.groupBox2.Controls.Add(this.lblTarget);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 144);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ICMP";
            // 
            // btnSendPing
            // 
            this.btnSendPing.Location = new System.Drawing.Point(9, 115);
            this.btnSendPing.Name = "btnSendPing";
            this.btnSendPing.Size = new System.Drawing.Size(75, 23);
            this.btnSendPing.TabIndex = 4;
            this.btnSendPing.Text = "Send";
            this.btnSendPing.UseVisualStyleBackColor = true;
            this.btnSendPing.Click += new System.EventHandler(this.btnSendPing_Click);
            // 
            // lblMac
            // 
            this.lblMac.AutoSize = true;
            this.lblMac.Location = new System.Drawing.Point(5, 81);
            this.lblMac.Name = "lblMac";
            this.lblMac.Size = new System.Drawing.Size(33, 13);
            this.lblMac.TabIndex = 0;
            this.lblMac.Text = "MAC:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(6, 68);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status:";
            // 
            // lblRoundtrip
            // 
            this.lblRoundtrip.AutoSize = true;
            this.lblRoundtrip.Location = new System.Drawing.Point(6, 55);
            this.lblRoundtrip.Name = "lblRoundtrip";
            this.lblRoundtrip.Size = new System.Drawing.Size(56, 13);
            this.lblRoundtrip.TabIndex = 0;
            this.lblRoundtrip.Text = "Roundtrip:";
            // 
            // lblBufferSize
            // 
            this.lblBufferSize.AutoSize = true;
            this.lblBufferSize.Location = new System.Drawing.Point(6, 42);
            this.lblBufferSize.Name = "lblBufferSize";
            this.lblBufferSize.Size = new System.Drawing.Size(61, 13);
            this.lblBufferSize.TabIndex = 0;
            this.lblBufferSize.Text = "Buffer Size:";
            // 
            // lblIpv4
            // 
            this.lblIpv4.AutoSize = true;
            this.lblIpv4.Location = new System.Drawing.Point(6, 29);
            this.lblIpv4.Name = "lblIpv4";
            this.lblIpv4.Size = new System.Drawing.Size(32, 13);
            this.lblIpv4.TabIndex = 0;
            this.lblIpv4.Text = "IPv4:";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(6, 16);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(41, 13);
            this.lblTarget.TabIndex = 0;
            this.lblTarget.Text = "Target:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(539, 181);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(9, 19);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRestart);
            this.groupBox3.Location = new System.Drawing.Point(12, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 56);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tools";
            // 
            // frmDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 234);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDetails";
            this.Text = "PowerPinger - Details";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxLoggedOnUsers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMac;
        private System.Windows.Forms.Label lblRoundtrip;
        private System.Windows.Forms.Label lblBufferSize;
        private System.Windows.Forms.Label lblIpv4;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSendPing;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
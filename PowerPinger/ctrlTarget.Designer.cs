namespace PowerPinger
{
    partial class ctrlTarget
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRoundtrip = new System.Windows.Forms.Label();
            this.lblBufferSize = new System.Windows.Forms.Label();
            this.lblIpAdress = new System.Windows.Forms.Label();
            this.panelFunctions = new System.Windows.Forms.Panel();
            this.btnRestartMachine = new System.Windows.Forms.Button();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblLastPing = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanelMain.SuspendLayout();
            this.panelFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelMain.ColumnCount = 8;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.58736F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.58736F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.15242F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.49814F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.58736F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.58736F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanelMain.Controls.Add(this.lblAdress, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.lblStatus, 4, 0);
            this.tableLayoutPanelMain.Controls.Add(this.lblRoundtrip, 3, 0);
            this.tableLayoutPanelMain.Controls.Add(this.lblBufferSize, 2, 0);
            this.tableLayoutPanelMain.Controls.Add(this.lblIpAdress, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelFunctions, 6, 0);
            this.tableLayoutPanelMain.Controls.Add(this.lblLastPing, 5, 0);
            this.tableLayoutPanelMain.Controls.Add(this.progressBar, 7, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1322, 30);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.BackColor = System.Drawing.Color.Transparent;
            this.lblAdress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lblAdress.Location = new System.Drawing.Point(0, 0);
            this.lblAdress.Margin = new System.Windows.Forms.Padding(0);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(198, 30);
            this.lblAdress.TabIndex = 0;
            this.lblAdress.Text = "Adress: 255.255.255.255";
            this.lblAdress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lblStatus.Location = new System.Drawing.Point(668, 0);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(198, 30);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status: N/A";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRoundtrip
            // 
            this.lblRoundtrip.AutoSize = true;
            this.lblRoundtrip.BackColor = System.Drawing.Color.Transparent;
            this.lblRoundtrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRoundtrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundtrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lblRoundtrip.Location = new System.Drawing.Point(514, 0);
            this.lblRoundtrip.Margin = new System.Windows.Forms.Padding(0);
            this.lblRoundtrip.Name = "lblRoundtrip";
            this.lblRoundtrip.Size = new System.Drawing.Size(154, 30);
            this.lblRoundtrip.TabIndex = 2;
            this.lblRoundtrip.Text = "Roundtrip:";
            this.lblRoundtrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBufferSize
            // 
            this.lblBufferSize.AutoSize = true;
            this.lblBufferSize.BackColor = System.Drawing.Color.Transparent;
            this.lblBufferSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBufferSize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBufferSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lblBufferSize.Location = new System.Drawing.Point(396, 0);
            this.lblBufferSize.Margin = new System.Windows.Forms.Padding(0);
            this.lblBufferSize.Name = "lblBufferSize";
            this.lblBufferSize.Size = new System.Drawing.Size(118, 30);
            this.lblBufferSize.TabIndex = 1;
            this.lblBufferSize.Text = "Buffer: 32";
            this.lblBufferSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIpAdress
            // 
            this.lblIpAdress.AutoSize = true;
            this.lblIpAdress.BackColor = System.Drawing.Color.Transparent;
            this.lblIpAdress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIpAdress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIpAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lblIpAdress.Location = new System.Drawing.Point(198, 0);
            this.lblIpAdress.Margin = new System.Windows.Forms.Padding(0);
            this.lblIpAdress.Name = "lblIpAdress";
            this.lblIpAdress.Size = new System.Drawing.Size(198, 30);
            this.lblIpAdress.TabIndex = 1;
            this.lblIpAdress.Text = "IPv4:";
            this.lblIpAdress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFunctions
            // 
            this.panelFunctions.BackColor = System.Drawing.Color.Transparent;
            this.panelFunctions.Controls.Add(this.btnRestartMachine);
            this.panelFunctions.Controls.Add(this.btnShowDetails);
            this.panelFunctions.Controls.Add(this.btnSend);
            this.panelFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFunctions.Location = new System.Drawing.Point(1064, 0);
            this.panelFunctions.Margin = new System.Windows.Forms.Padding(0);
            this.panelFunctions.Name = "panelFunctions";
            this.panelFunctions.Size = new System.Drawing.Size(144, 30);
            this.panelFunctions.TabIndex = 4;
            // 
            // btnRestartMachine
            // 
            this.btnRestartMachine.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRestartMachine.BackgroundImage = global::PowerPinger.Properties.Resources.Restart;
            this.btnRestartMachine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRestartMachine.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRestartMachine.FlatAppearance.BorderSize = 0;
            this.btnRestartMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestartMachine.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRestartMachine.Location = new System.Drawing.Point(95, 3);
            this.btnRestartMachine.Name = "btnRestartMachine";
            this.btnRestartMachine.Size = new System.Drawing.Size(40, 24);
            this.btnRestartMachine.TabIndex = 0;
            this.btnRestartMachine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestartMachine.UseVisualStyleBackColor = false;
            this.btnRestartMachine.Click += new System.EventHandler(this.btnRestartMachine_Click);
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowDetails.BackgroundImage = global::PowerPinger.Properties.Resources.Info;
            this.btnShowDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowDetails.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnShowDetails.FlatAppearance.BorderSize = 0;
            this.btnShowDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowDetails.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowDetails.Location = new System.Drawing.Point(49, 3);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(40, 24);
            this.btnShowDetails.TabIndex = 0;
            this.btnShowDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowDetails.UseVisualStyleBackColor = false;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSend.BackgroundImage = global::PowerPinger.Properties.Resources.Event;
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSend.Location = new System.Drawing.Point(3, 3);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(40, 24);
            this.btnSend.TabIndex = 0;
            this.btnSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblLastPing
            // 
            this.lblLastPing.AutoSize = true;
            this.lblLastPing.BackColor = System.Drawing.Color.Transparent;
            this.lblLastPing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastPing.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastPing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lblLastPing.Location = new System.Drawing.Point(866, 0);
            this.lblLastPing.Margin = new System.Windows.Forms.Padding(0);
            this.lblLastPing.Name = "lblLastPing";
            this.lblLastPing.Size = new System.Drawing.Size(198, 30);
            this.lblLastPing.TabIndex = 3;
            this.lblLastPing.Text = "Last Ping:";
            this.lblLastPing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar
            // 
            this.progressBar.Enabled = false;
            this.progressBar.Location = new System.Drawing.Point(1211, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(103, 23);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 5;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ctrlTarget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "ctrlTarget";
            this.Size = new System.Drawing.Size(1322, 30);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.panelFunctions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblBufferSize;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblRoundtrip;
        private System.Windows.Forms.Panel panelFunctions;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblIpAdress;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.Label lblLastPing;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnRestartMachine;
    }
}

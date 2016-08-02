namespace PowerPinger
{
    partial class frmMain
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.btnRestartAll = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPingAll = new System.Windows.Forms.Button();
            this.btnOpenTargetManager = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpMain
            // 
            this.flpMain.AutoScroll = true;
            this.flpMain.BackColor = System.Drawing.Color.White;
            this.flpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMain.Location = new System.Drawing.Point(181, 38);
            this.flpMain.Name = "flpMain";
            this.flpMain.Size = new System.Drawing.Size(1162, 685);
            this.flpMain.TabIndex = 1;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.flpMain, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.panelSideBar, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelTopBar, 1, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1346, 726);
            this.tableLayoutPanelMain.TabIndex = 3;
            // 
            // panelSideBar
            // 
            this.panelSideBar.Controls.Add(this.panel1);
            this.panelSideBar.Controls.Add(this.btnRestartAll);
            this.panelSideBar.Controls.Add(this.btnExport);
            this.panelSideBar.Controls.Add(this.btnPingAll);
            this.panelSideBar.Controls.Add(this.btnOpenTargetManager);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSideBar.Location = new System.Drawing.Point(0, 35);
            this.panelSideBar.Margin = new System.Windows.Forms.Padding(0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(178, 691);
            this.panelSideBar.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(1, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 2);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "PowerPinger";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTopBar
            // 
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopBar.Location = new System.Drawing.Point(178, 0);
            this.panelTopBar.Margin = new System.Windows.Forms.Padding(0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(1168, 35);
            this.panelTopBar.TabIndex = 6;
            // 
            // btnRestartAll
            // 
            this.btnRestartAll.FlatAppearance.BorderSize = 0;
            this.btnRestartAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestartAll.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnRestartAll.Image = global::PowerPinger.Properties.Resources.Command;
            this.btnRestartAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestartAll.Location = new System.Drawing.Point(0, 134);
            this.btnRestartAll.Name = "btnRestartAll";
            this.btnRestartAll.Size = new System.Drawing.Size(175, 35);
            this.btnRestartAll.TabIndex = 0;
            this.btnRestartAll.Text = "Restart All";
            this.btnRestartAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestartAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestartAll.UseVisualStyleBackColor = true;
            this.btnRestartAll.Click += new System.EventHandler(this.btnRestartAll_Click);
            // 
            // btnExport
            // 
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnExport.Image = global::PowerPinger.Properties.Resources.Export_32v2;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(0, 85);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(175, 35);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export to CSV";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPingAll
            // 
            this.btnPingAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPingAll.FlatAppearance.BorderSize = 0;
            this.btnPingAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPingAll.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPingAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnPingAll.Image = global::PowerPinger.Properties.Resources.Lightning_32v2;
            this.btnPingAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPingAll.Location = new System.Drawing.Point(0, 44);
            this.btnPingAll.Name = "btnPingAll";
            this.btnPingAll.Size = new System.Drawing.Size(175, 35);
            this.btnPingAll.TabIndex = 0;
            this.btnPingAll.Text = "Ping All";
            this.btnPingAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPingAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPingAll.UseVisualStyleBackColor = true;
            this.btnPingAll.Click += new System.EventHandler(this.btnPingAll_Click);
            // 
            // btnOpenTargetManager
            // 
            this.btnOpenTargetManager.FlatAppearance.BorderSize = 0;
            this.btnOpenTargetManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenTargetManager.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenTargetManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnOpenTargetManager.Image = global::PowerPinger.Properties.Resources.Pen_32v2;
            this.btnOpenTargetManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenTargetManager.Location = new System.Drawing.Point(0, 3);
            this.btnOpenTargetManager.Name = "btnOpenTargetManager";
            this.btnOpenTargetManager.Size = new System.Drawing.Size(175, 35);
            this.btnOpenTargetManager.TabIndex = 0;
            this.btnOpenTargetManager.Text = "Manage Targets";
            this.btnOpenTargetManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenTargetManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenTargetManager.UseVisualStyleBackColor = true;
            this.btnOpenTargetManager.Click += new System.EventHandler(this.btnOpenTargetManager_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1346, 726);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "frmMain";
            this.Text = "PowerPinger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.panelSideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpMain;
        private System.Windows.Forms.Button btnOpenTargetManager;
        private System.Windows.Forms.Button btnPingAll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRestartAll;
    }
}


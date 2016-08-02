namespace PowerPinger
{
    partial class frmTargetManager
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
            this.tbxTargets = new System.Windows.Forms.TextBox();
            this.btnSaveTargets = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxTargets
            // 
            this.tbxTargets.Location = new System.Drawing.Point(12, 12);
            this.tbxTargets.Multiline = true;
            this.tbxTargets.Name = "tbxTargets";
            this.tbxTargets.Size = new System.Drawing.Size(376, 344);
            this.tbxTargets.TabIndex = 0;
            // 
            // btnSaveTargets
            // 
            this.btnSaveTargets.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveTargets.Location = new System.Drawing.Point(12, 362);
            this.btnSaveTargets.Name = "btnSaveTargets";
            this.btnSaveTargets.Size = new System.Drawing.Size(75, 23);
            this.btnSaveTargets.TabIndex = 1;
            this.btnSaveTargets.Text = "Save";
            this.btnSaveTargets.UseVisualStyleBackColor = true;
            this.btnSaveTargets.Click += new System.EventHandler(this.btnSaveTargets_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(93, 362);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmTargetManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 392);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveTargets);
            this.Controls.Add(this.tbxTargets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTargetManager";
            this.Text = "PowerPinger - Add Targets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxTargets;
        private System.Windows.Forms.Button btnSaveTargets;
        private System.Windows.Forms.Button btnCancel;
    }
}
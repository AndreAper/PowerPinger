using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.IO;

namespace PowerPinger
{
    public partial class frmMain : Form
    {
        private StringCollection _scTargetList;

        private void UpdateTargetList()
        {
            this.flpMain.Controls.Clear();
            _scTargetList = Properties.Settings.Default.TargetList;

            if (_scTargetList != null)
            {
                if (_scTargetList.Count > 0)
                {
                    foreach (string target in _scTargetList)
                    {
                        this.flpMain.Controls.Add(new ctrlTarget(target));
                    }
                }
            }

            foreach (var targetCtrl in this.flpMain.Controls.OfType<ctrlTarget>())
            {
                targetCtrl.Width = this.flpMain.Width - 20;
            }
        }

        public frmMain()
        {
            InitializeComponent();
            _scTargetList = new StringCollection();
            UpdateTargetList();
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            foreach (var targetCtrl in this.flpMain.Controls.OfType<ctrlTarget>())
            {
                targetCtrl.Width = this.flpMain.Width - 20;
            }
        }

        private void btnOpenTargetManager_Click(object sender, EventArgs e)
        {
            frmTargetManager tm = new frmTargetManager(this._scTargetList);
            if (tm.ShowDialog() == DialogResult.OK)
            {
                if (tm.TargetList != null)
                {
                    this._scTargetList = tm.TargetList;
                    UpdateTargetList();
                }
            }
        }

        private void btnPingAll_Click(object sender, EventArgs e)
        {
            if (this.flpMain.Controls.Count > 0)
            {
                foreach (var targetCtrl in this.flpMain.Controls.OfType<ctrlTarget>())
                {
                    targetCtrl.SendPing();
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (this.flpMain.Controls.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.FilterIndex = 1;
                sfd.RestoreDirectory = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        sw.WriteLine("Target;IPv4;BufferLength;RoundtripTime;Status");

                        foreach (var targetCtrl in this.flpMain.Controls.OfType<ctrlTarget>())
                        {
                            if (targetCtrl.LastReply != null)
                            {
                                sw.WriteLine(string.Join(";", targetCtrl.TargetAdress, targetCtrl.LastReply.Address.ToString(), targetCtrl.LastReply.Buffer.Length, targetCtrl.LastReply.RoundtripTime, targetCtrl.LastReply.Status.ToString())); 
                            }
                            else
                            {
                                sw.WriteLine(string.Join(";", targetCtrl.TargetAdress, "NULL", "NULL", "NULL", "NULL"));
                            }
                        }
                    }
                }

            }
        }

        private void btnRestartAll_Click(object sender, EventArgs e)
        {
            if (this.flpMain.Controls.Count > 0)
            {
                foreach (var targetCtrl in this.flpMain.Controls.OfType<ctrlTarget>())
                {
                    targetCtrl.ExecRestart();
                }
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.TargetList = _scTargetList;
            Properties.Settings.Default.Save();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Diagnostics;

namespace PowerPinger
{
    public partial class ctrlTarget : UserControl
    {
        /// <summary>
        /// Get or set the target hostname or ip adress.
        /// </summary>
        public string TargetAdress { get { return _targteAdress; } set { _targteAdress = value; } }

        /// <summary>
        /// Get or set the timeóut in ms for icmp echo request
        /// </summary>
        public int Timeout { get { return _timeout; } set { _timeout = value; } }

        /// <summary>
        /// Get or set the buffer of data received in an Internet Control Message Protocol (ICMP) echo reply message.
        /// </summary>
        public int BufferSize { get { return _bufferSize; } set { _bufferSize = value; } }

        /// <summary>
        /// A PingReply object that provides information about the ICMP echo reply message, if one was received, or provides the reason for the failure, if no message was received.
        /// </summary>
        public PingReply LastReply { get { return _lastReply; } private set { _lastReply = value; } }


        private int _timeout;
        private int _bufferSize;
        private string _targteAdress;
        private bool _unreachableFlag = false;
        private Ping _ping;
        private PingReply _lastReply;

        /// <summary>
        /// Send icmp echo message to the target;
        /// </summary>
        /// <returns></returns>
        public async Task<PingReply> SendPing()
        {
            try
            {
                btnSend.Enabled = false;
                progressBar.MarqueeAnimationSpeed = 30;
                this.lblStatus.ForeColor = Color.Black;
                this.lblStatus.BackColor = Color.Gold;
                this.lblStatus.Text = "Status: Requesting...";
                
                PingReply pr = await _ping.SendPingAsync(_targteAdress, _timeout, new byte[_bufferSize]);
                return pr;
            }
            catch (Exception)
            {
                this.lblStatus.ForeColor = Color.White;                
                this.lblStatus.BackColor = Color.Crimson;
                this.lblStatus.Text = "Status: Failed";
                return null;
            }
        }

        /// <summary>
        /// Execute restart command
        /// </summary>
        public void ExecRestart()
        {
            this.lblStatus.ForeColor = Color.Black;
            this.lblStatus.BackColor = Color.Gold;
            this.lblStatus.Text = "Status: Cmd sended...";

            if (LastReply.Status == IPStatus.Success)
            {
                Process.Start("shutdown", "-r -f -m \\\\" + _targteAdress + " -t 0");
                progressBar.MarqueeAnimationSpeed = 30;
                timer.Interval = _timeout;
                timer.Enabled = true;
                btnSend.Enabled = false;
            }
        }

        public ctrlTarget()
        {
            InitializeComponent();
            progressBar.MarqueeAnimationSpeed = 0;
            _timeout = 5000;
            _bufferSize = 32;
        }

        public ctrlTarget(string adress)
        {
            InitializeComponent();
            progressBar.MarqueeAnimationSpeed = 0;

            _ping = new Ping();
            _ping.PingCompleted += P_PingCompleted;

            _timeout = 5000;
            _bufferSize = 32;

            _targteAdress = adress;
            this.lblAdress.Text = "Target: " + _targteAdress;
        }

        private void P_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            if (e != null)
            {
                if (e.Reply != null)
                {
                    _lastReply = e.Reply;

                    if (e.Reply.Status == IPStatus.Success)
                    {
                        this.lblStatus.ForeColor = Color.Black;
                        this.lblStatus.BackColor = Color.SpringGreen;

                        if (_unreachableFlag)
                        {
                            timer.Enabled = false;
                            _unreachableFlag = false;
                            btnSend.Enabled = true;
                            progressBar.MarqueeAnimationSpeed = 0;
                            progressBar.Value = 0;
                        }

                        progressBar.MarqueeAnimationSpeed = 0;
                        progressBar.Value = 0;
                    }
                    else
                    {
                        this.lblStatus.ForeColor = Color.White;
                        this.lblStatus.BackColor = Color.Crimson;
                    }

                    this.lblIpAdress.Text = "IPv4: " + e.Reply.Address.ToString();
                    this.lblBufferSize.Text = "Buffer: " + e.Reply.Buffer.Length.ToString();
                    this.lblRoundtrip.Text = "Roundtrip: " + e.Reply.RoundtripTime.ToString();
                    this.lblStatus.Text = "Status: " + e.Reply.Status.ToString();
                    this.lblLastPing.Text = "Last Ping: " + DateTime.Now.ToString();
                }
                else
                {
                    this.lblStatus.BackColor = Color.Crimson;
                    this.lblStatus.ForeColor = Color.White;
                    this.lblStatus.Text = "Status: BadDestination";
                }
            }

            
            btnSend.Enabled = true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendPing();
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            frmDetails frm = new frmDetails(_targteAdress);
            frm.ShowDialog();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            SendPing();
            _unreachableFlag = LastReply.Status != IPStatus.Success;
        }

        private void btnRestartMachine_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Restart Machine", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ExecRestart();
            }
        }
    }
}

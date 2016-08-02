using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Text.RegularExpressions;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Net;


namespace PowerPinger
{
    public partial class frmDetails : Form
    {
        private string _targetAdress;
        private List<string> _logonSessionList;

        [DllImport("iphlpapi.dll")]
        static extern int SendARP(int DestIP, int SrcIP, [Out] byte[] pMacAddr, ref int PhyAddrLen);

        /// <summary>
        /// Requests the MAC address using Address Resolution Protocol
        /// </summary>
        /// <param name="IP">The IP.</param>
        /// <returns>the MAC address</returns>
        static internal string GetMACAddress(string IP)
        {
            IPAddress addr = IPAddress.Parse(IP);
            byte[] mac = new byte[6];
            int length = mac.Length;
            SendARP((int)addr.Address, 0, mac, ref length);
            string macAddress = BitConverter.ToString(mac, 0, length);
            return macAddress;
        }

        /// <summary>
        /// Send icmp echo message to the target;
        /// </summary>
        /// <returns></returns>
        public async void SendPing()
        {
            try
            {
                this.lblStatus.Text = "Status: Working...";
                Ping _ping = new Ping();
                PingReply pr = await _ping.SendPingAsync(_targetAdress, 1000, new byte[32]);

                lblTarget.Text = "Target: " + _targetAdress;
                lblIpv4.Text = "IPv4: " + pr.Address.ToString();
                lblBufferSize.Text = "Buffer Size: " + pr.Buffer.Length.ToString();
                lblRoundtrip.Text = "Roundtrip: " + pr.RoundtripTime.ToString();
                lblStatus.Text = "Status: " + pr.Status.ToString();
                lblMac.Text = "MAC: " + GetMACAddress(pr.Address.ToString());
            }
            catch (Exception)
            {
                this.lblStatus.Text = "Status: Failed";
            }
        }

        public List<string> GetData()
        {
            //Instanziiere eine ManagementScope instance
            ManagementScope Scope;
            List<string> lst = new List<string>();

            //Wenn _targetAdress nicht localhost ist, dann werden Admin Credentials benötigt um Remoteverbindungen herstellen zu können.
            //Bei localhost kann das Argument ConnectionOptions null sein.
            if (!_targetAdress.Equals("localhost", StringComparison.OrdinalIgnoreCase))
            {
                ConnectionOptions Conn = new ConnectionOptions();
                Conn.EnablePrivileges = true;
                Scope = new ManagementScope(String.Format("\\\\{0}\\root\\CIMV2", _targetAdress), Conn);
            }
            else
                Scope = new ManagementScope(String.Format("\\\\{0}\\root\\CIMV2", _targetAdress), null);

            //Verbinde zum WMI Scope des Remotecomputers
            try
            {
                Scope.Connect();

                if (Scope.IsConnected)
                {
                    ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_LogonSession");
                    ManagementObjectSearcher searcher = new ManagementObjectSearcher(Scope, query);
                    ManagementObjectCollection results = searcher.Get();

                    foreach (ManagementObject logonCurrent in results)
                    {
                        Dictionary<string, string> userTable = GetLoggedOnUsersTable();

                        string logonName = "";
                        if (userTable.ContainsKey((string)logonCurrent["LogonID"]))
                        {
                            logonName = (string)userTable[(string)logonCurrent["LogonID"]];
                        }

                        DateTime startTime = ManagementDateTimeConverter.ToDateTime(logonCurrent["StartTime"].ToString());
                        lst.Add(string.Join(":", logonName, startTime.ToString()));
                    }

                }

                return lst;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static Dictionary<string, string> GetLoggedOnUsersTable()
        {
            string query = "Select * From Win32_LoggedOnUser";

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

            ManagementObjectCollection results = searcher.Get();

            Dictionary<string, string> table = new Dictionary<string, string>(results.Count);

            foreach (ManagementObject currentObject in results)
            {
                string account = GetUser((string)currentObject["Antecedent"]);
                string session = GetLogonID((string)currentObject["Dependent"]);
                table.Add(session, account);
            }
            return table;
        }

        private static string GetLogonID(string propertyText)
        {
            string pattern = "LogonId=\"(?<id>\\d+)\"";
            Match matchID = Regex.Match(propertyText, pattern);
            if (matchID.Success)
            {
                return matchID.Groups["id"].Value;
            }
            else
            {
                return "";
            }
        }

        private static string GetUser(string propertyText)
        {
            string pattern = "Domain=\"(?<domain>[A-Za-z\\d_-]+)\"|Name=\"(?<name>[A-Za-z\\d\\s_-]+)\"";
            string domain = "";
            string name = "";
            foreach (Match matchCurrent in Regex.Matches(propertyText, pattern))
            {
                string fullText = matchCurrent.Groups[0].Value;
                if (fullText.StartsWith("Domain"))
                {
                    domain = matchCurrent.Groups["domain"].Value;
                }
                else
                {
                    name = matchCurrent.Groups["name"].Value;
                }
            }
            if (domain.Length == 0)
            {
                return name;
            }
            else
            {
                return domain + "\\" + name;
            }
        }

        private static DateTime ConvertFileTime(string time)
        {
            if (time != null)
            {
                const string FILE_TIME_MASK = "yyyyMMddHHmmss";
                time = time.Substring(0, time.IndexOf("."));
                return DateTime.ParseExact(time, FILE_TIME_MASK, null);
            }
            return DateTime.MinValue;
        }

        private void UpdateForm()
        {
            _logonSessionList = GetData();

            if (_logonSessionList != null)
            {
                if (_logonSessionList.Count > 0)
                {
                    lbxLoggedOnUsers.Items.Clear();

                    foreach (string usr in _logonSessionList)
                    {
                        lbxLoggedOnUsers.Items.Add(usr);
                    }
                }
            }

            SendPing();
        }

        public frmDetails()
        {
            InitializeComponent();
            _targetAdress = "localhost";
            UpdateForm();
        }

        public frmDetails(string target)
        {
            InitializeComponent();

            if (String.IsNullOrEmpty(target))
            {
                _targetAdress = "localhost"; 
            }
            else
            {
                _targetAdress = target;
            }

            UpdateForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSendPing_Click(object sender, EventArgs e)
        {
            SendPing();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {

        }

        private void btnSutdown_Click(object sender, EventArgs e)
        {

        }
    }
}

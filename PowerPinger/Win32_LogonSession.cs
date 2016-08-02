using System;
using System.Collections;
using System.Management;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace PowerPinger
{
    public class Win32_LogonSession
    {
        public string AuthenticationPackage;
        public string LogonID;
        public LogonEventType LogonType;
        public string Name;
        public DateTime StartTime;

        public enum LogonEventType
        {
            System = 0,
            Interactive,
            Network,
            Batch,
            Service,
            Proxy,
            Unlock,
            NetworkClearText,
            NewCredentials,
            RemoteInteractive,
            CachedInteractive,
            CachedRemoteInteractive,
            CachedUnlock
        }

        public static List<Win32_LogonSession> GetList()
        {
            string query = "Select * From Win32_LogonSession";

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

            ManagementObjectCollection results = searcher.Get();

            List<Win32_LogonSession> list = new List<Win32_LogonSession>(results.Count);

            Dictionary<string, string> userTable = GetLoggedOnUsersTable();

            foreach (ManagementObject logonCurrent in results)
            {
                Win32_LogonSession entry = new Win32_LogonSession();

                entry.AuthenticationPackage = (string)logonCurrent["AuthenticationPackage"];
                entry.LogonID = (string)logonCurrent["LogonID"];
                entry.LogonType = (LogonEventType)Convert.ToInt32(logonCurrent["LogonType"]);
                entry.StartTime = ConvertFileTime((string)logonCurrent["StartTime"]);
                if (userTable.ContainsKey(entry.LogonID))
                {
                    entry.Name = (string)userTable[entry.LogonID];
                }
                list.Add(entry);
            }
            return list;
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
    }

}


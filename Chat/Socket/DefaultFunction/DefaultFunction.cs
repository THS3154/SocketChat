using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Socket
{
    class DefaultFunction
    {
        public static string GetIP()
        {
            //내부 IP주소 가져오기
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            string getIP = string.Empty;

            for (int i = 0; i < host.AddressList.Length; i++)
            {
                if (host.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                {

                    getIP = host.AddressList[i].ToString();
                    break;
                }
            }
            return getIP;
        }

        public static string ExternalGetIP()
        {
            //외부 IP가져오기
            try
            {
                string checkipURL = "http://checkip.dyndns.org/";
                WebClient wc = new WebClient();
                UTF8Encoding utf8 = new UTF8Encoding();
                string requestHtml = "";


                requestHtml = utf8.GetString(wc.DownloadData(checkipURL));
                //"<html><head><title>Current IP Check</title></head><body>Current IP Address: 111.222.333.444</body></html>\r\n"
                requestHtml = requestHtml.Substring(requestHtml.IndexOf("Current IP Address:"));
                requestHtml = requestHtml.Substring(0, requestHtml.IndexOf("</body>"));
                requestHtml = requestHtml.Split(':')[1].Trim();

                IPAddress externalIp = null;

                externalIp = IPAddress.Parse(requestHtml);
                return externalIp.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

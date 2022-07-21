using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

struct UserInfo
{
    //해당 유저 아이디 정보 저장
    public string ID;

    //유저 레벨 저장
    public int Level;
};
namespace Socket
{
    class SocketClient
    {
        System.Net.Sockets.Socket client;
        ListBox logs;
        int port;
        string ServerIP;

        //최초 접속시 서버에 정보값 전달
        bool bSendInfo;
        UserInfo user;
        Thread th;
        
        //현재 접속중인지.
        public bool bJoinCheck;
        
        //출력해줄 이름
        string Name;
        public SocketClient(ListBox log,string IP = "127.0.0.1",int pt = 9999,string UserName = "None",int UserLevel = 1)
        {
            logs = log;
            ServerIP = IP;
            port = pt;


            //유저 정보 저장
            user.ID = UserName;
            user.Level = UserLevel;

            th = new Thread(Join);
            th.IsBackground = true;
            bSendInfo = false;
            th.Start();
        }

        public bool JoinCheck()
        {
            return bJoinCheck;
        }
        private void SendMyInfo()
        {
            //기본적인 유저정보 전달
            string SendInfo = $"\\SetUserInfo\\{user.ID}\\{user.Level}";
            client.Send(Encoding.Default.GetBytes(SendInfo + "\r\n"));
            bSendInfo = true;
        }

        private void Join()
        {
            var EP = new IPEndPoint(IPAddress.Parse(ServerIP), port);

            using (client = new System.Net.Sockets.Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                client.Connect(EP);

                try
                {
                    //접속 후 1회만 작동
                    if (bSendInfo == false)
                    {
                        SendMyInfo();
                        bJoinCheck = true;
                    }

                    //PrintLog("접속완료");
                    while (true)
                    {
                        //통신버퍼
                        var binary = new Byte[1024];

                        //서버로부터 메세지 대기
                        client.Receive(binary);

                        var data = Encoding.Default.GetString(binary).Trim('\0');

                        // 메시지 내용이 공백
                        if (String.IsNullOrWhiteSpace(data)) { continue; }
                        PrintLog(DataEncoding.UTF8_TO_EUCKR(data));
                    }
                }
                catch (SocketException)
                {
                    PrintLog("호스트와 연결이 종료되었습니다.");
                    bJoinCheck = false;
                    th.Abort();

                    //접속끊김
                }
            }
        }

        private delegate void PrintCallDelegate(string log);

        void PrintLog(string log)
        {
            if (logs.InvokeRequired)
            {
                var d = new PrintCallDelegate(PrintLog);
                object[] objs = new object[] { log };
                logs.BeginInvoke(d, objs);
            }
            else
            {
                logs.Items.Add(log);
            }

        }

        public void SendData(string data)
        {
            client.Send(Encoding.Default.GetBytes(data + "\r\n"));
        }

        public void Close()
        {
            client.Send(Encoding.Default.GetBytes("/Close" + "\r\n"));
            th.Abort();
        }
    }
}

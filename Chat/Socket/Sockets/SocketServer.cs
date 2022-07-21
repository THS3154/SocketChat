using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;


struct ClientInfo
{
    public System.Net.Sockets.Socket Socket;
    //해당 유저 아이디 정보 저장
    public string ID;

    //유저 레벨 저장
    public int Level;

    //특정 권한인 경우만 채팅이 보일수있게
    public int Authority;
};
namespace Socket
{
    
    class SocketServer 
    {
        //TCP 소켓 생성
        System.Net.Sockets.Socket SrSocket;
        int port;
        //로그 저장할 리스트박스
        ListBox logs;
        Thread th;
        List<ClientInfo> ListClient = new List<ClientInfo>();


        int LimitPerson;
        public SocketServer(ListBox log,int pt = 9999,int person = 50)
        {
            SrSocket = new System.Net.Sockets.Socket(AddressFamily.InterNetwork,
                                     SocketType.Stream,
                                     ProtocolType.Tcp);

            LimitPerson = person;
            //로그박스값을 전달받음
            logs = log;
            port = pt; 
            th = new Thread(new ThreadStart(SrListen));
            th.IsBackground = true;
            th.Start();
        }

        private void SrListen()
        {
            //포트에 바인드
            IPEndPoint EP = new IPEndPoint(IPAddress.Any, port);
            SrSocket.Bind(EP);

            //서버시작
            SrSocket.Listen(20);

            Console.WriteLine("Server Start");
            PrintLog("Server Start");

            while (true)
            {
                if(ListClient.Count() <= LimitPerson)
                {
                    //클라이언트 접속 대기중
                    System.Net.Sockets.Socket client = SrSocket.Accept();

                    new Task(() =>
                    {
                        var ip = client.RemoteEndPoint as IPEndPoint;
                        //PrintLog($"클라이언트 접속 IPAdress{ip.Address.ToString()}:{ip.Port} 접속시간 : {DateTime.Now}");
                        Console.WriteLine($"클라이언트 접속 IPAdress{ip.Address.ToString()}:{ip.Port} 접속시간 : {DateTime.Now}");
                        var Messge = new StringBuilder();
                        ClientInfo info = new ClientInfo();
                        using (client)
                        {
                            while (true)
                            {
                                //통신 바이너리 버퍼
                                var binary = new Byte[1024];

                                //클라이언트로부터 메세지를 받음
                                client.Receive(binary);

                                //받은메세지를 스트링으로 변경
                                var data = Encoding.Default.GetString(binary);

                                //공백 제거
                                Messge.Append(data.Trim('\0'));

                                if (Messge.Length > 2 && Messge[Messge.Length - 2] == '\r' && Messge[Messge.Length - 1] == '\n')
                                {

                                    //개행을 지워줌
                                    data = Messge.ToString().Replace("\n", "").Replace("\r", "");

                                    //메세지 내용이 없을경우
                                    if (String.IsNullOrWhiteSpace(data))
                                    {
                                        continue;
                                    }

                                    //유저 정보들을 저장해둔곳
                                    if (data.Split('\\').Length > 1)
                                    {
                                        //최초 접속 해당 유저 정보를 서버에다가 저장함
                                        if (data.Split('\\')[1] == "SetUserInfo")
                                        {
                                            info.Socket = client;
                                            info.ID = data.Split('\\')[2];
                                            info.Level = int.Parse(data.Split('\\')[3]);
                                            ListClient.Add(info);
                                            string Infos = $"{info.ID}님이 접속하셨습니다";
                                            StaticSendData(Infos, client);
                                            PrintLog(Infos);
                                            Messge.Length = 0;
                                            continue;
                                        }

                                    }

                                    if (data == "/Close")
                                    {
                                        //PrintLog("Client Exit");
                                        //리스트에있는 해당 클라이언트를 삭제시킴
                                        ListClient.Remove(info);
                                        break;
                                    }
                                    PrintLog(DataEncoding.UTF8_TO_EUCKR(data));

                                    StaticSendData(data, client);

                                    //클라이언트가 호스트에게 나갈때 메세지를 보냄.
                                    Messge.Length = 0;
                                }

                            }
                        }
                    }).Start();
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
                logs.BeginInvoke(d,objs);
            }
            else
            {
                logs.Items.Add(log);
            }
            
        }

        public void SendData(string data)
        {
            //해당 서버에 접속한 모든 클라이언트에게 보냄
            foreach (var client in ListClient)
            {
                client.Socket.Send(Encoding.Default.GetBytes(data + "\r\n"));
            }
        }

        public void StaticSendData(string data, System.Net.Sockets.Socket DontSend = null)
        {
            //클라이언트에서 받은 메세지를 다른데다 뿌려줌
            foreach (var client in ListClient)
            {
                //클라이언트가 서로 다를때만 전송
                if (DontSend != client.Socket)
                    client.Socket.Send(Encoding.Default.GetBytes(data + "\r\n"));
            }
        }
        public void Close()
        {
            SrSocket.Close();
            th.Abort();
            foreach (var client in ListClient)
            {
                client.Socket.Close();
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Socket
{
    public partial class Chat : Form
    {

        SocketClient sc;
        SocketServer sr;

        //서버, 클라이언트 현재 활성화 되어있으면 끌때 자동으로 나가기처리
        //현재 접속이 서버로 했는지 클라이언트로했는지 체크해줌
        bool bSr;
        bool bSc;

        string MyID;
        string MyNickName;

        //방 인덱스 기억
        int RoomIndex;
        string ServerID;
        string Watermark;

        //방 인원수
        int LimitPerson;
        public Chat(bool bsr,int port,string ID,int room,string IP="none",string ServerID = "none",string person = "20")
        {
            InitializeComponent();

            LimitPerson = Convert.ToInt32(person);

            //아이디 저장
            MyID = ID;

            //해당 접속계정 정보를 얻어오기위해
            MSSQL sql = new MSSQL();
            sql.ReadData($"SELECT * FROM {Tables.MemberInfo} WHERE ID = '{MyID}'");
            sql.rdr.Read();
            //닉네임 저장
            MyNickName = sql.rdr["NICKNAME"].ToString();

            sql.RdrClose();

            //방제목을 폼 타이틀에 표시
            RoomIndex = room;
            sql.ReadData($"SELECT RNAME FROM {Tables.RoomList} WHERE ROOMINDEX = {RoomIndex}");
            sql.rdr.Read();

            this.Text = sql.rdr["RNAME"].ToString();
            sql.RdrClose();

            if (bsr)
            {
                //접속상태 : 서버
                bSr = bsr;

                //서버일경우 서버를 연다
                this.sr = new SocketServer(Lb_Chats, port,LimitPerson);
            }
            else
            {
                //접속상태 : 클라언트
                bSc = true;

                this.ServerID = ServerID;

                //해당 서버 소켓으로 접속시도
                sc = new SocketClient(Lb_Chats,pt:port,
                    IP: IP,
                    UserName: MyNickName);
            }


            //폼 기본 설정
            Forms.FormSetting fs = new Forms.FormSetting();
            this.FormBorderStyle = fs.MyFormBorderStyle();
            this.BackColor = fs.MyFormColor();

            foreach (Control c in this.Controls)
            {
                if (c.Name != "")
                {
                    string str = c.Name.Split('_')[0];
                    if (str == "Label" || str == "Btn" || str == "Txt" || str == "Lb")
                    {
                        //폰트 컬러값을 변경
                        c.ForeColor = fs.MyFontColor();

                        //컨트롤 백그라운드색
                        c.BackColor = fs.MyFormColor();
                    }

                }
            }

        }

        private void Chat_Load(object sender, EventArgs e)
        {
            //워터마크 텍스트를 받아옴
            Watermark = StringText.WatermarkSend();
            SetWatermark();
        }


        void SetWatermark()
        {
            if(Txt_Send.Text.Length == 0)
            {
                Txt_Send.Text = Watermark;
                //텍스트 생상변경
                Txt_Send.ForeColor = SystemColors.GrayText;
            }
            else if(Txt_Send.Text == Watermark)
            {
                Forms.FormSetting fs = new Forms.FormSetting();
                //입력받기위해 있던 워터마크를 제거
                Txt_Send.Text = "";
                Txt_Send.ForeColor = fs.MyFontColor();
            }
        }
        

        private void Txt_Send_Enter(object sender, EventArgs e)
        {
            SetWatermark();
        }

        private void Txt_Send_Leave(object sender, EventArgs e)
        {
            SetWatermark();
        }

        private void Txt_Send_KeyPress(object sender, KeyPressEventArgs e)
        {
            //엔터키누르면 메세지 보내기
            if((char)Keys.Enter == e.KeyChar)
            {
                MSSQL sql = new MSSQL();
                string Query = $"INSERT INTO {Tables.MessageLogs} (ROOMINDEX,SENDER,MESSAGE,TIMES) " +
                        $"VALUES ({RoomIndex},'{MyID}','{Txt_Send.Text}','{sql.Datetime()}')";
                
                //내 텍스트 출력
                Lb_Chats.Items.Add($"나 : {Txt_Send.Text}");

                if (bSr)
                {
                    //해당 접속유저가 서버일경우
                    sql.SendQuery(Query);
                    sr.SendData($"{MyNickName} : {Txt_Send.Text}");
                    
                }
                else if (bSc)
                {
                    //해당 접속유저가 클라이언트일경우
                    if (sc.bJoinCheck)
                    {
                        sql.SendQuery(Query);
                        sc.SendData($"{MyNickName} : {Txt_Send.Text}");
                    }
                        
                }
                
                //보낸후 텍스트 내용을 지운후 워터마크를 생성해줌.
                Txt_Send.Text = "";
            }
        }

        private void Chat_FormClosed(object sender, FormClosedEventArgs e)
        {
            MSSQL sql = new MSSQL();
            sql.SendQuery($"UPDATE {Tables.InOutLogs} SET OUTTIME = '{sql.Datetime()}' WHERE ID = '{MyID}' AND ROOMINDEX = {RoomIndex}");
            //채팅창닫을때
            if (bSr)
            {
                
                sql.SendQuery($"UPDATE {Tables.RoomList} SET ENDTIME = '{sql.Datetime()}' WHERE ROOMINDEX = {RoomIndex}");
                sql.ReadData($"SELECT * FROM {Tables.RoomList} WHERE ROOMINDEX = {RoomIndex}");
                sql.rdr.Read();
                string Query = $"INSERT INTO {Tables.EndRoomList} SELECT * FROM {Tables.RoomList} WHERE ROOMINDEX = {RoomIndex}";
                sql.RdrClose();

                //방끝난 LIST로 데이터를 전달
                sql.SendQuery(Query);

                //방목록 리스트에서 지워버림
                sql.SendQuery($"DELETE FROM {Tables.RoomList} WHERE ROOMINDEX = {RoomIndex}");

                /*
                string Query = $"INSERT INTO {Tables.EndRoomList} (ROOMINDEX,ID,IPADDR,RNAME,PORT,PEOPLECONNECT,PEOPLELIMIT,RPW,CREATETIME,ENDTIME) VALUES (" +
                    $"{sql.rdr["ROOMINDEX"].ToString()}," +
                    $"'{sql.rdr["ID"].ToString()}'," +
                    $"'{sql.rdr["IPADDR"].ToString()}'," +
                    $"'{sql.rdr["RNAME"].ToString()}'," +
                    $"{sql.rdr["PORT"].ToString()}," +
                    $"{sql.rdr["PEOPLECONNECT"].ToString()}," +
                    $"{sql.rdr["PEOPLELIMIT"].ToString()}," +
                    $"'{sql.rdr["RPW"].ToString()}'," +
                    $"'{sql.rdr["CREATETIME"].ToString()}'," +
                    $"'{sql.rdr["ENDTIME"].ToString()}')";
                */

                //서버 종료
                sr.Close();
            }
            if (bSc)
            {
                if (sc.JoinCheck())
                {
                    //서버에 정상적으로 들어가있을때 작동
                    sc.SendData($"{MyNickName}님이 퇴장하셨습니다.");
                    sc.Close();
                }
            }
        }
    }
}

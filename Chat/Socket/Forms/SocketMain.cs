using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Globalization;
using System.Drawing;

namespace Socket
{
    public delegate void PrintLogGetEventHandler(string log);
    public partial class SocketMain : Form
    {


        bool bRoomListRefresh;

        //현재 프로그램에서 쓰일 닉네임
        string MyID;
        string MyNickName;
        int MyLevel;//관리자는 레벨 9999

        public SocketMain(string ID)
        {
            InitializeComponent();

            bRoomListRefresh = true;

            MyID = ID;

            MSSQL sql = new MSSQL();
            sql.ReadData($"SELECT * FROM {Tables.MemberInfo} WHERE ID ='{ID}'");
            sql.rdr.Read();

            //해당 닉네임으로 창 이름 변경
            this.Text = $"{sql.rdr["NICKNAME"].ToString()}{StringText.LoginSuccess()}";

            //닉네임 저장
            MyNickName = sql.rdr["NICKNAME"].ToString();

            //레벨을 저장함 받아올때는 문자열로받아와서
            //숫자로 변경해주는 작업
            this.MyLevel = Convert.ToInt32(sql.rdr["LEVEL"].ToString());

            sql.RdrClose();
            //현재 프로그램 언어를 설정
            //0->한글
            //1->영문 -> 아직 작업 안함
            StringText StrText = new StringText(0);

            //폼 기본 설정
            Forms.FormSetting fs = new Forms.FormSetting();
            //this.FormBorderStyle = fs.MyFormBorderStyle();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            //관리자 옵션창 활성화/비활성화
            if (MyLevel == 9999)
                menuStrip1.Visible = true;
            else
                menuStrip1.Visible = false;
            
            
            //this.BackColor = Color.FromArgb(47,49,54);
            //Lb_RoomList.BackColor = Color.FromArgb(47, 49, 54);
            ListRefresh();
        }

        private void SocketMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            MSSQL sql = new MSSQL();
            sql.SendQuery($"UPDATE {Tables.RoomList} SET ENDTIME = '{sql.Datetime()}' WHERE ID = '{MyID}'");
            string Query = $"INSERT INTO {Tables.EndRoomList} SELECT * FROM {Tables.RoomList} WHERE ID = '{MyID}'";

            //방끝난 LIST로 데이터를 전달
            sql.SendQuery(Query);

            //방목록 리스트에서 지워버림
            sql.SendQuery($"DELETE FROM {Tables.RoomList} WHERE ID = '{MyID}'");

            //프로그램 종료
            Environment.Exit(0);
        }

        struct RoomInfo {
            public int index;//방 실제 인덱스번호
            public string ID;//서버주인 아이디정보
            public string IP;//서버접속 아이피
            public string RoomName;//방제
            public string Person;//방인원수
            public string LimitPerson;//방인원수제한
            public bool Rock;//잠금방인지
            public int port;
        };
        //방 정보를 저장함
        List<RoomInfo> RInfo = new List<RoomInfo>();
        private void Btn_RoomListReset_Click(object sender, EventArgs e)
        {
            
        }
        private void ListRefresh()
        {
            RInfo.Clear();
            Lb_RoomList.Items.Clear();

            MSSQL sql = new MSSQL();
            sql.ReadData("SELECT * FROM ROOMLIST");

            //해당 쿼리 데이터를 읽어온다
            while (sql.rdr.Read())
            {
                //방 목록을 읽어옴
                Lb_RoomList.Items.Add(sql.rdr["RNAME"].ToString());

                RoomInfo info = new RoomInfo();
                info.ID = sql.rdr["ID"].ToString();
                info.IP = sql.rdr["IPADDR"].ToString();
                info.RoomName = sql.rdr["RNAME"].ToString();
                info.Person = sql.rdr["PEOPLECONNECT"].ToString();
                info.LimitPerson = sql.rdr["PEOPLELIMIT"].ToString();
                //방이 잠금방인지.
                info.Rock = (sql.rdr["RPW"].ToString() == "" ? false : true);
                info.port = Convert.ToInt32(sql.rdr["PORT"].ToString());

                info.index = Convert.ToInt32(sql.rdr["ROOMINDEX"].ToString());
                RInfo.Add(info);
            }
        }

        private void Lb_RoomList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Lb_RoomList.SelectedIndex == -1)
                return;
            //클라이언트로 접속
            Chat chat = new Chat(false, RInfo[Lb_RoomList.SelectedIndex].port,
                MyID,
                RInfo[Lb_RoomList.SelectedIndex].index,
                RInfo[Lb_RoomList.SelectedIndex].IP,
                RInfo[Lb_RoomList.SelectedIndex].ID);//클라이언트는 서버 아이디를 가지고있음
            chat.Show();


            //방입장정보를 저장해둔다
            MSSQL sql = new MSSQL();
            sql.SendQuery($"INSERT INTO {Tables.InOutLogs}(ID,ROOMINDEX,INTIME) VALUES (" +
                $"'{MyID}'," +                                      //내아이디 정보
                $"{RInfo[Lb_RoomList.SelectedIndex].index}," +       //룸 인덱스번호
                $"'{sql.Datetime()}')");
                
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            //Chat chat = new Chat();
            //chat.Show();
        }


        private void Lb_RoomList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Timer_Refresh_Tick(object sender, EventArgs e)
        {
            //새로고침 주기 10초 
            bRoomListRefresh = true;
            Timer_Refresh.Enabled = false;
        }

        private void Timer_AutoRefresh_Tick(object sender, EventArgs e)
        {
            //자동새로고침 주기 10초
            ListRefresh();
        }

        private void Btn_CreateRoom_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show(StringText.CreateRoom(),Btn_CreateRoom);
        }
        private void Btn_Setting_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show(StringText.Setting(), Btn_Setting);
        }

        private void Btn_CreateRoom_Click(object sender, EventArgs e)
        {
            CreateRoom createRoom = new CreateRoom(MyID);
            createRoom.Show();
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            if (!bRoomListRefresh)
            {
                return;
            }
            Timer_Refresh.Enabled = true;
            bRoomListRefresh = false;

            //방목록 새로고침
            ListRefresh();
        }

        private void Timer_RefreshAnimation_Tick(object sender, EventArgs e)
        {

        }

        private void MenuAdmin_Click(object sender, EventArgs e)
        {

            Forms.Admin.Admin admin = new Forms.Admin.Admin();
            admin.Show();
        }

        private void Btn_Setting_Click(object sender, EventArgs e)
        {
            Forms.MyInfo myInfo = new Forms.MyInfo(MyID);
            myInfo.Show();
            //MessageBox.Show("미구현");
        }

        private void Btn_ReplayChat_Click(object sender, EventArgs e)
        {
            Forms.MyChatList MyChat = new Forms.MyChatList(MyID);
            MyChat.Show();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Socket
{
    public partial class CreateRoom : Form
    {
        string MyID;
        public CreateRoom(string ID)
        {
            InitializeComponent();
            MyID = ID;

            //폼 기본 설정
            Forms.FormSetting fs = new Forms.FormSetting();
            this.FormBorderStyle = fs.MyFormBorderStyle();
            this.BackColor = fs.MyFormColor();

            foreach (Control c in this.Controls)
            {
                if (c.Name != "")
                {
                    string str = c.Name.Split('_')[0];
                    if (str == "Label" || str == "Btn" || str == "Txt" || str == "Cb")
                    {
                        //폰트 컬러값을 변경
                        c.ForeColor = fs.MyFontColor();

                        //컨트롤 백그라운드색
                        c.BackColor = fs.MyFormColor();
                    }

                }
            }
        }

        private void Btn_CreateRoom_Click(object sender, EventArgs e)
        {
            //포트번호가 이탈했을 경우
            int port = Convert.ToInt32(Txt_Port.Text);
            if ( !(0 <= port && port <= 65535))
            {
                MessageBox.Show(StringText.CreatePort());
                return;
            }
            
            //인원을 선택하지 않았을경우
            if(Cb_Person.SelectedIndex == -1)
            {
                MessageBox.Show(StringText.CreatePerson());
                return;
            }

            //방제목 비어있을때
            if (Txt_RoomName.Text == "")
            {
                MessageBox.Show(StringText.CreateName());
                return;
            }

            //호스트가 똑같은 방제목으로 방을 만들수없게만듬
            MSSQL sql = new MSSQL();
            if((int)sql.GetQueryCnt($"SELECT COUNT(*) FROM {Tables.RoomList} WHERE ID ='{MyID}' AND RNAME ='{Txt_RoomName.Text}'") != 0)
            {
                MessageBox.Show(StringText.CreateCheckName());
                return;
            }

            string keeptime = sql.Datetime();

            string query = $"INSERT INTO {Tables.RoomList}(ID,IPADDR,PORT,RNAME,PEOPLELIMIT,RPW,CREATETIME) VALUES " +
                $"('{MyID}'," +                                     //아이디
                $"'{DefaultFunction.ExternalGetIP()}'," +           //아이피
                $"{port}," +                                        //포트
                $"'{Txt_RoomName.Text}'," +                         //방제목
                $"{Convert.ToInt32(Cb_Person.SelectedItem)}," +     //방인원수제한
                $"''," +                                            //방비밀번호 아직 추가안함
                $"'{keeptime}')";                             //생성시간

            //방 생성정보를 DB에 올림
            sql.SendQuery(query);


            sql.ReadData($"SELECT * FROM {Tables.RoomList} WHERE CREATETIME ='{keeptime}' AND ID = '{MyID}' AND RNAME = '{Txt_RoomName.Text}'");
            sql.rdr.Read();
            string RoomIndex = sql.rdr["ROOMINDEX"].ToString();

            Chat chat = new Chat(true, port, MyID,Convert.ToInt32(RoomIndex),person: Cb_Person.SelectedItem.ToString());
            sql.RdrClose();

            //서버도 입장로그 남김
            sql.SendQuery($"INSERT INTO {Tables.InOutLogs}(ID,ROOMINDEX,INTIME) VALUES (" +
                $"'{MyID}'," +                                      //내아이디 정보
                $"{RoomIndex}," +                                   //룸 인덱스번호
                $"'{sql.Datetime()}')");
            chat.Show();
            //방을생성후 해당 폼은 종료한다.
            this.Close();
        }

        private void CreateRoom_Load(object sender, EventArgs e)
        {
            for(int i = 1; i <= 50; i++)
            {
                Cb_Person.Items.Add(i.ToString());
            }
        }
    }
}

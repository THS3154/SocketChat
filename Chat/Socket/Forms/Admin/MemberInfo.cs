using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Socket.Forms.Admin
{
    
    public partial class MemberInfo : Form
    {
        string MyID;
        public MemberInfo(string ID)
        {
            InitializeComponent();
            
            //아이디값을 저장해둠
            MyID = ID;
            this.Text = MyID + StringText.AdminMemberTitle();

            //폼 기본 설정
            Forms.FormSetting fs = new Forms.FormSetting();
            this.FormBorderStyle = fs.MyFormBorderStyle();
            this.BackColor = fs.MyFormColor();

            groupBox1.ForeColor = fs.MyFontColor();
            groupBox2.ForeColor = fs.MyFontColor();

            foreach (Control c in this.Controls)
            {
                if (c.Name != "")
                {
                    string str = c.Name.Split('_')[0];
                    if (str == "Label" || str == "Btn" || str == "Txt" || str == "Lb" || str == "Lv")
                    {
                        //폰트 컬러값을 변경
                        c.ForeColor = fs.MyFontColor();

                        //컨트롤 백그라운드색
                        c.BackColor = fs.MyFormColor();
                    }
                    else
                    {

                    }
                }
            }

            foreach (Control c in groupBox1.Controls)
            {
                if (c.Name != "")
                {
                    string str = c.Name.Split('_')[0];
                    if (str == "Label" || str == "Btn" || str == "Txt" || str == "Lb" || str == "Lv")
                    {
                        //폰트 컬러값을 변경
                        c.ForeColor = fs.MyFontColor();

                        //컨트롤 백그라운드색
                        c.BackColor = fs.MyFormColor();
                    }
                    else
                    {

                    }
                }
            }

            foreach (Control c in groupBox2.Controls)
            {
                if (c.Name != "")
                {
                    string str = c.Name.Split('_')[0];
                    if (str == "Label" || str == "Btn" || str == "Txt" || str == "Lb" || str == "Lv")
                    {
                        //폰트 컬러값을 변경
                        c.ForeColor = fs.MyFontColor();

                        //컨트롤 백그라운드색
                        c.BackColor = fs.MyFormColor();
                    }
                    else
                    {

                    }
                }
            }

        }

        List<Chat.ChatFunction.ChatListData> Rooms = new List<Chat.ChatFunction.ChatListData>();

        private void MemberInfo_Load(object sender, EventArgs e)
        {
            Chat.ChatFunction.ReadRoom(MyID,ref Rooms);

            foreach(var room in Rooms)
            {
                Lb_ChatList.Items.Add(room.RoomName);
            }


            //멤버 세부정보를 읽어옴
            MSSQL sql = new MSSQL();
            sql.ReadData($"SELECT * FROM {Tables.MemberInfo} WHERE ID = '{MyID}'");
            sql.rdr.Read();

            Txt_UserID.Text = MyID;
            Txt_NickName.Text = sql.rdr["NICKNAME"].ToString();
            Txt_Level.Text =  sql.rdr["LEVEL"].ToString();

            sql.RdrClose();
        }



        

        private void Lb_ChatList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //선택된게없을때 하지않음
            if (Lb_ChatList.SelectedIndex == -1)
                return;

            ReplayChat rchat = new ReplayChat(Lb_ChatList.Items[Lb_ChatList.SelectedIndex].ToString(),
                Rooms[Lb_ChatList.SelectedIndex].Roomindex);
            rchat.Show();
        }

        private void Btn_InfoUpdate_Click(object sender, EventArgs e)
        {
            MSSQL sql = new MSSQL();

            //현재는 레벨정보만 수정하게 만듬
            sql.SendQuery($"UPDATE {Tables.MemberInfo} SET LEVEL = {Txt_Level.Text} WHERE ID = '{MyID}'");

            //완료메세지
            MessageBox.Show(StringText.DBUpdateSuccess());
        }
    }
}

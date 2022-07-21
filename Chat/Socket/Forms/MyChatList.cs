using Socket.Forms.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Socket.Forms
{
    public partial class MyChatList : Form
    {
        string MyID;
        List<Chat.ChatFunction.ChatListData> Rooms = new List<Chat.ChatFunction.ChatListData>();

        public MyChatList(string id)
        {
            InitializeComponent();
            MyID = id;

            //폼 기본 설정
            Forms.FormSetting fs = new Forms.FormSetting();
            this.FormBorderStyle = fs.MyFormBorderStyle();
            this.BackColor = fs.MyFormColor();

            foreach (Control c in this.Controls)
            {
                if (c.Name != "")
                {
                    string str = c.Name.Split('_')[0];
                    if (str == "Label" ||  str == "Txt" || str == "Lb")
                    {
                        //폰트 컬러값을 변경
                        c.ForeColor = fs.MyFontColor();

                        //컨트롤 백그라운드색
                        c.BackColor = fs.MyFormColor();
                    }

                }
            }
        }
        
        private void MyChatList_Load(object sender, EventArgs e)
        {
            Chat.ChatFunction.ReadRoom(MyID, ref Rooms);

            //채팅리스에 채팅제목 추가
            foreach(var room in Rooms)
            {
                Lb_ChatList.Items.Add(room.RoomName);
            }
        }

        private void Lb_ChatList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //선택하지않았을땐 종료
            if (Lb_ChatList.SelectedIndex == -1)
                return;

            ReplayChat rchat = new ReplayChat(Lb_ChatList.Items[Lb_ChatList.SelectedIndex].ToString(),
                Rooms[Lb_ChatList.SelectedIndex].Roomindex);
            rchat.Show();

        }
    }
}

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
    public partial class Admin : Form
    {
        List<ListViewItem> list = new List<ListViewItem>();

        //-1 -> 전체 / 0->탈퇴 / 1->정상 / 2->정지
        int SerchType = -1;
        public Admin()
        {
            InitializeComponent();

            //폼 기본 설정
            Forms.FormSetting fs = new Forms.FormSetting();
            this.FormBorderStyle = fs.MyFormBorderStyle();
            this.BackColor = fs.MyFormColor();

            foreach (Control c in this.Controls)
            {
                if (c.Name != "")
                {
                    string str = c.Name.Split('_')[0];
                    if (str == "Label" || str == "Btn" || str == "Txt" || str == "Lb" || str =="Lv")
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

            tabPage1.BackColor = fs.MyFormColor();
            tabPage2.BackColor = fs.MyFormColor();
            foreach (Control c in tabPage1.Controls)
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
                }
            }

            foreach (Control c in tabPage2.Controls)
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
                }
            }

            Group_SerchOption.ForeColor = fs.MyFontColor();
            foreach (Control c in Group_SerchOption.Controls)
            {
                if (c.Name != "")
                {
                    string str = c.Name.Split('_')[0];
                    if (str == "Label" || str == "Btn" || str == "Txt" || str == "Lb" || str == "Radio")
                    {
                        //폰트 컬러값을 변경
                        c.ForeColor = fs.MyFontColor();

                        //컨트롤 백그라운드색
                        c.BackColor = fs.MyFormColor();
                    }
                }
            }
        }

        private void Btn_RefreshList_Click(object sender, EventArgs e)
        {
            GetMemberList();
            PrintMemberList(Txt_SerchID.Text);
        }
        private void GetMemberList()
        {
            list.Clear();
            //회원 목록을 가져옴
            MSSQL sql = new MSSQL();
            string query = $"SELECT ID,NICKNAME,LEVEL,STATE FROM {Tables.MemberInfo}";
            sql.ReadData(query);
            while (sql.rdr.Read())
            {
                ListViewItem lv = new ListViewItem(sql.rdr["ID"].ToString());
                lv.SubItems.Add(sql.rdr["NICKNAME"].ToString());
                lv.SubItems.Add(sql.rdr["LEVEL"].ToString());
                lv.SubItems.Add(sql.rdr["STATE"].ToString());

                list.Add(lv);
            }
            sql.RdrClose();
        }

        private void PrintMemberList(string SerchId = "")
        {
            //회원 목록을 가져온후
            //Listview에 출력한다.
            Lv_MemberList.Items.Clear();
            if(SerchType == -1)
            {
                if(SerchId == "")
                {
                    //전체검색
                    foreach (var lv in list)
                    {
                        Lv_MemberList.Items.Add(lv);
                    }
                }
                else
                {
                    //전체검색 -> 아이디 찾기
                    foreach (var lv in list)
                    {
                        //해당 문자열이 포함이 됐을때
                        if(lv.SubItems[0].Text.Contains(SerchId))
                            Lv_MemberList.Items.Add(lv);
                    }
                }
                
            }
            else
            {
                if (SerchId == "")
                {
                    //부분검색
                    foreach (var lv in list)
                    {
                        //설정된 검색조건에 맞는 유저를 찾음
                        if (Convert.ToInt32(lv.SubItems[3].Text) == SerchType)
                            Lv_MemberList.Items.Add(lv);
                    }
                }
                else
                {
                    //부분검색
                    foreach (var lv in list)
                    {
                        //설정된 검색조건에 맞는 유저를 찾음 -> 아이디도 포함
                        if (Convert.ToInt32(lv.SubItems[3].Text) == SerchType && lv.SubItems[0].Text.Contains(SerchId))
                            Lv_MemberList.Items.Add(lv);
                    }
                }
                
            }
            
        }

        private void Radio_CheckedChanged(object sender, EventArgs e)
        {
            int state;
            if(((RadioButton)sender) == Radio_All)
            {
                //전체 리스트를 읽어옴
                state = -1;
            }
            else if (((RadioButton)sender) == Radio_State0)
            {
                //탈퇴유저
                state = 0;
            }
            else if (((RadioButton)sender) == Radio_State1)
            {
                //현재 정상적인 아이디 목록
                state = 1;
            }
            else
            {
                //정지먹은 아이디 목록
                state = 2;
            }


            if (((RadioButton)sender).Checked == true)
            {
                SerchType = state;
                PrintMemberList(Txt_SerchID.Text);
            }
                
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            GetMemberList();
            PrintMemberList(Txt_SerchID.Text);
        }

        private void Txt_SerchID_TextChanged(object sender, EventArgs e)
        {
            //입력할때마다 데이터를 읽어와서 목록에 띄워줌
            //나중에 연산량이 늘어날경우 느려질 경우가 있을수있으니
            //엔터처리로 변경하는 옵션을 추가해야할듯
            PrintMemberList(Txt_SerchID.Text);
        }

        private void Lv_MemberList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(Lv_MemberList.SelectedItems.Count != 0)
            {
                //해당 인덱스를 구함
                int Select = Lv_MemberList.SelectedItems[0].Index;

                //선택한 인덱스 ID값을 가져옴
                string SelectID = Lv_MemberList.Items[Select].SubItems[0].Text;

                //멤버 상세정보창을 띄운다
                MemberInfo minfo = new MemberInfo(SelectID);
                minfo.Show();
            }
            
        }
    }
}

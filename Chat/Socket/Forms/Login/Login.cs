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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            //폼 기본 설정
            Forms.FormSetting fs = new Forms.FormSetting();
            this.FormBorderStyle = fs.MyFormBorderStyle();
            this.BackColor = fs.MyFormColor();

            foreach(Control c in this.Controls)
            {
                if(c.Name != "")
                {
                    string str = c.Name.Split('_')[0];
                    if(str == "Label" || str == "Btn" || str == "Txt")
                    {
                        //폰트 컬러값을 변경
                        c.ForeColor = fs.MyFontColor();

                        //컨트롤 백그라운드색
                        c.BackColor = fs.MyFormColor();
                    }

                }
            }

        }
        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void Label_Join_Click(object sender, EventArgs e)
        {
            //회원가입창을 열어줌
            Join join = new Join();
            join.Show();
        }


        private void CursorOut(object sender, EventArgs e)
        {
            //마우스커서 기본으로 되돌림
            Cursor.Current = Cursors.Default;
        }


        private void CursorIn(object sender, MouseEventArgs e)
        {
            //마우스 커서 클릭모양으로 바꿈
            Cursor.Current = Cursors.Hand;
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            MSSQL sql = new MSSQL();
            string query = $"SELECT COUNT(*) FROM {Tables.MemberInfo} WHERE ID = '{Txt_ID.Text}'";
            if((int)sql.GetQueryCnt(query) != 0)
            {
                //계정이 있을경우 로그인
                sql.ReadData($"SELECT * FROM {Tables.MemberInfo} WHERE ID = '{Txt_ID.Text}'");
                sql.rdr.Read();
                string pw = sql.rdr["PW"].ToString();
                

                if(pw == Txt_PW.Text)
                {
                    //로그인 성공
                    SocketMain scmain = new SocketMain(sql.rdr["ID"].ToString());
                    scmain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(StringText.LoginCancel());
                }
                sql.RdrClose();
            }
            
        }

        

        private void Txt_PW_KeyPress(object sender, KeyPressEventArgs e)
        {
            //패스워드란에서 엔터를 눌럿을경우 로그인 버튼이 눌리게 처리
            if(e.KeyChar == (char)Keys.Enter)
            {
                Btn_Login_Click(null, null);
            }
        }
    }
}

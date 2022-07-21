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
    public partial class Join : Form
    {
        bool IDCheck;
        bool PWCheck;
        public Join()
        {
            InitializeComponent();
            IDCheck = false;
            PWCheck = false;

            //폼 기본 설정
            Forms.FormSetting fs = new Forms.FormSetting();
            this.FormBorderStyle = fs.MyFormBorderStyle();
            this.BackColor = fs.MyFormColor();

            foreach (Control c in this.Controls)
            {
                if (c.Name != "")
                {
                    string str = c.Name.Split('_')[0];
                    if (str == "Label" || str == "Btn" || str == "Txt" || str == "Group")
                    {
                        //폰트 컬러값을 변경
                        c.ForeColor = fs.MyFontColor();

                        //컨트롤 백그라운드색
                        c.BackColor = fs.MyFormColor();
                    }

                }
            }
            
            //그룹박스에있는 컨트롤들도 변경
            foreach(Control c in Group_Info.Controls)
            {
                if (c.Name != "")
                {
                    string str = c.Name.Split('_')[0];
                    if (str == "Label" || str == "Btn" || str == "Txt")
                    {
                        //폰트 컬러값을 변경
                        c.ForeColor = fs.MyFontColor();

                        //컨트롤 백그라운드색
                        c.BackColor = fs.MyFormColor();
                    }

                }
            }
        }
        
        private void Btn_Join_Click(object sender, EventArgs e)
        {
            //아이디 체크랑 비밀번호체크가 다됐을때
            if(IDCheck && PWCheck)
            {
                MSSQL sql = new MSSQL();
                sql.SendQuery($"INSERT INTO {Tables.MemberInfo}(ID,PW,NICKNAME,LEVEL,JOINTIME) VALUES " +
                    $"('{Txt_ID.Text}'," +      //아이디
                    $"'{Txt_Pw.Text}'," +       //비밀번호
                    $"'{Txt_NickName.Text}'," + //닉네임
                    $"1," +                     //레벨
                    $"'{sql.Datetime()}')");                  //회원가입날짜

                MessageBox.Show("회원가입 완료");
                this.Close();
            }
            else
            {
                if (!IDCheck)
                    MessageBox.Show("ID 중복확인 해주세요.");

                if (!PWCheck)
                    MessageBox.Show("비밀번호가 일치하지 않습니다.");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_IDCheck_Click(object sender, EventArgs e)
        {
            MSSQL sql = new MSSQL();

            //해당 아이디가 있는지 확인 없을경우 진행
            int check = (int)sql.GetQueryCnt($"SELECT COUNT(*) FROM MEMBERINFO WHERE ID = '{Txt_ID.Text}'");
            if(check == 0)
            {
                //아이디 중복확인
                IDCheck = true;
                Btn_IDCheck.Text = "사용가능";

                //아이디 입력 비활성화
                Txt_ID.Enabled = false;
            }
            else
            {
                MessageBox.Show("ID 중복입니다.");
            }
        }

        private void Txt_ID_TextChanged(object sender, EventArgs e)
        {
            //텍스트 변경이 일어났을경우 사용할 예정 현재는 사용하지않음
        }

        private void Txt_Pw_TextChanged(object sender, EventArgs e)
        {
            //원본 비밀번호

        }

        private void Txt_RePw_TextChanged(object sender, EventArgs e)
        {
            //재확인 비밀번호
            if(Txt_Pw.Text == Txt_RePw.Text && Txt_RePw.Text != "" && Txt_Pw.Text != "")
            {
                Label_PWCheck.Text = "일치";
                PWCheck = true;
            }
            else
            {
                Label_PWCheck.Text = "불일치";
                PWCheck = false;
            }
        }

        private void Btn_Cancle_Click(object sender, EventArgs e)
        {
            //해당 폼을 종료한다
            this.Close();
        }

        private void Join_Load(object sender, EventArgs e)
        {

        }
    }
}

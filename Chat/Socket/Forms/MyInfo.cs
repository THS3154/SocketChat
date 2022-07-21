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
    public partial class MyInfo : Form
    {
        string MyID;
        public MyInfo(string id)
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

        private void MyInfo_Load(object sender, EventArgs e)
        {
            MSSQL sql = new MSSQL();
            sql.ReadData($"SELECT * FROM {Tables.MemberInfo} WHERE ID = '{MyID}'");
            sql.rdr.Read();
            Txt_NickName.Text = sql.rdr["NICKNAME"].ToString();
            sql.RdrClose();
        }

        private void Btn_SetNickName_Click(object sender, EventArgs e)
        {
            MSSQL sql = new MSSQL();

            //현재는 레벨정보만 수정하게 만듬
            sql.SendQuery($"UPDATE {Tables.MemberInfo} SET NICKNAME = '{Txt_NickName.Text}' WHERE ID = '{MyID}'");

            //완료메세지
            MessageBox.Show(StringText.DBUpdateSuccess());
        }
    }
}

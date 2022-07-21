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
    public partial class ReplayChat : Form
    {
        int RoomIndex;
        public ReplayChat(string RoomName,int RoomIndex)
        {
            InitializeComponent();
            this.Text = RoomName;
            this.RoomIndex = RoomIndex;

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

        private void ReplayChat_Load(object sender, EventArgs e)
        {
            MSSQL sql = new MSSQL();
            sql.ReadData($"SELECT * FROM {Tables.MessageLogs} WHERE ROOMINDEX = {RoomIndex} ORDER BY TIMES ASC");

            while (sql.rdr.Read())
            {
                Lb_Chat.Items.Add($"{sql.rdr["SENDER"].ToString()} : {sql.rdr["MESSAGE"].ToString()}");
            }
        }
    }
}

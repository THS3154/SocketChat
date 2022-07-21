
namespace Socket
{
    partial class SocketMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SocketMain));
            this.Lb_RoomList = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Timer_Refresh = new System.Windows.Forms.Timer(this.components);
            this.Timer_AutoRefresh = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Btn_ReplayChat = new Socket.CustomButton();
            this.Btn_Refresh = new Socket.CustomButton();
            this.Btn_Setting = new Socket.CustomButton();
            this.Btn_CreateRoom = new Socket.CustomButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lb_RoomList
            // 
            this.Lb_RoomList.Font = new System.Drawing.Font("굴림", 12F);
            this.Lb_RoomList.ForeColor = System.Drawing.Color.White;
            this.Lb_RoomList.FormattingEnabled = true;
            this.Lb_RoomList.ItemHeight = 16;
            this.Lb_RoomList.Location = new System.Drawing.Point(117, 74);
            this.Lb_RoomList.Name = "Lb_RoomList";
            this.Lb_RoomList.Size = new System.Drawing.Size(249, 196);
            this.Lb_RoomList.TabIndex = 6;
            this.Lb_RoomList.SelectedIndexChanged += new System.EventHandler(this.Lb_RoomList_SelectedIndexChanged);
            this.Lb_RoomList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Lb_RoomList_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAdmin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(374, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuAdmin
            // 
            this.MenuAdmin.Name = "MenuAdmin";
            this.MenuAdmin.Size = new System.Drawing.Size(55, 20);
            this.MenuAdmin.Text = "관리자";
            this.MenuAdmin.Click += new System.EventHandler(this.MenuAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(114, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "방목록";
            // 
            // Timer_Refresh
            // 
            this.Timer_Refresh.Interval = 10000;
            this.Timer_Refresh.Tick += new System.EventHandler(this.Timer_Refresh_Tick);
            // 
            // Timer_AutoRefresh
            // 
            this.Timer_AutoRefresh.Enabled = true;
            this.Timer_AutoRefresh.Interval = 10000;
            this.Timer_AutoRefresh.Tick += new System.EventHandler(this.Timer_AutoRefresh_Tick);
            // 
            // Btn_ReplayChat
            // 
            this.Btn_ReplayChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Btn_ReplayChat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_ReplayChat.BackgroundImage")));
            this.Btn_ReplayChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_ReplayChat.BorderThickness = 2F;
            this.Btn_ReplayChat.Image1 = ((System.Drawing.Image)(resources.GetObject("Btn_ReplayChat.Image1")));
            this.Btn_ReplayChat.Image2 = ((System.Drawing.Image)(resources.GetObject("Btn_ReplayChat.Image2")));
            this.Btn_ReplayChat.Location = new System.Drawing.Point(0, 120);
            this.Btn_ReplayChat.Name = "Btn_ReplayChat";
            this.Btn_ReplayChat.Size = new System.Drawing.Size(111, 78);
            this.Btn_ReplayChat.TabIndex = 17;
            this.Btn_ReplayChat.Click += new System.EventHandler(this.Btn_ReplayChat_Click);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Btn_Refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Refresh.BackgroundImage")));
            this.Btn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Refresh.BorderThickness = 2F;
            this.Btn_Refresh.Image1 = ((System.Drawing.Image)(resources.GetObject("Btn_Refresh.Image1")));
            this.Btn_Refresh.Image2 = ((System.Drawing.Image)(resources.GetObject("Btn_Refresh.Image2")));
            this.Btn_Refresh.Location = new System.Drawing.Point(329, 29);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(37, 37);
            this.Btn_Refresh.TabIndex = 16;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // Btn_Setting
            // 
            this.Btn_Setting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Btn_Setting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Setting.BackgroundImage")));
            this.Btn_Setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Setting.BorderThickness = 2F;
            this.Btn_Setting.Image1 = ((System.Drawing.Image)(resources.GetObject("Btn_Setting.Image1")));
            this.Btn_Setting.Image2 = ((System.Drawing.Image)(resources.GetObject("Btn_Setting.Image2")));
            this.Btn_Setting.Location = new System.Drawing.Point(0, 204);
            this.Btn_Setting.Name = "Btn_Setting";
            this.Btn_Setting.Size = new System.Drawing.Size(111, 78);
            this.Btn_Setting.TabIndex = 15;
            this.Btn_Setting.Click += new System.EventHandler(this.Btn_Setting_Click);
            this.Btn_Setting.MouseHover += new System.EventHandler(this.Btn_Setting_MouseHover);
            // 
            // Btn_CreateRoom
            // 
            this.Btn_CreateRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Btn_CreateRoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_CreateRoom.BackgroundImage")));
            this.Btn_CreateRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_CreateRoom.BorderThickness = 2F;
            this.Btn_CreateRoom.Image1 = ((System.Drawing.Image)(resources.GetObject("Btn_CreateRoom.Image1")));
            this.Btn_CreateRoom.Image2 = ((System.Drawing.Image)(resources.GetObject("Btn_CreateRoom.Image2")));
            this.Btn_CreateRoom.Location = new System.Drawing.Point(0, 36);
            this.Btn_CreateRoom.Name = "Btn_CreateRoom";
            this.Btn_CreateRoom.Size = new System.Drawing.Size(111, 78);
            this.Btn_CreateRoom.TabIndex = 14;
            this.Btn_CreateRoom.Click += new System.EventHandler(this.Btn_CreateRoom_Click);
            this.Btn_CreateRoom.MouseHover += new System.EventHandler(this.Btn_CreateRoom_MouseHover);
            // 
            // SocketMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(374, 288);
            this.Controls.Add(this.Btn_ReplayChat);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.Btn_Setting);
            this.Controls.Add(this.Btn_CreateRoom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lb_RoomList);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SocketMain";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SocketMain_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox Lb_RoomList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Timer_Refresh;
        private System.Windows.Forms.Timer Timer_AutoRefresh;
        private CustomButton Btn_CreateRoom;
        private CustomButton Btn_Setting;
        private System.Windows.Forms.ToolTip toolTip;
        private CustomButton Btn_Refresh;
        private CustomButton Btn_ReplayChat;
    }
}


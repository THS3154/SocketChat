
namespace Socket.Forms.Admin
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_SerchID = new System.Windows.Forms.TextBox();
            this.Tab_Control = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Btn_RefreshList = new System.Windows.Forms.Button();
            this.Group_SerchOption = new System.Windows.Forms.GroupBox();
            this.Radio_State2 = new System.Windows.Forms.RadioButton();
            this.Radio_State0 = new System.Windows.Forms.RadioButton();
            this.Radio_State1 = new System.Windows.Forms.RadioButton();
            this.Radio_All = new System.Windows.Forms.RadioButton();
            this.Lv_MemberList = new System.Windows.Forms.ListView();
            this.MEMBERID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NICKNAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LEVEL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Tab_Control.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Group_SerchOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_SerchID
            // 
            this.Txt_SerchID.Font = new System.Drawing.Font("굴림", 12F);
            this.Txt_SerchID.Location = new System.Drawing.Point(12, 83);
            this.Txt_SerchID.Name = "Txt_SerchID";
            this.Txt_SerchID.Size = new System.Drawing.Size(200, 26);
            this.Txt_SerchID.TabIndex = 1;
            this.Txt_SerchID.TextChanged += new System.EventHandler(this.Txt_SerchID_TextChanged);
            // 
            // Tab_Control
            // 
            this.Tab_Control.Controls.Add(this.tabPage1);
            this.Tab_Control.Controls.Add(this.tabPage2);
            this.Tab_Control.Location = new System.Drawing.Point(12, 12);
            this.Tab_Control.Name = "Tab_Control";
            this.Tab_Control.SelectedIndex = 0;
            this.Tab_Control.Size = new System.Drawing.Size(686, 342);
            this.Tab_Control.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Btn_RefreshList);
            this.tabPage1.Controls.Add(this.Group_SerchOption);
            this.tabPage1.Controls.Add(this.Lv_MemberList);
            this.tabPage1.Controls.Add(this.Txt_SerchID);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(678, 316);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ID 목록";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Btn_RefreshList
            // 
            this.Btn_RefreshList.Location = new System.Drawing.Point(137, 287);
            this.Btn_RefreshList.Name = "Btn_RefreshList";
            this.Btn_RefreshList.Size = new System.Drawing.Size(75, 23);
            this.Btn_RefreshList.TabIndex = 4;
            this.Btn_RefreshList.Text = "목록 갱신";
            this.Btn_RefreshList.UseVisualStyleBackColor = true;
            this.Btn_RefreshList.Click += new System.EventHandler(this.Btn_RefreshList_Click);
            // 
            // Group_SerchOption
            // 
            this.Group_SerchOption.Controls.Add(this.Radio_State2);
            this.Group_SerchOption.Controls.Add(this.Radio_State0);
            this.Group_SerchOption.Controls.Add(this.Radio_State1);
            this.Group_SerchOption.Controls.Add(this.Radio_All);
            this.Group_SerchOption.Location = new System.Drawing.Point(12, 6);
            this.Group_SerchOption.Name = "Group_SerchOption";
            this.Group_SerchOption.Size = new System.Drawing.Size(200, 71);
            this.Group_SerchOption.TabIndex = 3;
            this.Group_SerchOption.TabStop = false;
            this.Group_SerchOption.Text = "검색조건";
            // 
            // Radio_State2
            // 
            this.Radio_State2.AutoSize = true;
            this.Radio_State2.Location = new System.Drawing.Point(104, 42);
            this.Radio_State2.Name = "Radio_State2";
            this.Radio_State2.Size = new System.Drawing.Size(71, 16);
            this.Radio_State2.TabIndex = 7;
            this.Radio_State2.TabStop = true;
            this.Radio_State2.Text = "정지회원";
            this.Radio_State2.UseVisualStyleBackColor = true;
            this.Radio_State2.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // Radio_State0
            // 
            this.Radio_State0.AutoSize = true;
            this.Radio_State0.Location = new System.Drawing.Point(6, 42);
            this.Radio_State0.Name = "Radio_State0";
            this.Radio_State0.Size = new System.Drawing.Size(71, 16);
            this.Radio_State0.TabIndex = 6;
            this.Radio_State0.TabStop = true;
            this.Radio_State0.Text = "탈퇴회원";
            this.Radio_State0.UseVisualStyleBackColor = true;
            this.Radio_State0.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // Radio_State1
            // 
            this.Radio_State1.AutoSize = true;
            this.Radio_State1.Location = new System.Drawing.Point(104, 20);
            this.Radio_State1.Name = "Radio_State1";
            this.Radio_State1.Size = new System.Drawing.Size(71, 16);
            this.Radio_State1.TabIndex = 5;
            this.Radio_State1.TabStop = true;
            this.Radio_State1.Text = "현재회원";
            this.Radio_State1.UseVisualStyleBackColor = true;
            this.Radio_State1.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // Radio_All
            // 
            this.Radio_All.AutoSize = true;
            this.Radio_All.Location = new System.Drawing.Point(6, 20);
            this.Radio_All.Name = "Radio_All";
            this.Radio_All.Size = new System.Drawing.Size(47, 16);
            this.Radio_All.TabIndex = 4;
            this.Radio_All.TabStop = true;
            this.Radio_All.Text = "전체";
            this.Radio_All.UseVisualStyleBackColor = true;
            this.Radio_All.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // Lv_MemberList
            // 
            this.Lv_MemberList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MEMBERID,
            this.NICKNAME,
            this.LEVEL});
            this.Lv_MemberList.Font = new System.Drawing.Font("굴림", 12F);
            this.Lv_MemberList.FullRowSelect = true;
            this.Lv_MemberList.HideSelection = false;
            this.Lv_MemberList.Location = new System.Drawing.Point(218, 12);
            this.Lv_MemberList.Name = "Lv_MemberList";
            this.Lv_MemberList.Size = new System.Drawing.Size(454, 298);
            this.Lv_MemberList.TabIndex = 2;
            this.Lv_MemberList.UseCompatibleStateImageBehavior = false;
            this.Lv_MemberList.View = System.Windows.Forms.View.Details;
            this.Lv_MemberList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Lv_MemberList_MouseDoubleClick);
            // 
            // MEMBERID
            // 
            this.MEMBERID.Text = "MEMBERID";
            this.MEMBERID.Width = 111;
            // 
            // NICKNAME
            // 
            this.NICKNAME.Text = "NICKNAME";
            this.NICKNAME.Width = 275;
            // 
            // LEVEL
            // 
            this.LEVEL.Text = "LEVLE";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(678, 316);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "채팅목록";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 366);
            this.Controls.Add(this.Tab_Control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.Tab_Control.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Group_SerchOption.ResumeLayout(false);
            this.Group_SerchOption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_SerchID;
        private System.Windows.Forms.TabControl Tab_Control;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox Group_SerchOption;
        private System.Windows.Forms.RadioButton Radio_State2;
        private System.Windows.Forms.RadioButton Radio_State0;
        private System.Windows.Forms.RadioButton Radio_State1;
        private System.Windows.Forms.RadioButton Radio_All;
        private System.Windows.Forms.ListView Lv_MemberList;
        private System.Windows.Forms.ColumnHeader MEMBERID;
        private System.Windows.Forms.ColumnHeader NICKNAME;
        private System.Windows.Forms.ColumnHeader LEVEL;
        private System.Windows.Forms.Button Btn_RefreshList;
    }
}
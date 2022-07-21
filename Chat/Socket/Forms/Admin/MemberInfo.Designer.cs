
namespace Socket.Forms.Admin
{
    partial class MemberInfo
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
            this.Txt_UserID = new System.Windows.Forms.TextBox();
            this.Label_ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_NickName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_InfoUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Level = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Lb_ChatList = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_UserID
            // 
            this.Txt_UserID.Enabled = false;
            this.Txt_UserID.Font = new System.Drawing.Font("굴림", 12F);
            this.Txt_UserID.Location = new System.Drawing.Point(96, 20);
            this.Txt_UserID.Name = "Txt_UserID";
            this.Txt_UserID.Size = new System.Drawing.Size(182, 26);
            this.Txt_UserID.TabIndex = 0;
            // 
            // Label_ID
            // 
            this.Label_ID.AutoSize = true;
            this.Label_ID.Font = new System.Drawing.Font("굴림", 12F);
            this.Label_ID.Location = new System.Drawing.Point(5, 23);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(21, 16);
            this.Label_ID.TabIndex = 1;
            this.Label_ID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(5, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "NickName";
            // 
            // Txt_NickName
            // 
            this.Txt_NickName.Enabled = false;
            this.Txt_NickName.Font = new System.Drawing.Font("굴림", 12F);
            this.Txt_NickName.Location = new System.Drawing.Point(96, 52);
            this.Txt_NickName.Name = "Txt_NickName";
            this.Txt_NickName.Size = new System.Drawing.Size(182, 26);
            this.Txt_NickName.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_InfoUpdate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_Level);
            this.groupBox1.Controls.Add(this.Txt_UserID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Label_ID);
            this.groupBox1.Controls.Add(this.Txt_NickName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 249);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "회원정보";
            // 
            // Btn_InfoUpdate
            // 
            this.Btn_InfoUpdate.Location = new System.Drawing.Point(170, 220);
            this.Btn_InfoUpdate.Name = "Btn_InfoUpdate";
            this.Btn_InfoUpdate.Size = new System.Drawing.Size(108, 23);
            this.Btn_InfoUpdate.TabIndex = 6;
            this.Btn_InfoUpdate.Text = "수정";
            this.Btn_InfoUpdate.UseVisualStyleBackColor = true;
            this.Btn_InfoUpdate.Click += new System.EventHandler(this.Btn_InfoUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F);
            this.label2.Location = new System.Drawing.Point(5, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Level";
            // 
            // Txt_Level
            // 
            this.Txt_Level.Font = new System.Drawing.Font("굴림", 12F);
            this.Txt_Level.Location = new System.Drawing.Point(96, 84);
            this.Txt_Level.Name = "Txt_Level";
            this.Txt_Level.Size = new System.Drawing.Size(182, 26);
            this.Txt_Level.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Lb_ChatList);
            this.groupBox2.Location = new System.Drawing.Point(325, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 249);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "채팅 목록";
            // 
            // Lb_ChatList
            // 
            this.Lb_ChatList.FormattingEnabled = true;
            this.Lb_ChatList.ItemHeight = 12;
            this.Lb_ChatList.Location = new System.Drawing.Point(6, 20);
            this.Lb_ChatList.Name = "Lb_ChatList";
            this.Lb_ChatList.Size = new System.Drawing.Size(272, 220);
            this.Lb_ChatList.TabIndex = 0;
            this.Lb_ChatList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Lb_ChatList_MouseDoubleClick);
            // 
            // MemberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 273);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MemberInfo";
            this.Text = "MemberInfo";
            this.Load += new System.EventHandler(this.MemberInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_UserID;
        private System.Windows.Forms.Label Label_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_NickName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_InfoUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Level;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox Lb_ChatList;
    }
}
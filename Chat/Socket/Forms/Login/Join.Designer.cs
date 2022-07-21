
namespace Socket
{
    partial class Join
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
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.Group_Info = new System.Windows.Forms.GroupBox();
            this.Label_NickName = new System.Windows.Forms.Label();
            this.Txt_NickName = new System.Windows.Forms.TextBox();
            this.Label_PWCheck = new System.Windows.Forms.Label();
            this.Label_RePw = new System.Windows.Forms.Label();
            this.Txt_RePw = new System.Windows.Forms.TextBox();
            this.Label_PW = new System.Windows.Forms.Label();
            this.Txt_Pw = new System.Windows.Forms.TextBox();
            this.Label_ID = new System.Windows.Forms.Label();
            this.Btn_IDCheck = new System.Windows.Forms.Button();
            this.Btn_Join = new System.Windows.Forms.Button();
            this.Btn_Cancle = new System.Windows.Forms.Button();
            this.Group_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_ID
            // 
            this.Txt_ID.Location = new System.Drawing.Point(99, 20);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(100, 21);
            this.Txt_ID.TabIndex = 0;
            this.Txt_ID.TextChanged += new System.EventHandler(this.Txt_ID_TextChanged);
            // 
            // Group_Info
            // 
            this.Group_Info.Controls.Add(this.Label_NickName);
            this.Group_Info.Controls.Add(this.Txt_NickName);
            this.Group_Info.Controls.Add(this.Label_PWCheck);
            this.Group_Info.Controls.Add(this.Label_RePw);
            this.Group_Info.Controls.Add(this.Txt_RePw);
            this.Group_Info.Controls.Add(this.Label_PW);
            this.Group_Info.Controls.Add(this.Txt_Pw);
            this.Group_Info.Controls.Add(this.Label_ID);
            this.Group_Info.Controls.Add(this.Btn_IDCheck);
            this.Group_Info.Controls.Add(this.Txt_ID);
            this.Group_Info.Location = new System.Drawing.Point(13, 12);
            this.Group_Info.Name = "Group_Info";
            this.Group_Info.Size = new System.Drawing.Size(293, 143);
            this.Group_Info.TabIndex = 1;
            this.Group_Info.TabStop = false;
            this.Group_Info.Text = "회원정보";
            this.Group_Info.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Label_NickName
            // 
            this.Label_NickName.AutoSize = true;
            this.Label_NickName.Location = new System.Drawing.Point(10, 108);
            this.Label_NickName.Name = "Label_NickName";
            this.Label_NickName.Size = new System.Drawing.Size(64, 12);
            this.Label_NickName.TabIndex = 11;
            this.Label_NickName.Text = "NickName";
            // 
            // Txt_NickName
            // 
            this.Txt_NickName.Location = new System.Drawing.Point(99, 103);
            this.Txt_NickName.Name = "Txt_NickName";
            this.Txt_NickName.Size = new System.Drawing.Size(100, 21);
            this.Txt_NickName.TabIndex = 10;
            // 
            // Label_PWCheck
            // 
            this.Label_PWCheck.AutoSize = true;
            this.Label_PWCheck.Location = new System.Drawing.Point(205, 67);
            this.Label_PWCheck.Name = "Label_PWCheck";
            this.Label_PWCheck.Size = new System.Drawing.Size(71, 12);
            this.Label_PWCheck.TabIndex = 9;
            this.Label_PWCheck.Text = "일치/불일치";
            // 
            // Label_RePw
            // 
            this.Label_RePw.AutoSize = true;
            this.Label_RePw.Location = new System.Drawing.Point(10, 81);
            this.Label_RePw.Name = "Label_RePw";
            this.Label_RePw.Size = new System.Drawing.Size(44, 12);
            this.Label_RePw.TabIndex = 8;
            this.Label_RePw.Text = "Re-PW";
            // 
            // Txt_RePw
            // 
            this.Txt_RePw.Location = new System.Drawing.Point(99, 76);
            this.Txt_RePw.Name = "Txt_RePw";
            this.Txt_RePw.Size = new System.Drawing.Size(100, 21);
            this.Txt_RePw.TabIndex = 7;
            this.Txt_RePw.TextChanged += new System.EventHandler(this.Txt_RePw_TextChanged);
            // 
            // Label_PW
            // 
            this.Label_PW.AutoSize = true;
            this.Label_PW.Location = new System.Drawing.Point(11, 54);
            this.Label_PW.Name = "Label_PW";
            this.Label_PW.Size = new System.Drawing.Size(23, 12);
            this.Label_PW.TabIndex = 6;
            this.Label_PW.Text = "PW";
            // 
            // Txt_Pw
            // 
            this.Txt_Pw.Location = new System.Drawing.Point(99, 49);
            this.Txt_Pw.Name = "Txt_Pw";
            this.Txt_Pw.PasswordChar = '*';
            this.Txt_Pw.Size = new System.Drawing.Size(100, 21);
            this.Txt_Pw.TabIndex = 4;
            this.Txt_Pw.TextChanged += new System.EventHandler(this.Txt_Pw_TextChanged);
            // 
            // Label_ID
            // 
            this.Label_ID.AutoSize = true;
            this.Label_ID.Location = new System.Drawing.Point(12, 25);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(16, 12);
            this.Label_ID.TabIndex = 3;
            this.Label_ID.Text = "ID";
            // 
            // Btn_IDCheck
            // 
            this.Btn_IDCheck.Location = new System.Drawing.Point(205, 20);
            this.Btn_IDCheck.Name = "Btn_IDCheck";
            this.Btn_IDCheck.Size = new System.Drawing.Size(73, 23);
            this.Btn_IDCheck.TabIndex = 2;
            this.Btn_IDCheck.Text = "중복확인";
            this.Btn_IDCheck.UseVisualStyleBackColor = true;
            this.Btn_IDCheck.Click += new System.EventHandler(this.Btn_IDCheck_Click);
            // 
            // Btn_Join
            // 
            this.Btn_Join.Location = new System.Drawing.Point(156, 161);
            this.Btn_Join.Name = "Btn_Join";
            this.Btn_Join.Size = new System.Drawing.Size(73, 29);
            this.Btn_Join.TabIndex = 12;
            this.Btn_Join.Text = "회원가입";
            this.Btn_Join.UseVisualStyleBackColor = true;
            this.Btn_Join.Click += new System.EventHandler(this.Btn_Join_Click);
            // 
            // Btn_Cancle
            // 
            this.Btn_Cancle.Location = new System.Drawing.Point(235, 161);
            this.Btn_Cancle.Name = "Btn_Cancle";
            this.Btn_Cancle.Size = new System.Drawing.Size(73, 29);
            this.Btn_Cancle.TabIndex = 13;
            this.Btn_Cancle.Text = "취소";
            this.Btn_Cancle.UseVisualStyleBackColor = true;
            this.Btn_Cancle.Click += new System.EventHandler(this.Btn_Cancle_Click);
            // 
            // Join
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 201);
            this.Controls.Add(this.Btn_Cancle);
            this.Controls.Add(this.Btn_Join);
            this.Controls.Add(this.Group_Info);
            this.Name = "Join";
            this.Text = "회원가입";
            this.Load += new System.EventHandler(this.Join_Load);
            this.Group_Info.ResumeLayout(false);
            this.Group_Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.GroupBox Group_Info;
        private System.Windows.Forms.Label Label_NickName;
        private System.Windows.Forms.TextBox Txt_NickName;
        private System.Windows.Forms.Label Label_PWCheck;
        private System.Windows.Forms.Label Label_RePw;
        private System.Windows.Forms.TextBox Txt_RePw;
        private System.Windows.Forms.Label Label_PW;
        private System.Windows.Forms.TextBox Txt_Pw;
        private System.Windows.Forms.Label Label_ID;
        private System.Windows.Forms.Button Btn_IDCheck;
        private System.Windows.Forms.Button Btn_Join;
        private System.Windows.Forms.Button Btn_Cancle;
    }
}
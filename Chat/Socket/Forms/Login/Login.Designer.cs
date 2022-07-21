
namespace Socket
{
    partial class Login
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
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Txt_PW = new System.Windows.Forms.TextBox();
            this.Label_ID = new System.Windows.Forms.Label();
            this.Label_PW = new System.Windows.Forms.Label();
            this.Label_Join = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_ID
            // 
            this.Txt_ID.Location = new System.Drawing.Point(44, 12);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(152, 21);
            this.Txt_ID.TabIndex = 0;
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(202, 10);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(91, 51);
            this.Btn_Login.TabIndex = 2;
            this.Btn_Login.Text = "로그인";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            this.Btn_Login.MouseLeave += new System.EventHandler(this.CursorOut);
            this.Btn_Login.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CursorIn);
            // 
            // Txt_PW
            // 
            this.Txt_PW.Location = new System.Drawing.Point(44, 38);
            this.Txt_PW.Name = "Txt_PW";
            this.Txt_PW.PasswordChar = '*';
            this.Txt_PW.Size = new System.Drawing.Size(152, 21);
            this.Txt_PW.TabIndex = 1;
            this.Txt_PW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_PW_KeyPress);
            // 
            // Label_ID
            // 
            this.Label_ID.AutoSize = true;
            this.Label_ID.Font = new System.Drawing.Font("굴림", 10F);
            this.Label_ID.Location = new System.Drawing.Point(8, 15);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(20, 14);
            this.Label_ID.TabIndex = 3;
            this.Label_ID.Text = "ID";
            // 
            // Label_PW
            // 
            this.Label_PW.AutoSize = true;
            this.Label_PW.Font = new System.Drawing.Font("굴림", 10F);
            this.Label_PW.Location = new System.Drawing.Point(7, 42);
            this.Label_PW.Name = "Label_PW";
            this.Label_PW.Size = new System.Drawing.Size(31, 14);
            this.Label_PW.TabIndex = 4;
            this.Label_PW.Text = "PW";
            // 
            // Label_Join
            // 
            this.Label_Join.AutoSize = true;
            this.Label_Join.Location = new System.Drawing.Point(143, 69);
            this.Label_Join.Name = "Label_Join";
            this.Label_Join.Size = new System.Drawing.Size(53, 12);
            this.Label_Join.TabIndex = 5;
            this.Label_Join.Text = "회원가입";
            this.Label_Join.Click += new System.EventHandler(this.Label_Join_Click);
            this.Label_Join.MouseLeave += new System.EventHandler(this.CursorOut);
            this.Label_Join.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CursorIn);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 90);
            this.Controls.Add(this.Label_Join);
            this.Controls.Add(this.Label_PW);
            this.Controls.Add(this.Label_ID);
            this.Controls.Add(this.Txt_PW);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Txt_ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "로그인";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.TextBox Txt_PW;
        private System.Windows.Forms.Label Label_ID;
        private System.Windows.Forms.Label Label_PW;
        private System.Windows.Forms.Label Label_Join;
    }
}
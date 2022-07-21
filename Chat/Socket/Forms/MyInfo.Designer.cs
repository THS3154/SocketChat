
namespace Socket.Forms
{
    partial class MyInfo
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
            this.Txt_NickName = new System.Windows.Forms.TextBox();
            this.Btn_SetNickName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_NickName
            // 
            this.Txt_NickName.Location = new System.Drawing.Point(12, 12);
            this.Txt_NickName.Name = "Txt_NickName";
            this.Txt_NickName.Size = new System.Drawing.Size(143, 21);
            this.Txt_NickName.TabIndex = 0;
            // 
            // Btn_SetNickName
            // 
            this.Btn_SetNickName.Location = new System.Drawing.Point(161, 12);
            this.Btn_SetNickName.Name = "Btn_SetNickName";
            this.Btn_SetNickName.Size = new System.Drawing.Size(85, 23);
            this.Btn_SetNickName.TabIndex = 1;
            this.Btn_SetNickName.Text = "닉네임 변경";
            this.Btn_SetNickName.UseVisualStyleBackColor = true;
            this.Btn_SetNickName.Click += new System.EventHandler(this.Btn_SetNickName_Click);
            // 
            // MyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 47);
            this.Controls.Add(this.Btn_SetNickName);
            this.Controls.Add(this.Txt_NickName);
            this.Name = "MyInfo";
            this.Text = "MyInfo";
            this.Load += new System.EventHandler(this.MyInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_NickName;
        private System.Windows.Forms.Button Btn_SetNickName;
    }
}
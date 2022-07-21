
namespace Socket.Forms
{
    partial class MyChatList
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
            this.Label_ChatList = new System.Windows.Forms.Label();
            this.Lb_ChatList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Label_ChatList
            // 
            this.Label_ChatList.AutoSize = true;
            this.Label_ChatList.Font = new System.Drawing.Font("굴림", 12F);
            this.Label_ChatList.Location = new System.Drawing.Point(12, 9);
            this.Label_ChatList.Name = "Label_ChatList";
            this.Label_ChatList.Size = new System.Drawing.Size(114, 16);
            this.Label_ChatList.TabIndex = 0;
            this.Label_ChatList.Text = "이전 채팅 목록";
            // 
            // Lb_ChatList
            // 
            this.Lb_ChatList.Font = new System.Drawing.Font("굴림", 12F);
            this.Lb_ChatList.FormattingEnabled = true;
            this.Lb_ChatList.ItemHeight = 16;
            this.Lb_ChatList.Location = new System.Drawing.Point(12, 28);
            this.Lb_ChatList.Name = "Lb_ChatList";
            this.Lb_ChatList.Size = new System.Drawing.Size(406, 148);
            this.Lb_ChatList.TabIndex = 1;
            this.Lb_ChatList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Lb_ChatList_MouseDoubleClick);
            // 
            // MyChatList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 187);
            this.Controls.Add(this.Lb_ChatList);
            this.Controls.Add(this.Label_ChatList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MyChatList";
            this.Text = "MyChatList";
            this.Load += new System.EventHandler(this.MyChatList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_ChatList;
        private System.Windows.Forms.ListBox Lb_ChatList;
    }
}
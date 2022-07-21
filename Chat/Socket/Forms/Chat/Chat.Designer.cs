
namespace Socket
{
    partial class Chat
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
            this.Txt_Send = new System.Windows.Forms.TextBox();
            this.Lb_Chats = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Txt_Send
            // 
            this.Txt_Send.Font = new System.Drawing.Font("굴림", 12F);
            this.Txt_Send.Location = new System.Drawing.Point(12, 338);
            this.Txt_Send.Name = "Txt_Send";
            this.Txt_Send.Size = new System.Drawing.Size(383, 26);
            this.Txt_Send.TabIndex = 1;
            this.Txt_Send.Enter += new System.EventHandler(this.Txt_Send_Enter);
            this.Txt_Send.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Send_KeyPress);
            this.Txt_Send.Leave += new System.EventHandler(this.Txt_Send_Leave);
            // 
            // Lb_Chats
            // 
            this.Lb_Chats.Font = new System.Drawing.Font("굴림", 12F);
            this.Lb_Chats.FormattingEnabled = true;
            this.Lb_Chats.ItemHeight = 16;
            this.Lb_Chats.Location = new System.Drawing.Point(12, 12);
            this.Lb_Chats.Name = "Lb_Chats";
            this.Lb_Chats.Size = new System.Drawing.Size(383, 308);
            this.Lb_Chats.TabIndex = 0;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 380);
            this.Controls.Add(this.Lb_Chats);
            this.Controls.Add(this.Txt_Send);
            this.Name = "Chat";
            this.Text = "Chat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Chat_FormClosed);
            this.Load += new System.EventHandler(this.Chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Send;
        private System.Windows.Forms.ListBox Lb_Chats;
    }
}
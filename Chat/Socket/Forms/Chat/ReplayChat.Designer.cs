
namespace Socket.Forms.Admin
{
    partial class ReplayChat
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
            this.Lb_Chat = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Lb_Chat
            // 
            this.Lb_Chat.FormattingEnabled = true;
            this.Lb_Chat.ItemHeight = 12;
            this.Lb_Chat.Location = new System.Drawing.Point(12, 12);
            this.Lb_Chat.Name = "Lb_Chat";
            this.Lb_Chat.Size = new System.Drawing.Size(366, 424);
            this.Lb_Chat.TabIndex = 0;
            // 
            // ReplayChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 450);
            this.Controls.Add(this.Lb_Chat);
            this.Name = "ReplayChat";
            this.Text = "ReplayChat";
            this.Load += new System.EventHandler(this.ReplayChat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Lb_Chat;
    }
}
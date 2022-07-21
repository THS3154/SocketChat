
namespace Socket
{
    partial class CreateRoom
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
            this.Txt_RoomName = new System.Windows.Forms.TextBox();
            this.Label_RoomName = new System.Windows.Forms.Label();
            this.Cb_Person = new System.Windows.Forms.ComboBox();
            this.Label_Person = new System.Windows.Forms.Label();
            this.Btn_CreateRoom = new System.Windows.Forms.Button();
            this.Label_Port = new System.Windows.Forms.Label();
            this.Txt_Port = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Txt_RoomName
            // 
            this.Txt_RoomName.Font = new System.Drawing.Font("굴림", 12F);
            this.Txt_RoomName.Location = new System.Drawing.Point(86, 13);
            this.Txt_RoomName.Name = "Txt_RoomName";
            this.Txt_RoomName.Size = new System.Drawing.Size(132, 26);
            this.Txt_RoomName.TabIndex = 0;
            // 
            // Label_RoomName
            // 
            this.Label_RoomName.AutoSize = true;
            this.Label_RoomName.Font = new System.Drawing.Font("굴림", 12F);
            this.Label_RoomName.Location = new System.Drawing.Point(12, 18);
            this.Label_RoomName.Name = "Label_RoomName";
            this.Label_RoomName.Size = new System.Drawing.Size(56, 16);
            this.Label_RoomName.TabIndex = 1;
            this.Label_RoomName.Text = "방제목";
            // 
            // Cb_Person
            // 
            this.Cb_Person.Font = new System.Drawing.Font("굴림", 12F);
            this.Cb_Person.FormattingEnabled = true;
            this.Cb_Person.Location = new System.Drawing.Point(86, 54);
            this.Cb_Person.Name = "Cb_Person";
            this.Cb_Person.Size = new System.Drawing.Size(132, 24);
            this.Cb_Person.TabIndex = 2;
            // 
            // Label_Person
            // 
            this.Label_Person.AutoSize = true;
            this.Label_Person.Font = new System.Drawing.Font("굴림", 12F);
            this.Label_Person.Location = new System.Drawing.Point(12, 57);
            this.Label_Person.Name = "Label_Person";
            this.Label_Person.Size = new System.Drawing.Size(40, 16);
            this.Label_Person.TabIndex = 3;
            this.Label_Person.Text = "인원";
            // 
            // Btn_CreateRoom
            // 
            this.Btn_CreateRoom.Font = new System.Drawing.Font("굴림", 12F);
            this.Btn_CreateRoom.Location = new System.Drawing.Point(15, 126);
            this.Btn_CreateRoom.Name = "Btn_CreateRoom";
            this.Btn_CreateRoom.Size = new System.Drawing.Size(203, 35);
            this.Btn_CreateRoom.TabIndex = 4;
            this.Btn_CreateRoom.Text = "방생성";
            this.Btn_CreateRoom.UseVisualStyleBackColor = true;
            this.Btn_CreateRoom.Click += new System.EventHandler(this.Btn_CreateRoom_Click);
            // 
            // Label_Port
            // 
            this.Label_Port.AutoSize = true;
            this.Label_Port.Font = new System.Drawing.Font("굴림", 12F);
            this.Label_Port.Location = new System.Drawing.Point(12, 93);
            this.Label_Port.Name = "Label_Port";
            this.Label_Port.Size = new System.Drawing.Size(40, 16);
            this.Label_Port.TabIndex = 6;
            this.Label_Port.Text = "포트";
            // 
            // Txt_Port
            // 
            this.Txt_Port.Font = new System.Drawing.Font("굴림", 12F);
            this.Txt_Port.Location = new System.Drawing.Point(86, 88);
            this.Txt_Port.Name = "Txt_Port";
            this.Txt_Port.Size = new System.Drawing.Size(132, 26);
            this.Txt_Port.TabIndex = 5;
            this.Txt_Port.Text = "9999";
            // 
            // CreateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 173);
            this.Controls.Add(this.Label_Port);
            this.Controls.Add(this.Txt_Port);
            this.Controls.Add(this.Btn_CreateRoom);
            this.Controls.Add(this.Label_Person);
            this.Controls.Add(this.Cb_Person);
            this.Controls.Add(this.Label_RoomName);
            this.Controls.Add(this.Txt_RoomName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateRoom";
            this.Text = "CreateRoom";
            this.Load += new System.EventHandler(this.CreateRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_RoomName;
        private System.Windows.Forms.Label Label_RoomName;
        private System.Windows.Forms.ComboBox Cb_Person;
        private System.Windows.Forms.Label Label_Person;
        private System.Windows.Forms.Button Btn_CreateRoom;
        private System.Windows.Forms.Label Label_Port;
        private System.Windows.Forms.TextBox Txt_Port;
    }
}
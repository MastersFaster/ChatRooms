namespace ChatRooms
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
            this.TestButton = new System.Windows.Forms.Button();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.UsernameFieldLabel = new System.Windows.Forms.Label();
            this.CreateRoomButton = new System.Windows.Forms.Button();
            this.JoinRoomButton = new System.Windows.Forms.Button();
            this.RoomNameField = new System.Windows.Forms.TextBox();
            this.RoomNameLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(569, 415);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(219, 23);
            this.TestButton.TabIndex = 0;
            this.TestButton.Text = "Test Connection To Server (DEV)";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(274, 64);
            this.UserNameBox.MaxLength = 16;
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(185, 20);
            this.UserNameBox.TabIndex = 1;
            // 
            // UsernameFieldLabel
            // 
            this.UsernameFieldLabel.AutoSize = true;
            this.UsernameFieldLabel.Location = new System.Drawing.Point(271, 48);
            this.UsernameFieldLabel.Name = "UsernameFieldLabel";
            this.UsernameFieldLabel.Size = new System.Drawing.Size(55, 13);
            this.UsernameFieldLabel.TabIndex = 2;
            this.UsernameFieldLabel.Text = "Username";
            this.UsernameFieldLabel.Click += new System.EventHandler(this.UsernameFieldLabel_Click);
            // 
            // CreateRoomButton
            // 
            this.CreateRoomButton.Location = new System.Drawing.Point(274, 165);
            this.CreateRoomButton.Name = "CreateRoomButton";
            this.CreateRoomButton.Size = new System.Drawing.Size(81, 23);
            this.CreateRoomButton.TabIndex = 3;
            this.CreateRoomButton.Text = "Create Room";
            this.CreateRoomButton.UseVisualStyleBackColor = true;
            this.CreateRoomButton.Click += new System.EventHandler(this.CreateRoomButton_Click);
            // 
            // JoinRoomButton
            // 
            this.JoinRoomButton.Location = new System.Drawing.Point(378, 165);
            this.JoinRoomButton.Name = "JoinRoomButton";
            this.JoinRoomButton.Size = new System.Drawing.Size(81, 23);
            this.JoinRoomButton.TabIndex = 4;
            this.JoinRoomButton.Text = "Join Room";
            this.JoinRoomButton.UseVisualStyleBackColor = true;
            this.JoinRoomButton.Click += new System.EventHandler(this.JoinRoomButton_Click);
            // 
            // RoomNameField
            // 
            this.RoomNameField.Location = new System.Drawing.Point(274, 139);
            this.RoomNameField.Name = "RoomNameField";
            this.RoomNameField.Size = new System.Drawing.Size(185, 20);
            this.RoomNameField.TabIndex = 5;
            this.RoomNameField.Visible = false;
            // 
            // RoomNameLabel
            // 
            this.RoomNameLabel.AutoSize = true;
            this.RoomNameLabel.Location = new System.Drawing.Point(274, 120);
            this.RoomNameLabel.Name = "RoomNameLabel";
            this.RoomNameLabel.Size = new System.Drawing.Size(138, 13);
            this.RoomNameLabel.TabIndex = 6;
            this.RoomNameLabel.Text = "Please Enter a Room Name";
            this.RoomNameLabel.Visible = false;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(274, 210);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 7;
            // 
            // CreateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.RoomNameLabel);
            this.Controls.Add(this.RoomNameField);
            this.Controls.Add(this.JoinRoomButton);
            this.Controls.Add(this.CreateRoomButton);
            this.Controls.Add(this.UsernameFieldLabel);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.TestButton);
            this.Name = "CreateRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.Label UsernameFieldLabel;
        private System.Windows.Forms.Button CreateRoomButton;
        private System.Windows.Forms.Button JoinRoomButton;
        private System.Windows.Forms.TextBox RoomNameField;
        private System.Windows.Forms.Label RoomNameLabel;
        private System.Windows.Forms.Label ErrorLabel;
    }
}
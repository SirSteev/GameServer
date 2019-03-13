namespace GameServer
{
    partial class GameServerForm
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
            this.lbPlayerList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSeverConsoleMessages = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKickPlayer = new System.Windows.Forms.Button();
            this.btnKillServer = new System.Windows.Forms.Button();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPlayerList
            // 
            this.lbPlayerList.FormattingEnabled = true;
            this.lbPlayerList.Location = new System.Drawing.Point(12, 29);
            this.lbPlayerList.Name = "lbPlayerList";
            this.lbPlayerList.Size = new System.Drawing.Size(120, 407);
            this.lbPlayerList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player List";
            // 
            // tbSeverConsoleMessages
            // 
            this.tbSeverConsoleMessages.Location = new System.Drawing.Point(138, 29);
            this.tbSeverConsoleMessages.Multiline = true;
            this.tbSeverConsoleMessages.Name = "tbSeverConsoleMessages";
            this.tbSeverConsoleMessages.Size = new System.Drawing.Size(650, 409);
            this.tbSeverConsoleMessages.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Server Console Messages";
            // 
            // btnKickPlayer
            // 
            this.btnKickPlayer.Location = new System.Drawing.Point(13, 443);
            this.btnKickPlayer.Name = "btnKickPlayer";
            this.btnKickPlayer.Size = new System.Drawing.Size(75, 23);
            this.btnKickPlayer.TabIndex = 4;
            this.btnKickPlayer.Text = "Kick Player";
            this.btnKickPlayer.UseVisualStyleBackColor = true;
            // 
            // btnKillServer
            // 
            this.btnKillServer.Location = new System.Drawing.Point(632, 443);
            this.btnKillServer.Name = "btnKillServer";
            this.btnKillServer.Size = new System.Drawing.Size(75, 23);
            this.btnKillServer.TabIndex = 5;
            this.btnKillServer.Text = "Kill Server";
            this.btnKillServer.UseVisualStyleBackColor = true;
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(713, 443);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(75, 23);
            this.btnStartServer.TabIndex = 6;
            this.btnStartServer.Text = "Start Server";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // GameServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.btnStartServer);
            this.Controls.Add(this.btnKillServer);
            this.Controls.Add(this.btnKickPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSeverConsoleMessages);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPlayerList);
            this.Name = "GameServerForm";
            this.Text = "Game Server";
            this.Load += new System.EventHandler(this.GameServerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPlayerList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSeverConsoleMessages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKickPlayer;
        private System.Windows.Forms.Button btnKillServer;
        private System.Windows.Forms.Button btnStartServer;
    }
}


namespace MultipleConnection_Client
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblLAT = new System.Windows.Forms.Label();
            this.lblLON = new System.Windows.Forms.Label();
            this.txtLAT = new System.Windows.Forms.TextBox();
            this.txtLON = new System.Windows.Forms.TextBox();
            this.LATandLON = new System.Windows.Forms.Timer(this.components);
            this.lblAircraft = new System.Windows.Forms.Label();
            this.txtAircraft = new System.Windows.Forms.TextBox();
            this.txtCallsign = new System.Windows.Forms.TextBox();
            this.lblCallsign = new System.Windows.Forms.Label();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.txtChatText = new System.Windows.Forms.TextBox();
            this.btnChatSend = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cboxServer = new System.Windows.Forms.ComboBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Enabled = false;
            this.btnConnect.Location = new System.Drawing.Point(12, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 41);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(12, 70);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(100, 20);
            this.txtMsg.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.Location = new System.Drawing.Point(12, 96);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Disconnect";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblLAT
            // 
            this.lblLAT.AutoSize = true;
            this.lblLAT.Location = new System.Drawing.Point(40, 122);
            this.lblLAT.Name = "lblLAT";
            this.lblLAT.Size = new System.Drawing.Size(45, 13);
            this.lblLAT.TabIndex = 4;
            this.lblLAT.Text = "Latitude";
            // 
            // lblLON
            // 
            this.lblLON.AutoSize = true;
            this.lblLON.Location = new System.Drawing.Point(35, 162);
            this.lblLON.Name = "lblLON";
            this.lblLON.Size = new System.Drawing.Size(54, 13);
            this.lblLON.TabIndex = 5;
            this.lblLON.Text = "Longitude";
            // 
            // txtLAT
            // 
            this.txtLAT.Location = new System.Drawing.Point(12, 139);
            this.txtLAT.Name = "txtLAT";
            this.txtLAT.ReadOnly = true;
            this.txtLAT.Size = new System.Drawing.Size(100, 20);
            this.txtLAT.TabIndex = 6;
            // 
            // txtLON
            // 
            this.txtLON.Location = new System.Drawing.Point(12, 178);
            this.txtLON.Name = "txtLON";
            this.txtLON.ReadOnly = true;
            this.txtLON.Size = new System.Drawing.Size(100, 20);
            this.txtLON.TabIndex = 7;
            // 
            // LATandLON
            // 
            this.LATandLON.Interval = 1000;
            this.LATandLON.Tick += new System.EventHandler(this.LATandLON_Tick);
            // 
            // lblAircraft
            // 
            this.lblAircraft.AutoSize = true;
            this.lblAircraft.Location = new System.Drawing.Point(171, 80);
            this.lblAircraft.Name = "lblAircraft";
            this.lblAircraft.Size = new System.Drawing.Size(40, 13);
            this.lblAircraft.TabIndex = 8;
            this.lblAircraft.Text = "Aircraft";
            // 
            // txtAircraft
            // 
            this.txtAircraft.Location = new System.Drawing.Point(142, 96);
            this.txtAircraft.Name = "txtAircraft";
            this.txtAircraft.Size = new System.Drawing.Size(100, 20);
            this.txtAircraft.TabIndex = 1;
            this.txtAircraft.TextChanged += new System.EventHandler(this.txtAircraft_TextChanged);
            // 
            // txtCallsign
            // 
            this.txtCallsign.Location = new System.Drawing.Point(142, 57);
            this.txtCallsign.Name = "txtCallsign";
            this.txtCallsign.Size = new System.Drawing.Size(100, 20);
            this.txtCallsign.TabIndex = 0;
            this.txtCallsign.TextChanged += new System.EventHandler(this.txtCallsign_TextChanged);
            // 
            // lblCallsign
            // 
            this.lblCallsign.AutoSize = true;
            this.lblCallsign.Location = new System.Drawing.Point(171, 41);
            this.lblCallsign.Name = "lblCallsign";
            this.lblCallsign.Size = new System.Drawing.Size(43, 13);
            this.lblCallsign.TabIndex = 10;
            this.lblCallsign.Text = "Callsign";
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(266, 15);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.ReadOnly = true;
            this.txtChat.Size = new System.Drawing.Size(324, 120);
            this.txtChat.TabIndex = 12;
            // 
            // txtChatText
            // 
            this.txtChatText.Enabled = false;
            this.txtChatText.Location = new System.Drawing.Point(266, 152);
            this.txtChatText.Multiline = true;
            this.txtChatText.Name = "txtChatText";
            this.txtChatText.Size = new System.Drawing.Size(324, 23);
            this.txtChatText.TabIndex = 13;
            // 
            // btnChatSend
            // 
            this.btnChatSend.Enabled = false;
            this.btnChatSend.Location = new System.Drawing.Point(490, 181);
            this.btnChatSend.Name = "btnChatSend";
            this.btnChatSend.Size = new System.Drawing.Size(100, 23);
            this.btnChatSend.TabIndex = 14;
            this.btnChatSend.Text = "Send";
            this.btnChatSend.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.DarkRed;
            this.lblStatus.Location = new System.Drawing.Point(142, 12);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 23);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Disconnected";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // cboxServer
            // 
            this.cboxServer.Enabled = false;
            this.cboxServer.FormattingEnabled = true;
            this.cboxServer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboxServer.Location = new System.Drawing.Point(139, 139);
            this.cboxServer.Name = "cboxServer";
            this.cboxServer.Size = new System.Drawing.Size(103, 21);
            this.cboxServer.TabIndex = 17;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(171, 120);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(38, 13);
            this.lblServer.TabIndex = 18;
            this.lblServer.Text = "Server";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 216);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.cboxServer);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnChatSend);
            this.Controls.Add(this.txtChatText);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.txtCallsign);
            this.Controls.Add(this.lblCallsign);
            this.Controls.Add(this.txtAircraft);
            this.Controls.Add(this.lblAircraft);
            this.Controls.Add(this.txtLON);
            this.Controls.Add(this.txtLAT);
            this.Controls.Add(this.lblLON);
            this.Controls.Add(this.lblLAT);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnConnect);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblLAT;
        private System.Windows.Forms.Label lblLON;
        private System.Windows.Forms.TextBox txtLAT;
        private System.Windows.Forms.TextBox txtLON;
        private System.Windows.Forms.Timer LATandLON;
        private System.Windows.Forms.Label lblAircraft;
        private System.Windows.Forms.TextBox txtAircraft;
        private System.Windows.Forms.TextBox txtCallsign;
        private System.Windows.Forms.Label lblCallsign;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.TextBox txtChatText;
        private System.Windows.Forms.Button btnChatSend;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cboxServer;
        private System.Windows.Forms.Label lblServer;
    }
}
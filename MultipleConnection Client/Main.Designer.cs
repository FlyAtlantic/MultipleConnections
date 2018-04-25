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
            this.btnClose.Location = new System.Drawing.Point(12, 96);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
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
            this.lblAircraft.Location = new System.Drawing.Point(172, 54);
            this.lblAircraft.Name = "lblAircraft";
            this.lblAircraft.Size = new System.Drawing.Size(40, 13);
            this.lblAircraft.TabIndex = 8;
            this.lblAircraft.Text = "Aircraft";
            // 
            // txtAircraft
            // 
            this.txtAircraft.Location = new System.Drawing.Point(143, 70);
            this.txtAircraft.Name = "txtAircraft";
            this.txtAircraft.Size = new System.Drawing.Size(100, 20);
            this.txtAircraft.TabIndex = 1;
            this.txtAircraft.TextChanged += new System.EventHandler(this.txtAircraft_TextChanged);
            // 
            // txtCallsign
            // 
            this.txtCallsign.Location = new System.Drawing.Point(143, 31);
            this.txtCallsign.Name = "txtCallsign";
            this.txtCallsign.Size = new System.Drawing.Size(100, 20);
            this.txtCallsign.TabIndex = 0;
            this.txtCallsign.TextChanged += new System.EventHandler(this.txtCallsign_TextChanged);
            // 
            // lblCallsign
            // 
            this.lblCallsign.AutoSize = true;
            this.lblCallsign.Location = new System.Drawing.Point(172, 15);
            this.lblCallsign.Name = "lblCallsign";
            this.lblCallsign.Size = new System.Drawing.Size(43, 13);
            this.lblCallsign.TabIndex = 10;
            this.lblCallsign.Text = "Callsign";
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(143, 99);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(100, 105);
            this.txtChat.TabIndex = 12;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 216);
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
    }
}
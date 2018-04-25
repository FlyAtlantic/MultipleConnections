namespace MultipleConnections
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
            System.Windows.Forms.ColumnHeader Callsign;
            this.lstClients = new System.Windows.Forms.ListView();
            this.EndPoint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastMsg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aircraft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LAT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LON = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HDG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ALT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastReceivePoint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Callsign = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Callsign
            // 
            Callsign.Text = "Callsign";
            // 
            // lstClients
            // 
            this.lstClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EndPoint,
            this.ID,
            this.Type,
            this.LastMsg,
            Callsign,
            this.Aircraft,
            this.LAT,
            this.LON,
            this.HDG,
            this.ALT,
            this.GS,
            this.LastReceivePoint});
            this.lstClients.Location = new System.Drawing.Point(12, 12);
            this.lstClients.Name = "lstClients";
            this.lstClients.Size = new System.Drawing.Size(1099, 295);
            this.lstClients.TabIndex = 0;
            this.lstClients.UseCompatibleStateImageBehavior = false;
            this.lstClients.View = System.Windows.Forms.View.Details;
            // 
            // EndPoint
            // 
            this.EndPoint.Text = "EndPoint";
            this.EndPoint.Width = 145;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 113;
            // 
            // LastMsg
            // 
            this.LastMsg.Text = "LastMsg";
            this.LastMsg.Width = 219;
            // 
            // Aircraft
            // 
            this.Aircraft.Text = "Aircraft";
            // 
            // LAT
            // 
            this.LAT.Text = "Latitude";
            // 
            // LON
            // 
            this.LON.Text = "Longitude";
            // 
            // HDG
            // 
            this.HDG.Text = "HDG";
            // 
            // ALT
            // 
            this.ALT.Text = "ALT";
            // 
            // GS
            // 
            this.GS.Text = "G/S";
            // 
            // LastReceivePoint
            // 
            this.LastReceivePoint.Text = "LastReceivePoint";
            this.LastReceivePoint.Width = 191;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 319);
            this.Controls.Add(this.lstClients);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstClients;
        private System.Windows.Forms.ColumnHeader EndPoint;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader LastMsg;
        private System.Windows.Forms.ColumnHeader LastReceivePoint;
        private System.Windows.Forms.ColumnHeader LAT;
        private System.Windows.Forms.ColumnHeader LON;
        private System.Windows.Forms.ColumnHeader HDG;
        private System.Windows.Forms.ColumnHeader ALT;
        private System.Windows.Forms.ColumnHeader GS;
        private System.Windows.Forms.ColumnHeader Aircraft;
        private System.Windows.Forms.ColumnHeader Type;
    }
}
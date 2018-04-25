namespace MultipleConnection_Client
{
    partial class FlightPlanFrm
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
            this.btnSendFP = new System.Windows.Forms.Button();
            this.txtDEP = new System.Windows.Forms.TextBox();
            this.txtARR = new System.Windows.Forms.TextBox();
            this.txtALTER = new System.Windows.Forms.TextBox();
            this.lblARR = new System.Windows.Forms.Label();
            this.lblALTER = new System.Windows.Forms.Label();
            this.lblDEP = new System.Windows.Forms.Label();
            this.txtRoute = new System.Windows.Forms.TextBox();
            this.lblRoute = new System.Windows.Forms.Label();
            this.lblRMK = new System.Windows.Forms.Label();
            this.txtRMK = new System.Windows.Forms.TextBox();
            this.btnCloseFP = new System.Windows.Forms.Button();
            this.lblALT = new System.Windows.Forms.Label();
            this.txtALT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSendFP
            // 
            this.btnSendFP.Location = new System.Drawing.Point(243, 123);
            this.btnSendFP.Name = "btnSendFP";
            this.btnSendFP.Size = new System.Drawing.Size(75, 23);
            this.btnSendFP.TabIndex = 0;
            this.btnSendFP.Text = "Send";
            this.btnSendFP.UseVisualStyleBackColor = true;
            // 
            // txtDEP
            // 
            this.txtDEP.Location = new System.Drawing.Point(85, 16);
            this.txtDEP.MaxLength = 4;
            this.txtDEP.Name = "txtDEP";
            this.txtDEP.Size = new System.Drawing.Size(68, 20);
            this.txtDEP.TabIndex = 1;
            // 
            // txtARR
            // 
            this.txtARR.Location = new System.Drawing.Point(85, 42);
            this.txtARR.MaxLength = 4;
            this.txtARR.Name = "txtARR";
            this.txtARR.Size = new System.Drawing.Size(68, 20);
            this.txtARR.TabIndex = 2;
            // 
            // txtALTER
            // 
            this.txtALTER.Location = new System.Drawing.Point(85, 68);
            this.txtALTER.MaxLength = 4;
            this.txtALTER.Name = "txtALTER";
            this.txtALTER.Size = new System.Drawing.Size(68, 20);
            this.txtALTER.TabIndex = 3;
            // 
            // lblARR
            // 
            this.lblARR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblARR.Location = new System.Drawing.Point(-5, 45);
            this.lblARR.Name = "lblARR";
            this.lblARR.Size = new System.Drawing.Size(84, 13);
            this.lblARR.TabIndex = 5;
            this.lblARR.Text = "Destination :";
            this.lblARR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblALTER
            // 
            this.lblALTER.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblALTER.Location = new System.Drawing.Point(14, 71);
            this.lblALTER.Name = "lblALTER";
            this.lblALTER.Size = new System.Drawing.Size(65, 13);
            this.lblALTER.TabIndex = 6;
            this.lblALTER.Text = "Alternate :";
            this.lblALTER.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDEP
            // 
            this.lblDEP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDEP.Location = new System.Drawing.Point(12, 19);
            this.lblDEP.Name = "lblDEP";
            this.lblDEP.Size = new System.Drawing.Size(67, 13);
            this.lblDEP.TabIndex = 7;
            this.lblDEP.Text = "Departure :";
            this.lblDEP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRoute
            // 
            this.txtRoute.Location = new System.Drawing.Point(243, 16);
            this.txtRoute.MaxLength = 4;
            this.txtRoute.Multiline = true;
            this.txtRoute.Name = "txtRoute";
            this.txtRoute.Size = new System.Drawing.Size(328, 46);
            this.txtRoute.TabIndex = 8;
            // 
            // lblRoute
            // 
            this.lblRoute.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblRoute.Location = new System.Drawing.Point(170, 19);
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(67, 13);
            this.lblRoute.TabIndex = 9;
            this.lblRoute.Text = "Route :";
            this.lblRoute.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRMK
            // 
            this.lblRMK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblRMK.Location = new System.Drawing.Point(170, 74);
            this.lblRMK.Name = "lblRMK";
            this.lblRMK.Size = new System.Drawing.Size(67, 13);
            this.lblRMK.TabIndex = 11;
            this.lblRMK.Text = "Remarks :";
            this.lblRMK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRMK
            // 
            this.txtRMK.Location = new System.Drawing.Point(243, 71);
            this.txtRMK.MaxLength = 4;
            this.txtRMK.Multiline = true;
            this.txtRMK.Name = "txtRMK";
            this.txtRMK.Size = new System.Drawing.Size(328, 46);
            this.txtRMK.TabIndex = 10;
            // 
            // btnCloseFP
            // 
            this.btnCloseFP.Location = new System.Drawing.Point(324, 123);
            this.btnCloseFP.Name = "btnCloseFP";
            this.btnCloseFP.Size = new System.Drawing.Size(75, 23);
            this.btnCloseFP.TabIndex = 12;
            this.btnCloseFP.Text = "Close";
            this.btnCloseFP.UseVisualStyleBackColor = true;
            this.btnCloseFP.Click += new System.EventHandler(this.btnCloseFP_Click);
            // 
            // lblALT
            // 
            this.lblALT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblALT.Location = new System.Drawing.Point(14, 97);
            this.lblALT.Name = "lblALT";
            this.lblALT.Size = new System.Drawing.Size(65, 13);
            this.lblALT.TabIndex = 14;
            this.lblALT.Text = "Altitude :";
            this.lblALT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtALT
            // 
            this.txtALT.Location = new System.Drawing.Point(85, 94);
            this.txtALT.MaxLength = 4;
            this.txtALT.Name = "txtALT";
            this.txtALT.Size = new System.Drawing.Size(68, 20);
            this.txtALT.TabIndex = 13;
            // 
            // FlightPlanFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 160);
            this.Controls.Add(this.lblALT);
            this.Controls.Add(this.txtALT);
            this.Controls.Add(this.btnCloseFP);
            this.Controls.Add(this.lblRMK);
            this.Controls.Add(this.txtRMK);
            this.Controls.Add(this.lblRoute);
            this.Controls.Add(this.txtRoute);
            this.Controls.Add(this.lblDEP);
            this.Controls.Add(this.lblALTER);
            this.Controls.Add(this.lblARR);
            this.Controls.Add(this.txtALTER);
            this.Controls.Add(this.txtARR);
            this.Controls.Add(this.txtDEP);
            this.Controls.Add(this.btnSendFP);
            this.Name = "FlightPlanFrm";
            this.Text = "FlightPlanFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendFP;
        private System.Windows.Forms.TextBox txtDEP;
        private System.Windows.Forms.TextBox txtARR;
        private System.Windows.Forms.TextBox txtALTER;
        private System.Windows.Forms.Label lblARR;
        private System.Windows.Forms.Label lblALTER;
        private System.Windows.Forms.Label lblDEP;
        private System.Windows.Forms.TextBox txtRoute;
        private System.Windows.Forms.Label lblRoute;
        private System.Windows.Forms.Label lblRMK;
        private System.Windows.Forms.TextBox txtRMK;
        private System.Windows.Forms.Button btnCloseFP;
        private System.Windows.Forms.Label lblALT;
        private System.Windows.Forms.TextBox txtALT;
    }
}
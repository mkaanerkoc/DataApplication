﻿namespace DataApplication.Views
{
    partial class TCPDeviceConfig
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.portNameTb = new System.Windows.Forms.TextBox();
            this.ipAddrTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // portNameTb
            // 
            this.portNameTb.Location = new System.Drawing.Point(18, 101);
            this.portNameTb.Name = "portNameTb";
            this.portNameTb.Size = new System.Drawing.Size(155, 22);
            this.portNameTb.TabIndex = 7;
            // 
            // ipAddrTb
            // 
            this.ipAddrTb.Location = new System.Drawing.Point(18, 36);
            this.ipAddrTb.Name = "ipAddrTb";
            this.ipAddrTb.Size = new System.Drawing.Size(155, 22);
            this.ipAddrTb.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP Adresi";
            // 
            // TCPDeviceConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.portNameTb);
            this.Controls.Add(this.ipAddrTb);
            this.Controls.Add(this.label1);
            this.Name = "TCPDeviceConfig";
            this.Size = new System.Drawing.Size(203, 249);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox portNameTb;
        private System.Windows.Forms.TextBox ipAddrTb;
        private System.Windows.Forms.Label label1;
    }
}

namespace DataApplication.Views
{
    partial class UDPDeviceConfig
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
            this.label1 = new System.Windows.Forms.Label();
            this.ipAddrTb = new System.Windows.Forms.TextBox();
            this.portNameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Adresi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ipAddrTb
            // 
            this.ipAddrTb.Location = new System.Drawing.Point(12, 45);
            this.ipAddrTb.Name = "ipAddrTb";
            this.ipAddrTb.Size = new System.Drawing.Size(155, 22);
            this.ipAddrTb.TabIndex = 1;
            this.ipAddrTb.TextChanged += new System.EventHandler(this.ipAddrTb_TextChanged);
            // 
            // portNameTb
            // 
            this.portNameTb.Location = new System.Drawing.Point(12, 110);
            this.portNameTb.Name = "portNameTb";
            this.portNameTb.Size = new System.Drawing.Size(155, 22);
            this.portNameTb.TabIndex = 3;
            this.portNameTb.TextChanged += new System.EventHandler(this.portNameTb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // UDPDeviceConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.portNameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ipAddrTb);
            this.Controls.Add(this.label1);
            this.Name = "UDPDeviceConfig";
            this.Size = new System.Drawing.Size(211, 259);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ipAddrTb;
        private System.Windows.Forms.TextBox portNameTb;
        private System.Windows.Forms.Label label2;
    }
}

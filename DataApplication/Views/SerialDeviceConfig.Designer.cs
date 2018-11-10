namespace DataApplication.Views
{
    partial class SerialDeviceConfig
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
            this.portNameCb = new System.Windows.Forms.ComboBox();
            this.baudRateCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StopBitsCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.parityBitsCb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataBitsCb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port Adı ";
            // 
            // portNameCb
            // 
            this.portNameCb.FormattingEnabled = true;
            this.portNameCb.Location = new System.Drawing.Point(13, 28);
            this.portNameCb.Name = "portNameCb";
            this.portNameCb.Size = new System.Drawing.Size(149, 24);
            this.portNameCb.TabIndex = 1;
            // 
            // baudRateCb
            // 
            this.baudRateCb.FormattingEnabled = true;
            this.baudRateCb.Location = new System.Drawing.Point(13, 75);
            this.baudRateCb.Name = "baudRateCb";
            this.baudRateCb.Size = new System.Drawing.Size(149, 24);
            this.baudRateCb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stop Bits";
            // 
            // StopBitsCb
            // 
            this.StopBitsCb.FormattingEnabled = true;
            this.StopBitsCb.Location = new System.Drawing.Point(13, 126);
            this.StopBitsCb.Name = "StopBitsCb";
            this.StopBitsCb.Size = new System.Drawing.Size(149, 24);
            this.StopBitsCb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Parity Bits";
            // 
            // parityBitsCb
            // 
            this.parityBitsCb.FormattingEnabled = true;
            this.parityBitsCb.Location = new System.Drawing.Point(13, 178);
            this.parityBitsCb.Name = "parityBitsCb";
            this.parityBitsCb.Size = new System.Drawing.Size(149, 24);
            this.parityBitsCb.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data Bits";
            // 
            // dataBitsCb
            // 
            this.dataBitsCb.FormattingEnabled = true;
            this.dataBitsCb.Location = new System.Drawing.Point(13, 228);
            this.dataBitsCb.Name = "dataBitsCb";
            this.dataBitsCb.Size = new System.Drawing.Size(149, 24);
            this.dataBitsCb.TabIndex = 9;
            // 
            // SerialDeviceConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataBitsCb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.parityBitsCb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StopBitsCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.baudRateCb);
            this.Controls.Add(this.portNameCb);
            this.Controls.Add(this.label1);
            this.Name = "SerialDeviceConfig";
            this.Size = new System.Drawing.Size(204, 298);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox portNameCb;
        private System.Windows.Forms.ComboBox baudRateCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox StopBitsCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox parityBitsCb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dataBitsCb;
    }
}

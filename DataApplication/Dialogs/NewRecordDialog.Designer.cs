namespace DataApplication.Dialogs
{
    partial class NewRecordDialog
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
            this.allDevicesCb = new System.Windows.Forms.ComboBox();
            this.channelsCbList = new System.Windows.Forms.CheckedListBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deviceSettingsContainer = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fileTypeSelectionCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fileNameTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.operatorsCb = new System.Windows.Forms.ComboBox();
            this.facilitiesCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // allDevicesCb
            // 
            this.allDevicesCb.FormattingEnabled = true;
            this.allDevicesCb.Location = new System.Drawing.Point(22, 54);
            this.allDevicesCb.Name = "allDevicesCb";
            this.allDevicesCb.Size = new System.Drawing.Size(190, 24);
            this.allDevicesCb.TabIndex = 0;
            this.allDevicesCb.SelectedIndexChanged += new System.EventHandler(this.allDevicesCb_SelectedIndexChanged);
            // 
            // channelsCbList
            // 
            this.channelsCbList.FormattingEnabled = true;
            this.channelsCbList.Location = new System.Drawing.Point(20, 268);
            this.channelsCbList.Name = "channelsCbList";
            this.channelsCbList.Size = new System.Drawing.Size(273, 174);
            this.channelsCbList.TabIndex = 1;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(242, 493);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(209, 38);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Kayıt Başla";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mevcut Cihazlar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kaydedilecek Cihaz Kanalları";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deviceSettingsContainer);
            this.groupBox1.Controls.Add(this.allDevicesCb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 475);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cihaz Ayarları";
            // 
            // deviceSettingsContainer
            // 
            this.deviceSettingsContainer.Location = new System.Drawing.Point(6, 84);
            this.deviceSettingsContainer.Name = "deviceSettingsContainer";
            this.deviceSettingsContainer.Size = new System.Drawing.Size(249, 385);
            this.deviceSettingsContainer.TabIndex = 4;
            this.deviceSettingsContainer.TabStop = false;
            this.deviceSettingsContainer.Text = "Cihaz Ayarları";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.channelsCbList);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.operatorsCb);
            this.groupBox2.Controls.Add(this.facilitiesCb);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(279, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 475);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıt Bilgileri";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.fileTypeSelectionCb);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.fileNameTb);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(17, 116);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(418, 119);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dosya Bilgileri";
            // 
            // fileTypeSelectionCb
            // 
            this.fileTypeSelectionCb.FormattingEnabled = true;
            this.fileTypeSelectionCb.Items.AddRange(new object[] {
            "EXCEL ( .xlsx )",
            "CSV ( .csv )"});
            this.fileTypeSelectionCb.Location = new System.Drawing.Point(102, 28);
            this.fileTypeSelectionCb.Name = "fileTypeSelectionCb";
            this.fileTypeSelectionCb.Size = new System.Drawing.Size(167, 24);
            this.fileTypeSelectionCb.TabIndex = 9;
            this.fileTypeSelectionCb.SelectedIndexChanged += new System.EventHandler(this.fileTypeSelectionCb_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Dosya Türü";
            // 
            // fileNameTb
            // 
            this.fileNameTb.Location = new System.Drawing.Point(102, 64);
            this.fileNameTb.Name = "fileNameTb";
            this.fileNameTb.Size = new System.Drawing.Size(290, 22);
            this.fileNameTb.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Dosya Adı";
            // 
            // operatorsCb
            // 
            this.operatorsCb.FormattingEnabled = true;
            this.operatorsCb.Location = new System.Drawing.Point(210, 54);
            this.operatorsCb.Name = "operatorsCb";
            this.operatorsCb.Size = new System.Drawing.Size(155, 24);
            this.operatorsCb.TabIndex = 3;
            // 
            // facilitiesCb
            // 
            this.facilitiesCb.FormattingEnabled = true;
            this.facilitiesCb.Location = new System.Drawing.Point(17, 54);
            this.facilitiesCb.Name = "facilitiesCb";
            this.facilitiesCb.Size = new System.Drawing.Size(155, 24);
            this.facilitiesCb.TabIndex = 2;
            this.facilitiesCb.SelectedIndexChanged += new System.EventHandler(this.facilitiesCb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Operatör";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tesis";
            // 
            // NewRecordDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 543);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveBtn);
            this.Name = "NewRecordDialog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox allDevicesCb;
        private System.Windows.Forms.CheckedListBox channelsCbList;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox operatorsCb;
        private System.Windows.Forms.ComboBox facilitiesCb;
        private System.Windows.Forms.TextBox fileNameTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox fileTypeSelectionCb;
        private System.Windows.Forms.GroupBox deviceSettingsContainer;
    }
}

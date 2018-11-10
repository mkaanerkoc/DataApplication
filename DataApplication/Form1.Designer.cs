using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DataApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mainContainer = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lastSaveLbl = new System.Windows.Forms.Label();
            this.fileNameLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lastReadLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.readPeriodTb = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKayıtCtrlNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eskiKayıttanDevamEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetCtrlNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farklıKaydetCtrlShiftSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cihazAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cihazAyarlarıToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.programAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görünümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.activeChannelsCbList = new System.Windows.Forms.CheckedListBox();
            this.activeDeviceNameLbl = new System.Windows.Forms.Label();
            this.mainContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(787, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Serial- PG250";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(926, 546);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "UDP- PG300";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mainContainer
            // 
            this.mainContainer.Controls.Add(this.panel1);
            this.mainContainer.Location = new System.Drawing.Point(12, 128);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(769, 473);
            this.mainContainer.TabIndex = 3;
            this.mainContainer.TabStop = false;
            this.mainContainer.Text = "Graph";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(7, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 445);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lastSaveLbl);
            this.groupBox1.Controls.Add(this.fileNameLbl);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lastReadLbl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.readPeriodTb);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 91);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Session";
            // 
            // lastSaveLbl
            // 
            this.lastSaveLbl.AutoSize = true;
            this.lastSaveLbl.Location = new System.Drawing.Point(458, 42);
            this.lastSaveLbl.Name = "lastSaveLbl";
            this.lastSaveLbl.Size = new System.Drawing.Size(23, 17);
            this.lastSaveLbl.TabIndex = 8;
            this.lastSaveLbl.Text = "---";
            // 
            // fileNameLbl
            // 
            this.fileNameLbl.AutoSize = true;
            this.fileNameLbl.Location = new System.Drawing.Point(428, 18);
            this.fileNameLbl.Name = "fileNameLbl";
            this.fileNameLbl.Size = new System.Drawing.Size(23, 17);
            this.fileNameLbl.TabIndex = 7;
            this.fileNameLbl.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Son Kaydetme :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dosya Adı :";
            // 
            // lastReadLbl
            // 
            this.lastReadLbl.AutoSize = true;
            this.lastReadLbl.Location = new System.Drawing.Point(439, 65);
            this.lastReadLbl.Name = "lastReadLbl";
            this.lastReadLbl.Size = new System.Drawing.Size(23, 17);
            this.lastReadLbl.TabIndex = 4;
            this.lastReadLbl.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Son Okuma :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Okuma Periyodu";
            // 
            // readPeriodTb
            // 
            this.readPeriodTb.Location = new System.Drawing.Point(11, 48);
            this.readPeriodTb.Name = "readPeriodTb";
            this.readPeriodTb.Size = new System.Drawing.Size(127, 22);
            this.readPeriodTb.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(162, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 45);
            this.button3.TabIndex = 0;
            this.button3.Text = "Başlat";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtToolStripMenuItem,
            this.cihazAyarlarıToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1075, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kayıtToolStripMenuItem
            // 
            this.kayıtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKayıtCtrlNToolStripMenuItem,
            this.eskiKayıttanDevamEtToolStripMenuItem,
            this.kaydetCtrlNToolStripMenuItem,
            this.farklıKaydetCtrlShiftSToolStripMenuItem});
            this.kayıtToolStripMenuItem.Name = "kayıtToolStripMenuItem";
            this.kayıtToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.kayıtToolStripMenuItem.Text = "Kayıt";
            // 
            // yeniKayıtCtrlNToolStripMenuItem
            // 
            this.yeniKayıtCtrlNToolStripMenuItem.Name = "yeniKayıtCtrlNToolStripMenuItem";
            this.yeniKayıtCtrlNToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.yeniKayıtCtrlNToolStripMenuItem.Text = "Yeni Kayıt  Ctrl + N";
            this.yeniKayıtCtrlNToolStripMenuItem.Click += new System.EventHandler(this.yeniKayıtCtrlNToolStripMenuItem_Click);
            // 
            // eskiKayıttanDevamEtToolStripMenuItem
            // 
            this.eskiKayıttanDevamEtToolStripMenuItem.Name = "eskiKayıttanDevamEtToolStripMenuItem";
            this.eskiKayıttanDevamEtToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.eskiKayıttanDevamEtToolStripMenuItem.Text = "Eski Kayıttan Devam Et";
            this.eskiKayıttanDevamEtToolStripMenuItem.Click += new System.EventHandler(this.eskiKayıttanDevamEtToolStripMenuItem_Click);
            // 
            // kaydetCtrlNToolStripMenuItem
            // 
            this.kaydetCtrlNToolStripMenuItem.Name = "kaydetCtrlNToolStripMenuItem";
            this.kaydetCtrlNToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.kaydetCtrlNToolStripMenuItem.Text = "Kaydet Ctrl + S";
            // 
            // farklıKaydetCtrlShiftSToolStripMenuItem
            // 
            this.farklıKaydetCtrlShiftSToolStripMenuItem.Name = "farklıKaydetCtrlShiftSToolStripMenuItem";
            this.farklıKaydetCtrlShiftSToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.farklıKaydetCtrlShiftSToolStripMenuItem.Text = "Farklı Kaydet Ctrl+Shift+S";
            // 
            // cihazAyarlarıToolStripMenuItem
            // 
            this.cihazAyarlarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cihazAyarlarıToolStripMenuItem1,
            this.programAyarlarıToolStripMenuItem,
            this.kayıtAyarlarıToolStripMenuItem});
            this.cihazAyarlarıToolStripMenuItem.Name = "cihazAyarlarıToolStripMenuItem";
            this.cihazAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.cihazAyarlarıToolStripMenuItem.Text = "Ayarlar";
            // 
            // cihazAyarlarıToolStripMenuItem1
            // 
            this.cihazAyarlarıToolStripMenuItem1.Name = "cihazAyarlarıToolStripMenuItem1";
            this.cihazAyarlarıToolStripMenuItem1.Size = new System.Drawing.Size(196, 26);
            this.cihazAyarlarıToolStripMenuItem1.Text = "Cihaz Ayarları";
            // 
            // programAyarlarıToolStripMenuItem
            // 
            this.programAyarlarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.görünümToolStripMenuItem});
            this.programAyarlarıToolStripMenuItem.Name = "programAyarlarıToolStripMenuItem";
            this.programAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.programAyarlarıToolStripMenuItem.Text = "Program Ayarları";
            // 
            // görünümToolStripMenuItem
            // 
            this.görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            this.görünümToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.görünümToolStripMenuItem.Text = "Görünüm";
            // 
            // kayıtAyarlarıToolStripMenuItem
            // 
            this.kayıtAyarlarıToolStripMenuItem.Name = "kayıtAyarlarıToolStripMenuItem";
            this.kayıtAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.kayıtAyarlarıToolStripMenuItem.Text = "Kayıt Ayarları";
            this.kayıtAyarlarıToolStripMenuItem.Click += new System.EventHandler(this.kayıtAyarlarıToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.activeDeviceNameLbl);
            this.groupBox2.Location = new System.Drawing.Point(787, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 91);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cihaz";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.activeChannelsCbList);
            this.groupBox3.Location = new System.Drawing.Point(787, 129);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(276, 411);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Veri Kanalları";
            // 
            // activeChannelsCbList
            // 
            this.activeChannelsCbList.FormattingEnabled = true;
            this.activeChannelsCbList.Location = new System.Drawing.Point(6, 21);
            this.activeChannelsCbList.Name = "activeChannelsCbList";
            this.activeChannelsCbList.Size = new System.Drawing.Size(264, 361);
            this.activeChannelsCbList.TabIndex = 0;
            // 
            // activeDeviceNameLbl
            // 
            this.activeDeviceNameLbl.AutoSize = true;
            this.activeDeviceNameLbl.Location = new System.Drawing.Point(24, 25);
            this.activeDeviceNameLbl.Name = "activeDeviceNameLbl";
            this.activeDeviceNameLbl.Size = new System.Drawing.Size(18, 17);
            this.activeDeviceNameLbl.TabIndex = 0;
            this.activeDeviceNameLbl.Text = "--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1075, 613);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainContainer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private GroupBox mainContainer;
        private GroupBox groupBox1;
        private Button button3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem kayıtToolStripMenuItem;
        private ToolStripMenuItem yeniKayıtCtrlNToolStripMenuItem;
        private ToolStripMenuItem kaydetCtrlNToolStripMenuItem;
        private ToolStripMenuItem farklıKaydetCtrlShiftSToolStripMenuItem;
        private ToolStripMenuItem cihazAyarlarıToolStripMenuItem;
        private ToolStripMenuItem cihazAyarlarıToolStripMenuItem1;
        private ToolStripMenuItem programAyarlarıToolStripMenuItem;
        private ToolStripMenuItem hakkındaToolStripMenuItem;
        private Label label2;
        private TextBox readPeriodTb;
        private Label lastReadLbl;
        private Label label3;
        private ToolStripMenuItem görünümToolStripMenuItem;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private CheckedListBox activeChannelsCbList;
        private ToolStripMenuItem eskiKayıttanDevamEtToolStripMenuItem;
        private ToolStripMenuItem kayıtAyarlarıToolStripMenuItem;
        private Label label5;
        private Label label4;
        private Label fileNameLbl;
        private Label lastSaveLbl;
        private Panel panel1;
        private Label activeDeviceNameLbl;
    }
}


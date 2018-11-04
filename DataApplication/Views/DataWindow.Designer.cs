namespace DataApplication.Views
{
    partial class DataWindow
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
            this.box = new System.Windows.Forms.GroupBox();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.unitTb = new System.Windows.Forms.Label();
            this.valueTb = new System.Windows.Forms.Label();
            this.box.SuspendLayout();
            this.SuspendLayout();
            // 
            // box
            // 
            this.box.Controls.Add(this.settingsBtn);
            this.box.Controls.Add(this.unitTb);
            this.box.Controls.Add(this.valueTb);
            this.box.Location = new System.Drawing.Point(3, 3);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(162, 186);
            this.box.TabIndex = 0;
            this.box.TabStop = false;
            this.box.Text = "--";
            // 
            // settingsBtn
            // 
            this.settingsBtn.Location = new System.Drawing.Point(128, 12);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(28, 23);
            this.settingsBtn.TabIndex = 7;
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // unitTb
            // 
            this.unitTb.AutoSize = true;
            this.unitTb.Location = new System.Drawing.Point(51, 158);
            this.unitTb.Name = "unitTb";
            this.unitTb.Size = new System.Drawing.Size(18, 17);
            this.unitTb.TabIndex = 6;
            this.unitTb.Text = "--";
            // 
            // valueTb
            // 
            this.valueTb.AutoSize = true;
            this.valueTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueTb.Location = new System.Drawing.Point(23, 74);
            this.valueTb.Name = "valueTb";
            this.valueTb.Size = new System.Drawing.Size(32, 31);
            this.valueTb.TabIndex = 5;
            this.valueTb.Text = "--";
            // 
            // DataWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.box);
            this.Name = "DataWindow";
            this.Size = new System.Drawing.Size(168, 192);
            this.box.ResumeLayout(false);
            this.box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox box;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Label unitTb;
        private System.Windows.Forms.Label valueTb;
    }
}

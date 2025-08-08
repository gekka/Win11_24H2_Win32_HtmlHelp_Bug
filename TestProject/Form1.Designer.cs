namespace Win11_24H2_Win32_HtmlHelp_Bug
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFont = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSavePNG = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnHelpShowPopup = new System.Windows.Forms.Button();
            this.btnNoFont = new System.Windows.Forms.Button();
            this.btnNoCharSet = new System.Windows.Forms.Button();
            this.lblSystemLCID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnHelpShowPopup);
            this.panel1.Controls.Add(this.btnNoFont);
            this.panel1.Controls.Add(this.btnNoCharSet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 443);
            this.panel1.TabIndex = 0;
            // 
            // lblFont
            // 
            this.lblFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(6, 249);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(74, 19);
            this.lblFont.TabIndex = 7;
            this.lblFont.Text = "szFont=";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblSystemLCID);
            this.groupBox1.Controls.Add(this.lblFont);
            this.groupBox1.Controls.Add(this.chkSavePNG);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(14, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 274);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CharSet";
            // 
            // chkSavePNG
            // 
            this.chkSavePNG.AutoSize = true;
            this.chkSavePNG.Location = new System.Drawing.Point(122, 0);
            this.chkSavePNG.Name = "chkSavePNG";
            this.chkSavePNG.Size = new System.Drawing.Size(104, 23);
            this.chkSavePNG.TabIndex = 6;
            this.chkSavePNG.Text = "SavePNG";
            this.chkSavePNG.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(10, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(328, 185);
            this.listBox1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(14, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(344, 35);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "ABC あいう";
            // 
            // btnHelpShowPopup
            // 
            this.btnHelpShowPopup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelpShowPopup.Location = new System.Drawing.Point(12, 52);
            this.btnHelpShowPopup.Name = "btnHelpShowPopup";
            this.btnHelpShowPopup.Size = new System.Drawing.Size(346, 32);
            this.btnHelpShowPopup.TabIndex = 1;
            this.btnHelpShowPopup.Text = "Forms.Help.ShowPopup";
            this.btnHelpShowPopup.UseVisualStyleBackColor = true;
            this.btnHelpShowPopup.Click += new System.EventHandler(this.btnHelpShowPopup_Click);
            // 
            // btnNoFont
            // 
            this.btnNoFont.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNoFont.Location = new System.Drawing.Point(12, 90);
            this.btnNoFont.Name = "btnNoFont";
            this.btnNoFont.Size = new System.Drawing.Size(346, 32);
            this.btnNoFont.TabIndex = 2;
            this.btnNoFont.Text = "Win32 HtmlHelpW : no Font";
            this.btnNoFont.UseVisualStyleBackColor = true;
            this.btnNoFont.Click += new System.EventHandler(this.btnNoFont_Click);
            // 
            // btnNoCharSet
            // 
            this.btnNoCharSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNoCharSet.Location = new System.Drawing.Point(12, 128);
            this.btnNoCharSet.Name = "btnNoCharSet";
            this.btnNoCharSet.Size = new System.Drawing.Size(346, 32);
            this.btnNoCharSet.TabIndex = 3;
            this.btnNoCharSet.Text = "Win32 HtmlHelpW : no charset";
            this.btnNoCharSet.UseVisualStyleBackColor = true;
            this.btnNoCharSet.Click += new System.EventHandler(this.btnNoCharSet_Click);
            // 
            // lblSystemLCID
            // 
            this.lblSystemLCID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSystemLCID.AutoSize = true;
            this.lblSystemLCID.Location = new System.Drawing.Point(6, 221);
            this.lblSystemLCID.Name = "lblSystemLCID";
            this.lblSystemLCID.Size = new System.Drawing.Size(119, 19);
            this.lblSystemLCID.TabIndex = 7;
            this.lblSystemLCID.Text = "SystemLCID=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(371, 443);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "HtmlHelpW Bug Test";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHelpShowPopup;
        private System.Windows.Forms.Button btnNoFont;
        private System.Windows.Forms.Button btnNoCharSet;


        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSavePNG;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.Label lblSystemLCID;
    }
}



namespace LibraryMgrProgram
{
    partial class AdminMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            this.lbAMHome = new System.Windows.Forms.Label();
            this.AdGridView = new System.Windows.Forms.DataGridView();
            this.lbAMInOut = new System.Windows.Forms.Label();
            this.lbAMCusInfo = new System.Windows.Forms.Label();
            this.lbAMBookInfo = new System.Windows.Forms.Label();
            this.lbAMOperation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbAMLoginOut = new System.Windows.Forms.Label();
            this.lbAMCustomer = new System.Windows.Forms.Label();
            this.palAMMain = new System.Windows.Forms.Panel();
            this.plnAM = new System.Windows.Forms.TableLayoutPanel();
            this.btnLFClose = new System.Windows.Forms.Button();
            this.btnLFMax = new System.Windows.Forms.Button();
            this.btnLFMin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picAMOperation = new System.Windows.Forms.PictureBox();
            this.picAMBookInfo = new System.Windows.Forms.PictureBox();
            this.picAMCusInfo = new System.Windows.Forms.PictureBox();
            this.picAMInOut = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AdGridView)).BeginInit();
            this.plnAM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAMOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAMBookInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAMCusInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAMInOut)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAMHome
            // 
            this.lbAMHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAMHome.AutoSize = true;
            this.lbAMHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbAMHome.Font = new System.Drawing.Font("Gulim", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbAMHome.Location = new System.Drawing.Point(12, 135);
            this.lbAMHome.Name = "lbAMHome";
            this.lbAMHome.Size = new System.Drawing.Size(209, 34);
            this.lbAMHome.TabIndex = 78;
            this.lbAMHome.Text = "CAPA 도서관";
            this.lbAMHome.Click += new System.EventHandler(this.lbAMHome_Click);
            // 
            // AdGridView
            // 
            this.AdGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AdGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.AdGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdGridView.Location = new System.Drawing.Point(-3, 211);
            this.AdGridView.Name = "AdGridView";
            this.AdGridView.RowTemplate.Height = 23;
            this.AdGridView.Size = new System.Drawing.Size(1403, 18);
            this.AdGridView.TabIndex = 74;
            // 
            // lbAMInOut
            // 
            this.lbAMInOut.AutoSize = true;
            this.lbAMInOut.BackColor = System.Drawing.Color.Yellow;
            this.lbAMInOut.Font = new System.Drawing.Font("Gulim", 20F);
            this.lbAMInOut.Location = new System.Drawing.Point(327, 135);
            this.lbAMInOut.Name = "lbAMInOut";
            this.lbAMInOut.Size = new System.Drawing.Size(131, 27);
            this.lbAMInOut.TabIndex = 107;
            this.lbAMInOut.Text = "대출/반납";
            this.lbAMInOut.Click += new System.EventHandler(this.lbAMInOut_Click);
            // 
            // lbAMCusInfo
            // 
            this.lbAMCusInfo.AutoSize = true;
            this.lbAMCusInfo.BackColor = System.Drawing.Color.Yellow;
            this.lbAMCusInfo.Font = new System.Drawing.Font("Gulim", 20F);
            this.lbAMCusInfo.Location = new System.Drawing.Point(527, 135);
            this.lbAMCusInfo.Name = "lbAMCusInfo";
            this.lbAMCusInfo.Size = new System.Drawing.Size(120, 27);
            this.lbAMCusInfo.TabIndex = 109;
            this.lbAMCusInfo.Text = "회원정보";
            this.lbAMCusInfo.Click += new System.EventHandler(this.lbAMCusInfo_Click);
            // 
            // lbAMBookInfo
            // 
            this.lbAMBookInfo.AutoSize = true;
            this.lbAMBookInfo.BackColor = System.Drawing.Color.Yellow;
            this.lbAMBookInfo.Font = new System.Drawing.Font("Gulim", 20F);
            this.lbAMBookInfo.Location = new System.Drawing.Point(727, 135);
            this.lbAMBookInfo.Name = "lbAMBookInfo";
            this.lbAMBookInfo.Size = new System.Drawing.Size(93, 27);
            this.lbAMBookInfo.TabIndex = 111;
            this.lbAMBookInfo.Text = "책정보";
            this.lbAMBookInfo.Click += new System.EventHandler(this.lbAMBookInfo_Click);
            // 
            // lbAMOperation
            // 
            this.lbAMOperation.AutoSize = true;
            this.lbAMOperation.BackColor = System.Drawing.Color.Yellow;
            this.lbAMOperation.Font = new System.Drawing.Font("Gulim", 20F);
            this.lbAMOperation.Location = new System.Drawing.Point(927, 135);
            this.lbAMOperation.Name = "lbAMOperation";
            this.lbAMOperation.Size = new System.Drawing.Size(120, 27);
            this.lbAMOperation.TabIndex = 113;
            this.lbAMOperation.Text = "환경설정";
            this.lbAMOperation.Click += new System.EventHandler(this.lbAMOperation_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 115;
            // 
            // lbAMLoginOut
            // 
            this.lbAMLoginOut.AutoSize = true;
            this.lbAMLoginOut.Font = new System.Drawing.Font("Gulim", 12F);
            this.lbAMLoginOut.ForeColor = System.Drawing.Color.Black;
            this.lbAMLoginOut.Location = new System.Drawing.Point(1316, 85);
            this.lbAMLoginOut.Name = "lbAMLoginOut";
            this.lbAMLoginOut.Size = new System.Drawing.Size(72, 16);
            this.lbAMLoginOut.TabIndex = 119;
            this.lbAMLoginOut.Text = "로그아웃";
            this.lbAMLoginOut.Click += new System.EventHandler(this.lbAMLoginOut_Click);
            // 
            // lbAMCustomer
            // 
            this.lbAMCustomer.AutoSize = true;
            this.lbAMCustomer.Font = new System.Drawing.Font("Gulim", 14F);
            this.lbAMCustomer.Location = new System.Drawing.Point(1223, 56);
            this.lbAMCustomer.Name = "lbAMCustomer";
            this.lbAMCustomer.Size = new System.Drawing.Size(165, 19);
            this.lbAMCustomer.TabIndex = 120;
            this.lbAMCustomer.Text = "000님 환영합니다.";
            // 
            // palAMMain
            // 
            this.palAMMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.palAMMain.BackColor = System.Drawing.Color.White;
            this.palAMMain.Location = new System.Drawing.Point(12, 235);
            this.palAMMain.Name = "palAMMain";
            this.palAMMain.Size = new System.Drawing.Size(1376, 553);
            this.palAMMain.TabIndex = 130;
            // 
            // plnAM
            // 
            this.plnAM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plnAM.AutoSize = true;
            this.plnAM.BackColor = System.Drawing.Color.Silver;
            this.plnAM.ColumnCount = 4;
            this.plnAM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.plnAM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.plnAM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.plnAM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.plnAM.Controls.Add(this.btnLFClose, 3, 1);
            this.plnAM.Controls.Add(this.btnLFMax, 2, 1);
            this.plnAM.Controls.Add(this.btnLFMin, 1, 1);
            this.plnAM.Controls.Add(this.label1, 0, 1);
            this.plnAM.ImeMode = System.Windows.Forms.ImeMode.On;
            this.plnAM.Location = new System.Drawing.Point(-3, -3);
            this.plnAM.Name = "plnAM";
            this.plnAM.RowCount = 2;
            this.plnAM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.plnAM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.plnAM.Size = new System.Drawing.Size(1403, 35);
            this.plnAM.TabIndex = 130;
            this.plnAM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plnAM_MouseDown);
            this.plnAM.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plnAM_MouseMove);
            this.plnAM.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plnAM_MouseUp);
            // 
            // btnLFClose
            // 
            this.btnLFClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLFClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLFClose.FlatAppearance.BorderSize = 0;
            this.btnLFClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLFClose.Font = new System.Drawing.Font("Gulim", 10F);
            this.btnLFClose.Location = new System.Drawing.Point(1380, 6);
            this.btnLFClose.Name = "btnLFClose";
            this.btnLFClose.Size = new System.Drawing.Size(20, 20);
            this.btnLFClose.TabIndex = 1;
            this.btnLFClose.Text = "🗙";
            this.btnLFClose.UseVisualStyleBackColor = false;
            this.btnLFClose.Click += new System.EventHandler(this.btnAMClose_Click);
            // 
            // btnLFMax
            // 
            this.btnLFMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLFMax.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLFMax.FlatAppearance.BorderSize = 0;
            this.btnLFMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLFMax.Font = new System.Drawing.Font("Gulim", 10F);
            this.btnLFMax.Location = new System.Drawing.Point(1354, 6);
            this.btnLFMax.Name = "btnLFMax";
            this.btnLFMax.Size = new System.Drawing.Size(19, 20);
            this.btnLFMax.TabIndex = 3;
            this.btnLFMax.Text = "🗖";
            this.btnLFMax.UseVisualStyleBackColor = false;
            this.btnLFMax.Click += new System.EventHandler(this.btnAMMax_Click);
            // 
            // btnLFMin
            // 
            this.btnLFMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLFMin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLFMin.FlatAppearance.BorderSize = 0;
            this.btnLFMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLFMin.Font = new System.Drawing.Font("Gulim", 10F);
            this.btnLFMin.Location = new System.Drawing.Point(1326, 6);
            this.btnLFMin.Name = "btnLFMin";
            this.btnLFMin.Size = new System.Drawing.Size(20, 20);
            this.btnLFMin.TabIndex = 2;
            this.btnLFMin.Text = "🗕";
            this.btnLFMin.UseVisualStyleBackColor = false;
            this.btnLFMin.Click += new System.EventHandler(this.btnAMMin_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Font = new System.Drawing.Font("Gulim", 15F);
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "메인폼";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 131;
            this.pictureBox1.TabStop = false;
            // 
            // picAMOperation
            // 
            this.picAMOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAMOperation.Image = ((System.Drawing.Image)(resources.GetObject("picAMOperation.Image")));
            this.picAMOperation.Location = new System.Drawing.Point(886, 85);
            this.picAMOperation.Name = "picAMOperation";
            this.picAMOperation.Size = new System.Drawing.Size(100, 77);
            this.picAMOperation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAMOperation.TabIndex = 114;
            this.picAMOperation.TabStop = false;
            // 
            // picAMBookInfo
            // 
            this.picAMBookInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAMBookInfo.Image = ((System.Drawing.Image)(resources.GetObject("picAMBookInfo.Image")));
            this.picAMBookInfo.Location = new System.Drawing.Point(686, 85);
            this.picAMBookInfo.Name = "picAMBookInfo";
            this.picAMBookInfo.Size = new System.Drawing.Size(100, 77);
            this.picAMBookInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAMBookInfo.TabIndex = 112;
            this.picAMBookInfo.TabStop = false;
            // 
            // picAMCusInfo
            // 
            this.picAMCusInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAMCusInfo.Image = ((System.Drawing.Image)(resources.GetObject("picAMCusInfo.Image")));
            this.picAMCusInfo.Location = new System.Drawing.Point(486, 85);
            this.picAMCusInfo.Name = "picAMCusInfo";
            this.picAMCusInfo.Size = new System.Drawing.Size(100, 77);
            this.picAMCusInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAMCusInfo.TabIndex = 110;
            this.picAMCusInfo.TabStop = false;
            // 
            // picAMInOut
            // 
            this.picAMInOut.BackColor = System.Drawing.Color.White;
            this.picAMInOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAMInOut.Image = ((System.Drawing.Image)(resources.GetObject("picAMInOut.Image")));
            this.picAMInOut.Location = new System.Drawing.Point(286, 85);
            this.picAMInOut.Name = "picAMInOut";
            this.picAMInOut.Size = new System.Drawing.Size(100, 77);
            this.picAMInOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAMInOut.TabIndex = 108;
            this.picAMInOut.TabStop = false;
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.lbAMHome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.plnAM);
            this.Controls.Add(this.palAMMain);
            this.Controls.Add(this.lbAMCustomer);
            this.Controls.Add(this.lbAMLoginOut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbAMOperation);
            this.Controls.Add(this.picAMOperation);
            this.Controls.Add(this.lbAMBookInfo);
            this.Controls.Add(this.picAMBookInfo);
            this.Controls.Add(this.lbAMCusInfo);
            this.Controls.Add(this.picAMCusInfo);
            this.Controls.Add(this.lbAMInOut);
            this.Controls.Add(this.picAMInOut);
            this.Controls.Add(this.AdGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "사용자 메인화면";
            this.Load += new System.EventHandler(this.AdminMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdGridView)).EndInit();
            this.plnAM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAMOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAMBookInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAMCusInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAMInOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbAMHome;
        private System.Windows.Forms.DataGridView AdGridView;
        private System.Windows.Forms.Label lbAMInOut;
        private System.Windows.Forms.PictureBox picAMInOut;
        private System.Windows.Forms.Label lbAMCusInfo;
        private System.Windows.Forms.PictureBox picAMCusInfo;
        private System.Windows.Forms.Label lbAMBookInfo;
        private System.Windows.Forms.PictureBox picAMBookInfo;
        private System.Windows.Forms.Label lbAMOperation;
        private System.Windows.Forms.PictureBox picAMOperation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbAMLoginOut;
        private System.Windows.Forms.Label lbAMCustomer;
        private System.Windows.Forms.Panel palAMMain;
        private System.Windows.Forms.TableLayoutPanel plnAM;
        private System.Windows.Forms.Button btnLFMax;
        private System.Windows.Forms.Button btnLFMin;
        private System.Windows.Forms.Button btnLFClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

namespace LibraryMgrProgram
{
    partial class CustomerMainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMainForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.palCMMain = new System.Windows.Forms.Panel();
            this.lbCMCustomer = new System.Windows.Forms.Label();
            this.lbCMLoginOut = new System.Windows.Forms.Label();
            this.lbCMOperation = new System.Windows.Forms.Label();
            this.lbCMBookInfo = new System.Windows.Forms.Label();
            this.lbCMCusInfo = new System.Windows.Forms.Label();
            this.lbCMHome = new System.Windows.Forms.Label();
            this.picCMLogo = new System.Windows.Forms.PictureBox();
            this.picCMCustomer = new System.Windows.Forms.PictureBox();
            this.picCMOperation = new System.Windows.Forms.PictureBox();
            this.picCMCusInfo = new System.Windows.Forms.PictureBox();
            this.picCMBookInfo = new System.Windows.Forms.PictureBox();
            this.plnCM = new System.Windows.Forms.TableLayoutPanel();
            this.btnCMClose = new System.Windows.Forms.Button();
            this.btnCMMax = new System.Windows.Forms.Button();
            this.btnCMMin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.plnAM0 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picCMLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCMCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCMOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCMCusInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCMBookInfo)).BeginInit();
            this.plnCM.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // palCMMain
            // 
            this.palCMMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.palCMMain.Location = new System.Drawing.Point(12, 235);
            this.palCMMain.Name = "palCMMain";
            this.palCMMain.Size = new System.Drawing.Size(1376, 553);
            this.palCMMain.TabIndex = 131;
            // 
            // lbCMCustomer
            // 
            this.lbCMCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCMCustomer.AutoSize = true;
            this.lbCMCustomer.Font = new System.Drawing.Font("Gulim", 14F);
            this.lbCMCustomer.Location = new System.Drawing.Point(1208, 56);
            this.lbCMCustomer.Name = "lbCMCustomer";
            this.lbCMCustomer.Size = new System.Drawing.Size(165, 19);
            this.lbCMCustomer.TabIndex = 142;
            this.lbCMCustomer.Text = "000님 환영합니다.";
            // 
            // lbCMLoginOut
            // 
            this.lbCMLoginOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCMLoginOut.AutoSize = true;
            this.lbCMLoginOut.Font = new System.Drawing.Font("Gulim", 12F);
            this.lbCMLoginOut.ForeColor = System.Drawing.Color.Black;
            this.lbCMLoginOut.Location = new System.Drawing.Point(1301, 85);
            this.lbCMLoginOut.Name = "lbCMLoginOut";
            this.lbCMLoginOut.Size = new System.Drawing.Size(72, 16);
            this.lbCMLoginOut.TabIndex = 141;
            this.lbCMLoginOut.Text = "로그아웃";
            this.lbCMLoginOut.Click += new System.EventHandler(this.lbCMLogOut_Click_1);
            // 
            // lbCMOperation
            // 
            this.lbCMOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCMOperation.AutoSize = true;
            this.lbCMOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbCMOperation.Font = new System.Drawing.Font("Gulim", 20F);
            this.lbCMOperation.Location = new System.Drawing.Point(727, 135);
            this.lbCMOperation.Name = "lbCMOperation";
            this.lbCMOperation.Size = new System.Drawing.Size(120, 27);
            this.lbCMOperation.TabIndex = 139;
            this.lbCMOperation.Text = "환경설정";
            this.lbCMOperation.Click += new System.EventHandler(this.lbCMOperation_Click);
            // 
            // lbCMBookInfo
            // 
            this.lbCMBookInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCMBookInfo.AutoSize = true;
            this.lbCMBookInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbCMBookInfo.Font = new System.Drawing.Font("Gulim", 20F);
            this.lbCMBookInfo.Location = new System.Drawing.Point(328, 135);
            this.lbCMBookInfo.Name = "lbCMBookInfo";
            this.lbCMBookInfo.Size = new System.Drawing.Size(93, 27);
            this.lbCMBookInfo.TabIndex = 137;
            this.lbCMBookInfo.Text = "책정보";
            this.lbCMBookInfo.Click += new System.EventHandler(this.lbCMBookInfo_Click);
            // 
            // lbCMCusInfo
            // 
            this.lbCMCusInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCMCusInfo.AutoSize = true;
            this.lbCMCusInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbCMCusInfo.Font = new System.Drawing.Font("Gulim", 20F);
            this.lbCMCusInfo.Location = new System.Drawing.Point(527, 135);
            this.lbCMCusInfo.Name = "lbCMCusInfo";
            this.lbCMCusInfo.Size = new System.Drawing.Size(120, 27);
            this.lbCMCusInfo.TabIndex = 135;
            this.lbCMCusInfo.Text = "회원정보";
            this.lbCMCusInfo.Click += new System.EventHandler(this.lbCMInfo_Click);
            // 
            // lbCMHome
            // 
            this.lbCMHome.AutoSize = true;
            this.lbCMHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCMHome.Font = new System.Drawing.Font("Gulim", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCMHome.Location = new System.Drawing.Point(12, 135);
            this.lbCMHome.Name = "lbCMHome";
            this.lbCMHome.Size = new System.Drawing.Size(209, 34);
            this.lbCMHome.TabIndex = 145;
            this.lbCMHome.Text = "CAPA 도서관";
            this.lbCMHome.Click += new System.EventHandler(this.lbCMHome_Click);
            // 
            // picCMLogo
            // 
            this.picCMLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCMLogo.BackColor = System.Drawing.Color.White;
            this.picCMLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCMLogo.Image = ((System.Drawing.Image)(resources.GetObject("picCMLogo.Image")));
            this.picCMLogo.Location = new System.Drawing.Point(39, 56);
            this.picCMLogo.Name = "picCMLogo";
            this.picCMLogo.Size = new System.Drawing.Size(127, 106);
            this.picCMLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCMLogo.TabIndex = 146;
            this.picCMLogo.TabStop = false;
            // 
            // picCMCustomer
            // 
            this.picCMCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCMCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCMCustomer.Image = ((System.Drawing.Image)(resources.GetObject("picCMCustomer.Image")));
            this.picCMCustomer.Location = new System.Drawing.Point(1159, 42);
            this.picCMCustomer.Name = "picCMCustomer";
            this.picCMCustomer.Size = new System.Drawing.Size(44, 33);
            this.picCMCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCMCustomer.TabIndex = 144;
            this.picCMCustomer.TabStop = false;
            // 
            // picCMOperation
            // 
            this.picCMOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCMOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCMOperation.Image = ((System.Drawing.Image)(resources.GetObject("picCMOperation.Image")));
            this.picCMOperation.Location = new System.Drawing.Point(686, 85);
            this.picCMOperation.Name = "picCMOperation";
            this.picCMOperation.Size = new System.Drawing.Size(100, 77);
            this.picCMOperation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCMOperation.TabIndex = 140;
            this.picCMOperation.TabStop = false;
            // 
            // picCMCusInfo
            // 
            this.picCMCusInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCMCusInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCMCusInfo.Image = ((System.Drawing.Image)(resources.GetObject("picCMCusInfo.Image")));
            this.picCMCusInfo.Location = new System.Drawing.Point(486, 85);
            this.picCMCusInfo.Name = "picCMCusInfo";
            this.picCMCusInfo.Size = new System.Drawing.Size(100, 77);
            this.picCMCusInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCMCusInfo.TabIndex = 136;
            this.picCMCusInfo.TabStop = false;
            // 
            // picCMBookInfo
            // 
            this.picCMBookInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCMBookInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCMBookInfo.Image = ((System.Drawing.Image)(resources.GetObject("picCMBookInfo.Image")));
            this.picCMBookInfo.Location = new System.Drawing.Point(286, 85);
            this.picCMBookInfo.Name = "picCMBookInfo";
            this.picCMBookInfo.Size = new System.Drawing.Size(100, 77);
            this.picCMBookInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCMBookInfo.TabIndex = 138;
            this.picCMBookInfo.TabStop = false;
            // 
            // plnCM
            // 
            this.plnCM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plnCM.AutoSize = true;
            this.plnCM.BackColor = System.Drawing.Color.Silver;
            this.plnCM.ColumnCount = 4;
            this.plnCM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.plnCM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.plnCM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.plnCM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.plnCM.Controls.Add(this.btnCMClose, 3, 1);
            this.plnCM.Controls.Add(this.btnCMMax, 2, 1);
            this.plnCM.Controls.Add(this.btnCMMin, 1, 1);
            this.plnCM.ImeMode = System.Windows.Forms.ImeMode.On;
            this.plnCM.Location = new System.Drawing.Point(-3, -3);
            this.plnCM.Name = "plnCM";
            this.plnCM.RowCount = 2;
            this.plnCM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.plnCM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.plnCM.Size = new System.Drawing.Size(1403, 35);
            this.plnCM.TabIndex = 147;
            this.plnCM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plnCM_MouseDown);
            this.plnCM.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plnCM_MouseMove);
            this.plnCM.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plnCM_MouseUp);
            // 
            // btnCMClose
            // 
            this.btnCMClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCMClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCMClose.FlatAppearance.BorderSize = 0;
            this.btnCMClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCMClose.Font = new System.Drawing.Font("Gulim", 10F);
            this.btnCMClose.Location = new System.Drawing.Point(1380, 6);
            this.btnCMClose.Name = "btnCMClose";
            this.btnCMClose.Size = new System.Drawing.Size(20, 20);
            this.btnCMClose.TabIndex = 1;
            this.btnCMClose.Text = "🗙";
            this.btnCMClose.UseVisualStyleBackColor = false;
            this.btnCMClose.Click += new System.EventHandler(this.btnCMClose_Click);
            // 
            // btnCMMax
            // 
            this.btnCMMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCMMax.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCMMax.FlatAppearance.BorderSize = 0;
            this.btnCMMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCMMax.Font = new System.Drawing.Font("Gulim", 10F);
            this.btnCMMax.Location = new System.Drawing.Point(1354, 6);
            this.btnCMMax.Name = "btnCMMax";
            this.btnCMMax.Size = new System.Drawing.Size(19, 20);
            this.btnCMMax.TabIndex = 3;
            this.btnCMMax.Text = "🗖";
            this.btnCMMax.UseVisualStyleBackColor = false;
            this.btnCMMax.Click += new System.EventHandler(this.btnCMMax_Click);
            // 
            // btnCMMin
            // 
            this.btnCMMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCMMin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCMMin.FlatAppearance.BorderSize = 0;
            this.btnCMMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCMMin.Font = new System.Drawing.Font("Gulim", 10F);
            this.btnCMMin.Location = new System.Drawing.Point(1326, 6);
            this.btnCMMin.Name = "btnCMMin";
            this.btnCMMin.Size = new System.Drawing.Size(20, 20);
            this.btnCMMin.TabIndex = 2;
            this.btnCMMin.Text = "🗕";
            this.btnCMMin.UseVisualStyleBackColor = false;
            this.btnCMMin.Click += new System.EventHandler(this.btnCMMin_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Gulim", 15F);
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 148;
            this.label1.Text = "메인폼";
            // 
            // plnAM0
            // 
            this.plnAM0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plnAM0.AutoSize = true;
            this.plnAM0.BackColor = System.Drawing.Color.Silver;
            this.plnAM0.ColumnCount = 1;
            this.plnAM0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.plnAM0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.plnAM0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.plnAM0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.plnAM0.ImeMode = System.Windows.Forms.ImeMode.On;
            this.plnAM0.Location = new System.Drawing.Point(-3, 209);
            this.plnAM0.Name = "plnAM0";
            this.plnAM0.RowCount = 2;
            this.plnAM0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.plnAM0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.plnAM0.Size = new System.Drawing.Size(1403, 20);
            this.plnAM0.TabIndex = 149;
            // 
            // CustomerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.plnAM0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plnCM);
            this.Controls.Add(this.lbCMHome);
            this.Controls.Add(this.picCMLogo);
            this.Controls.Add(this.picCMCustomer);
            this.Controls.Add(this.lbCMCustomer);
            this.Controls.Add(this.lbCMLoginOut);
            this.Controls.Add(this.lbCMOperation);
            this.Controls.Add(this.picCMOperation);
            this.Controls.Add(this.lbCMBookInfo);
            this.Controls.Add(this.picCMBookInfo);
            this.Controls.Add(this.lbCMCusInfo);
            this.Controls.Add(this.picCMCusInfo);
            this.Controls.Add(this.palCMMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerMainForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerMainForm_FormClosing);
            this.Load += new System.EventHandler(this.CustomerMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCMLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCMCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCMOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCMCusInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCMBookInfo)).EndInit();
            this.plnCM.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbCMCustomer;
        private System.Windows.Forms.Label lbCMLoginOut;
        private System.Windows.Forms.Label lbCMOperation;
        private System.Windows.Forms.PictureBox picCMOperation;
        private System.Windows.Forms.Label lbCMBookInfo;
        private System.Windows.Forms.Label lbCMCusInfo;
        private System.Windows.Forms.PictureBox picCMCusInfo;
        private System.Windows.Forms.PictureBox picCMCustomer;
        private System.Windows.Forms.Label lbCMHome;
        private System.Windows.Forms.PictureBox picCMLogo;
        private System.Windows.Forms.PictureBox picCMBookInfo;
        private System.Windows.Forms.TableLayoutPanel plnCM;
        private System.Windows.Forms.Button btnCMClose;
        private System.Windows.Forms.Button btnCMMax;
        private System.Windows.Forms.Button btnCMMin;
        public System.Windows.Forms.Panel palCMMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel plnAM0;
    }
}
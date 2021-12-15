
namespace LibraryMgrProgram
{
    partial class NonCustomerMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NonCustomerMainForm));
            this.lbNCMLogin = new System.Windows.Forms.Label();
            this.lbNCMOperation = new System.Windows.Forms.Label();
            this.lbNCMBookInfo = new System.Windows.Forms.Label();
            this.palNCMMain = new System.Windows.Forms.Panel();
            this.picNCMOperation = new System.Windows.Forms.PictureBox();
            this.picNCMBookInfo = new System.Windows.Forms.PictureBox();
            this.lbNCMHome = new System.Windows.Forms.Label();
            this.picNCMLogo = new System.Windows.Forms.PictureBox();
            this.plnAM = new System.Windows.Forms.TableLayoutPanel();
            this.btnLFClose = new System.Windows.Forms.Button();
            this.btnLFMax = new System.Windows.Forms.Button();
            this.btnLFMin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.plnAM0 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picNCMOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNCMBookInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNCMLogo)).BeginInit();
            this.plnAM.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNCMLogin
            // 
            this.lbNCMLogin.AutoSize = true;
            this.lbNCMLogin.Font = new System.Drawing.Font("Gulim", 12F);
            this.lbNCMLogin.ForeColor = System.Drawing.Color.Black;
            this.lbNCMLogin.Location = new System.Drawing.Point(1315, 56);
            this.lbNCMLogin.Name = "lbNCMLogin";
            this.lbNCMLogin.Size = new System.Drawing.Size(56, 16);
            this.lbNCMLogin.TabIndex = 150;
            this.lbNCMLogin.Text = "로그인";
            this.lbNCMLogin.Click += new System.EventHandler(this.lbNCMLogin_Click);
            // 
            // lbNCMOperation
            // 
            this.lbNCMOperation.AutoSize = true;
            this.lbNCMOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbNCMOperation.Font = new System.Drawing.Font("Gulim", 20F);
            this.lbNCMOperation.Location = new System.Drawing.Point(528, 135);
            this.lbNCMOperation.Name = "lbNCMOperation";
            this.lbNCMOperation.Size = new System.Drawing.Size(120, 27);
            this.lbNCMOperation.TabIndex = 148;
            this.lbNCMOperation.Text = "환경설정";
            this.lbNCMOperation.Click += new System.EventHandler(this.lbNCMOperation_Click_1);
            // 
            // lbNCMBookInfo
            // 
            this.lbNCMBookInfo.AutoSize = true;
            this.lbNCMBookInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbNCMBookInfo.Font = new System.Drawing.Font("Gulim", 20F);
            this.lbNCMBookInfo.Location = new System.Drawing.Point(328, 135);
            this.lbNCMBookInfo.Name = "lbNCMBookInfo";
            this.lbNCMBookInfo.Size = new System.Drawing.Size(93, 27);
            this.lbNCMBookInfo.TabIndex = 146;
            this.lbNCMBookInfo.Text = "책정보";
            this.lbNCMBookInfo.Click += new System.EventHandler(this.lbNCMBookInfo_Click_1);
            // 
            // palNCMMain
            // 
            this.palNCMMain.Location = new System.Drawing.Point(12, 235);
            this.palNCMMain.Name = "palNCMMain";
            this.palNCMMain.Size = new System.Drawing.Size(1376, 553);
            this.palNCMMain.TabIndex = 152;
            // 
            // picNCMOperation
            // 
            this.picNCMOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picNCMOperation.Image = ((System.Drawing.Image)(resources.GetObject("picNCMOperation.Image")));
            this.picNCMOperation.Location = new System.Drawing.Point(486, 85);
            this.picNCMOperation.Name = "picNCMOperation";
            this.picNCMOperation.Size = new System.Drawing.Size(100, 77);
            this.picNCMOperation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNCMOperation.TabIndex = 149;
            this.picNCMOperation.TabStop = false;
            // 
            // picNCMBookInfo
            // 
            this.picNCMBookInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picNCMBookInfo.Image = ((System.Drawing.Image)(resources.GetObject("picNCMBookInfo.Image")));
            this.picNCMBookInfo.Location = new System.Drawing.Point(286, 85);
            this.picNCMBookInfo.Name = "picNCMBookInfo";
            this.picNCMBookInfo.Size = new System.Drawing.Size(100, 77);
            this.picNCMBookInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNCMBookInfo.TabIndex = 147;
            this.picNCMBookInfo.TabStop = false;
            // 
            // lbNCMHome
            // 
            this.lbNCMHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNCMHome.AutoSize = true;
            this.lbNCMHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNCMHome.Font = new System.Drawing.Font("Gulim", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbNCMHome.Location = new System.Drawing.Point(12, 135);
            this.lbNCMHome.Name = "lbNCMHome";
            this.lbNCMHome.Size = new System.Drawing.Size(209, 34);
            this.lbNCMHome.TabIndex = 153;
            this.lbNCMHome.Text = "CAPA 도서관";
            this.lbNCMHome.Click += new System.EventHandler(this.lbNCMLogo_Click);
            // 
            // picNCMLogo
            // 
            this.picNCMLogo.BackColor = System.Drawing.Color.White;
            this.picNCMLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picNCMLogo.Image = ((System.Drawing.Image)(resources.GetObject("picNCMLogo.Image")));
            this.picNCMLogo.Location = new System.Drawing.Point(39, 56);
            this.picNCMLogo.Name = "picNCMLogo";
            this.picNCMLogo.Size = new System.Drawing.Size(127, 106);
            this.picNCMLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNCMLogo.TabIndex = 154;
            this.picNCMLogo.TabStop = false;
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
            this.plnAM.Controls.Add(this.label2, 0, 1);
            this.plnAM.ImeMode = System.Windows.Forms.ImeMode.On;
            this.plnAM.Location = new System.Drawing.Point(-2, -2);
            this.plnAM.Name = "plnAM";
            this.plnAM.RowCount = 2;
            this.plnAM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.plnAM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.plnAM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.plnAM.Size = new System.Drawing.Size(1403, 35);
            this.plnAM.TabIndex = 168;
            this.plnAM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plnNCM_MouseDown);
            this.plnAM.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plnNCM_MouseMove);
            this.plnAM.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plnNCM_MouseUp);
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
            this.btnLFClose.Click += new System.EventHandler(this.btnNCMClose_Click);
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
            this.btnLFMax.Click += new System.EventHandler(this.btnNCMMax_Click);
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
            this.btnLFMin.Click += new System.EventHandler(this.btnNCMMin_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.Font = new System.Drawing.Font("Gulim", 15F);
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "메인폼";
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
            // NonCustomerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.plnAM0);
            this.Controls.Add(this.plnAM);
            this.Controls.Add(this.lbNCMHome);
            this.Controls.Add(this.picNCMLogo);
            this.Controls.Add(this.lbNCMLogin);
            this.Controls.Add(this.lbNCMOperation);
            this.Controls.Add(this.picNCMOperation);
            this.Controls.Add(this.lbNCMBookInfo);
            this.Controls.Add(this.picNCMBookInfo);
            this.Controls.Add(this.palNCMMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NonCustomerMainForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NonCustomerMainForm_FormClosing);
            this.Load += new System.EventHandler(this.NonCustomerMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNCMOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNCMBookInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNCMLogo)).EndInit();
            this.plnAM.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbNCMLogin;
        private System.Windows.Forms.Label lbNCMOperation;
        private System.Windows.Forms.PictureBox picNCMOperation;
        private System.Windows.Forms.Label lbNCMBookInfo;
        private System.Windows.Forms.PictureBox picNCMBookInfo;
        private System.Windows.Forms.Panel palNCMMain;
        private System.Windows.Forms.Label lbNCMHome;
        private System.Windows.Forms.PictureBox picNCMLogo;
        private System.Windows.Forms.TableLayoutPanel plnAM;
        private System.Windows.Forms.Button btnLFClose;
        private System.Windows.Forms.Button btnLFMax;
        private System.Windows.Forms.Button btnLFMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel plnAM0;
    }
}
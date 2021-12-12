
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
            this.plnNCM = new System.Windows.Forms.TableLayoutPanel();
            this.btnNCMMax = new System.Windows.Forms.Button();
            this.btnNCMMin = new System.Windows.Forms.Button();
            this.btnNCMClose = new System.Windows.Forms.Button();
            this.lbNCMLogin = new System.Windows.Forms.Label();
            this.lbNCMOperation = new System.Windows.Forms.Label();
            this.lbNCMBookInfo = new System.Windows.Forms.Label();
            this.dgvNCM = new System.Windows.Forms.DataGridView();
            this.palNCMMain = new System.Windows.Forms.Panel();
            this.picNCMOperation = new System.Windows.Forms.PictureBox();
            this.picNCMBookInfo = new System.Windows.Forms.PictureBox();
            this.lbNCMHome = new System.Windows.Forms.Label();
            this.picNCMLogo = new System.Windows.Forms.PictureBox();
            this.plnNCM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNCMOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNCMBookInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNCMLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // plnNCM
            // 
            this.plnNCM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plnNCM.AutoSize = true;
            this.plnNCM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plnNCM.ColumnCount = 3;
            this.plnNCM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.plnNCM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.plnNCM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.plnNCM.Controls.Add(this.btnNCMMax, 1, 1);
            this.plnNCM.Controls.Add(this.btnNCMMin, 0, 1);
            this.plnNCM.Controls.Add(this.btnNCMClose, 2, 1);
            this.plnNCM.Location = new System.Drawing.Point(0, -3);
            this.plnNCM.Name = "plnNCM";
            this.plnNCM.RowCount = 2;
            this.plnNCM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.plnNCM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.plnNCM.Size = new System.Drawing.Size(1399, 39);
            this.plnNCM.TabIndex = 0;
            this.plnNCM.Paint += new System.Windows.Forms.PaintEventHandler(this.plnNCM_Paint);
            this.plnNCM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plnNCM_MouseDown);
            this.plnNCM.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plnNCM_MouseMove);
            this.plnNCM.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plnNCM_MouseUp);
            // 
            // btnNCMMax
            // 
            this.btnNCMMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNCMMax.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNCMMax.FlatAppearance.BorderSize = 0;
            this.btnNCMMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNCMMax.Font = new System.Drawing.Font("Gulim", 15F);
            this.btnNCMMax.Location = new System.Drawing.Point(1336, 6);
            this.btnNCMMax.Name = "btnNCMMax";
            this.btnNCMMax.Size = new System.Drawing.Size(20, 20);
            this.btnNCMMax.TabIndex = 3;
            this.btnNCMMax.Text = "🗖";
            this.btnNCMMax.UseVisualStyleBackColor = false;
            this.btnNCMMax.Click += new System.EventHandler(this.btnNCMMax_Click);
            // 
            // btnNCMMin
            // 
            this.btnNCMMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNCMMin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNCMMin.FlatAppearance.BorderSize = 0;
            this.btnNCMMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNCMMin.Font = new System.Drawing.Font("Gulim", 15F);
            this.btnNCMMin.Location = new System.Drawing.Point(1296, 6);
            this.btnNCMMin.Name = "btnNCMMin";
            this.btnNCMMin.Size = new System.Drawing.Size(20, 20);
            this.btnNCMMin.TabIndex = 2;
            this.btnNCMMin.Text = "🗕";
            this.btnNCMMin.UseVisualStyleBackColor = false;
            this.btnNCMMin.Click += new System.EventHandler(this.btnNCMMin_Click);
            // 
            // btnNCMClose
            // 
            this.btnNCMClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNCMClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNCMClose.FlatAppearance.BorderSize = 0;
            this.btnNCMClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNCMClose.Font = new System.Drawing.Font("Gulim", 15F);
            this.btnNCMClose.Location = new System.Drawing.Point(1376, 6);
            this.btnNCMClose.Name = "btnNCMClose";
            this.btnNCMClose.Size = new System.Drawing.Size(20, 20);
            this.btnNCMClose.TabIndex = 1;
            this.btnNCMClose.Text = "🗙";
            this.btnNCMClose.UseVisualStyleBackColor = false;
            this.btnNCMClose.Click += new System.EventHandler(this.btnNCMClose_Click);
            // 
            // lbNCMLogin
            // 
            this.lbNCMLogin.AutoSize = true;
            this.lbNCMLogin.Font = new System.Drawing.Font("Gulim", 12F);
            this.lbNCMLogin.ForeColor = System.Drawing.Color.Black;
            this.lbNCMLogin.Location = new System.Drawing.Point(1316, 85);
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
            // 
            // dgvNCM
            // 
            this.dgvNCM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNCM.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvNCM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNCM.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvNCM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCM.Location = new System.Drawing.Point(-3, 211);
            this.dgvNCM.Name = "dgvNCM";
            this.dgvNCM.RowTemplate.Height = 23;
            this.dgvNCM.Size = new System.Drawing.Size(1403, 18);
            this.dgvNCM.TabIndex = 151;
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
            // NonCustomerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.lbNCMHome);
            this.Controls.Add(this.picNCMLogo);
            this.Controls.Add(this.dgvNCM);
            this.Controls.Add(this.lbNCMLogin);
            this.Controls.Add(this.lbNCMOperation);
            this.Controls.Add(this.picNCMOperation);
            this.Controls.Add(this.lbNCMBookInfo);
            this.Controls.Add(this.picNCMBookInfo);
            this.Controls.Add(this.plnNCM);
            this.Controls.Add(this.palNCMMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NonCustomerMainForm";
            this.RightToLeftLayout = true;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NonCustomerMainForm_FormClosing);
            this.Load += new System.EventHandler(this.NonCustomerMainForm_Load);
            this.plnNCM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNCMOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNCMBookInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNCMLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel plnNCM;
        private System.Windows.Forms.Button btnNCMMax;
        private System.Windows.Forms.Button btnNCMMin;
        private System.Windows.Forms.Button btnNCMClose;
        private System.Windows.Forms.Label lbNCMLogin;
        private System.Windows.Forms.Label lbNCMOperation;
        private System.Windows.Forms.PictureBox picNCMOperation;
        private System.Windows.Forms.Label lbNCMBookInfo;
        private System.Windows.Forms.PictureBox picNCMBookInfo;
        private System.Windows.Forms.DataGridView dgvNCM;
        private System.Windows.Forms.Panel palNCMMain;
        private System.Windows.Forms.Label lbNCMHome;
        private System.Windows.Forms.PictureBox picNCMLogo;
    }
}
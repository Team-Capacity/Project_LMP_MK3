
namespace LMP_Projcet
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labLogID = new System.Windows.Forms.Label();
            this.labLogPW = new System.Windows.Forms.Label();
            this.txtLFID = new System.Windows.Forms.TextBox();
            this.txtLFPW = new System.Windows.Forms.TextBox();
            this.labLFSearch = new System.Windows.Forms.Label();
            this.labLFAddMem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLFLogin = new System.Windows.Forms.Button();
            this.grpLogLogin = new System.Windows.Forms.GroupBox();
            this.btnLFNonLogin = new System.Windows.Forms.Button();
            this.picLogLogo = new System.Windows.Forms.PictureBox();
            this.plnAM = new System.Windows.Forms.TableLayoutPanel();
            this.btnLFMax = new System.Windows.Forms.Button();
            this.btnLFMin = new System.Windows.Forms.Button();
            this.btnLFClose = new System.Windows.Forms.Button();
            this.grpLogLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogLogo)).BeginInit();
            this.plnAM.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 30F);
            this.label1.Location = new System.Drawing.Point(197, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // labLogID
            // 
            this.labLogID.AutoSize = true;
            this.labLogID.Font = new System.Drawing.Font("Gulim", 10F);
            this.labLogID.Location = new System.Drawing.Point(104, 190);
            this.labLogID.Name = "labLogID";
            this.labLogID.Size = new System.Drawing.Size(64, 14);
            this.labLogID.TabIndex = 1;
            this.labLogID.Text = "아이디 : ";
            // 
            // labLogPW
            // 
            this.labLogPW.AutoSize = true;
            this.labLogPW.Font = new System.Drawing.Font("Gulim", 10F);
            this.labLogPW.Location = new System.Drawing.Point(90, 257);
            this.labLogPW.Name = "labLogPW";
            this.labLogPW.Size = new System.Drawing.Size(78, 14);
            this.labLogPW.TabIndex = 2;
            this.labLogPW.Text = "비밀번호 : ";
            // 
            // txtLFID
            // 
            this.txtLFID.Location = new System.Drawing.Point(181, 188);
            this.txtLFID.Name = "txtLFID";
            this.txtLFID.Size = new System.Drawing.Size(201, 21);
            this.txtLFID.TabIndex = 3;
            this.txtLFID.TextChanged += new System.EventHandler(this.txtLFID_TextChanged);
            // 
            // txtLFPW
            // 
            this.txtLFPW.Location = new System.Drawing.Point(181, 255);
            this.txtLFPW.Name = "txtLFPW";
            this.txtLFPW.PasswordChar = '*';
            this.txtLFPW.Size = new System.Drawing.Size(201, 21);
            this.txtLFPW.TabIndex = 4;
            // 
            // labLFSearch
            // 
            this.labLFSearch.AutoSize = true;
            this.labLFSearch.Font = new System.Drawing.Font("Gulim", 10F);
            this.labLFSearch.Location = new System.Drawing.Point(81, 313);
            this.labLFSearch.Name = "labLFSearch";
            this.labLFSearch.Size = new System.Drawing.Size(144, 14);
            this.labLFSearch.TabIndex = 5;
            this.labLFSearch.Text = "아이디/비밀번호 찾기";
            this.labLFSearch.Click += new System.EventHandler(this.labLFSearch_Click);
            // 
            // labLFAddMem
            // 
            this.labLFAddMem.AutoSize = true;
            this.labLFAddMem.Font = new System.Drawing.Font("Gulim", 10F);
            this.labLFAddMem.Location = new System.Drawing.Point(266, 313);
            this.labLFAddMem.Name = "labLFAddMem";
            this.labLFAddMem.Size = new System.Drawing.Size(63, 14);
            this.labLFAddMem.TabIndex = 6;
            this.labLFAddMem.Text = "회원가입";
            this.labLFAddMem.Click += new System.EventHandler(this.labLFAddMem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "------------------------------------------------------------------";
            // 
            // btnLFLogin
            // 
            this.btnLFLogin.Font = new System.Drawing.Font("Gulim", 20F);
            this.btnLFLogin.Location = new System.Drawing.Point(61, 408);
            this.btnLFLogin.Name = "btnLFLogin";
            this.btnLFLogin.Size = new System.Drawing.Size(150, 50);
            this.btnLFLogin.TabIndex = 8;
            this.btnLFLogin.Text = "로그인";
            this.btnLFLogin.UseVisualStyleBackColor = true;
            this.btnLFLogin.Click += new System.EventHandler(this.btnLFLogin_Click);
            // 
            // grpLogLogin
            // 
            this.grpLogLogin.BackColor = System.Drawing.Color.PaleTurquoise;
            this.grpLogLogin.Controls.Add(this.btnLFNonLogin);
            this.grpLogLogin.Controls.Add(this.picLogLogo);
            this.grpLogLogin.Controls.Add(this.label1);
            this.grpLogLogin.Controls.Add(this.labLogID);
            this.grpLogLogin.Controls.Add(this.btnLFLogin);
            this.grpLogLogin.Controls.Add(this.labLogPW);
            this.grpLogLogin.Controls.Add(this.label2);
            this.grpLogLogin.Controls.Add(this.txtLFID);
            this.grpLogLogin.Controls.Add(this.labLFAddMem);
            this.grpLogLogin.Controls.Add(this.txtLFPW);
            this.grpLogLogin.Controls.Add(this.labLFSearch);
            this.grpLogLogin.Location = new System.Drawing.Point(81, 52);
            this.grpLogLogin.Name = "grpLogLogin";
            this.grpLogLogin.Size = new System.Drawing.Size(453, 468);
            this.grpLogLogin.TabIndex = 11;
            this.grpLogLogin.TabStop = false;
            this.grpLogLogin.Enter += new System.EventHandler(this.grpLogLogin_Enter);
            // 
            // btnLFNonLogin
            // 
            this.btnLFNonLogin.Font = new System.Drawing.Font("Gulim", 20F);
            this.btnLFNonLogin.Location = new System.Drawing.Point(242, 408);
            this.btnLFNonLogin.Name = "btnLFNonLogin";
            this.btnLFNonLogin.Size = new System.Drawing.Size(150, 50);
            this.btnLFNonLogin.TabIndex = 11;
            this.btnLFNonLogin.Text = "비회원";
            this.btnLFNonLogin.UseVisualStyleBackColor = true;
            this.btnLFNonLogin.Click += new System.EventHandler(this.btnLFNonLogin_Click);
            // 
            // picLogLogo
            // 
            this.picLogLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLogLogo.Image = global::LMP_Projcet.Properties.Resources.ddoing1;
            this.picLogLogo.Location = new System.Drawing.Point(52, 20);
            this.picLogLogo.Name = "picLogLogo";
            this.picLogLogo.Size = new System.Drawing.Size(116, 145);
            this.picLogLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogLogo.TabIndex = 10;
            this.picLogLogo.TabStop = false;
            // 
            // plnAM
            // 
            this.plnAM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plnAM.AutoSize = true;
            this.plnAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.plnAM.ColumnCount = 3;
            this.plnAM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.plnAM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.plnAM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.plnAM.Controls.Add(this.btnLFMax, 1, 1);
            this.plnAM.Controls.Add(this.btnLFMin, 0, 1);
            this.plnAM.Controls.Add(this.btnLFClose, 2, 1);
            this.plnAM.Location = new System.Drawing.Point(1, 0);
            this.plnAM.Name = "plnAM";
            this.plnAM.RowCount = 2;
            this.plnAM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.plnAM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.plnAM.Size = new System.Drawing.Size(600, 30);
            this.plnAM.TabIndex = 74;
            this.plnAM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plnAM_MouseDown);
            this.plnAM.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plnAM_MouseMove);
            this.plnAM.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plnAM_MouseUp);
            // 
            // btnLFMax
            // 
            this.btnLFMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLFMax.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLFMax.FlatAppearance.BorderSize = 0;
            this.btnLFMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLFMax.Font = new System.Drawing.Font("Gulim", 15F);
            this.btnLFMax.Location = new System.Drawing.Point(538, 6);
            this.btnLFMax.Name = "btnLFMax";
            this.btnLFMax.Size = new System.Drawing.Size(20, 20);
            this.btnLFMax.TabIndex = 3;
            this.btnLFMax.Text = "🗖";
            this.btnLFMax.UseVisualStyleBackColor = false;
            this.btnLFMax.Click += new System.EventHandler(this.btnLFMax_Click);
            // 
            // btnLFMin
            // 
            this.btnLFMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLFMin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLFMin.FlatAppearance.BorderSize = 0;
            this.btnLFMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLFMin.Font = new System.Drawing.Font("Gulim", 15F);
            this.btnLFMin.Location = new System.Drawing.Point(495, 6);
            this.btnLFMin.Name = "btnLFMin";
            this.btnLFMin.Size = new System.Drawing.Size(20, 20);
            this.btnLFMin.TabIndex = 2;
            this.btnLFMin.Text = "🗕";
            this.btnLFMin.UseVisualStyleBackColor = false;
            this.btnLFMin.Click += new System.EventHandler(this.btnLFMin_Click);
            // 
            // btnLFClose
            // 
            this.btnLFClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLFClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLFClose.FlatAppearance.BorderSize = 0;
            this.btnLFClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLFClose.Font = new System.Drawing.Font("Gulim", 15F);
            this.btnLFClose.Location = new System.Drawing.Point(577, 6);
            this.btnLFClose.Name = "btnLFClose";
            this.btnLFClose.Size = new System.Drawing.Size(20, 20);
            this.btnLFClose.TabIndex = 1;
            this.btnLFClose.Text = "🗙";
            this.btnLFClose.UseVisualStyleBackColor = false;
            this.btnLFClose.Click += new System.EventHandler(this.btnLFClose_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 550);
            this.Controls.Add(this.plnAM);
            this.Controls.Add(this.grpLogLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "로그인폼";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.grpLogLogin.ResumeLayout(false);
            this.grpLogLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogLogo)).EndInit();
            this.plnAM.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labLogID;
        private System.Windows.Forms.Label labLogPW;
        private System.Windows.Forms.TextBox txtLFID;
        private System.Windows.Forms.TextBox txtLFPW;
        private System.Windows.Forms.Label labLFSearch;
        private System.Windows.Forms.Label labLFAddMem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLFLogin;
        private System.Windows.Forms.PictureBox picLogLogo;
        private System.Windows.Forms.GroupBox grpLogLogin;
        private System.Windows.Forms.Button btnLFNonLogin;
        private System.Windows.Forms.TableLayoutPanel plnAM;
        private System.Windows.Forms.Button btnLFMax;
        private System.Windows.Forms.Button btnLFMin;
        private System.Windows.Forms.Button btnLFClose;
    }
}


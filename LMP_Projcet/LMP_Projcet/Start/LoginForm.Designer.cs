
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.grpLogLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogLogo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.labLogPW.Location = new System.Drawing.Point(90, 242);
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
            this.txtLFPW.Location = new System.Drawing.Point(181, 240);
            this.txtLFPW.Name = "txtLFPW";
            this.txtLFPW.PasswordChar = '*';
            this.txtLFPW.Size = new System.Drawing.Size(201, 21);
            this.txtLFPW.TabIndex = 4;
            // 
            // labLFSearch
            // 
            this.labLFSearch.AutoSize = true;
            this.labLFSearch.Font = new System.Drawing.Font("Gulim", 10F);
            this.labLFSearch.Location = new System.Drawing.Point(81, 299);
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
            this.labLFAddMem.Location = new System.Drawing.Point(266, 299);
            this.labLFAddMem.Name = "labLFAddMem";
            this.labLFAddMem.Size = new System.Drawing.Size(63, 14);
            this.labLFAddMem.TabIndex = 6;
            this.labLFAddMem.Text = "회원가입";
            this.labLFAddMem.Click += new System.EventHandler(this.labLFAddMem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "------------------------------------------------------------------";
            // 
            // btnLFLogin
            // 
            this.btnLFLogin.Font = new System.Drawing.Font("Gulim", 20F);
            this.btnLFLogin.Location = new System.Drawing.Point(61, 375);
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
            this.btnLFNonLogin.Location = new System.Drawing.Point(242, 375);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, -1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(601, 35);
            this.tableLayoutPanel1.TabIndex = 132;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plnAM_MouseDown);
            this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plnAM_MouseMove);
            this.tableLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plnAM_MouseUp);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gulim", 10F);
            this.button1.Location = new System.Drawing.Point(578, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "🗙";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Gulim", 10F);
            this.button2.Location = new System.Drawing.Point(552, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(19, 20);
            this.button2.TabIndex = 3;
            this.button2.Text = "🗖";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Gulim", 10F);
            this.button3.Location = new System.Drawing.Point(524, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 20);
            this.button3.TabIndex = 2;
            this.button3.Text = "🗕";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.Font = new System.Drawing.Font("Gulim", 15F);
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "로그인폼";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 550);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.grpLogLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "로그인폼";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.grpLogLogin.ResumeLayout(false);
            this.grpLogLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogLogo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
    }
}


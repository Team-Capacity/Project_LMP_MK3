
namespace LMP_Projcet.Customer
{
    partial class CustomerWriteForm
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
            this.grpCWSuggest = new System.Windows.Forms.GroupBox();
            this.lbCWMyCusNum = new System.Windows.Forms.Label();
            this.lbCWCusNum = new System.Windows.Forms.Label();
            this.lbCWToday = new System.Windows.Forms.Label();
            this.btnCWOk = new System.Windows.Forms.Button();
            this.btnCWCancel = new System.Windows.Forms.Button();
            this.lbCWNotice = new System.Windows.Forms.Label();
            this.txtCWContent = new System.Windows.Forms.TextBox();
            this.lbCWDate = new System.Windows.Forms.Label();
            this.lbCWContent = new System.Windows.Forms.Label();
            this.lbCWTitle = new System.Windows.Forms.Label();
            this.txtCWTitle = new System.Windows.Forms.TextBox();
            this.plnCW = new System.Windows.Forms.TableLayoutPanel();
            this.btnCWMax = new System.Windows.Forms.Button();
            this.btnCWMin = new System.Windows.Forms.Button();
            this.btnCWClose = new System.Windows.Forms.Button();
            this.lbCWLogo = new System.Windows.Forms.Label();
            this.grpCWSuggest.SuspendLayout();
            this.plnCW.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCWSuggest
            // 
            this.grpCWSuggest.Controls.Add(this.lbCWMyCusNum);
            this.grpCWSuggest.Controls.Add(this.lbCWCusNum);
            this.grpCWSuggest.Controls.Add(this.lbCWToday);
            this.grpCWSuggest.Controls.Add(this.btnCWOk);
            this.grpCWSuggest.Controls.Add(this.btnCWCancel);
            this.grpCWSuggest.Controls.Add(this.lbCWNotice);
            this.grpCWSuggest.Controls.Add(this.txtCWContent);
            this.grpCWSuggest.Controls.Add(this.lbCWDate);
            this.grpCWSuggest.Controls.Add(this.lbCWContent);
            this.grpCWSuggest.Controls.Add(this.lbCWTitle);
            this.grpCWSuggest.Controls.Add(this.txtCWTitle);
            this.grpCWSuggest.Location = new System.Drawing.Point(102, 97);
            this.grpCWSuggest.Name = "grpCWSuggest";
            this.grpCWSuggest.Size = new System.Drawing.Size(632, 461);
            this.grpCWSuggest.TabIndex = 22;
            this.grpCWSuggest.TabStop = false;
            this.grpCWSuggest.Enter += new System.EventHandler(this.GBCusWriteSuggest_Enter);
            // 
            // lbCWMyCusNum
            // 
            this.lbCWMyCusNum.AutoSize = true;
            this.lbCWMyCusNum.Location = new System.Drawing.Point(499, 23);
            this.lbCWMyCusNum.Name = "lbCWMyCusNum";
            this.lbCWMyCusNum.Size = new System.Drawing.Size(53, 12);
            this.lbCWMyCusNum.TabIndex = 47;
            this.lbCWMyCusNum.Text = "17831046";
            // 
            // lbCWCusNum
            // 
            this.lbCWCusNum.AutoSize = true;
            this.lbCWCusNum.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCWCusNum.Location = new System.Drawing.Point(402, 20);
            this.lbCWCusNum.Name = "lbCWCusNum";
            this.lbCWCusNum.Size = new System.Drawing.Size(101, 21);
            this.lbCWCusNum.TabIndex = 46;
            this.lbCWCusNum.Text = "회원번호:";
            // 
            // lbCWToday
            // 
            this.lbCWToday.AutoSize = true;
            this.lbCWToday.Location = new System.Drawing.Point(107, 23);
            this.lbCWToday.Name = "lbCWToday";
            this.lbCWToday.Size = new System.Drawing.Size(53, 12);
            this.lbCWToday.TabIndex = 45;
            this.lbCWToday.Text = "날짜출력";
            // 
            // btnCWOk
            // 
            this.btnCWOk.BackColor = System.Drawing.Color.Gray;
            this.btnCWOk.FlatAppearance.BorderSize = 0;
            this.btnCWOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCWOk.ForeColor = System.Drawing.Color.White;
            this.btnCWOk.Location = new System.Drawing.Point(200, 414);
            this.btnCWOk.Name = "btnCWOk";
            this.btnCWOk.Size = new System.Drawing.Size(75, 25);
            this.btnCWOk.TabIndex = 31;
            this.btnCWOk.Text = "확 인";
            this.btnCWOk.UseVisualStyleBackColor = false;
            this.btnCWOk.Click += new System.EventHandler(this.btnCusWriteOk_Click);
            // 
            // btnCWCancel
            // 
            this.btnCWCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCWCancel.FlatAppearance.BorderSize = 0;
            this.btnCWCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCWCancel.ForeColor = System.Drawing.Color.White;
            this.btnCWCancel.Location = new System.Drawing.Point(406, 414);
            this.btnCWCancel.Name = "btnCWCancel";
            this.btnCWCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCWCancel.TabIndex = 30;
            this.btnCWCancel.Text = "취 소";
            this.btnCWCancel.UseVisualStyleBackColor = false;
            this.btnCWCancel.Click += new System.EventHandler(this.btnCWCancel_Click);
            // 
            // lbCWNotice
            // 
            this.lbCWNotice.AutoSize = true;
            this.lbCWNotice.Font = new System.Drawing.Font("굴림", 15F);
            this.lbCWNotice.Location = new System.Drawing.Point(272, 0);
            this.lbCWNotice.Name = "lbCWNotice";
            this.lbCWNotice.Size = new System.Drawing.Size(89, 20);
            this.lbCWNotice.TabIndex = 0;
            this.lbCWNotice.Text = "건의하기";
            this.lbCWNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCWContent
            // 
            this.txtCWContent.Location = new System.Drawing.Point(107, 118);
            this.txtCWContent.Multiline = true;
            this.txtCWContent.Name = "txtCWContent";
            this.txtCWContent.Size = new System.Drawing.Size(483, 270);
            this.txtCWContent.TabIndex = 4;
            // 
            // lbCWDate
            // 
            this.lbCWDate.AutoSize = true;
            this.lbCWDate.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCWDate.Location = new System.Drawing.Point(28, 20);
            this.lbCWDate.Name = "lbCWDate";
            this.lbCWDate.Size = new System.Drawing.Size(73, 21);
            this.lbCWDate.TabIndex = 42;
            this.lbCWDate.Text = "날 짜 :";
            // 
            // lbCWContent
            // 
            this.lbCWContent.AutoSize = true;
            this.lbCWContent.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCWContent.Location = new System.Drawing.Point(28, 118);
            this.lbCWContent.Name = "lbCWContent";
            this.lbCWContent.Size = new System.Drawing.Size(73, 21);
            this.lbCWContent.TabIndex = 2;
            this.lbCWContent.Text = "내 용 :";
            // 
            // lbCWTitle
            // 
            this.lbCWTitle.AutoSize = true;
            this.lbCWTitle.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCWTitle.Location = new System.Drawing.Point(28, 62);
            this.lbCWTitle.Name = "lbCWTitle";
            this.lbCWTitle.Size = new System.Drawing.Size(73, 21);
            this.lbCWTitle.TabIndex = 1;
            this.lbCWTitle.Text = "제 목 :";
            // 
            // txtCWTitle
            // 
            this.txtCWTitle.Location = new System.Drawing.Point(107, 62);
            this.txtCWTitle.Multiline = true;
            this.txtCWTitle.Name = "txtCWTitle";
            this.txtCWTitle.Size = new System.Drawing.Size(483, 21);
            this.txtCWTitle.TabIndex = 2;
            // 
            // plnCW
            // 
            this.plnCW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plnCW.AutoSize = true;
            this.plnCW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.plnCW.ColumnCount = 3;
            this.plnCW.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.plnCW.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.plnCW.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.plnCW.Controls.Add(this.btnCWMax, 1, 1);
            this.plnCW.Controls.Add(this.btnCWMin, 0, 1);
            this.plnCW.Controls.Add(this.btnCWClose, 2, 1);
            this.plnCW.Location = new System.Drawing.Point(-1, -4);
            this.plnCW.Name = "plnCW";
            this.plnCW.RowCount = 2;
            this.plnCW.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.plnCW.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.plnCW.Size = new System.Drawing.Size(839, 39);
            this.plnCW.TabIndex = 40;
            this.plnCW.Paint += new System.Windows.Forms.PaintEventHandler(this.plnCus_Paint_1);
            this.plnCW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plnCus_MouseDown);
            this.plnCW.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plnCus_MouseMove);
            this.plnCW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plnCus_MouseUp);
            // 
            // btnCWMax
            // 
            this.btnCWMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCWMax.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCWMax.FlatAppearance.BorderSize = 0;
            this.btnCWMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCWMax.Font = new System.Drawing.Font("굴림", 15F);
            this.btnCWMax.Location = new System.Drawing.Point(776, 6);
            this.btnCWMax.Name = "btnCWMax";
            this.btnCWMax.Size = new System.Drawing.Size(20, 20);
            this.btnCWMax.TabIndex = 3;
            this.btnCWMax.Text = "🗖";
            this.btnCWMax.UseVisualStyleBackColor = false;
            this.btnCWMax.Click += new System.EventHandler(this.btnCusMax_Click);
            // 
            // btnCWMin
            // 
            this.btnCWMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCWMin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCWMin.FlatAppearance.BorderSize = 0;
            this.btnCWMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCWMin.Font = new System.Drawing.Font("굴림", 15F);
            this.btnCWMin.Location = new System.Drawing.Point(736, 6);
            this.btnCWMin.Name = "btnCWMin";
            this.btnCWMin.Size = new System.Drawing.Size(20, 20);
            this.btnCWMin.TabIndex = 2;
            this.btnCWMin.Text = "🗕";
            this.btnCWMin.UseVisualStyleBackColor = false;
            this.btnCWMin.Click += new System.EventHandler(this.btnCusMin_Click);
            // 
            // btnCWClose
            // 
            this.btnCWClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCWClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCWClose.FlatAppearance.BorderSize = 0;
            this.btnCWClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCWClose.Font = new System.Drawing.Font("굴림", 15F);
            this.btnCWClose.Location = new System.Drawing.Point(816, 6);
            this.btnCWClose.Name = "btnCWClose";
            this.btnCWClose.Size = new System.Drawing.Size(20, 20);
            this.btnCWClose.TabIndex = 1;
            this.btnCWClose.Text = "🗙";
            this.btnCWClose.UseVisualStyleBackColor = false;
            this.btnCWClose.Click += new System.EventHandler(this.btnCusClose_Click);
            // 
            // lbCWLogo
            // 
            this.lbCWLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCWLogo.AutoSize = true;
            this.lbCWLogo.Font = new System.Drawing.Font("굴림", 24F);
            this.lbCWLogo.Location = new System.Drawing.Point(12, 51);
            this.lbCWLogo.Name = "lbCWLogo";
            this.lbCWLogo.Size = new System.Drawing.Size(207, 32);
            this.lbCWLogo.TabIndex = 41;
            this.lbCWLogo.Text = "CAPA 도서관";
            // 
            // CustomerWriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 617);
            this.Controls.Add(this.lbCWLogo);
            this.Controls.Add(this.plnCW);
            this.Controls.Add(this.grpCWSuggest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerWriteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerWriteForm";
            this.Load += new System.EventHandler(this.CustomerWriteForm_Load);
            this.grpCWSuggest.ResumeLayout(false);
            this.grpCWSuggest.PerformLayout();
            this.plnCW.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCWSuggest;
        private System.Windows.Forms.Button btnCWOk;
        private System.Windows.Forms.Button btnCWCancel;
        private System.Windows.Forms.TextBox txtCWContent;
        private System.Windows.Forms.Label lbCWContent;
        private System.Windows.Forms.Label lbCWTitle;
        private System.Windows.Forms.Label lbCWNotice;
        private System.Windows.Forms.TextBox txtCWTitle;
        private System.Windows.Forms.TableLayoutPanel plnCW;
        private System.Windows.Forms.Button btnCWMax;
        private System.Windows.Forms.Button btnCWMin;
        private System.Windows.Forms.Button btnCWClose;
        private System.Windows.Forms.Label lbCWLogo;
        private System.Windows.Forms.Label lbCWDate;
        private System.Windows.Forms.Label lbCWToday;
        private System.Windows.Forms.Label lbCWMyCusNum;
        private System.Windows.Forms.Label lbCWCusNum;
    }
}
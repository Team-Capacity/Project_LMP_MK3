
namespace LMP_Projcet.Customer
{
    partial class CustomerNoticeForm
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
            this.cmbCNSerList = new System.Windows.Forms.ComboBox();
            this.txtCNInput = new System.Windows.Forms.TextBox();
            this.btnCNListFind = new System.Windows.Forms.Button();
            this.lbCNNotice = new System.Windows.Forms.Label();
            this.lvCNList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbCNNoticeView = new System.Windows.Forms.Label();
            this.plnCN = new System.Windows.Forms.TableLayoutPanel();
            this.btnCNClose = new System.Windows.Forms.Button();
            this.btnCNMax = new System.Windows.Forms.Button();
            this.btnCNMin = new System.Windows.Forms.Button();
            this.plnCN.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCNSerList
            // 
            this.cmbCNSerList.FormattingEnabled = true;
            this.cmbCNSerList.Location = new System.Drawing.Point(552, 73);
            this.cmbCNSerList.Name = "cmbCNSerList";
            this.cmbCNSerList.Size = new System.Drawing.Size(121, 20);
            this.cmbCNSerList.TabIndex = 39;
            this.cmbCNSerList.Text = "제목";
            // 
            // txtCNInput
            // 
            this.txtCNInput.Location = new System.Drawing.Point(679, 73);
            this.txtCNInput.Multiline = true;
            this.txtCNInput.Name = "txtCNInput";
            this.txtCNInput.Size = new System.Drawing.Size(252, 20);
            this.txtCNInput.TabIndex = 38;
            // 
            // btnCNListFind
            // 
            this.btnCNListFind.BackColor = System.Drawing.Color.Gray;
            this.btnCNListFind.FlatAppearance.BorderSize = 0;
            this.btnCNListFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCNListFind.ForeColor = System.Drawing.Color.White;
            this.btnCNListFind.Location = new System.Drawing.Point(937, 73);
            this.btnCNListFind.Name = "btnCNListFind";
            this.btnCNListFind.Size = new System.Drawing.Size(75, 20);
            this.btnCNListFind.TabIndex = 37;
            this.btnCNListFind.Text = "검 색";
            this.btnCNListFind.UseVisualStyleBackColor = false;
            // 
            // lbCNNotice
            // 
            this.lbCNNotice.AutoSize = true;
            this.lbCNNotice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbCNNotice.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCNNotice.ForeColor = System.Drawing.Color.Black;
            this.lbCNNotice.Location = new System.Drawing.Point(203, 53);
            this.lbCNNotice.Name = "lbCNNotice";
            this.lbCNNotice.Size = new System.Drawing.Size(110, 24);
            this.lbCNNotice.TabIndex = 36;
            this.lbCNNotice.Text = "공지사항";
            // 
            // lvCNList
            // 
            this.lvCNList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvCNList.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lvCNList.FullRowSelect = true;
            this.lvCNList.GridLines = true;
            this.lvCNList.HideSelection = false;
            this.lvCNList.Location = new System.Drawing.Point(553, 99);
            this.lvCNList.Name = "lvCNList";
            this.lvCNList.Size = new System.Drawing.Size(501, 412);
            this.lvCNList.TabIndex = 42;
            this.lvCNList.UseCompatibleStateImageBehavior = false;
            this.lvCNList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "번호";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "제목";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 81;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "내용";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 254;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "날짜";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // lbCNNoticeView
            // 
            this.lbCNNoticeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCNNoticeView.Location = new System.Drawing.Point(32, 90);
            this.lbCNNoticeView.Name = "lbCNNoticeView";
            this.lbCNNoticeView.Size = new System.Drawing.Size(480, 451);
            this.lbCNNoticeView.TabIndex = 43;
            this.lbCNNoticeView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // plnCN
            // 
            this.plnCN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plnCN.AutoSize = true;
            this.plnCN.BackColor = System.Drawing.Color.Silver;
            this.plnCN.ColumnCount = 4;
            this.plnCN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.plnCN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.plnCN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.plnCN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.plnCN.Controls.Add(this.btnCNClose, 3, 1);
            this.plnCN.Controls.Add(this.btnCNMax, 2, 1);
            this.plnCN.Controls.Add(this.btnCNMin, 1, 1);
            this.plnCN.ImeMode = System.Windows.Forms.ImeMode.On;
            this.plnCN.Location = new System.Drawing.Point(0, -4);
            this.plnCN.Name = "plnCN";
            this.plnCN.RowCount = 2;
            this.plnCN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.plnCN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.plnCN.Size = new System.Drawing.Size(1113, 39);
            this.plnCN.TabIndex = 149;
            this.plnCN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plnCN_MouseDown);
            this.plnCN.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plnCN_MouseMove);
            this.plnCN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plnCN_MouseUp);
            // 
            // btnCNClose
            // 
            this.btnCNClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCNClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCNClose.FlatAppearance.BorderSize = 0;
            this.btnCNClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCNClose.Font = new System.Drawing.Font("굴림", 10F);
            this.btnCNClose.Location = new System.Drawing.Point(1090, 6);
            this.btnCNClose.Name = "btnCNClose";
            this.btnCNClose.Size = new System.Drawing.Size(20, 20);
            this.btnCNClose.TabIndex = 1;
            this.btnCNClose.Text = "🗙";
            this.btnCNClose.UseVisualStyleBackColor = false;
            this.btnCNClose.Click += new System.EventHandler(this.btnCNClose_Click_1);
            // 
            // btnCNMax
            // 
            this.btnCNMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCNMax.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCNMax.FlatAppearance.BorderSize = 0;
            this.btnCNMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCNMax.Font = new System.Drawing.Font("굴림", 10F);
            this.btnCNMax.Location = new System.Drawing.Point(1064, 6);
            this.btnCNMax.Name = "btnCNMax";
            this.btnCNMax.Size = new System.Drawing.Size(19, 20);
            this.btnCNMax.TabIndex = 3;
            this.btnCNMax.Text = "🗖";
            this.btnCNMax.UseVisualStyleBackColor = false;
            this.btnCNMax.Click += new System.EventHandler(this.btnCNMax_Click_1);
            // 
            // btnCNMin
            // 
            this.btnCNMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCNMin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCNMin.FlatAppearance.BorderSize = 0;
            this.btnCNMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCNMin.Font = new System.Drawing.Font("굴림", 10F);
            this.btnCNMin.Location = new System.Drawing.Point(1036, 6);
            this.btnCNMin.Name = "btnCNMin";
            this.btnCNMin.Size = new System.Drawing.Size(20, 20);
            this.btnCNMin.TabIndex = 2;
            this.btnCNMin.Text = "🗕";
            this.btnCNMin.UseVisualStyleBackColor = false;
            this.btnCNMin.Click += new System.EventHandler(this.btnCNMin_Click);
            // 
            // CustomerNoticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1112, 553);
            this.Controls.Add(this.plnCN);
            this.Controls.Add(this.lbCNNoticeView);
            this.Controls.Add(this.lvCNList);
            this.Controls.Add(this.cmbCNSerList);
            this.Controls.Add(this.txtCNInput);
            this.Controls.Add(this.btnCNListFind);
            this.Controls.Add(this.lbCNNotice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerNoticeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerNoticeForm";
            this.Load += new System.EventHandler(this.CustomerNoticeForm_Load);
            this.plnCN.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbCNSerList;
        private System.Windows.Forms.TextBox txtCNInput;
        private System.Windows.Forms.Button btnCNListFind;
        private System.Windows.Forms.Label lbCNNotice;
        private System.Windows.Forms.ListView lvCNList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lbCNNoticeView;
        private System.Windows.Forms.TableLayoutPanel plnCN;
        private System.Windows.Forms.Button btnCNClose;
        private System.Windows.Forms.Button btnCNMax;
        private System.Windows.Forms.Button btnCNMin;
    }
}
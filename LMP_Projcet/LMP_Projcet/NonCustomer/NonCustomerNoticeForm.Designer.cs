
namespace LMP_Projcet.NonCustomer
{
    partial class NonCustomerNoticeForm
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
            this.plnNCN = new System.Windows.Forms.TableLayoutPanel();
            this.btnNCNMax = new System.Windows.Forms.Button();
            this.btnNCNMin = new System.Windows.Forms.Button();
            this.btnNCNClose = new System.Windows.Forms.Button();
            this.lbNCNNoticeView = new System.Windows.Forms.Label();
            this.lvNCNList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbNCNSerList = new System.Windows.Forms.ComboBox();
            this.txtNCNInput = new System.Windows.Forms.TextBox();
            this.btnNCNListFind = new System.Windows.Forms.Button();
            this.lbNCNNotice = new System.Windows.Forms.Label();
            this.plnNCN.SuspendLayout();
            this.SuspendLayout();
            // 
            // plnNCN
            // 
            this.plnNCN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plnNCN.AutoSize = true;
            this.plnNCN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.plnNCN.ColumnCount = 3;
            this.plnNCN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.plnNCN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.plnNCN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.plnNCN.Controls.Add(this.btnNCNMax, 1, 1);
            this.plnNCN.Controls.Add(this.btnNCNMin, 0, 1);
            this.plnNCN.Controls.Add(this.btnNCNClose, 2, 1);
            this.plnNCN.Location = new System.Drawing.Point(0, -4);
            this.plnNCN.Name = "plnNCN";
            this.plnNCN.RowCount = 2;
            this.plnNCN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.plnNCN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.plnNCN.Size = new System.Drawing.Size(1113, 39);
            this.plnNCN.TabIndex = 47;
            this.plnNCN.Paint += new System.Windows.Forms.PaintEventHandler(this.plnNCN_Paint);
            this.plnNCN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plnNCN_MouseDown);
            this.plnNCN.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plnNCN_MouseMove);
            this.plnNCN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plnNCN_MouseUp);
            // 
            // btnNCNMax
            // 
            this.btnNCNMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNCNMax.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNCNMax.FlatAppearance.BorderSize = 0;
            this.btnNCNMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNCNMax.Font = new System.Drawing.Font("굴림", 15F);
            this.btnNCNMax.Location = new System.Drawing.Point(1050, 6);
            this.btnNCNMax.Name = "btnNCNMax";
            this.btnNCNMax.Size = new System.Drawing.Size(20, 20);
            this.btnNCNMax.TabIndex = 3;
            this.btnNCNMax.Text = "🗖";
            this.btnNCNMax.UseVisualStyleBackColor = false;
            this.btnNCNMax.Click += new System.EventHandler(this.btnNCNMax_Click);
            // 
            // btnNCNMin
            // 
            this.btnNCNMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNCNMin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNCNMin.FlatAppearance.BorderSize = 0;
            this.btnNCNMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNCNMin.Font = new System.Drawing.Font("굴림", 15F);
            this.btnNCNMin.Location = new System.Drawing.Point(1010, 6);
            this.btnNCNMin.Name = "btnNCNMin";
            this.btnNCNMin.Size = new System.Drawing.Size(20, 20);
            this.btnNCNMin.TabIndex = 2;
            this.btnNCNMin.Text = "🗕";
            this.btnNCNMin.UseVisualStyleBackColor = false;
            this.btnNCNMin.Click += new System.EventHandler(this.btnNCNMin_Click);
            // 
            // btnNCNClose
            // 
            this.btnNCNClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNCNClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNCNClose.FlatAppearance.BorderSize = 0;
            this.btnNCNClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNCNClose.Font = new System.Drawing.Font("굴림", 15F);
            this.btnNCNClose.Location = new System.Drawing.Point(1090, 6);
            this.btnNCNClose.Name = "btnNCNClose";
            this.btnNCNClose.Size = new System.Drawing.Size(20, 20);
            this.btnNCNClose.TabIndex = 1;
            this.btnNCNClose.Text = "🗙";
            this.btnNCNClose.UseVisualStyleBackColor = false;
            this.btnNCNClose.Click += new System.EventHandler(this.btnNCNClose_Click);
            // 
            // lbNCNNoticeView
            // 
            this.lbNCNNoticeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNCNNoticeView.Location = new System.Drawing.Point(43, 90);
            this.lbNCNNoticeView.Name = "lbNCNNoticeView";
            this.lbNCNNoticeView.Size = new System.Drawing.Size(480, 451);
            this.lbNCNNoticeView.TabIndex = 54;
            this.lbNCNNoticeView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvNCNList
            // 
            this.lvNCNList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvNCNList.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lvNCNList.FullRowSelect = true;
            this.lvNCNList.GridLines = true;
            this.lvNCNList.HideSelection = false;
            this.lvNCNList.Location = new System.Drawing.Point(569, 93);
            this.lvNCNList.Name = "lvNCNList";
            this.lvNCNList.Size = new System.Drawing.Size(501, 412);
            this.lvNCNList.TabIndex = 53;
            this.lvNCNList.UseCompatibleStateImageBehavior = false;
            this.lvNCNList.View = System.Windows.Forms.View.Details;
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
            // cmbNCNSerList
            // 
            this.cmbNCNSerList.FormattingEnabled = true;
            this.cmbNCNSerList.Location = new System.Drawing.Point(569, 67);
            this.cmbNCNSerList.Name = "cmbNCNSerList";
            this.cmbNCNSerList.Size = new System.Drawing.Size(121, 20);
            this.cmbNCNSerList.TabIndex = 52;
            this.cmbNCNSerList.Text = "제목";
            // 
            // txtNCNInput
            // 
            this.txtNCNInput.Location = new System.Drawing.Point(696, 67);
            this.txtNCNInput.Multiline = true;
            this.txtNCNInput.Name = "txtNCNInput";
            this.txtNCNInput.Size = new System.Drawing.Size(252, 20);
            this.txtNCNInput.TabIndex = 51;
            // 
            // btnNCNListFind
            // 
            this.btnNCNListFind.BackColor = System.Drawing.Color.Gray;
            this.btnNCNListFind.FlatAppearance.BorderSize = 0;
            this.btnNCNListFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNCNListFind.ForeColor = System.Drawing.Color.White;
            this.btnNCNListFind.Location = new System.Drawing.Point(954, 67);
            this.btnNCNListFind.Name = "btnNCNListFind";
            this.btnNCNListFind.Size = new System.Drawing.Size(75, 20);
            this.btnNCNListFind.TabIndex = 50;
            this.btnNCNListFind.Text = "검 색";
            this.btnNCNListFind.UseVisualStyleBackColor = false;
            // 
            // lbNCNNotice
            // 
            this.lbNCNNotice.AutoSize = true;
            this.lbNCNNotice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbNCNNotice.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbNCNNotice.ForeColor = System.Drawing.Color.Black;
            this.lbNCNNotice.Location = new System.Drawing.Point(225, 59);
            this.lbNCNNotice.Name = "lbNCNNotice";
            this.lbNCNNotice.Size = new System.Drawing.Size(110, 24);
            this.lbNCNNotice.TabIndex = 49;
            this.lbNCNNotice.Text = "공지사항";
            // 
            // NonCustomerNoticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1112, 553);
            this.Controls.Add(this.lbNCNNoticeView);
            this.Controls.Add(this.lvNCNList);
            this.Controls.Add(this.cmbNCNSerList);
            this.Controls.Add(this.txtNCNInput);
            this.Controls.Add(this.btnNCNListFind);
            this.Controls.Add(this.lbNCNNotice);
            this.Controls.Add(this.plnNCN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NonCustomerNoticeForm";
            this.Text = "NonCustomerNoticeForm";
            this.plnNCN.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel plnNCN;
        private System.Windows.Forms.Button btnNCNMax;
        private System.Windows.Forms.Button btnNCNMin;
        private System.Windows.Forms.Button btnNCNClose;
        private System.Windows.Forms.Label lbNCNNoticeView;
        private System.Windows.Forms.ListView lvNCNList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox cmbNCNSerList;
        private System.Windows.Forms.TextBox txtNCNInput;
        private System.Windows.Forms.Button btnNCNListFind;
        private System.Windows.Forms.Label lbNCNNotice;
    }
}
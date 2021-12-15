
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
            this.lbCNNoticeView4 = new System.Windows.Forms.Label();
            this.plnCN = new System.Windows.Forms.TableLayoutPanel();
            this.btnCNClose = new System.Windows.Forms.Button();
            this.btnCNMax = new System.Windows.Forms.Button();
            this.btnCNMin = new System.Windows.Forms.Button();
            this.lbCNNoticeView2 = new System.Windows.Forms.Label();
            this.lbCNNoticeView = new System.Windows.Forms.Label();
            this.lbCNNoticeView3 = new System.Windows.Forms.Label();
            this.dgvCNList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.plnCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCNList)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCNSerList
            // 
            this.cmbCNSerList.FormattingEnabled = true;
            this.cmbCNSerList.Items.AddRange(new object[] {
            "제목"});
            this.cmbCNSerList.Location = new System.Drawing.Point(589, 94);
            this.cmbCNSerList.Name = "cmbCNSerList";
            this.cmbCNSerList.Size = new System.Drawing.Size(121, 20);
            this.cmbCNSerList.TabIndex = 39;
            this.cmbCNSerList.Text = "제목";
            // 
            // txtCNInput
            // 
            this.txtCNInput.Location = new System.Drawing.Point(716, 94);
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
            this.btnCNListFind.Location = new System.Drawing.Point(974, 94);
            this.btnCNListFind.Name = "btnCNListFind";
            this.btnCNListFind.Size = new System.Drawing.Size(75, 20);
            this.btnCNListFind.TabIndex = 37;
            this.btnCNListFind.Text = "검 색";
            this.btnCNListFind.UseVisualStyleBackColor = false;
            this.btnCNListFind.Click += new System.EventHandler(this.btnCNListFind_Click);
            // 
            // lbCNNotice
            // 
            this.lbCNNotice.AutoSize = true;
            this.lbCNNotice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbCNNotice.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCNNotice.ForeColor = System.Drawing.Color.Black;
            this.lbCNNotice.Location = new System.Drawing.Point(269, 50);
            this.lbCNNotice.Name = "lbCNNotice";
            this.lbCNNotice.Size = new System.Drawing.Size(110, 24);
            this.lbCNNotice.TabIndex = 36;
            this.lbCNNotice.Text = "공지사항";
            // 
            // lbCNNoticeView4
            // 
            this.lbCNNoticeView4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCNNoticeView4.Location = new System.Drawing.Point(105, 129);
            this.lbCNNoticeView4.Name = "lbCNNoticeView4";
            this.lbCNNoticeView4.Size = new System.Drawing.Size(445, 386);
            this.lbCNNoticeView4.TabIndex = 43;
            this.lbCNNoticeView4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.plnCN.Size = new System.Drawing.Size(1158, 35);
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
            this.btnCNClose.Font = new System.Drawing.Font("Gulim", 10F);
            this.btnCNClose.Location = new System.Drawing.Point(1135, 6);
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
            this.btnCNMax.Font = new System.Drawing.Font("Gulim", 10F);
            this.btnCNMax.Location = new System.Drawing.Point(1109, 6);
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
            this.btnCNMin.Font = new System.Drawing.Font("Gulim", 10F);
            this.btnCNMin.Location = new System.Drawing.Point(1081, 6);
            this.btnCNMin.Name = "btnCNMin";
            this.btnCNMin.Size = new System.Drawing.Size(20, 20);
            this.btnCNMin.TabIndex = 2;
            this.btnCNMin.Text = "🗕";
            this.btnCNMin.UseVisualStyleBackColor = false;
            this.btnCNMin.Click += new System.EventHandler(this.btnCNMin_Click);
            // 
            // lbCNNoticeView2
            // 
            this.lbCNNoticeView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCNNoticeView2.Location = new System.Drawing.Point(105, 94);
            this.lbCNNoticeView2.Name = "lbCNNoticeView2";
            this.lbCNNoticeView2.Size = new System.Drawing.Size(445, 29);
            this.lbCNNoticeView2.TabIndex = 150;
            this.lbCNNoticeView2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCNNoticeView
            // 
            this.lbCNNoticeView.AutoSize = true;
            this.lbCNNoticeView.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCNNoticeView.Location = new System.Drawing.Point(33, 97);
            this.lbCNNoticeView.Name = "lbCNNoticeView";
            this.lbCNNoticeView.Size = new System.Drawing.Size(62, 21);
            this.lbCNNoticeView.TabIndex = 151;
            this.lbCNNoticeView.Text = "제목:";
            // 
            // lbCNNoticeView3
            // 
            this.lbCNNoticeView3.AutoSize = true;
            this.lbCNNoticeView3.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCNNoticeView3.Location = new System.Drawing.Point(33, 129);
            this.lbCNNoticeView3.Name = "lbCNNoticeView3";
            this.lbCNNoticeView3.Size = new System.Drawing.Size(62, 21);
            this.lbCNNoticeView3.TabIndex = 152;
            this.lbCNNoticeView3.Text = "내용:";
            // 
            // dgvCNList
            // 
            this.dgvCNList.AllowUserToAddRows = false;
            this.dgvCNList.AllowUserToDeleteRows = false;
            this.dgvCNList.AllowUserToResizeColumns = false;
            this.dgvCNList.AllowUserToResizeRows = false;
            this.dgvCNList.BackgroundColor = System.Drawing.Color.White;
            this.dgvCNList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCNList.Location = new System.Drawing.Point(584, 129);
            this.dgvCNList.Name = "dgvCNList";
            this.dgvCNList.ReadOnly = true;
            this.dgvCNList.RowHeadersVisible = false;
            this.dgvCNList.RowHeadersWidth = 200;
            this.dgvCNList.RowTemplate.Height = 23;
            this.dgvCNList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCNList.Size = new System.Drawing.Size(478, 386);
            this.dgvCNList.TabIndex = 153;
            this.dgvCNList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCNList_CellClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Gulim", 15F);
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 167;
            this.label1.Text = "공지사항폼";
            // 
            // CustomerNoticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1157, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCNList);
            this.Controls.Add(this.lbCNNoticeView3);
            this.Controls.Add(this.lbCNNoticeView);
            this.Controls.Add(this.lbCNNoticeView2);
            this.Controls.Add(this.plnCN);
            this.Controls.Add(this.lbCNNoticeView4);
            this.Controls.Add(this.cmbCNSerList);
            this.Controls.Add(this.txtCNInput);
            this.Controls.Add(this.btnCNListFind);
            this.Controls.Add(this.lbCNNotice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(558, 93);
            this.Name = "CustomerNoticeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerNoticeForm";
            this.Load += new System.EventHandler(this.CustomerNoticeForm_Load);
            this.plnCN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCNList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbCNSerList;
        private System.Windows.Forms.TextBox txtCNInput;
        private System.Windows.Forms.Button btnCNListFind;
        private System.Windows.Forms.Label lbCNNotice;
        private System.Windows.Forms.Label lbCNNoticeView4;
        private System.Windows.Forms.TableLayoutPanel plnCN;
        private System.Windows.Forms.Button btnCNClose;
        private System.Windows.Forms.Button btnCNMax;
        private System.Windows.Forms.Button btnCNMin;
        private System.Windows.Forms.Label lbCNNoticeView2;
        private System.Windows.Forms.Label lbCNNoticeView;
        private System.Windows.Forms.Label lbCNNoticeView3;
        private System.Windows.Forms.DataGridView dgvCNList;
        private System.Windows.Forms.Label label1;
    }
}
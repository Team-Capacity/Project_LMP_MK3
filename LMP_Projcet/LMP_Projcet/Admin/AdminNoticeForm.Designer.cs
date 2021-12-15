
namespace LibraryMgrProgram
{
    partial class AdminNoticeForm
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
            this.comANSerList = new System.Windows.Forms.ComboBox();
            this.txtANInput = new System.Windows.Forms.TextBox();
            this.btnANListFind = new System.Windows.Forms.Button();
            this.btnANDel = new System.Windows.Forms.Button();
            this.btnANModi = new System.Windows.Forms.Button();
            this.btnANAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvANList = new System.Windows.Forms.DataGridView();
            this.lbANNoticeCont = new System.Windows.Forms.Label();
            this.lbANNoticeView = new System.Windows.Forms.Label();
            this.txtANNoticeCont = new System.Windows.Forms.TextBox();
            this.txtANNoticeView = new System.Windows.Forms.TextBox();
            this.plnAM = new System.Windows.Forms.TableLayoutPanel();
            this.btnLFClose = new System.Windows.Forms.Button();
            this.btnLFMax = new System.Windows.Forms.Button();
            this.btnLFMin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvANList)).BeginInit();
            this.plnAM.SuspendLayout();
            this.SuspendLayout();
            // 
            // comANSerList
            // 
            this.comANSerList.FormattingEnabled = true;
            this.comANSerList.Items.AddRange(new object[] {
            "제목"});
            this.comANSerList.Location = new System.Drawing.Point(588, 77);
            this.comANSerList.Name = "comANSerList";
            this.comANSerList.Size = new System.Drawing.Size(121, 20);
            this.comANSerList.TabIndex = 33;
            this.comANSerList.Text = "제목";
            // 
            // txtANInput
            // 
            this.txtANInput.Location = new System.Drawing.Point(715, 77);
            this.txtANInput.Multiline = true;
            this.txtANInput.Name = "txtANInput";
            this.txtANInput.Size = new System.Drawing.Size(252, 20);
            this.txtANInput.TabIndex = 32;
            // 
            // btnANListFind
            // 
            this.btnANListFind.BackColor = System.Drawing.Color.Gray;
            this.btnANListFind.FlatAppearance.BorderSize = 0;
            this.btnANListFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnANListFind.ForeColor = System.Drawing.Color.White;
            this.btnANListFind.Location = new System.Drawing.Point(973, 77);
            this.btnANListFind.Name = "btnANListFind";
            this.btnANListFind.Size = new System.Drawing.Size(75, 20);
            this.btnANListFind.TabIndex = 31;
            this.btnANListFind.Text = "검 색";
            this.btnANListFind.UseVisualStyleBackColor = false;
            this.btnANListFind.Click += new System.EventHandler(this.btnANListFind_Click);
            // 
            // btnANDel
            // 
            this.btnANDel.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnANDel.Location = new System.Drawing.Point(880, 511);
            this.btnANDel.Name = "btnANDel";
            this.btnANDel.Size = new System.Drawing.Size(92, 30);
            this.btnANDel.TabIndex = 30;
            this.btnANDel.Text = "삭제";
            this.btnANDel.UseVisualStyleBackColor = true;
            this.btnANDel.Click += new System.EventHandler(this.btnANDel_Click);
            // 
            // btnANModi
            // 
            this.btnANModi.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnANModi.Location = new System.Drawing.Point(780, 511);
            this.btnANModi.Name = "btnANModi";
            this.btnANModi.Size = new System.Drawing.Size(92, 30);
            this.btnANModi.TabIndex = 29;
            this.btnANModi.Text = "수정";
            this.btnANModi.UseVisualStyleBackColor = true;
            this.btnANModi.Click += new System.EventHandler(this.btnANModi_Click);
            // 
            // btnANAdd
            // 
            this.btnANAdd.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnANAdd.Location = new System.Drawing.Point(680, 511);
            this.btnANAdd.Name = "btnANAdd";
            this.btnANAdd.Size = new System.Drawing.Size(92, 30);
            this.btnANAdd.TabIndex = 28;
            this.btnANAdd.Text = "추가";
            this.btnANAdd.UseVisualStyleBackColor = true;
            this.btnANAdd.Click += new System.EventHandler(this.btnANAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gulim", 15F);
            this.label2.Location = new System.Drawing.Point(273, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "공지사항";
            // 
            // dgvANList
            // 
            this.dgvANList.AllowUserToAddRows = false;
            this.dgvANList.AllowUserToDeleteRows = false;
            this.dgvANList.AllowUserToResizeColumns = false;
            this.dgvANList.AllowUserToResizeRows = false;
            this.dgvANList.BackgroundColor = System.Drawing.Color.White;
            this.dgvANList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvANList.Location = new System.Drawing.Point(584, 112);
            this.dgvANList.Name = "dgvANList";
            this.dgvANList.ReadOnly = true;
            this.dgvANList.RowHeadersVisible = false;
            this.dgvANList.RowHeadersWidth = 200;
            this.dgvANList.RowTemplate.Height = 23;
            this.dgvANList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvANList.Size = new System.Drawing.Size(478, 386);
            this.dgvANList.TabIndex = 154;
            this.dgvANList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvANList_CellClick);
            // 
            // lbANNoticeCont
            // 
            this.lbANNoticeCont.AutoSize = true;
            this.lbANNoticeCont.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbANNoticeCont.Location = new System.Drawing.Point(33, 112);
            this.lbANNoticeCont.Name = "lbANNoticeCont";
            this.lbANNoticeCont.Size = new System.Drawing.Size(62, 21);
            this.lbANNoticeCont.TabIndex = 158;
            this.lbANNoticeCont.Text = "내용:";
            // 
            // lbANNoticeView
            // 
            this.lbANNoticeView.AutoSize = true;
            this.lbANNoticeView.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbANNoticeView.Location = new System.Drawing.Point(33, 80);
            this.lbANNoticeView.Name = "lbANNoticeView";
            this.lbANNoticeView.Size = new System.Drawing.Size(70, 21);
            this.lbANNoticeView.TabIndex = 157;
            this.lbANNoticeView.Text = "제목: ";
            // 
            // txtANNoticeCont
            // 
            this.txtANNoticeCont.BackColor = System.Drawing.Color.White;
            this.txtANNoticeCont.Location = new System.Drawing.Point(101, 112);
            this.txtANNoticeCont.Multiline = true;
            this.txtANNoticeCont.Name = "txtANNoticeCont";
            this.txtANNoticeCont.Size = new System.Drawing.Size(447, 386);
            this.txtANNoticeCont.TabIndex = 159;
            // 
            // txtANNoticeView
            // 
            this.txtANNoticeView.BackColor = System.Drawing.Color.White;
            this.txtANNoticeView.Location = new System.Drawing.Point(104, 77);
            this.txtANNoticeView.Multiline = true;
            this.txtANNoticeView.Name = "txtANNoticeView";
            this.txtANNoticeView.Size = new System.Drawing.Size(445, 29);
            this.txtANNoticeView.TabIndex = 160;
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
            this.plnAM.Location = new System.Drawing.Point(0, -2);
            this.plnAM.Name = "plnAM";
            this.plnAM.RowCount = 2;
            this.plnAM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.plnAM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.plnAM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.plnAM.Size = new System.Drawing.Size(1157, 35);
            this.plnAM.TabIndex = 161;
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
            this.btnLFClose.Location = new System.Drawing.Point(1134, 6);
            this.btnLFClose.Name = "btnLFClose";
            this.btnLFClose.Size = new System.Drawing.Size(20, 20);
            this.btnLFClose.TabIndex = 1;
            this.btnLFClose.Text = "🗙";
            this.btnLFClose.UseVisualStyleBackColor = false;
            this.btnLFClose.Click += new System.EventHandler(this.btnLFClose_Click);
            // 
            // btnLFMax
            // 
            this.btnLFMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLFMax.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLFMax.FlatAppearance.BorderSize = 0;
            this.btnLFMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLFMax.Font = new System.Drawing.Font("Gulim", 10F);
            this.btnLFMax.Location = new System.Drawing.Point(1108, 6);
            this.btnLFMax.Name = "btnLFMax";
            this.btnLFMax.Size = new System.Drawing.Size(19, 20);
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
            this.btnLFMin.Font = new System.Drawing.Font("Gulim", 10F);
            this.btnLFMin.Location = new System.Drawing.Point(1080, 6);
            this.btnLFMin.Name = "btnLFMin";
            this.btnLFMin.Size = new System.Drawing.Size(20, 20);
            this.btnLFMin.TabIndex = 2;
            this.btnLFMin.Text = "🗕";
            this.btnLFMin.UseVisualStyleBackColor = false;
            this.btnLFMin.Click += new System.EventHandler(this.btnLFMin_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Font = new System.Drawing.Font("Gulim", 15F);
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "공지사항";
            // 
            // AdminNoticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1157, 553);
            this.Controls.Add(this.plnAM);
            this.Controls.Add(this.lbANNoticeCont);
            this.Controls.Add(this.lbANNoticeView);
            this.Controls.Add(this.dgvANList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comANSerList);
            this.Controls.Add(this.txtANInput);
            this.Controls.Add(this.btnANListFind);
            this.Controls.Add(this.btnANDel);
            this.Controls.Add(this.btnANModi);
            this.Controls.Add(this.btnANAdd);
            this.Controls.Add(this.txtANNoticeView);
            this.Controls.Add(this.txtANNoticeCont);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminNoticeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "공지사항";
            this.Load += new System.EventHandler(this.AdminNoticeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvANList)).EndInit();
            this.plnAM.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comANSerList;
        private System.Windows.Forms.TextBox txtANInput;
        private System.Windows.Forms.Button btnANListFind;
        private System.Windows.Forms.Button btnANDel;
        private System.Windows.Forms.Button btnANModi;
        private System.Windows.Forms.Button btnANAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbANNoticeCont;
        private System.Windows.Forms.Label lbANNoticeView;
        private System.Windows.Forms.TextBox txtANNoticeCont;
        private System.Windows.Forms.TextBox txtANNoticeView;
        public System.Windows.Forms.DataGridView dgvANList;
        private System.Windows.Forms.TableLayoutPanel plnAM;
        private System.Windows.Forms.Button btnLFClose;
        private System.Windows.Forms.Button btnLFMax;
        private System.Windows.Forms.Button btnLFMin;
        private System.Windows.Forms.Label label1;
    }
}
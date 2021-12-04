
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
            this.lvANList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comANSerList = new System.Windows.Forms.ComboBox();
            this.txtANInput = new System.Windows.Forms.TextBox();
            this.btnANListFind = new System.Windows.Forms.Button();
            this.btnANDel = new System.Windows.Forms.Button();
            this.btnANModi = new System.Windows.Forms.Button();
            this.btnANAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbANNoticeView = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLFMax = new System.Windows.Forms.Button();
            this.btnLFMin = new System.Windows.Forms.Button();
            this.btnLFClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvANList
            // 
            this.lvANList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvANList.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lvANList.FullRowSelect = true;
            this.lvANList.GridLines = true;
            this.lvANList.HideSelection = false;
            this.lvANList.Location = new System.Drawing.Point(558, 93);
            this.lvANList.Name = "lvANList";
            this.lvANList.Size = new System.Drawing.Size(501, 412);
            this.lvANList.TabIndex = 5;
            this.lvANList.UseCompatibleStateImageBehavior = false;
            this.lvANList.View = System.Windows.Forms.View.Details;
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
            // comANSerList
            // 
            this.comANSerList.FormattingEnabled = true;
            this.comANSerList.Location = new System.Drawing.Point(558, 67);
            this.comANSerList.Name = "comANSerList";
            this.comANSerList.Size = new System.Drawing.Size(121, 20);
            this.comANSerList.TabIndex = 33;
            this.comANSerList.Text = "제목";
            // 
            // txtANInput
            // 
            this.txtANInput.Location = new System.Drawing.Point(685, 67);
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
            this.btnANListFind.Location = new System.Drawing.Point(943, 67);
            this.btnANListFind.Name = "btnANListFind";
            this.btnANListFind.Size = new System.Drawing.Size(75, 20);
            this.btnANListFind.TabIndex = 31;
            this.btnANListFind.Text = "검 색";
            this.btnANListFind.UseVisualStyleBackColor = false;
            // 
            // btnANDel
            // 
            this.btnANDel.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnANDel.Location = new System.Drawing.Point(968, 511);
            this.btnANDel.Name = "btnANDel";
            this.btnANDel.Size = new System.Drawing.Size(92, 30);
            this.btnANDel.TabIndex = 30;
            this.btnANDel.Text = "삭제";
            this.btnANDel.UseVisualStyleBackColor = true;
            // 
            // btnANModi
            // 
            this.btnANModi.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnANModi.Location = new System.Drawing.Point(868, 511);
            this.btnANModi.Name = "btnANModi";
            this.btnANModi.Size = new System.Drawing.Size(92, 30);
            this.btnANModi.TabIndex = 29;
            this.btnANModi.Text = "수정";
            this.btnANModi.UseVisualStyleBackColor = true;
            // 
            // btnANAdd
            // 
            this.btnANAdd.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnANAdd.Location = new System.Drawing.Point(768, 511);
            this.btnANAdd.Name = "btnANAdd";
            this.btnANAdd.Size = new System.Drawing.Size(92, 30);
            this.btnANAdd.TabIndex = 28;
            this.btnANAdd.Text = "추가";
            this.btnANAdd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gulim", 15F);
            this.label2.Location = new System.Drawing.Point(247, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "공지사항";
            // 
            // lbANNoticeView
            // 
            this.lbANNoticeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbANNoticeView.Location = new System.Drawing.Point(53, 90);
            this.lbANNoticeView.Name = "lbANNoticeView";
            this.lbANNoticeView.Size = new System.Drawing.Size(480, 451);
            this.lbANNoticeView.TabIndex = 35;
            this.lbANNoticeView.Text = "공지사항 내용";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnLFMax, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLFMin, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLFClose, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-3, -3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1118, 35);
            this.tableLayoutPanel1.TabIndex = 131;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plnAM_MouseDown);
            this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plnAM_MouseMove);
            this.tableLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plnAM_MouseUp);
            // 
            // btnLFMax
            // 
            this.btnLFMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLFMax.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLFMax.FlatAppearance.BorderSize = 0;
            this.btnLFMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLFMax.Font = new System.Drawing.Font("Gulim", 10F);
            this.btnLFMax.Location = new System.Drawing.Point(1068, 6);
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
            this.btnLFMin.Location = new System.Drawing.Point(1042, 6);
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
            this.btnLFClose.Font = new System.Drawing.Font("Gulim", 10F);
            this.btnLFClose.Location = new System.Drawing.Point(1095, 6);
            this.btnLFClose.Name = "btnLFClose";
            this.btnLFClose.Size = new System.Drawing.Size(20, 20);
            this.btnLFClose.TabIndex = 1;
            this.btnLFClose.Text = "🗙";
            this.btnLFClose.UseVisualStyleBackColor = false;
            this.btnLFClose.Click += new System.EventHandler(this.btnLFClose_Click);
            // 
            // AdminNoticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1112, 553);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbANNoticeView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comANSerList);
            this.Controls.Add(this.txtANInput);
            this.Controls.Add(this.btnANListFind);
            this.Controls.Add(this.btnANDel);
            this.Controls.Add(this.btnANModi);
            this.Controls.Add(this.btnANAdd);
            this.Controls.Add(this.lvANList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminNoticeForm";
            this.Text = "공지사항";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvANList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox comANSerList;
        private System.Windows.Forms.TextBox txtANInput;
        private System.Windows.Forms.Button btnANListFind;
        private System.Windows.Forms.Button btnANDel;
        private System.Windows.Forms.Button btnANModi;
        private System.Windows.Forms.Button btnANAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbANNoticeView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnLFMax;
        private System.Windows.Forms.Button btnLFMin;
        private System.Windows.Forms.Button btnLFClose;
    }
}
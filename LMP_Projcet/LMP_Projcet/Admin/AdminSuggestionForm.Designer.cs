
namespace LMP_Projcet.Admin
{
    partial class AdminSuggestionForm
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
            System.Windows.Forms.ColumnHeader columnHeader2;
            System.Windows.Forms.ColumnHeader columnHeader3;
            System.Windows.Forms.ColumnHeader columnHeader4;
            this.comASSerList = new System.Windows.Forms.ComboBox();
            this.txtASInput = new System.Windows.Forms.TextBox();
            this.btnASDel = new System.Windows.Forms.Button();
            this.btnASListFind = new System.Windows.Forms.Button();
            this.lvASList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.lbASContent = new System.Windows.Forms.Label();
            this.lbASTitle = new System.Windows.Forms.Label();
            this.lbASday = new System.Windows.Forms.Label();
            this.lbASRealday = new System.Windows.Forms.Label();
            this.lbASWriter = new System.Windows.Forms.Label();
            this.lbASRealWriter = new System.Windows.Forms.Label();
            this.txtASTitleView = new System.Windows.Forms.TextBox();
            this.txtASContentView = new System.Windows.Forms.TextBox();
            this.plnAM = new System.Windows.Forms.TableLayoutPanel();
            this.btnLFClose = new System.Windows.Forms.Button();
            this.btnLFMax = new System.Windows.Forms.Button();
            this.btnLFMin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.plnAM.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "제목";
            columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader2.Width = 237;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "날짜";
            columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader3.Width = 105;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "작성자";
            columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader4.Width = 98;
            // 
            // comASSerList
            // 
            this.comASSerList.FormattingEnabled = true;
            this.comASSerList.Location = new System.Drawing.Point(558, 67);
            this.comASSerList.Name = "comASSerList";
            this.comASSerList.Size = new System.Drawing.Size(121, 20);
            this.comASSerList.TabIndex = 33;
            this.comASSerList.Text = "제목";
            // 
            // txtASInput
            // 
            this.txtASInput.Location = new System.Drawing.Point(685, 67);
            this.txtASInput.Multiline = true;
            this.txtASInput.Name = "txtASInput";
            this.txtASInput.Size = new System.Drawing.Size(252, 20);
            this.txtASInput.TabIndex = 32;
            // 
            // btnASDel
            // 
            this.btnASDel.BackColor = System.Drawing.Color.Gray;
            this.btnASDel.FlatAppearance.BorderSize = 0;
            this.btnASDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnASDel.ForeColor = System.Drawing.Color.White;
            this.btnASDel.Location = new System.Drawing.Point(1006, 516);
            this.btnASDel.Name = "btnASDel";
            this.btnASDel.Size = new System.Drawing.Size(75, 25);
            this.btnASDel.TabIndex = 30;
            this.btnASDel.Text = "삭 제";
            this.btnASDel.UseVisualStyleBackColor = false;
            this.btnASDel.Click += new System.EventHandler(this.btnASDel_Click);
            // 
            // btnASListFind
            // 
            this.btnASListFind.BackColor = System.Drawing.Color.Gray;
            this.btnASListFind.FlatAppearance.BorderSize = 0;
            this.btnASListFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnASListFind.ForeColor = System.Drawing.Color.White;
            this.btnASListFind.Location = new System.Drawing.Point(943, 67);
            this.btnASListFind.Name = "btnASListFind";
            this.btnASListFind.Size = new System.Drawing.Size(75, 20);
            this.btnASListFind.TabIndex = 31;
            this.btnASListFind.Text = "검 색";
            this.btnASListFind.UseVisualStyleBackColor = false;
            this.btnASListFind.Click += new System.EventHandler(this.btnASListFind_Click);
            // 
            // lvASList
            // 
            this.lvASList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            columnHeader2,
            columnHeader3,
            columnHeader4,
            this.columnHeader5});
            this.lvASList.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lvASList.GridLines = true;
            this.lvASList.HideSelection = false;
            this.lvASList.Location = new System.Drawing.Point(558, 93);
            this.lvASList.Name = "lvASList";
            this.lvASList.Size = new System.Drawing.Size(523, 412);
            this.lvASList.TabIndex = 29;
            this.lvASList.UseCompatibleStateImageBehavior = false;
            this.lvASList.View = System.Windows.Forms.View.Details;
            this.lvASList.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvASList_ColumnWidthChanging);
            this.lvASList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ItemSelect_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "번호";
            this.columnHeader1.Width = 62;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "건의내용";
            this.columnHeader5.Width = 102;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gulim", 15F);
            this.label2.Location = new System.Drawing.Point(222, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 132;
            this.label2.Text = "건의사항";
            // 
            // lbASContent
            // 
            this.lbASContent.AutoSize = true;
            this.lbASContent.Font = new System.Drawing.Font("Gulim", 15.75F);
            this.lbASContent.Location = new System.Drawing.Point(24, 212);
            this.lbASContent.Name = "lbASContent";
            this.lbASContent.Size = new System.Drawing.Size(59, 21);
            this.lbASContent.TabIndex = 134;
            this.lbASContent.Text = "내용:";
            // 
            // lbASTitle
            // 
            this.lbASTitle.AutoSize = true;
            this.lbASTitle.Font = new System.Drawing.Font("Gulim", 15.75F);
            this.lbASTitle.Location = new System.Drawing.Point(24, 114);
            this.lbASTitle.Name = "lbASTitle";
            this.lbASTitle.Size = new System.Drawing.Size(59, 21);
            this.lbASTitle.TabIndex = 135;
            this.lbASTitle.Text = "제목:";
            // 
            // lbASday
            // 
            this.lbASday.AutoSize = true;
            this.lbASday.Font = new System.Drawing.Font("Gulim", 15.75F);
            this.lbASday.Location = new System.Drawing.Point(85, 156);
            this.lbASday.Name = "lbASday";
            this.lbASday.Size = new System.Drawing.Size(59, 21);
            this.lbASday.TabIndex = 137;
            this.lbASday.Text = "날짜:";
            // 
            // lbASRealday
            // 
            this.lbASRealday.AutoSize = true;
            this.lbASRealday.Font = new System.Drawing.Font("Gulim", 15.75F);
            this.lbASRealday.Location = new System.Drawing.Point(139, 156);
            this.lbASRealday.Name = "lbASRealday";
            this.lbASRealday.Size = new System.Drawing.Size(101, 21);
            this.lbASRealday.TabIndex = 138;
            this.lbASRealday.Text = "날짜 출력";
            // 
            // lbASWriter
            // 
            this.lbASWriter.AutoSize = true;
            this.lbASWriter.Font = new System.Drawing.Font("Gulim", 15.75F);
            this.lbASWriter.Location = new System.Drawing.Point(310, 156);
            this.lbASWriter.Name = "lbASWriter";
            this.lbASWriter.Size = new System.Drawing.Size(80, 21);
            this.lbASWriter.TabIndex = 139;
            this.lbASWriter.Text = "작성자:";
            // 
            // lbASRealWriter
            // 
            this.lbASRealWriter.AutoSize = true;
            this.lbASRealWriter.Font = new System.Drawing.Font("Gulim", 15.75F);
            this.lbASRealWriter.Location = new System.Drawing.Point(396, 156);
            this.lbASRealWriter.Name = "lbASRealWriter";
            this.lbASRealWriter.Size = new System.Drawing.Size(52, 21);
            this.lbASRealWriter.TabIndex = 140;
            this.lbASRealWriter.Text = "이름";
            // 
            // txtASTitleView
            // 
            this.txtASTitleView.Location = new System.Drawing.Point(89, 108);
            this.txtASTitleView.Multiline = true;
            this.txtASTitleView.Name = "txtASTitleView";
            this.txtASTitleView.ReadOnly = true;
            this.txtASTitleView.Size = new System.Drawing.Size(417, 33);
            this.txtASTitleView.TabIndex = 141;
            // 
            // txtASContentView
            // 
            this.txtASContentView.Location = new System.Drawing.Point(89, 212);
            this.txtASContentView.Multiline = true;
            this.txtASContentView.Name = "txtASContentView";
            this.txtASContentView.ReadOnly = true;
            this.txtASContentView.Size = new System.Drawing.Size(417, 293);
            this.txtASContentView.TabIndex = 142;
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
            this.plnAM.Location = new System.Drawing.Point(-1, 0);
            this.plnAM.Name = "plnAM";
            this.plnAM.RowCount = 2;
            this.plnAM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.plnAM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.plnAM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.plnAM.Size = new System.Drawing.Size(1114, 35);
            this.plnAM.TabIndex = 143;
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
            this.btnLFClose.Location = new System.Drawing.Point(1091, 6);
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
            this.btnLFMax.Location = new System.Drawing.Point(1065, 6);
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
            this.btnLFMin.Location = new System.Drawing.Point(1037, 6);
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
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "건의함";
            // 
            // AdminSuggestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1112, 553);
            this.Controls.Add(this.plnAM);
            this.Controls.Add(this.txtASContentView);
            this.Controls.Add(this.txtASTitleView);
            this.Controls.Add(this.lbASRealWriter);
            this.Controls.Add(this.lbASWriter);
            this.Controls.Add(this.lbASRealday);
            this.Controls.Add(this.lbASday);
            this.Controls.Add(this.lbASTitle);
            this.Controls.Add(this.lbASContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comASSerList);
            this.Controls.Add(this.txtASInput);
            this.Controls.Add(this.btnASDel);
            this.Controls.Add(this.btnASListFind);
            this.Controls.Add(this.lvASList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminSuggestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminSuggestionForm";
            this.Load += new System.EventHandler(this.AdminSuggestionForm_Load);
            this.plnAM.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comASSerList;
        private System.Windows.Forms.TextBox txtASInput;
        private System.Windows.Forms.Button btnASDel;
        private System.Windows.Forms.Button btnASListFind;
        private System.Windows.Forms.ListView lvASList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbASContent;
        private System.Windows.Forms.Label lbASTitle;
        private System.Windows.Forms.Label lbASday;
        private System.Windows.Forms.Label lbASRealday;
        private System.Windows.Forms.Label lbASWriter;
        private System.Windows.Forms.Label lbASRealWriter;
        private System.Windows.Forms.TextBox txtASTitleView;
        private System.Windows.Forms.TextBox txtASContentView;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TableLayoutPanel plnAM;
        private System.Windows.Forms.Button btnLFClose;
        private System.Windows.Forms.Button btnLFMax;
        private System.Windows.Forms.Button btnLFMin;
        private System.Windows.Forms.Label label1;
    }
}
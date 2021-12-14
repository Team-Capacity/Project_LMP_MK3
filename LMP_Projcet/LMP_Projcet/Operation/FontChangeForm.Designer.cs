
namespace LibraryMgrProgram
{
    partial class FontChangeForm
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
            this.rdoFCBasic = new System.Windows.Forms.RadioButton();
            this.rdoFCSetting = new System.Windows.Forms.RadioButton();
            this.grpFCSetting = new System.Windows.Forms.GroupBox();
            this.picFCWhite = new System.Windows.Forms.PictureBox();
            this.picFCBlack = new System.Windows.Forms.PictureBox();
            this.rdoFCBlack = new System.Windows.Forms.RadioButton();
            this.rdoFCWhite = new System.Windows.Forms.RadioButton();
            this.lbFontTema = new System.Windows.Forms.Label();
            this.btnFCCancle = new System.Windows.Forms.Button();
            this.btnFCSetting = new System.Windows.Forms.Button();
            this.lstboxFCStylelist = new System.Windows.Forms.ListBox();
            this.lbFCStyle = new System.Windows.Forms.Label();
            this.cmbFCKo_Sel = new System.Windows.Forms.ComboBox();
            this.lbFCKorea = new System.Windows.Forms.Label();
            this.lbFCFontList = new System.Windows.Forms.Label();
            this.lstFCListChoice = new System.Windows.Forms.ListBox();
            this.lstboxFCSizelist = new System.Windows.Forms.ListBox();
            this.lbFCSize = new System.Windows.Forms.Label();
            this.cmbFCEn_Sel = new System.Windows.Forms.ComboBox();
            this.lbFCEnglish = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.plnFC = new System.Windows.Forms.TableLayoutPanel();
            this.btnFCClose = new System.Windows.Forms.Button();
            this.btnFCMax = new System.Windows.Forms.Button();
            this.btnFCMin = new System.Windows.Forms.Button();
            this.grpFCSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFCWhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFCBlack)).BeginInit();
            this.plnFC.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoFCBasic
            // 
            this.rdoFCBasic.AutoSize = true;
            this.rdoFCBasic.Location = new System.Drawing.Point(132, 117);
            this.rdoFCBasic.Name = "rdoFCBasic";
            this.rdoFCBasic.Size = new System.Drawing.Size(109, 16);
            this.rdoFCBasic.TabIndex = 43;
            this.rdoFCBasic.TabStop = true;
            this.rdoFCBasic.Text = "설정 안함(기본)";
            this.rdoFCBasic.UseVisualStyleBackColor = true;
            this.rdoFCBasic.CheckedChanged += new System.EventHandler(this.rdoFCBasic_CheckedChanged);
            // 
            // rdoFCSetting
            // 
            this.rdoFCSetting.AutoSize = true;
            this.rdoFCSetting.Location = new System.Drawing.Point(50, 117);
            this.rdoFCSetting.Name = "rdoFCSetting";
            this.rdoFCSetting.Size = new System.Drawing.Size(75, 16);
            this.rdoFCSetting.TabIndex = 42;
            this.rdoFCSetting.TabStop = true;
            this.rdoFCSetting.Text = "글꼴 설정";
            this.rdoFCSetting.UseVisualStyleBackColor = true;
            this.rdoFCSetting.CheckedChanged += new System.EventHandler(this.rdoFCSetting_CheckedChanged);
            // 
            // grpFCSetting
            // 
            this.grpFCSetting.BackColor = System.Drawing.SystemColors.Control;
            this.grpFCSetting.Controls.Add(this.picFCWhite);
            this.grpFCSetting.Controls.Add(this.picFCBlack);
            this.grpFCSetting.Controls.Add(this.rdoFCBlack);
            this.grpFCSetting.Controls.Add(this.rdoFCWhite);
            this.grpFCSetting.Controls.Add(this.lbFontTema);
            this.grpFCSetting.Controls.Add(this.btnFCCancle);
            this.grpFCSetting.Controls.Add(this.btnFCSetting);
            this.grpFCSetting.Controls.Add(this.lstboxFCStylelist);
            this.grpFCSetting.Controls.Add(this.lbFCStyle);
            this.grpFCSetting.Controls.Add(this.cmbFCKo_Sel);
            this.grpFCSetting.Controls.Add(this.lbFCKorea);
            this.grpFCSetting.Controls.Add(this.lbFCFontList);
            this.grpFCSetting.Controls.Add(this.lstFCListChoice);
            this.grpFCSetting.Location = new System.Drawing.Point(41, 139);
            this.grpFCSetting.Name = "grpFCSetting";
            this.grpFCSetting.Size = new System.Drawing.Size(956, 325);
            this.grpFCSetting.TabIndex = 41;
            this.grpFCSetting.TabStop = false;
            this.grpFCSetting.Text = "글꼴/색상";
            // 
            // picFCWhite
            // 
            this.picFCWhite.BackColor = System.Drawing.Color.White;
            this.picFCWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFCWhite.Location = new System.Drawing.Point(424, 79);
            this.picFCWhite.Name = "picFCWhite";
            this.picFCWhite.Size = new System.Drawing.Size(101, 109);
            this.picFCWhite.TabIndex = 18;
            this.picFCWhite.TabStop = false;
            // 
            // picFCBlack
            // 
            this.picFCBlack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.picFCBlack.Location = new System.Drawing.Point(630, 79);
            this.picFCBlack.Name = "picFCBlack";
            this.picFCBlack.Size = new System.Drawing.Size(101, 109);
            this.picFCBlack.TabIndex = 17;
            this.picFCBlack.TabStop = false;
            // 
            // rdoFCBlack
            // 
            this.rdoFCBlack.AutoSize = true;
            this.rdoFCBlack.Location = new System.Drawing.Point(637, 203);
            this.rdoFCBlack.Name = "rdoFCBlack";
            this.rdoFCBlack.Size = new System.Drawing.Size(87, 16);
            this.rdoFCBlack.TabIndex = 16;
            this.rdoFCBlack.TabStop = true;
            this.rdoFCBlack.Text = "어두운 테마";
            this.rdoFCBlack.UseVisualStyleBackColor = true;
            // 
            // rdoFCWhite
            // 
            this.rdoFCWhite.AutoSize = true;
            this.rdoFCWhite.Location = new System.Drawing.Point(420, 203);
            this.rdoFCWhite.Name = "rdoFCWhite";
            this.rdoFCWhite.Size = new System.Drawing.Size(109, 16);
            this.rdoFCWhite.TabIndex = 15;
            this.rdoFCWhite.TabStop = true;
            this.rdoFCWhite.Text = "밝은 테마(기본)";
            this.rdoFCWhite.UseVisualStyleBackColor = true;
            // 
            // lbFontTema
            // 
            this.lbFontTema.AutoSize = true;
            this.lbFontTema.Location = new System.Drawing.Point(564, 34);
            this.lbFontTema.Name = "lbFontTema";
            this.lbFontTema.Size = new System.Drawing.Size(29, 12);
            this.lbFontTema.TabIndex = 14;
            this.lbFontTema.Text = "테마";
            // 
            // btnFCCancle
            // 
            this.btnFCCancle.Location = new System.Drawing.Point(581, 253);
            this.btnFCCancle.Name = "btnFCCancle";
            this.btnFCCancle.Size = new System.Drawing.Size(109, 23);
            this.btnFCCancle.TabIndex = 13;
            this.btnFCCancle.Text = "취소";
            this.btnFCCancle.UseVisualStyleBackColor = true;
            this.btnFCCancle.Click += new System.EventHandler(this.btnFCCancle_Click);
            // 
            // btnFCSetting
            // 
            this.btnFCSetting.Location = new System.Drawing.Point(466, 253);
            this.btnFCSetting.Name = "btnFCSetting";
            this.btnFCSetting.Size = new System.Drawing.Size(109, 23);
            this.btnFCSetting.TabIndex = 6;
            this.btnFCSetting.Text = "설정";
            this.btnFCSetting.UseVisualStyleBackColor = true;
            this.btnFCSetting.Click += new System.EventHandler(this.btnFCSetting_Click);
            // 
            // lstboxFCStylelist
            // 
            this.lstboxFCStylelist.FormattingEnabled = true;
            this.lstboxFCStylelist.ItemHeight = 12;
            this.lstboxFCStylelist.Items.AddRange(new object[] {
            "보통",
            "기울임꼴",
            "굵게",
            "굵은 기울임꼴"});
            this.lstboxFCStylelist.Location = new System.Drawing.Point(182, 110);
            this.lstboxFCStylelist.Name = "lstboxFCStylelist";
            this.lstboxFCStylelist.Size = new System.Drawing.Size(154, 136);
            this.lstboxFCStylelist.TabIndex = 7;
            // 
            // lbFCStyle
            // 
            this.lbFCStyle.AutoSize = true;
            this.lbFCStyle.Location = new System.Drawing.Point(180, 95);
            this.lbFCStyle.Name = "lbFCStyle";
            this.lbFCStyle.Size = new System.Drawing.Size(41, 12);
            this.lbFCStyle.TabIndex = 6;
            this.lbFCStyle.Text = "스타일";
            // 
            // cmbFCKo_Sel
            // 
            this.cmbFCKo_Sel.FormattingEnabled = true;
            this.cmbFCKo_Sel.Items.AddRange(new object[] {
            "궁서체",
            "굵은체",
            "나눔명조",
            "바탕체",
            "함초롱바탕",
            "나눔고딕",
            "돋움",
            "굴림체"});
            this.cmbFCKo_Sel.Location = new System.Drawing.Point(215, 62);
            this.cmbFCKo_Sel.Name = "cmbFCKo_Sel";
            this.cmbFCKo_Sel.Size = new System.Drawing.Size(121, 20);
            this.cmbFCKo_Sel.TabIndex = 3;
            // 
            // lbFCKorea
            // 
            this.lbFCKorea.AutoSize = true;
            this.lbFCKorea.Location = new System.Drawing.Point(180, 66);
            this.lbFCKorea.Name = "lbFCKorea";
            this.lbFCKorea.Size = new System.Drawing.Size(29, 12);
            this.lbFCKorea.TabIndex = 2;
            this.lbFCKorea.Text = "한글";
            // 
            // lbFCFontList
            // 
            this.lbFCFontList.AutoSize = true;
            this.lbFCFontList.Location = new System.Drawing.Point(16, 43);
            this.lbFCFontList.Name = "lbFCFontList";
            this.lbFCFontList.Size = new System.Drawing.Size(85, 12);
            this.lbFCFontList.TabIndex = 1;
            this.lbFCFontList.Text = "대표 글꼴 목록";
            // 
            // lstFCListChoice
            // 
            this.lstFCListChoice.FormattingEnabled = true;
            this.lstFCListChoice.ItemHeight = 12;
            this.lstFCListChoice.Items.AddRange(new object[] {
            "궁서체",
            "굵은체",
            "나눔명조",
            "바탕체",
            "함초롱바탕"});
            this.lstFCListChoice.Location = new System.Drawing.Point(18, 60);
            this.lstFCListChoice.Name = "lstFCListChoice";
            this.lstFCListChoice.Size = new System.Drawing.Size(124, 196);
            this.lstFCListChoice.TabIndex = 0;
            this.lstFCListChoice.SelectedIndexChanged += new System.EventHandler(this.lstFCListChoice_SelectedIndexChanged);
            // 
            // lstboxFCSizelist
            // 
            this.lstboxFCSizelist.FormattingEnabled = true;
            this.lstboxFCSizelist.ItemHeight = 12;
            this.lstboxFCSizelist.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12"});
            this.lstboxFCSizelist.Location = new System.Drawing.Point(500, 56);
            this.lstboxFCSizelist.Name = "lstboxFCSizelist";
            this.lstboxFCSizelist.Size = new System.Drawing.Size(27, 52);
            this.lstboxFCSizelist.TabIndex = 9;
            this.lstboxFCSizelist.SelectedIndexChanged += new System.EventHandler(this.lstboxFCSizelist_SelectedIndexChanged);
            // 
            // lbFCSize
            // 
            this.lbFCSize.AutoSize = true;
            this.lbFCSize.Location = new System.Drawing.Point(568, 57);
            this.lbFCSize.Name = "lbFCSize";
            this.lbFCSize.Size = new System.Drawing.Size(29, 12);
            this.lbFCSize.TabIndex = 8;
            this.lbFCSize.Text = "크기";
            // 
            // cmbFCEn_Sel
            // 
            this.cmbFCEn_Sel.FormattingEnabled = true;
            this.cmbFCEn_Sel.Location = new System.Drawing.Point(354, 72);
            this.cmbFCEn_Sel.Name = "cmbFCEn_Sel";
            this.cmbFCEn_Sel.Size = new System.Drawing.Size(121, 20);
            this.cmbFCEn_Sel.TabIndex = 5;
            // 
            // lbFCEnglish
            // 
            this.lbFCEnglish.AutoSize = true;
            this.lbFCEnglish.Location = new System.Drawing.Point(320, 76);
            this.lbFCEnglish.Name = "lbFCEnglish";
            this.lbFCEnglish.Size = new System.Drawing.Size(29, 12);
            this.lbFCEnglish.TabIndex = 4;
            this.lbFCEnglish.Text = "영문";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12"});
            this.comboBox1.Location = new System.Drawing.Point(570, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(30, 20);
            this.comboBox1.TabIndex = 19;
            // 
            // plnFC
            // 
            this.plnFC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plnFC.AutoSize = true;
            this.plnFC.BackColor = System.Drawing.Color.Silver;
            this.plnFC.ColumnCount = 4;
            this.plnFC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.plnFC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.plnFC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.plnFC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.plnFC.Controls.Add(this.btnFCClose, 3, 1);
            this.plnFC.Controls.Add(this.btnFCMax, 2, 1);
            this.plnFC.Controls.Add(this.btnFCMin, 1, 1);
            this.plnFC.ImeMode = System.Windows.Forms.ImeMode.On;
            this.plnFC.Location = new System.Drawing.Point(0, -3);
            this.plnFC.Name = "plnFC";
            this.plnFC.RowCount = 2;
            this.plnFC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.plnFC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.plnFC.Size = new System.Drawing.Size(1031, 39);
            this.plnFC.TabIndex = 150;
            this.plnFC.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plnFC_MouseDown);
            this.plnFC.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plnFC_MouseMove);
            this.plnFC.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plnFC_MouseUp);
            // 
            // btnFCClose
            // 
            this.btnFCClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFCClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFCClose.FlatAppearance.BorderSize = 0;
            this.btnFCClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFCClose.Font = new System.Drawing.Font("굴림", 10F);
            this.btnFCClose.Location = new System.Drawing.Point(1008, 6);
            this.btnFCClose.Name = "btnFCClose";
            this.btnFCClose.Size = new System.Drawing.Size(20, 20);
            this.btnFCClose.TabIndex = 1;
            this.btnFCClose.Text = "🗙";
            this.btnFCClose.UseVisualStyleBackColor = false;
            this.btnFCClose.Click += new System.EventHandler(this.btnFCClose_Click_1);
            // 
            // btnFCMax
            // 
            this.btnFCMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFCMax.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFCMax.FlatAppearance.BorderSize = 0;
            this.btnFCMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFCMax.Font = new System.Drawing.Font("굴림", 10F);
            this.btnFCMax.Location = new System.Drawing.Point(982, 6);
            this.btnFCMax.Name = "btnFCMax";
            this.btnFCMax.Size = new System.Drawing.Size(19, 20);
            this.btnFCMax.TabIndex = 3;
            this.btnFCMax.Text = "🗖";
            this.btnFCMax.UseVisualStyleBackColor = false;
            this.btnFCMax.Click += new System.EventHandler(this.btnFCMax_Click);
            // 
            // btnFCMin
            // 
            this.btnFCMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFCMin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFCMin.FlatAppearance.BorderSize = 0;
            this.btnFCMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFCMin.Font = new System.Drawing.Font("굴림", 10F);
            this.btnFCMin.Location = new System.Drawing.Point(954, 6);
            this.btnFCMin.Name = "btnFCMin";
            this.btnFCMin.Size = new System.Drawing.Size(20, 20);
            this.btnFCMin.TabIndex = 2;
            this.btnFCMin.Text = "🗕";
            this.btnFCMin.UseVisualStyleBackColor = false;
            this.btnFCMin.Click += new System.EventHandler(this.btnFCMin_Click_1);
            // 
            // FontChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1027, 561);
            this.Controls.Add(this.plnFC);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rdoFCBasic);
            this.Controls.Add(this.rdoFCSetting);
            this.Controls.Add(this.grpFCSetting);
            this.Controls.Add(this.lstboxFCSizelist);
            this.Controls.Add(this.lbFCSize);
            this.Controls.Add(this.cmbFCEn_Sel);
            this.Controls.Add(this.lbFCEnglish);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FontChangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Font";
            this.Load += new System.EventHandler(this.FontChangeForm_Load);
            this.grpFCSetting.ResumeLayout(false);
            this.grpFCSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFCWhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFCBlack)).EndInit();
            this.plnFC.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstboxFCSizelist;
        private System.Windows.Forms.Label lbFCSize;
        private System.Windows.Forms.Label lbFCStyle;
        private System.Windows.Forms.Label lbFCFontList;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox cmbFCEn_Sel;
        private System.Windows.Forms.Label lbFCEnglish;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.GroupBox grpFCSetting;
        public System.Windows.Forms.RadioButton rdoFCBasic;
        public System.Windows.Forms.RadioButton rdoFCSetting;
        public System.Windows.Forms.PictureBox picFCWhite;
        public System.Windows.Forms.PictureBox picFCBlack;
        public System.Windows.Forms.RadioButton rdoFCBlack;
        public System.Windows.Forms.RadioButton rdoFCWhite;
        public System.Windows.Forms.Label lbFontTema;
        public System.Windows.Forms.Button btnFCCancle;
        public System.Windows.Forms.Button btnFCSetting;
        public System.Windows.Forms.ListBox lstboxFCStylelist;
        public System.Windows.Forms.ComboBox cmbFCKo_Sel;
        public System.Windows.Forms.Label lbFCKorea;
        public System.Windows.Forms.ListBox lstFCListChoice;
        private System.Windows.Forms.TableLayoutPanel plnFC;
        private System.Windows.Forms.Button btnFCClose;
        private System.Windows.Forms.Button btnFCMax;
        private System.Windows.Forms.Button btnFCMin;
    }
}
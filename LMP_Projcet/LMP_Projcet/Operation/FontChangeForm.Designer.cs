
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
            this.btnFCCancle = new System.Windows.Forms.Button();
            this.btnFCSetting = new System.Windows.Forms.Button();
            this.cmbFCKo_Sel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.plnAM = new System.Windows.Forms.TableLayoutPanel();
            this.btnLFClose = new System.Windows.Forms.Button();
            this.btnLFMax = new System.Windows.Forms.Button();
            this.btnLFMin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFCKo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpFCSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFCWhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFCBlack)).BeginInit();
            this.plnAM.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoFCBasic
            // 
            this.rdoFCBasic.AutoSize = true;
            this.rdoFCBasic.Checked = true;
            this.rdoFCBasic.Font = new System.Drawing.Font("Gulim", 12F);
            this.rdoFCBasic.Location = new System.Drawing.Point(6, 20);
            this.rdoFCBasic.Name = "rdoFCBasic";
            this.rdoFCBasic.Size = new System.Drawing.Size(139, 20);
            this.rdoFCBasic.TabIndex = 43;
            this.rdoFCBasic.TabStop = true;
            this.rdoFCBasic.Text = "설정 안함(기본)";
            this.rdoFCBasic.UseVisualStyleBackColor = true;
            this.rdoFCBasic.CheckedChanged += new System.EventHandler(this.rdoFCBasic_CheckedChanged);
            // 
            // rdoFCSetting
            // 
            this.rdoFCSetting.AutoSize = true;
            this.rdoFCSetting.Font = new System.Drawing.Font("Gulim", 12F);
            this.rdoFCSetting.Location = new System.Drawing.Point(151, 20);
            this.rdoFCSetting.Name = "rdoFCSetting";
            this.rdoFCSetting.Size = new System.Drawing.Size(95, 20);
            this.rdoFCSetting.TabIndex = 42;
            this.rdoFCSetting.Text = "글꼴 설정";
            this.rdoFCSetting.UseVisualStyleBackColor = true;
            this.rdoFCSetting.CheckedChanged += new System.EventHandler(this.rdoFCSetting_CheckedChanged);
            // 
            // grpFCSetting
            // 
            this.grpFCSetting.BackColor = System.Drawing.SystemColors.Control;
            this.grpFCSetting.Controls.Add(this.groupBox2);
            this.grpFCSetting.Controls.Add(this.groupBox1);
            this.grpFCSetting.Controls.Add(this.label4);
            this.grpFCSetting.Controls.Add(this.cmbFCKo);
            this.grpFCSetting.Controls.Add(this.label3);
            this.grpFCSetting.Controls.Add(this.picFCWhite);
            this.grpFCSetting.Controls.Add(this.picFCBlack);
            this.grpFCSetting.Controls.Add(this.btnFCCancle);
            this.grpFCSetting.Controls.Add(this.btnFCSetting);
            this.grpFCSetting.Controls.Add(this.cmbFCKo_Sel);
            this.grpFCSetting.Controls.Add(this.label2);
            this.grpFCSetting.Location = new System.Drawing.Point(12, 49);
            this.grpFCSetting.Name = "grpFCSetting";
            this.grpFCSetting.Size = new System.Drawing.Size(552, 247);
            this.grpFCSetting.TabIndex = 41;
            this.grpFCSetting.TabStop = false;
            // 
            // picFCWhite
            // 
            this.picFCWhite.BackColor = System.Drawing.Color.White;
            this.picFCWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFCWhite.Location = new System.Drawing.Point(23, 36);
            this.picFCWhite.Name = "picFCWhite";
            this.picFCWhite.Size = new System.Drawing.Size(101, 109);
            this.picFCWhite.TabIndex = 18;
            this.picFCWhite.TabStop = false;
            // 
            // picFCBlack
            // 
            this.picFCBlack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.picFCBlack.Location = new System.Drawing.Point(158, 36);
            this.picFCBlack.Name = "picFCBlack";
            this.picFCBlack.Size = new System.Drawing.Size(101, 109);
            this.picFCBlack.TabIndex = 17;
            this.picFCBlack.TabStop = false;
            // 
            // rdoFCBlack
            // 
            this.rdoFCBlack.AutoSize = true;
            this.rdoFCBlack.Font = new System.Drawing.Font("Gulim", 12F);
            this.rdoFCBlack.Location = new System.Drawing.Point(151, 20);
            this.rdoFCBlack.Name = "rdoFCBlack";
            this.rdoFCBlack.Size = new System.Drawing.Size(111, 20);
            this.rdoFCBlack.TabIndex = 16;
            this.rdoFCBlack.Text = "어두운 테마";
            this.rdoFCBlack.UseVisualStyleBackColor = true;
            // 
            // rdoFCWhite
            // 
            this.rdoFCWhite.AutoSize = true;
            this.rdoFCWhite.Checked = true;
            this.rdoFCWhite.Font = new System.Drawing.Font("Gulim", 12F);
            this.rdoFCWhite.Location = new System.Drawing.Point(6, 20);
            this.rdoFCWhite.Name = "rdoFCWhite";
            this.rdoFCWhite.Size = new System.Drawing.Size(139, 20);
            this.rdoFCWhite.TabIndex = 15;
            this.rdoFCWhite.TabStop = true;
            this.rdoFCWhite.Text = "밝은 테마(기본)";
            this.rdoFCWhite.UseVisualStyleBackColor = true;
            // 
            // btnFCCancle
            // 
            this.btnFCCancle.Location = new System.Drawing.Point(432, 211);
            this.btnFCCancle.Name = "btnFCCancle";
            this.btnFCCancle.Size = new System.Drawing.Size(109, 23);
            this.btnFCCancle.TabIndex = 13;
            this.btnFCCancle.Text = "취소";
            this.btnFCCancle.UseVisualStyleBackColor = true;
            this.btnFCCancle.Click += new System.EventHandler(this.btnFCCancle_Click);
            // 
            // btnFCSetting
            // 
            this.btnFCSetting.Location = new System.Drawing.Point(317, 211);
            this.btnFCSetting.Name = "btnFCSetting";
            this.btnFCSetting.Size = new System.Drawing.Size(109, 23);
            this.btnFCSetting.TabIndex = 6;
            this.btnFCSetting.Text = "설정";
            this.btnFCSetting.UseVisualStyleBackColor = true;
            this.btnFCSetting.Click += new System.EventHandler(this.btnFCSetting_Click);
            // 
            // cmbFCKo_Sel
            // 
            this.cmbFCKo_Sel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmbFCKo_Sel.Location = new System.Drawing.Point(355, 54);
            this.cmbFCKo_Sel.Name = "cmbFCKo_Sel";
            this.cmbFCKo_Sel.Size = new System.Drawing.Size(131, 20);
            this.cmbFCKo_Sel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gulim", 12F);
            this.label2.Location = new System.Drawing.Point(309, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "글꼴";
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
            this.plnAM.Location = new System.Drawing.Point(-1, -3);
            this.plnAM.Name = "plnAM";
            this.plnAM.RowCount = 2;
            this.plnAM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.plnAM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.plnAM.Size = new System.Drawing.Size(575, 35);
            this.plnAM.TabIndex = 151;
            this.plnAM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plnFC_MouseDown);
            this.plnAM.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plnFC_MouseMove);
            this.plnAM.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plnFC_MouseUp);
            // 
            // btnLFClose
            // 
            this.btnLFClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLFClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLFClose.FlatAppearance.BorderSize = 0;
            this.btnLFClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLFClose.Font = new System.Drawing.Font("Gulim", 10F);
            this.btnLFClose.Location = new System.Drawing.Point(552, 6);
            this.btnLFClose.Name = "btnLFClose";
            this.btnLFClose.Size = new System.Drawing.Size(20, 20);
            this.btnLFClose.TabIndex = 1;
            this.btnLFClose.Text = "🗙";
            this.btnLFClose.UseVisualStyleBackColor = false;
            this.btnLFClose.Click += new System.EventHandler(this.btnFCClose_Click_1);
            // 
            // btnLFMax
            // 
            this.btnLFMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLFMax.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLFMax.FlatAppearance.BorderSize = 0;
            this.btnLFMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLFMax.Font = new System.Drawing.Font("Gulim", 10F);
            this.btnLFMax.Location = new System.Drawing.Point(526, 6);
            this.btnLFMax.Name = "btnLFMax";
            this.btnLFMax.Size = new System.Drawing.Size(19, 20);
            this.btnLFMax.TabIndex = 3;
            this.btnLFMax.Text = "🗖";
            this.btnLFMax.UseVisualStyleBackColor = false;
            this.btnLFMax.Click += new System.EventHandler(this.btnFCMax_Click);
            // 
            // btnLFMin
            // 
            this.btnLFMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLFMin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLFMin.FlatAppearance.BorderSize = 0;
            this.btnLFMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLFMin.Font = new System.Drawing.Font("Gulim", 10F);
            this.btnLFMin.Location = new System.Drawing.Point(498, 6);
            this.btnLFMin.Name = "btnLFMin";
            this.btnLFMin.Size = new System.Drawing.Size(20, 20);
            this.btnLFMin.TabIndex = 2;
            this.btnLFMin.Text = "🗕";
            this.btnLFMin.UseVisualStyleBackColor = false;
            this.btnLFMin.Click += new System.EventHandler(this.btnFCMin_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Font = new System.Drawing.Font("Gulim", 15F);
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "색상/글꼴";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gulim", 12F);
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "배경색";
            // 
            // cmbFCKo
            // 
            this.cmbFCKo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFCKo.FormattingEnabled = true;
            this.cmbFCKo.Items.AddRange(new object[] {
            "궁서체",
            "굵은체",
            "나눔명조",
            "바탕체",
            "함초롱바탕",
            "나눔고딕",
            "돋움",
            "굴림체"});
            this.cmbFCKo.Location = new System.Drawing.Point(355, 105);
            this.cmbFCKo.Name = "cmbFCKo";
            this.cmbFCKo.Size = new System.Drawing.Size(131, 20);
            this.cmbFCKo.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gulim", 12F);
            this.label4.Location = new System.Drawing.Point(309, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "형태";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoFCWhite);
            this.groupBox1.Controls.Add(this.rdoFCBlack);
            this.groupBox1.Location = new System.Drawing.Point(9, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 53);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoFCBasic);
            this.groupBox2.Controls.Add(this.rdoFCSetting);
            this.groupBox2.Location = new System.Drawing.Point(295, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 53);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            // 
            // FontChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(574, 308);
            this.Controls.Add(this.plnAM);
            this.Controls.Add(this.grpFCSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FontChangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Font";
            this.Load += new System.EventHandler(this.FontChangeForm_Load);
            this.grpFCSetting.ResumeLayout(false);
            this.grpFCSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFCWhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFCBlack)).EndInit();
            this.plnAM.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.GroupBox grpFCSetting;
        public System.Windows.Forms.RadioButton rdoFCBasic;
        public System.Windows.Forms.RadioButton rdoFCSetting;
        public System.Windows.Forms.PictureBox picFCWhite;
        public System.Windows.Forms.PictureBox picFCBlack;
        public System.Windows.Forms.RadioButton rdoFCBlack;
        public System.Windows.Forms.RadioButton rdoFCWhite;
        public System.Windows.Forms.Button btnFCCancle;
        public System.Windows.Forms.Button btnFCSetting;
        public System.Windows.Forms.ComboBox cmbFCKo_Sel;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel plnAM;
        private System.Windows.Forms.Button btnLFClose;
        private System.Windows.Forms.Button btnLFMax;
        private System.Windows.Forms.Button btnLFMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cmbFCKo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
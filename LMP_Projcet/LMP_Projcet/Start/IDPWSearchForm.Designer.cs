
namespace LibraryMgrProgram
{
    partial class IDPWSearchForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSerID = new System.Windows.Forms.GroupBox();
            this.btnSerOK = new System.Windows.Forms.Button();
            this.txtSerBir = new System.Windows.Forms.TextBox();
            this.txtSerPH = new System.Windows.Forms.TextBox();
            this.txtSerName = new System.Windows.Forms.TextBox();
            this.labSerBir = new System.Windows.Forms.Label();
            this.labSerHP = new System.Windows.Forms.Label();
            this.labSerName = new System.Windows.Forms.Label();
            this.grpSerPW = new System.Windows.Forms.GroupBox();
            this.btnSerPwOK = new System.Windows.Forms.Button();
            this.txtSerPwBir = new System.Windows.Forms.TextBox();
            this.txtSerPwName = new System.Windows.Forms.TextBox();
            this.txtSerID = new System.Windows.Forms.TextBox();
            this.labSerPwBir = new System.Windows.Forms.Label();
            this.labSerPwHP = new System.Windows.Forms.Label();
            this.labSerPwID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Ttse = new System.Windows.Forms.ToolTip(this.components);
            this.plnAM = new System.Windows.Forms.TableLayoutPanel();
            this.btnLFClose = new System.Windows.Forms.Button();
            this.btnLFMax = new System.Windows.Forms.Button();
            this.btnLFMin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grpSerID.SuspendLayout();
            this.grpSerPW.SuspendLayout();
            this.plnAM.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 15F);
            this.label1.Location = new System.Drawing.Point(17, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디 찾기";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpSerID
            // 
            this.grpSerID.Controls.Add(this.btnSerOK);
            this.grpSerID.Controls.Add(this.txtSerBir);
            this.grpSerID.Controls.Add(this.txtSerPH);
            this.grpSerID.Controls.Add(this.txtSerName);
            this.grpSerID.Controls.Add(this.labSerBir);
            this.grpSerID.Controls.Add(this.labSerHP);
            this.grpSerID.Controls.Add(this.labSerName);
            this.grpSerID.Controls.Add(this.label1);
            this.grpSerID.Location = new System.Drawing.Point(9, 173);
            this.grpSerID.Name = "grpSerID";
            this.grpSerID.Size = new System.Drawing.Size(374, 212);
            this.grpSerID.TabIndex = 1;
            this.grpSerID.TabStop = false;
            // 
            // btnSerOK
            // 
            this.btnSerOK.Font = new System.Drawing.Font("Gulim", 10F);
            this.btnSerOK.Location = new System.Drawing.Point(134, 156);
            this.btnSerOK.Name = "btnSerOK";
            this.btnSerOK.Size = new System.Drawing.Size(112, 30);
            this.btnSerOK.TabIndex = 4;
            this.btnSerOK.Text = "확인";
            this.btnSerOK.UseVisualStyleBackColor = true;
            this.btnSerOK.Click += new System.EventHandler(this.btnSerOK_Click);
            // 
            // txtSerBir
            // 
            this.txtSerBir.Location = new System.Drawing.Point(90, 116);
            this.txtSerBir.Name = "txtSerBir";
            this.txtSerBir.Size = new System.Drawing.Size(238, 21);
            this.txtSerBir.TabIndex = 3;
            // 
            // txtSerPH
            // 
            this.txtSerPH.Location = new System.Drawing.Point(90, 84);
            this.txtSerPH.Name = "txtSerPH";
            this.txtSerPH.Size = new System.Drawing.Size(238, 21);
            this.txtSerPH.TabIndex = 2;
            // 
            // txtSerName
            // 
            this.txtSerName.Location = new System.Drawing.Point(90, 51);
            this.txtSerName.Name = "txtSerName";
            this.txtSerName.Size = new System.Drawing.Size(238, 21);
            this.txtSerName.TabIndex = 1;
            // 
            // labSerBir
            // 
            this.labSerBir.AutoSize = true;
            this.labSerBir.Location = new System.Drawing.Point(19, 119);
            this.labSerBir.Name = "labSerBir";
            this.labSerBir.Size = new System.Drawing.Size(65, 12);
            this.labSerBir.TabIndex = 3;
            this.labSerBir.Text = "생년월일 : ";
            // 
            // labSerHP
            // 
            this.labSerHP.AutoSize = true;
            this.labSerHP.Location = new System.Drawing.Point(19, 87);
            this.labSerHP.Name = "labSerHP";
            this.labSerHP.Size = new System.Drawing.Size(65, 12);
            this.labSerHP.TabIndex = 2;
            this.labSerHP.Text = "전화번호 : ";
            // 
            // labSerName
            // 
            this.labSerName.AutoSize = true;
            this.labSerName.Location = new System.Drawing.Point(43, 54);
            this.labSerName.Name = "labSerName";
            this.labSerName.Size = new System.Drawing.Size(41, 12);
            this.labSerName.TabIndex = 1;
            this.labSerName.Text = "이름 : ";
            // 
            // grpSerPW
            // 
            this.grpSerPW.Controls.Add(this.btnSerPwOK);
            this.grpSerPW.Controls.Add(this.txtSerPwBir);
            this.grpSerPW.Controls.Add(this.txtSerPwName);
            this.grpSerPW.Controls.Add(this.txtSerID);
            this.grpSerPW.Controls.Add(this.labSerPwBir);
            this.grpSerPW.Controls.Add(this.labSerPwHP);
            this.grpSerPW.Controls.Add(this.labSerPwID);
            this.grpSerPW.Controls.Add(this.label5);
            this.grpSerPW.Location = new System.Drawing.Point(389, 173);
            this.grpSerPW.Name = "grpSerPW";
            this.grpSerPW.Size = new System.Drawing.Size(383, 212);
            this.grpSerPW.TabIndex = 7;
            this.grpSerPW.TabStop = false;
            // 
            // btnSerPwOK
            // 
            this.btnSerPwOK.Font = new System.Drawing.Font("Gulim", 10F);
            this.btnSerPwOK.Location = new System.Drawing.Point(134, 156);
            this.btnSerPwOK.Name = "btnSerPwOK";
            this.btnSerPwOK.Size = new System.Drawing.Size(112, 30);
            this.btnSerPwOK.TabIndex = 9;
            this.btnSerPwOK.Text = "확인";
            this.btnSerPwOK.UseVisualStyleBackColor = true;
            this.btnSerPwOK.Click += new System.EventHandler(this.btnSerPwOK_Click);
            // 
            // txtSerPwBir
            // 
            this.txtSerPwBir.Location = new System.Drawing.Point(90, 116);
            this.txtSerPwBir.Name = "txtSerPwBir";
            this.txtSerPwBir.Size = new System.Drawing.Size(238, 21);
            this.txtSerPwBir.TabIndex = 7;
            // 
            // txtSerPwName
            // 
            this.txtSerPwName.Location = new System.Drawing.Point(90, 84);
            this.txtSerPwName.Name = "txtSerPwName";
            this.txtSerPwName.Size = new System.Drawing.Size(238, 21);
            this.txtSerPwName.TabIndex = 6;
            // 
            // txtSerID
            // 
            this.txtSerID.Location = new System.Drawing.Point(90, 51);
            this.txtSerID.Name = "txtSerID";
            this.txtSerID.Size = new System.Drawing.Size(238, 21);
            this.txtSerID.TabIndex = 5;
            // 
            // labSerPwBir
            // 
            this.labSerPwBir.AutoSize = true;
            this.labSerPwBir.Location = new System.Drawing.Point(19, 119);
            this.labSerPwBir.Name = "labSerPwBir";
            this.labSerPwBir.Size = new System.Drawing.Size(65, 12);
            this.labSerPwBir.TabIndex = 3;
            this.labSerPwBir.Text = "생년월일 : ";
            // 
            // labSerPwHP
            // 
            this.labSerPwHP.AutoSize = true;
            this.labSerPwHP.Location = new System.Drawing.Point(43, 87);
            this.labSerPwHP.Name = "labSerPwHP";
            this.labSerPwHP.Size = new System.Drawing.Size(41, 12);
            this.labSerPwHP.TabIndex = 2;
            this.labSerPwHP.Text = "이름 : ";
            // 
            // labSerPwID
            // 
            this.labSerPwID.AutoSize = true;
            this.labSerPwID.Location = new System.Drawing.Point(31, 54);
            this.labSerPwID.Name = "labSerPwID";
            this.labSerPwID.Size = new System.Drawing.Size(53, 12);
            this.labSerPwID.TabIndex = 1;
            this.labSerPwID.Text = "아이디 : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gulim", 15F);
            this.label5.Location = new System.Drawing.Point(17, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "비밀번호 찾기";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.plnAM.Controls.Add(this.label2, 0, 1);
            this.plnAM.ImeMode = System.Windows.Forms.ImeMode.On;
            this.plnAM.Location = new System.Drawing.Point(-3, -2);
            this.plnAM.Name = "plnAM";
            this.plnAM.RowCount = 2;
            this.plnAM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.plnAM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.plnAM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.plnAM.Size = new System.Drawing.Size(788, 35);
            this.plnAM.TabIndex = 131;
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
            this.btnLFClose.Location = new System.Drawing.Point(765, 6);
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
            this.btnLFMax.Location = new System.Drawing.Point(739, 6);
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
            this.btnLFMin.Location = new System.Drawing.Point(711, 6);
            this.btnLFMin.Name = "btnLFMin";
            this.btnLFMin.Size = new System.Drawing.Size(20, 20);
            this.btnLFMin.TabIndex = 2;
            this.btnLFMin.Text = "🗕";
            this.btnLFMin.UseVisualStyleBackColor = false;
            this.btnLFMin.Click += new System.EventHandler(this.btnLFMin_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.Font = new System.Drawing.Font("Gulim", 15F);
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "계정 찾기";
            // 
            // IDPWSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.plnAM);
            this.Controls.Add(this.grpSerPW);
            this.Controls.Add(this.grpSerID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IDPWSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "아이디/비밀번호 찾기";
            this.Load += new System.EventHandler(this.IDPWSearchForm_Load);
            this.grpSerID.ResumeLayout(false);
            this.grpSerID.PerformLayout();
            this.grpSerPW.ResumeLayout(false);
            this.grpSerPW.PerformLayout();
            this.plnAM.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpSerID;
        private System.Windows.Forms.TextBox txtSerBir;
        private System.Windows.Forms.TextBox txtSerPH;
        private System.Windows.Forms.TextBox txtSerName;
        private System.Windows.Forms.Label labSerBir;
        private System.Windows.Forms.Label labSerHP;
        private System.Windows.Forms.Label labSerName;
        private System.Windows.Forms.Button btnSerOK;
        private System.Windows.Forms.GroupBox grpSerPW;
        private System.Windows.Forms.Button btnSerPwOK;
        private System.Windows.Forms.TextBox txtSerPwBir;
        private System.Windows.Forms.TextBox txtSerPwName;
        private System.Windows.Forms.TextBox txtSerID;
        private System.Windows.Forms.Label labSerPwBir;
        private System.Windows.Forms.Label labSerPwHP;
        private System.Windows.Forms.Label labSerPwID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip Ttse;
        private System.Windows.Forms.TableLayoutPanel plnAM;
        private System.Windows.Forms.Button btnLFClose;
        private System.Windows.Forms.Button btnLFMax;
        private System.Windows.Forms.Button btnLFMin;
        private System.Windows.Forms.Label label2;
    }
}
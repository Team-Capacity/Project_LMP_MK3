
namespace LMP_Projcet.Start
{
    partial class MemberAddForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMA_Address = new System.Windows.Forms.Label();
            this.txtAM_Address = new System.Windows.Forms.TextBox();
            this.lbMA_Join = new System.Windows.Forms.Label();
            this.btnMA_Cancel = new System.Windows.Forms.Button();
            this.btnMA_Join = new System.Windows.Forms.Button();
            this.grpcMA_Sex = new LMP_Projcet.Methods.GroupBoxBorderChagne();
            this.rdbMA_Wom = new System.Windows.Forms.RadioButton();
            this.rdbMA_Man = new System.Windows.Forms.RadioButton();
            this.lbMA_Name = new System.Windows.Forms.Label();
            this.lbMA_Sex = new System.Windows.Forms.Label();
            this.cmbMA_Day = new System.Windows.Forms.ComboBox();
            this.txtMA_Name = new System.Windows.Forms.TextBox();
            this.lbMA_Day = new System.Windows.Forms.Label();
            this.cmbMA_Year = new System.Windows.Forms.ComboBox();
            this.cmbMA_Month = new System.Windows.Forms.ComboBox();
            this.lbMA_Month = new System.Windows.Forms.Label();
            this.lbMA_Year = new System.Windows.Forms.Label();
            this.lbMA_Phone = new System.Windows.Forms.Label();
            this.btnMA_IdCheck = new System.Windows.Forms.Button();
            this.txtMA_PwCheck = new System.Windows.Forms.TextBox();
            this.txtMA_Pw = new System.Windows.Forms.TextBox();
            this.lbMA_Birth = new System.Windows.Forms.Label();
            this.lbMA_PwCheck = new System.Windows.Forms.Label();
            this.lbMA_Pw = new System.Windows.Forms.Label();
            this.txtMA_Id = new System.Windows.Forms.TextBox();
            this.lbMA_Id = new System.Windows.Forms.Label();
            this.txtMA_Phone = new System.Windows.Forms.TextBox();
            this.TtMA = new System.Windows.Forms.ToolTip(this.components);
            this.plnAM = new System.Windows.Forms.TableLayoutPanel();
            this.btnLFClose = new System.Windows.Forms.Button();
            this.btnLFMax = new System.Windows.Forms.Button();
            this.btnLFMin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpcMA_Sex.SuspendLayout();
            this.plnAM.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblMA_Address);
            this.groupBox1.Controls.Add(this.txtAM_Address);
            this.groupBox1.Controls.Add(this.lbMA_Join);
            this.groupBox1.Controls.Add(this.btnMA_Cancel);
            this.groupBox1.Controls.Add(this.btnMA_Join);
            this.groupBox1.Controls.Add(this.grpcMA_Sex);
            this.groupBox1.Controls.Add(this.lbMA_Name);
            this.groupBox1.Controls.Add(this.lbMA_Sex);
            this.groupBox1.Controls.Add(this.cmbMA_Day);
            this.groupBox1.Controls.Add(this.txtMA_Name);
            this.groupBox1.Controls.Add(this.lbMA_Day);
            this.groupBox1.Controls.Add(this.cmbMA_Year);
            this.groupBox1.Controls.Add(this.cmbMA_Month);
            this.groupBox1.Controls.Add(this.lbMA_Month);
            this.groupBox1.Controls.Add(this.lbMA_Year);
            this.groupBox1.Controls.Add(this.lbMA_Phone);
            this.groupBox1.Controls.Add(this.btnMA_IdCheck);
            this.groupBox1.Controls.Add(this.txtMA_PwCheck);
            this.groupBox1.Controls.Add(this.txtMA_Pw);
            this.groupBox1.Controls.Add(this.lbMA_Birth);
            this.groupBox1.Controls.Add(this.lbMA_PwCheck);
            this.groupBox1.Controls.Add(this.lbMA_Pw);
            this.groupBox1.Controls.Add(this.txtMA_Id);
            this.groupBox1.Controls.Add(this.lbMA_Id);
            this.groupBox1.Controls.Add(this.txtMA_Phone);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(108, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 452);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblMA_Address
            // 
            this.lblMA_Address.AutoSize = true;
            this.lblMA_Address.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMA_Address.Location = new System.Drawing.Point(105, 216);
            this.lblMA_Address.Name = "lblMA_Address";
            this.lblMA_Address.Size = new System.Drawing.Size(42, 16);
            this.lblMA_Address.TabIndex = 180;
            this.lblMA_Address.Text = "주소";
            // 
            // txtAM_Address
            // 
            this.txtAM_Address.Font = new System.Drawing.Font("Gulim", 12F);
            this.txtAM_Address.Location = new System.Drawing.Point(168, 213);
            this.txtAM_Address.Multiline = true;
            this.txtAM_Address.Name = "txtAM_Address";
            this.txtAM_Address.Size = new System.Drawing.Size(257, 25);
            this.txtAM_Address.TabIndex = 5;
            this.TtMA.SetToolTip(this.txtAM_Address, "시/도 구/군 면/동으로 작성해주세요 ex)서울특별시 강북구 미아동");
            // 
            // lbMA_Join
            // 
            this.lbMA_Join.AutoSize = true;
            this.lbMA_Join.Font = new System.Drawing.Font("Gulim", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbMA_Join.ForeColor = System.Drawing.Color.Black;
            this.lbMA_Join.Location = new System.Drawing.Point(81, 0);
            this.lbMA_Join.Name = "lbMA_Join";
            this.lbMA_Join.Size = new System.Drawing.Size(289, 27);
            this.lbMA_Join.TabIndex = 1;
            this.lbMA_Join.Text = "CAPA 도서관 회원가입";
            // 
            // btnMA_Cancel
            // 
            this.btnMA_Cancel.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMA_Cancel.Location = new System.Drawing.Point(249, 402);
            this.btnMA_Cancel.Name = "btnMA_Cancel";
            this.btnMA_Cancel.Size = new System.Drawing.Size(96, 36);
            this.btnMA_Cancel.TabIndex = 13;
            this.btnMA_Cancel.Text = "취소";
            this.btnMA_Cancel.UseVisualStyleBackColor = true;
            this.btnMA_Cancel.Click += new System.EventHandler(this.btnMA_Cancel_Click);
            // 
            // btnMA_Join
            // 
            this.btnMA_Join.Enabled = false;
            this.btnMA_Join.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMA_Join.Location = new System.Drawing.Point(95, 402);
            this.btnMA_Join.Name = "btnMA_Join";
            this.btnMA_Join.Size = new System.Drawing.Size(96, 36);
            this.btnMA_Join.TabIndex = 12;
            this.btnMA_Join.Text = "회원가입";
            this.btnMA_Join.UseVisualStyleBackColor = true;
            this.btnMA_Join.Click += new System.EventHandler(this.btnMA_Join_Click);
            // 
            // grpcMA_Sex
            // 
            this.grpcMA_Sex.BorderColor = System.Drawing.Color.White;
            this.grpcMA_Sex.Controls.Add(this.rdbMA_Wom);
            this.grpcMA_Sex.Controls.Add(this.rdbMA_Man);
            this.grpcMA_Sex.Location = new System.Drawing.Point(168, 293);
            this.grpcMA_Sex.Name = "grpcMA_Sex";
            this.grpcMA_Sex.Size = new System.Drawing.Size(122, 37);
            this.grpcMA_Sex.TabIndex = 166;
            this.grpcMA_Sex.TabStop = false;
            // 
            // rdbMA_Wom
            // 
            this.rdbMA_Wom.AutoSize = true;
            this.rdbMA_Wom.Font = new System.Drawing.Font("Gulim", 10F);
            this.rdbMA_Wom.Location = new System.Drawing.Point(63, 9);
            this.rdbMA_Wom.Name = "rdbMA_Wom";
            this.rdbMA_Wom.Size = new System.Drawing.Size(53, 18);
            this.rdbMA_Wom.TabIndex = 10;
            this.rdbMA_Wom.TabStop = true;
            this.rdbMA_Wom.Text = "여자";
            this.rdbMA_Wom.UseVisualStyleBackColor = true;
            // 
            // rdbMA_Man
            // 
            this.rdbMA_Man.AutoSize = true;
            this.rdbMA_Man.Font = new System.Drawing.Font("Gulim", 10F);
            this.rdbMA_Man.Location = new System.Drawing.Point(6, 10);
            this.rdbMA_Man.Name = "rdbMA_Man";
            this.rdbMA_Man.Size = new System.Drawing.Size(53, 18);
            this.rdbMA_Man.TabIndex = 9;
            this.rdbMA_Man.TabStop = true;
            this.rdbMA_Man.Text = "남자";
            this.rdbMA_Man.UseVisualStyleBackColor = true;
            // 
            // lbMA_Name
            // 
            this.lbMA_Name.AutoSize = true;
            this.lbMA_Name.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbMA_Name.Location = new System.Drawing.Point(105, 45);
            this.lbMA_Name.Name = "lbMA_Name";
            this.lbMA_Name.Size = new System.Drawing.Size(42, 16);
            this.lbMA_Name.TabIndex = 170;
            this.lbMA_Name.Text = "이름";
            // 
            // lbMA_Sex
            // 
            this.lbMA_Sex.AutoSize = true;
            this.lbMA_Sex.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbMA_Sex.Location = new System.Drawing.Point(105, 302);
            this.lbMA_Sex.Name = "lbMA_Sex";
            this.lbMA_Sex.Size = new System.Drawing.Size(42, 16);
            this.lbMA_Sex.TabIndex = 165;
            this.lbMA_Sex.Text = "성별";
            // 
            // cmbMA_Day
            // 
            this.cmbMA_Day.FormattingEnabled = true;
            this.cmbMA_Day.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbMA_Day.Location = new System.Drawing.Point(350, 256);
            this.cmbMA_Day.Name = "cmbMA_Day";
            this.cmbMA_Day.Size = new System.Drawing.Size(38, 20);
            this.cmbMA_Day.TabIndex = 8;
            // 
            // txtMA_Name
            // 
            this.txtMA_Name.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMA_Name.Location = new System.Drawing.Point(168, 42);
            this.txtMA_Name.Multiline = true;
            this.txtMA_Name.Name = "txtMA_Name";
            this.txtMA_Name.Size = new System.Drawing.Size(162, 25);
            this.txtMA_Name.TabIndex = 0;
            // 
            // lbMA_Day
            // 
            this.lbMA_Day.AutoSize = true;
            this.lbMA_Day.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbMA_Day.Location = new System.Drawing.Point(392, 256);
            this.lbMA_Day.Name = "lbMA_Day";
            this.lbMA_Day.Size = new System.Drawing.Size(28, 19);
            this.lbMA_Day.TabIndex = 176;
            this.lbMA_Day.Text = "일";
            // 
            // cmbMA_Year
            // 
            this.cmbMA_Year.FormattingEnabled = true;
            this.cmbMA_Year.Location = new System.Drawing.Point(168, 256);
            this.cmbMA_Year.Name = "cmbMA_Year";
            this.cmbMA_Year.Size = new System.Drawing.Size(72, 20);
            this.cmbMA_Year.TabIndex = 6;
            // 
            // cmbMA_Month
            // 
            this.cmbMA_Month.FormattingEnabled = true;
            this.cmbMA_Month.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbMA_Month.Location = new System.Drawing.Point(273, 256);
            this.cmbMA_Month.Name = "cmbMA_Month";
            this.cmbMA_Month.Size = new System.Drawing.Size(38, 20);
            this.cmbMA_Month.TabIndex = 7;
            // 
            // lbMA_Month
            // 
            this.lbMA_Month.AutoSize = true;
            this.lbMA_Month.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbMA_Month.Location = new System.Drawing.Point(312, 256);
            this.lbMA_Month.Name = "lbMA_Month";
            this.lbMA_Month.Size = new System.Drawing.Size(28, 19);
            this.lbMA_Month.TabIndex = 175;
            this.lbMA_Month.Text = "월";
            // 
            // lbMA_Year
            // 
            this.lbMA_Year.AutoSize = true;
            this.lbMA_Year.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbMA_Year.Location = new System.Drawing.Point(240, 256);
            this.lbMA_Year.Name = "lbMA_Year";
            this.lbMA_Year.Size = new System.Drawing.Size(28, 19);
            this.lbMA_Year.TabIndex = 174;
            this.lbMA_Year.Text = "년";
            // 
            // lbMA_Phone
            // 
            this.lbMA_Phone.AutoSize = true;
            this.lbMA_Phone.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbMA_Phone.Location = new System.Drawing.Point(71, 350);
            this.lbMA_Phone.Name = "lbMA_Phone";
            this.lbMA_Phone.Size = new System.Drawing.Size(76, 16);
            this.lbMA_Phone.TabIndex = 173;
            this.lbMA_Phone.Text = "휴대전화";
            // 
            // btnMA_IdCheck
            // 
            this.btnMA_IdCheck.Location = new System.Drawing.Point(350, 86);
            this.btnMA_IdCheck.Name = "btnMA_IdCheck";
            this.btnMA_IdCheck.Size = new System.Drawing.Size(75, 23);
            this.btnMA_IdCheck.TabIndex = 2;
            this.btnMA_IdCheck.Text = "중복확인";
            this.btnMA_IdCheck.UseVisualStyleBackColor = true;
            this.btnMA_IdCheck.Click += new System.EventHandler(this.btnMA_IdCheck_Click);
            // 
            // txtMA_PwCheck
            // 
            this.txtMA_PwCheck.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMA_PwCheck.Location = new System.Drawing.Point(168, 171);
            this.txtMA_PwCheck.Multiline = true;
            this.txtMA_PwCheck.Name = "txtMA_PwCheck";
            this.txtMA_PwCheck.Size = new System.Drawing.Size(162, 25);
            this.txtMA_PwCheck.TabIndex = 4;
            // 
            // txtMA_Pw
            // 
            this.txtMA_Pw.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMA_Pw.Location = new System.Drawing.Point(168, 129);
            this.txtMA_Pw.Multiline = true;
            this.txtMA_Pw.Name = "txtMA_Pw";
            this.txtMA_Pw.Size = new System.Drawing.Size(162, 25);
            this.txtMA_Pw.TabIndex = 3;
            this.TtMA.SetToolTip(this.txtMA_Pw, "특수문자+영문자+숫자로 이루어져야 하며 8자 이상이어야 합니다.");
            // 
            // lbMA_Birth
            // 
            this.lbMA_Birth.AutoSize = true;
            this.lbMA_Birth.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbMA_Birth.Location = new System.Drawing.Point(71, 256);
            this.lbMA_Birth.Name = "lbMA_Birth";
            this.lbMA_Birth.Size = new System.Drawing.Size(76, 16);
            this.lbMA_Birth.TabIndex = 172;
            this.lbMA_Birth.Text = "생년월일";
            // 
            // lbMA_PwCheck
            // 
            this.lbMA_PwCheck.AutoSize = true;
            this.lbMA_PwCheck.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbMA_PwCheck.Location = new System.Drawing.Point(31, 174);
            this.lbMA_PwCheck.Name = "lbMA_PwCheck";
            this.lbMA_PwCheck.Size = new System.Drawing.Size(116, 16);
            this.lbMA_PwCheck.TabIndex = 169;
            this.lbMA_PwCheck.Text = "비밀번호 확인";
            // 
            // lbMA_Pw
            // 
            this.lbMA_Pw.AutoSize = true;
            this.lbMA_Pw.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbMA_Pw.Location = new System.Drawing.Point(71, 132);
            this.lbMA_Pw.Name = "lbMA_Pw";
            this.lbMA_Pw.Size = new System.Drawing.Size(76, 16);
            this.lbMA_Pw.TabIndex = 168;
            this.lbMA_Pw.Text = "비밀번호";
            // 
            // txtMA_Id
            // 
            this.txtMA_Id.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMA_Id.Location = new System.Drawing.Point(168, 86);
            this.txtMA_Id.Multiline = true;
            this.txtMA_Id.Name = "txtMA_Id";
            this.txtMA_Id.Size = new System.Drawing.Size(162, 25);
            this.txtMA_Id.TabIndex = 1;
            // 
            // lbMA_Id
            // 
            this.lbMA_Id.AutoSize = true;
            this.lbMA_Id.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbMA_Id.Location = new System.Drawing.Point(88, 89);
            this.lbMA_Id.Name = "lbMA_Id";
            this.lbMA_Id.Size = new System.Drawing.Size(59, 16);
            this.lbMA_Id.TabIndex = 167;
            this.lbMA_Id.Text = "아이디";
            // 
            // txtMA_Phone
            // 
            this.txtMA_Phone.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMA_Phone.Location = new System.Drawing.Point(168, 347);
            this.txtMA_Phone.Multiline = true;
            this.txtMA_Phone.Name = "txtMA_Phone";
            this.txtMA_Phone.Size = new System.Drawing.Size(162, 25);
            this.txtMA_Phone.TabIndex = 11;
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
            this.plnAM.Location = new System.Drawing.Point(-6, -2);
            this.plnAM.Name = "plnAM";
            this.plnAM.RowCount = 2;
            this.plnAM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.plnAM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.plnAM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.plnAM.Size = new System.Drawing.Size(676, 35);
            this.plnAM.TabIndex = 132;
            this.plnAM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plnMA_MouseDown);
            this.plnAM.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plnMA_MouseMove);
            this.plnAM.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plnMA_MouseUp);
            // 
            // btnLFClose
            // 
            this.btnLFClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLFClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLFClose.FlatAppearance.BorderSize = 0;
            this.btnLFClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLFClose.Font = new System.Drawing.Font("Gulim", 10F);
            this.btnLFClose.Location = new System.Drawing.Point(653, 6);
            this.btnLFClose.Name = "btnLFClose";
            this.btnLFClose.Size = new System.Drawing.Size(20, 20);
            this.btnLFClose.TabIndex = 1;
            this.btnLFClose.Text = "🗙";
            this.btnLFClose.UseVisualStyleBackColor = false;
            this.btnLFClose.Click += new System.EventHandler(this.btnMAClose_Click);
            // 
            // btnLFMax
            // 
            this.btnLFMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLFMax.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLFMax.FlatAppearance.BorderSize = 0;
            this.btnLFMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLFMax.Font = new System.Drawing.Font("Gulim", 10F);
            this.btnLFMax.Location = new System.Drawing.Point(627, 6);
            this.btnLFMax.Name = "btnLFMax";
            this.btnLFMax.Size = new System.Drawing.Size(19, 20);
            this.btnLFMax.TabIndex = 3;
            this.btnLFMax.Text = "🗖";
            this.btnLFMax.UseVisualStyleBackColor = false;
            this.btnLFMax.Click += new System.EventHandler(this.btnMAMax_Click);
            // 
            // btnLFMin
            // 
            this.btnLFMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLFMin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLFMin.FlatAppearance.BorderSize = 0;
            this.btnLFMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLFMin.Font = new System.Drawing.Font("Gulim", 10F);
            this.btnLFMin.Location = new System.Drawing.Point(599, 6);
            this.btnLFMin.Name = "btnLFMin";
            this.btnLFMin.Size = new System.Drawing.Size(20, 20);
            this.btnLFMin.TabIndex = 2;
            this.btnLFMin.Text = "🗕";
            this.btnLFMin.UseVisualStyleBackColor = false;
            this.btnLFMin.Click += new System.EventHandler(this.btnMAMin_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.Font = new System.Drawing.Font("Gulim", 15F);
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "회원가입";
            // 
            // MemberAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(666, 520);
            this.Controls.Add(this.plnAM);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MemberAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberAddForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MemberAddForm_FormClosing);
            this.Load += new System.EventHandler(this.MemberAddForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpcMA_Sex.ResumeLayout(false);
            this.grpcMA_Sex.PerformLayout();
            this.plnAM.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbMA_Join;
        private System.Windows.Forms.Button btnMA_Cancel;
        private System.Windows.Forms.Button btnMA_Join;
        private Methods.GroupBoxBorderChagne grpcMA_Sex;
        private System.Windows.Forms.RadioButton rdbMA_Wom;
        private System.Windows.Forms.RadioButton rdbMA_Man;
        private System.Windows.Forms.Label lbMA_Name;
        private System.Windows.Forms.Label lbMA_Sex;
        private System.Windows.Forms.ComboBox cmbMA_Day;
        private System.Windows.Forms.TextBox txtMA_Name;
        private System.Windows.Forms.Label lbMA_Day;
        private System.Windows.Forms.ComboBox cmbMA_Year;
        private System.Windows.Forms.ComboBox cmbMA_Month;
        private System.Windows.Forms.Label lbMA_Month;
        private System.Windows.Forms.Label lbMA_Year;
        private System.Windows.Forms.Label lbMA_Phone;
        private System.Windows.Forms.Button btnMA_IdCheck;
        private System.Windows.Forms.TextBox txtMA_PwCheck;
        private System.Windows.Forms.TextBox txtMA_Pw;
        private System.Windows.Forms.Label lbMA_Birth;
        private System.Windows.Forms.Label lbMA_PwCheck;
        private System.Windows.Forms.Label lbMA_Pw;
        private System.Windows.Forms.TextBox txtMA_Id;
        private System.Windows.Forms.Label lbMA_Id;
        private System.Windows.Forms.TextBox txtMA_Phone;
        private System.Windows.Forms.ToolTip TtMA;
        private System.Windows.Forms.Label lblMA_Address;
        private System.Windows.Forms.TextBox txtAM_Address;
        private System.Windows.Forms.TableLayoutPanel plnAM;
        private System.Windows.Forms.Button btnLFClose;
        private System.Windows.Forms.Button btnLFMax;
        private System.Windows.Forms.Button btnLFMin;
        private System.Windows.Forms.Label label2;
    }
}
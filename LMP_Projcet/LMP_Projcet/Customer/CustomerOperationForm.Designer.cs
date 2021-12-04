
namespace LMP_Projcet.Customer
{
    partial class CustomerOperationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerOperationForm));
            this.grpCOColor = new System.Windows.Forms.GroupBox();
            this.lbCOColor = new System.Windows.Forms.Label();
            this.picCOColor = new System.Windows.Forms.PictureBox();
            this.grpCOSuggest = new System.Windows.Forms.GroupBox();
            this.lbCOSuggest = new System.Windows.Forms.Label();
            this.picCOSuggest = new System.Windows.Forms.PictureBox();
            this.grpCOBookInfo = new System.Windows.Forms.GroupBox();
            this.lbCONotice = new System.Windows.Forms.Label();
            this.picCONotice = new System.Windows.Forms.PictureBox();
            this.fDCO = new System.Windows.Forms.FontDialog();
            this.grpCOColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCOColor)).BeginInit();
            this.grpCOSuggest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCOSuggest)).BeginInit();
            this.grpCOBookInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCONotice)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCOColor
            // 
            this.grpCOColor.BackColor = System.Drawing.Color.White;
            this.grpCOColor.Controls.Add(this.lbCOColor);
            this.grpCOColor.Controls.Add(this.picCOColor);
            this.grpCOColor.Location = new System.Drawing.Point(858, 228);
            this.grpCOColor.Name = "grpCOColor";
            this.grpCOColor.Size = new System.Drawing.Size(210, 97);
            this.grpCOColor.TabIndex = 130;
            this.grpCOColor.TabStop = false;
        
            // 
            // lbCOColor
            // 
            this.lbCOColor.AutoSize = true;
            this.lbCOColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbCOColor.Font = new System.Drawing.Font("굴림", 20F);
            this.lbCOColor.Location = new System.Drawing.Point(57, 67);
            this.lbCOColor.Name = "lbCOColor";
            this.lbCOColor.Size = new System.Drawing.Size(131, 27);
            this.lbCOColor.TabIndex = 124;
            this.lbCOColor.Text = "색상/글꼴";
            this.lbCOColor.Click += new System.EventHandler(this.lbCOColor_Click);
            // 
            // picCOColor
            // 
            this.picCOColor.Image = ((System.Drawing.Image)(resources.GetObject("picCOColor.Image")));
            this.picCOColor.Location = new System.Drawing.Point(6, 20);
            this.picCOColor.Name = "picCOColor";
            this.picCOColor.Size = new System.Drawing.Size(100, 77);
            this.picCOColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCOColor.TabIndex = 125;
            this.picCOColor.TabStop = false;
            // 
            // grpCOSuggest
            // 
            this.grpCOSuggest.BackColor = System.Drawing.Color.White;
            this.grpCOSuggest.Controls.Add(this.lbCOSuggest);
            this.grpCOSuggest.Controls.Add(this.picCOSuggest);
            this.grpCOSuggest.Location = new System.Drawing.Point(577, 228);
            this.grpCOSuggest.Name = "grpCOSuggest";
            this.grpCOSuggest.Size = new System.Drawing.Size(210, 97);
            this.grpCOSuggest.TabIndex = 131;
            this.grpCOSuggest.TabStop = false;
            // 
            // lbCOSuggest
            // 
            this.lbCOSuggest.AutoSize = true;
            this.lbCOSuggest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbCOSuggest.Font = new System.Drawing.Font("굴림", 20F);
            this.lbCOSuggest.Location = new System.Drawing.Point(57, 70);
            this.lbCOSuggest.Name = "lbCOSuggest";
            this.lbCOSuggest.Size = new System.Drawing.Size(120, 27);
            this.lbCOSuggest.TabIndex = 127;
            this.lbCOSuggest.Text = "건의하기";
            this.lbCOSuggest.Click += new System.EventHandler(this.lbCOSuggest_Click);
            // 
            // picCOSuggest
            // 
            this.picCOSuggest.Image = ((System.Drawing.Image)(resources.GetObject("picCOSuggest.Image")));
            this.picCOSuggest.Location = new System.Drawing.Point(13, 20);
            this.picCOSuggest.Name = "picCOSuggest";
            this.picCOSuggest.Size = new System.Drawing.Size(100, 77);
            this.picCOSuggest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCOSuggest.TabIndex = 128;
            this.picCOSuggest.TabStop = false;
            // 
            // grpCOBookInfo
            // 
            this.grpCOBookInfo.BackColor = System.Drawing.Color.White;
            this.grpCOBookInfo.Controls.Add(this.lbCONotice);
            this.grpCOBookInfo.Controls.Add(this.picCONotice);
            this.grpCOBookInfo.Location = new System.Drawing.Point(308, 228);
            this.grpCOBookInfo.Name = "grpCOBookInfo";
            this.grpCOBookInfo.Size = new System.Drawing.Size(210, 97);
            this.grpCOBookInfo.TabIndex = 132;
            this.grpCOBookInfo.TabStop = false;
            // 
            // lbCONotice
            // 
            this.lbCONotice.AutoSize = true;
            this.lbCONotice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbCONotice.Font = new System.Drawing.Font("굴림", 20F);
            this.lbCONotice.Location = new System.Drawing.Point(63, 70);
            this.lbCONotice.Name = "lbCONotice";
            this.lbCONotice.Size = new System.Drawing.Size(120, 27);
            this.lbCONotice.TabIndex = 127;
            this.lbCONotice.Text = "공지사항";
            this.lbCONotice.Click += new System.EventHandler(this.lbCONotice_Click);
            // 
            // picCONotice
            // 
            this.picCONotice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picCONotice.Image = ((System.Drawing.Image)(resources.GetObject("picCONotice.Image")));
            this.picCONotice.Location = new System.Drawing.Point(13, 20);
            this.picCONotice.Name = "picCONotice";
            this.picCONotice.Size = new System.Drawing.Size(100, 77);
            this.picCONotice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCONotice.TabIndex = 128;
            this.picCONotice.TabStop = false;
            // 
            // CustomerOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1376, 553);
            this.Controls.Add(this.grpCOBookInfo);
            this.Controls.Add(this.grpCOColor);
            this.Controls.Add(this.grpCOSuggest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerOperationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerOperationForm";
            this.Load += new System.EventHandler(this.CustomerOperationForm_Load);
            this.grpCOColor.ResumeLayout(false);
            this.grpCOColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCOColor)).EndInit();
            this.grpCOSuggest.ResumeLayout(false);
            this.grpCOSuggest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCOSuggest)).EndInit();
            this.grpCOBookInfo.ResumeLayout(false);
            this.grpCOBookInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCONotice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCOColor;
        private System.Windows.Forms.Label lbCOColor;
        private System.Windows.Forms.PictureBox picCOColor;
        private System.Windows.Forms.GroupBox grpCOSuggest;
        private System.Windows.Forms.Label lbCOSuggest;
        private System.Windows.Forms.PictureBox picCOSuggest;
        private System.Windows.Forms.GroupBox grpCOBookInfo;
        private System.Windows.Forms.Label lbCONotice;
        private System.Windows.Forms.PictureBox picCONotice;
        private System.Windows.Forms.FontDialog fDCO;
    }
}
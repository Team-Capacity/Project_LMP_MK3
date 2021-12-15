
namespace LibraryMgrProgram.CustomerForm
{
    partial class CustomerContentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerContentsForm));
            this.lbCCBestBook = new System.Windows.Forms.Label();
            this.lbCCStatus = new System.Windows.Forms.Label();
            this.lbCCNotic = new System.Windows.Forms.Label();
            this.lbAuthor1 = new System.Windows.Forms.Label();
            this.picCCBookView2 = new System.Windows.Forms.PictureBox();
            this.picCCBookView1 = new System.Windows.Forms.PictureBox();
            this.picCCBookView0 = new System.Windows.Forms.PictureBox();
            this.dgvCCInfo = new System.Windows.Forms.DataGridView();
            this.lbCCBookName1 = new System.Windows.Forms.Label();
            this.lbAuthor3 = new System.Windows.Forms.Label();
            this.lbAuthor5 = new System.Windows.Forms.Label();
            this.lbCCBookName3 = new System.Windows.Forms.Label();
            this.lbCCBookName5 = new System.Windows.Forms.Label();
            this.lbCCNotice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCCBookView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCCBookView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCCBookView0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCCInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCCBestBook
            // 
            this.lbCCBestBook.AutoSize = true;
            this.lbCCBestBook.Font = new System.Drawing.Font("Gulim", 16F);
            this.lbCCBestBook.Location = new System.Drawing.Point(727, 36);
            this.lbCCBestBook.Name = "lbCCBestBook";
            this.lbCCBestBook.Size = new System.Drawing.Size(156, 22);
            this.lbCCBestBook.TabIndex = 29;
            this.lbCCBestBook.Text = "최근 등록 도서";
            // 
            // lbCCStatus
            // 
            this.lbCCStatus.AutoSize = true;
            this.lbCCStatus.BackColor = System.Drawing.Color.White;
            this.lbCCStatus.Font = new System.Drawing.Font("Gulim", 16F);
            this.lbCCStatus.Location = new System.Drawing.Point(727, 313);
            this.lbCCStatus.Name = "lbCCStatus";
            this.lbCCStatus.Size = new System.Drawing.Size(98, 22);
            this.lbCCStatus.TabIndex = 27;
            this.lbCCStatus.Text = "대출현황";
            // 
            // lbCCNotic
            // 
            this.lbCCNotic.AutoSize = true;
            this.lbCCNotic.BackColor = System.Drawing.Color.White;
            this.lbCCNotic.Font = new System.Drawing.Font("Gulim", 22F);
            this.lbCCNotic.Location = new System.Drawing.Point(256, 29);
            this.lbCCNotic.Name = "lbCCNotic";
            this.lbCCNotic.Size = new System.Drawing.Size(133, 30);
            this.lbCCNotic.TabIndex = 26;
            this.lbCCNotic.Text = "공지사항";
            // 
            // lbAuthor1
            // 
            this.lbAuthor1.AutoSize = true;
            this.lbAuthor1.Location = new System.Drawing.Point(736, 270);
            this.lbAuthor1.Name = "lbAuthor1";
            this.lbAuthor1.Size = new System.Drawing.Size(33, 12);
            this.lbAuthor1.TabIndex = 38;
            this.lbAuthor1.Text = "저자:";
            // 
            // picCCBookView2
            // 
            this.picCCBookView2.Image = ((System.Drawing.Image)(resources.GetObject("picCCBookView2.Image")));
            this.picCCBookView2.Location = new System.Drawing.Point(1119, 77);
            this.picCCBookView2.Name = "picCCBookView2";
            this.picCCBookView2.Size = new System.Drawing.Size(120, 135);
            this.picCCBookView2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCCBookView2.TabIndex = 34;
            this.picCCBookView2.TabStop = false;
            // 
            // picCCBookView1
            // 
            this.picCCBookView1.Image = ((System.Drawing.Image)(resources.GetObject("picCCBookView1.Image")));
            this.picCCBookView1.Location = new System.Drawing.Point(924, 77);
            this.picCCBookView1.Name = "picCCBookView1";
            this.picCCBookView1.Size = new System.Drawing.Size(120, 135);
            this.picCCBookView1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCCBookView1.TabIndex = 33;
            this.picCCBookView1.TabStop = false;
            // 
            // picCCBookView0
            // 
            this.picCCBookView0.Image = global::LMP_Projcet.Properties.Resources.ddoing1;
            this.picCCBookView0.Location = new System.Drawing.Point(738, 77);
            this.picCCBookView0.Name = "picCCBookView0";
            this.picCCBookView0.Size = new System.Drawing.Size(120, 135);
            this.picCCBookView0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCCBookView0.TabIndex = 32;
            this.picCCBookView0.TabStop = false;
            // 
            // dgvCCInfo
            // 
            this.dgvCCInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgvCCInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCCInfo.Location = new System.Drawing.Point(720, 338);
            this.dgvCCInfo.Name = "dgvCCInfo";
            this.dgvCCInfo.RowTemplate.Height = 23;
            this.dgvCCInfo.Size = new System.Drawing.Size(563, 203);
            this.dgvCCInfo.TabIndex = 42;
            // 
            // lbCCBookName1
            // 
            this.lbCCBookName1.AutoSize = true;
            this.lbCCBookName1.Location = new System.Drawing.Point(736, 226);
            this.lbCCBookName1.Name = "lbCCBookName1";
            this.lbCCBookName1.Size = new System.Drawing.Size(33, 12);
            this.lbCCBookName1.TabIndex = 43;
            this.lbCCBookName1.Text = "제목:";
            // 
            // lbAuthor3
            // 
            this.lbAuthor3.AutoSize = true;
            this.lbAuthor3.Location = new System.Drawing.Point(922, 270);
            this.lbAuthor3.Name = "lbAuthor3";
            this.lbAuthor3.Size = new System.Drawing.Size(33, 12);
            this.lbAuthor3.TabIndex = 45;
            this.lbAuthor3.Text = "저자:";
            // 
            // lbAuthor5
            // 
            this.lbAuthor5.AutoSize = true;
            this.lbAuthor5.Location = new System.Drawing.Point(1117, 270);
            this.lbAuthor5.Name = "lbAuthor5";
            this.lbAuthor5.Size = new System.Drawing.Size(33, 12);
            this.lbAuthor5.TabIndex = 46;
            this.lbAuthor5.Text = "저자:";
            // 
            // lbCCBookName3
            // 
            this.lbCCBookName3.AutoSize = true;
            this.lbCCBookName3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbCCBookName3.Location = new System.Drawing.Point(922, 226);
            this.lbCCBookName3.Name = "lbCCBookName3";
            this.lbCCBookName3.Size = new System.Drawing.Size(33, 12);
            this.lbCCBookName3.TabIndex = 47;
            this.lbCCBookName3.Text = "제목:";
            // 
            // lbCCBookName5
            // 
            this.lbCCBookName5.AutoSize = true;
            this.lbCCBookName5.Location = new System.Drawing.Point(1117, 226);
            this.lbCCBookName5.Name = "lbCCBookName5";
            this.lbCCBookName5.Size = new System.Drawing.Size(33, 12);
            this.lbCCBookName5.TabIndex = 48;
            this.lbCCBookName5.Text = "제목:";
            // 
            // lbCCNotice
            // 
            this.lbCCNotice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCCNotice.Location = new System.Drawing.Point(110, 59);
            this.lbCCNotice.Name = "lbCCNotice";
            this.lbCCNotice.Size = new System.Drawing.Size(442, 479);
            this.lbCCNotice.TabIndex = 49;
            // 
            // CustomerContentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1376, 553);
            this.Controls.Add(this.lbCCNotice);
            this.Controls.Add(this.lbCCBookName5);
            this.Controls.Add(this.lbCCBookName3);
            this.Controls.Add(this.lbAuthor5);
            this.Controls.Add(this.lbAuthor3);
            this.Controls.Add(this.lbCCBookName1);
            this.Controls.Add(this.lbAuthor1);
            this.Controls.Add(this.picCCBookView2);
            this.Controls.Add(this.picCCBookView1);
            this.Controls.Add(this.picCCBookView0);
            this.Controls.Add(this.lbCCBestBook);
            this.Controls.Add(this.lbCCStatus);
            this.Controls.Add(this.lbCCNotic);
            this.Controls.Add(this.dgvCCInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerContentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerContentsForm";
            this.Load += new System.EventHandler(this.CustomerContentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCCBookView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCCBookView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCCBookView0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCCInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCCBestBook;
        private System.Windows.Forms.Label lbCCStatus;
        private System.Windows.Forms.Label lbCCNotic;
        private System.Windows.Forms.PictureBox picCCBookView0;
        private System.Windows.Forms.PictureBox picCCBookView1;
        private System.Windows.Forms.PictureBox picCCBookView2;
        private System.Windows.Forms.Label lbAuthor1;
        private System.Windows.Forms.DataGridView dgvCCInfo;
        private System.Windows.Forms.Label lbCCBookName1;
        private System.Windows.Forms.Label lbAuthor3;
        private System.Windows.Forms.Label lbAuthor5;
        private System.Windows.Forms.Label lbCCBookName3;
        private System.Windows.Forms.Label lbCCBookName5;
        private System.Windows.Forms.Label lbCCNotice;
    }
}
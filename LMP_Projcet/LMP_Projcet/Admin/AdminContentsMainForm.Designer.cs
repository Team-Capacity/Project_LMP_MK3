
namespace LibraryMgrProgram.AdminForm
{
    partial class AdminContentsMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminContentsMainForm));
            this.lbACMNotic = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dgvACNotice = new System.Windows.Forms.DataGridView();
            this.picACMBookView0 = new System.Windows.Forms.PictureBox();
            this.picACMBookView1 = new System.Windows.Forms.PictureBox();
            this.picACMBookView2 = new System.Windows.Forms.PictureBox();
            this.lbACMBestBook = new System.Windows.Forms.Label();
            this.lbACMBookName0 = new System.Windows.Forms.Label();
            this.lbACMAuthor0 = new System.Windows.Forms.Label();
            this.lbACMAuthor1 = new System.Windows.Forms.Label();
            this.lbACMBookName1 = new System.Windows.Forms.Label();
            this.lbACMAuthor2 = new System.Windows.Forms.Label();
            this.lbACMBookName2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvACNotice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picACMBookView0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picACMBookView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picACMBookView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbACMNotic
            // 
            this.lbACMNotic.AutoSize = true;
            this.lbACMNotic.BackColor = System.Drawing.Color.White;
            this.lbACMNotic.Font = new System.Drawing.Font("Gulim", 22F);
            this.lbACMNotic.Location = new System.Drawing.Point(273, 28);
            this.lbACMNotic.Name = "lbACMNotic";
            this.lbACMNotic.Size = new System.Drawing.Size(133, 30);
            this.lbACMNotic.TabIndex = 19;
            this.lbACMNotic.Text = "공지사항";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Gulim", 16F);
            this.label2.Location = new System.Drawing.Point(727, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "메모";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(720, 338);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(550, 203);
            this.textBox2.TabIndex = 21;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvACNotice
            // 
            this.dgvACNotice.AllowUserToResizeColumns = false;
            this.dgvACNotice.AllowUserToResizeRows = false;
            this.dgvACNotice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvACNotice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvACNotice.BackgroundColor = System.Drawing.Color.White;
            this.dgvACNotice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvACNotice.Location = new System.Drawing.Point(132, 61);
            this.dgvACNotice.Name = "dgvACNotice";
            this.dgvACNotice.ReadOnly = true;
            this.dgvACNotice.RowTemplate.Height = 23;
            this.dgvACNotice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvACNotice.Size = new System.Drawing.Size(450, 479);
            this.dgvACNotice.TabIndex = 32;
            // 
            // picACMBookView0
            // 
            this.picACMBookView0.Image = ((System.Drawing.Image)(resources.GetObject("picACMBookView0.Image")));
            this.picACMBookView0.Location = new System.Drawing.Point(11, 20);
            this.picACMBookView0.Name = "picACMBookView0";
            this.picACMBookView0.Size = new System.Drawing.Size(120, 135);
            this.picACMBookView0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picACMBookView0.TabIndex = 33;
            this.picACMBookView0.TabStop = false;
            // 
            // picACMBookView1
            // 
            this.picACMBookView1.Image = ((System.Drawing.Image)(resources.GetObject("picACMBookView1.Image")));
            this.picACMBookView1.Location = new System.Drawing.Point(206, 20);
            this.picACMBookView1.Name = "picACMBookView1";
            this.picACMBookView1.Size = new System.Drawing.Size(120, 135);
            this.picACMBookView1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picACMBookView1.TabIndex = 34;
            this.picACMBookView1.TabStop = false;
            // 
            // picACMBookView2
            // 
            this.picACMBookView2.Image = ((System.Drawing.Image)(resources.GetObject("picACMBookView2.Image")));
            this.picACMBookView2.Location = new System.Drawing.Point(401, 20);
            this.picACMBookView2.Name = "picACMBookView2";
            this.picACMBookView2.Size = new System.Drawing.Size(120, 135);
            this.picACMBookView2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picACMBookView2.TabIndex = 35;
            this.picACMBookView2.TabStop = false;
            // 
            // lbACMBestBook
            // 
            this.lbACMBestBook.AutoSize = true;
            this.lbACMBestBook.BackColor = System.Drawing.Color.White;
            this.lbACMBestBook.Font = new System.Drawing.Font("Gulim", 16F);
            this.lbACMBestBook.Location = new System.Drawing.Point(716, 53);
            this.lbACMBestBook.Name = "lbACMBestBook";
            this.lbACMBestBook.Size = new System.Drawing.Size(156, 22);
            this.lbACMBestBook.TabIndex = 36;
            this.lbACMBestBook.Text = "최근 등록 도서";
            // 
            // lbACMBookName0
            // 
            this.lbACMBookName0.AutoSize = true;
            this.lbACMBookName0.Location = new System.Drawing.Point(18, 169);
            this.lbACMBookName0.Name = "lbACMBookName0";
            this.lbACMBookName0.Size = new System.Drawing.Size(29, 12);
            this.lbACMBookName0.TabIndex = 37;
            this.lbACMBookName0.Text = "제목";
            // 
            // lbACMAuthor0
            // 
            this.lbACMAuthor0.AutoSize = true;
            this.lbACMAuthor0.Location = new System.Drawing.Point(18, 213);
            this.lbACMAuthor0.Name = "lbACMAuthor0";
            this.lbACMAuthor0.Size = new System.Drawing.Size(29, 12);
            this.lbACMAuthor0.TabIndex = 40;
            this.lbACMAuthor0.Text = "저자";
            // 
            // lbACMAuthor1
            // 
            this.lbACMAuthor1.AutoSize = true;
            this.lbACMAuthor1.Location = new System.Drawing.Point(213, 213);
            this.lbACMAuthor1.Name = "lbACMAuthor1";
            this.lbACMAuthor1.Size = new System.Drawing.Size(29, 12);
            this.lbACMAuthor1.TabIndex = 42;
            this.lbACMAuthor1.Text = "저자";
            // 
            // lbACMBookName1
            // 
            this.lbACMBookName1.AutoSize = true;
            this.lbACMBookName1.Location = new System.Drawing.Point(213, 169);
            this.lbACMBookName1.Name = "lbACMBookName1";
            this.lbACMBookName1.Size = new System.Drawing.Size(29, 12);
            this.lbACMBookName1.TabIndex = 41;
            this.lbACMBookName1.Text = "제목";
            // 
            // lbACMAuthor2
            // 
            this.lbACMAuthor2.AutoSize = true;
            this.lbACMAuthor2.Location = new System.Drawing.Point(408, 213);
            this.lbACMAuthor2.Name = "lbACMAuthor2";
            this.lbACMAuthor2.Size = new System.Drawing.Size(29, 12);
            this.lbACMAuthor2.TabIndex = 44;
            this.lbACMAuthor2.Text = "저자";
            // 
            // lbACMBookName2
            // 
            this.lbACMBookName2.AutoSize = true;
            this.lbACMBookName2.Location = new System.Drawing.Point(408, 169);
            this.lbACMBookName2.Name = "lbACMBookName2";
            this.lbACMBookName2.Size = new System.Drawing.Size(29, 12);
            this.lbACMBookName2.TabIndex = 43;
            this.lbACMBookName2.Text = "제목";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picACMBookView2);
            this.groupBox1.Controls.Add(this.lbACMAuthor2);
            this.groupBox1.Controls.Add(this.picACMBookView0);
            this.groupBox1.Controls.Add(this.lbACMBookName2);
            this.groupBox1.Controls.Add(this.picACMBookView1);
            this.groupBox1.Controls.Add(this.lbACMAuthor1);
            this.groupBox1.Controls.Add(this.lbACMBookName1);
            this.groupBox1.Controls.Add(this.lbACMBookName0);
            this.groupBox1.Controls.Add(this.lbACMAuthor0);
            this.groupBox1.Location = new System.Drawing.Point(720, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 232);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            // 
            // AdminContentsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1376, 553);
            this.Controls.Add(this.lbACMBestBook);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbACMNotic);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dgvACNotice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminContentsMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminContentsForm";
            this.Load += new System.EventHandler(this.AdminContentsMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvACNotice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picACMBookView0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picACMBookView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picACMBookView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbACMNotic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dgvACNotice;
        private System.Windows.Forms.PictureBox picACMBookView0;
        private System.Windows.Forms.PictureBox picACMBookView1;
        private System.Windows.Forms.PictureBox picACMBookView2;
        private System.Windows.Forms.Label lbACMBestBook;
        private System.Windows.Forms.Label lbACMBookName0;
        private System.Windows.Forms.Label lbACMAuthor0;
        private System.Windows.Forms.Label lbACMAuthor1;
        private System.Windows.Forms.Label lbACMBookName1;
        private System.Windows.Forms.Label lbACMAuthor2;
        private System.Windows.Forms.Label lbACMBookName2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
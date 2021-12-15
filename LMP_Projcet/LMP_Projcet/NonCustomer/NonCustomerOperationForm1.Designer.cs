
namespace LMP_Projcet.NonCustomer
{
    partial class NonCustomerOperationForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NonCustomerOperationForm1));
            this.grpNCOBookInfo = new System.Windows.Forms.GroupBox();
            this.lbNCONotice = new System.Windows.Forms.Label();
            this.picNCONotice = new System.Windows.Forms.PictureBox();
            this.grpNCOColor = new System.Windows.Forms.GroupBox();
            this.lbNCOColor = new System.Windows.Forms.Label();
            this.picNCOColor = new System.Windows.Forms.PictureBox();
            this.grpNCOBookInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNCONotice)).BeginInit();
            this.grpNCOColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNCOColor)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNCOBookInfo
            // 
            this.grpNCOBookInfo.BackColor = System.Drawing.Color.White;
            this.grpNCOBookInfo.Controls.Add(this.lbNCONotice);
            this.grpNCOBookInfo.Controls.Add(this.picNCONotice);
            this.grpNCOBookInfo.Location = new System.Drawing.Point(440, 189);
            this.grpNCOBookInfo.Name = "grpNCOBookInfo";
            this.grpNCOBookInfo.Size = new System.Drawing.Size(210, 97);
            this.grpNCOBookInfo.TabIndex = 135;
            this.grpNCOBookInfo.TabStop = false;
            // 
            // lbNCONotice
            // 
            this.lbNCONotice.AutoSize = true;
            this.lbNCONotice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbNCONotice.Font = new System.Drawing.Font("Gulim", 20F);
            this.lbNCONotice.Location = new System.Drawing.Point(63, 70);
            this.lbNCONotice.Name = "lbNCONotice";
            this.lbNCONotice.Size = new System.Drawing.Size(120, 27);
            this.lbNCONotice.TabIndex = 127;
            this.lbNCONotice.Text = "공지사항";
            this.lbNCONotice.Click += new System.EventHandler(this.lbNCONotice_Click);
            // 
            // picNCONotice
            // 
            this.picNCONotice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picNCONotice.Image = ((System.Drawing.Image)(resources.GetObject("picNCONotice.Image")));
            this.picNCONotice.Location = new System.Drawing.Point(13, 20);
            this.picNCONotice.Name = "picNCONotice";
            this.picNCONotice.Size = new System.Drawing.Size(100, 77);
            this.picNCONotice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNCONotice.TabIndex = 128;
            this.picNCONotice.TabStop = false;
            // 
            // grpNCOColor
            // 
            this.grpNCOColor.BackColor = System.Drawing.Color.White;
            this.grpNCOColor.Controls.Add(this.lbNCOColor);
            this.grpNCOColor.Controls.Add(this.picNCOColor);
            this.grpNCOColor.Location = new System.Drawing.Point(709, 189);
            this.grpNCOColor.Name = "grpNCOColor";
            this.grpNCOColor.Size = new System.Drawing.Size(210, 97);
            this.grpNCOColor.TabIndex = 133;
            this.grpNCOColor.TabStop = false;
            // 
            // lbNCOColor
            // 
            this.lbNCOColor.AutoSize = true;
            this.lbNCOColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbNCOColor.Font = new System.Drawing.Font("Gulim", 20F);
            this.lbNCOColor.Location = new System.Drawing.Point(57, 67);
            this.lbNCOColor.Name = "lbNCOColor";
            this.lbNCOColor.Size = new System.Drawing.Size(131, 27);
            this.lbNCOColor.TabIndex = 124;
            this.lbNCOColor.Text = "색상/글꼴";
            this.lbNCOColor.Click += new System.EventHandler(this.lbNCOColor_Click);
            // 
            // picNCOColor
            // 
            this.picNCOColor.Image = ((System.Drawing.Image)(resources.GetObject("picNCOColor.Image")));
            this.picNCOColor.Location = new System.Drawing.Point(6, 20);
            this.picNCOColor.Name = "picNCOColor";
            this.picNCOColor.Size = new System.Drawing.Size(100, 77);
            this.picNCOColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNCOColor.TabIndex = 125;
            this.picNCOColor.TabStop = false;
            // 
            // NonCustomerOperationForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1376, 553);
            this.Controls.Add(this.grpNCOBookInfo);
            this.Controls.Add(this.grpNCOColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NonCustomerOperationForm1";
            this.Text = "NonCustomerOperationForm1";
            this.Load += new System.EventHandler(this.NonCustomerOperationForm1_Load);
            this.grpNCOBookInfo.ResumeLayout(false);
            this.grpNCOBookInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNCONotice)).EndInit();
            this.grpNCOColor.ResumeLayout(false);
            this.grpNCOColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNCOColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNCOBookInfo;
        private System.Windows.Forms.Label lbNCONotice;
        private System.Windows.Forms.PictureBox picNCONotice;
        private System.Windows.Forms.GroupBox grpNCOColor;
        private System.Windows.Forms.Label lbNCOColor;
        private System.Windows.Forms.PictureBox picNCOColor;
    }
}
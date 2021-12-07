
namespace LMP_Projcet.NonCustomer
{
    partial class NonCustomerOperationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NonCustomerOperationForm));
            this.grpNCOColor = new System.Windows.Forms.GroupBox();
            this.lbNCOColor = new System.Windows.Forms.Label();
            this.picNCOColor = new System.Windows.Forms.PictureBox();
            this.grpNCONotice = new System.Windows.Forms.GroupBox();
            this.lbNCONotice = new System.Windows.Forms.Label();
            this.picNCONotice = new System.Windows.Forms.PictureBox();
            this.grpNCOColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNCOColor)).BeginInit();
            this.grpNCONotice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNCONotice)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNCOColor
            // 
            this.grpNCOColor.BackColor = System.Drawing.Color.White;
            this.grpNCOColor.Controls.Add(this.lbNCOColor);
            this.grpNCOColor.Controls.Add(this.picNCOColor);
            this.grpNCOColor.Location = new System.Drawing.Point(614, 189);
            this.grpNCOColor.Name = "grpNCOColor";
            this.grpNCOColor.Size = new System.Drawing.Size(210, 97);
            this.grpNCOColor.TabIndex = 130;
            this.grpNCOColor.TabStop = false;
            this.grpNCOColor.Visible = false;
            // 
            // lbNCOColor
            // 
            this.lbNCOColor.AutoSize = true;
            this.lbNCOColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbNCOColor.Font = new System.Drawing.Font("굴림", 20F);
            this.lbNCOColor.Location = new System.Drawing.Point(57, 70);
            this.lbNCOColor.Name = "lbNCOColor";
            this.lbNCOColor.Size = new System.Drawing.Size(131, 27);
            this.lbNCOColor.TabIndex = 124;
            this.lbNCOColor.Text = "색상/글꼴";
            // 
            // picNCOColor
            // 
            this.picNCOColor.Image = ((System.Drawing.Image)(resources.GetObject("picNCOColor.Image")));
            this.picNCOColor.Location = new System.Drawing.Point(13, 20);
            this.picNCOColor.Name = "picNCOColor";
            this.picNCOColor.Size = new System.Drawing.Size(100, 77);
            this.picNCOColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNCOColor.TabIndex = 125;
            this.picNCOColor.TabStop = false;
            // 
            // grpNCONotice
            // 
            this.grpNCONotice.BackColor = System.Drawing.Color.White;
            this.grpNCONotice.Controls.Add(this.lbNCONotice);
            this.grpNCONotice.Controls.Add(this.picNCONotice);
            this.grpNCONotice.Location = new System.Drawing.Point(345, 189);
            this.grpNCONotice.Name = "grpNCONotice";
            this.grpNCONotice.Size = new System.Drawing.Size(210, 97);
            this.grpNCONotice.TabIndex = 132;
            this.grpNCONotice.TabStop = false;
            this.grpNCONotice.Visible = false;
            // 
            // lbNCONotice
            // 
            this.lbNCONotice.AutoSize = true;
            this.lbNCONotice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbNCONotice.Font = new System.Drawing.Font("굴림", 20F);
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
            // NonCustomerOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1376, 553);
            this.Controls.Add(this.grpNCOColor);
            this.Controls.Add(this.grpNCONotice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NonCustomerOperationForm";
            this.Text = "NonCustomerOperationForm";
            this.grpNCOColor.ResumeLayout(false);
            this.grpNCOColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNCOColor)).EndInit();
            this.grpNCONotice.ResumeLayout(false);
            this.grpNCONotice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNCONotice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNCOColor;
        private System.Windows.Forms.Label lbNCOColor;
        private System.Windows.Forms.PictureBox picNCOColor;
        private System.Windows.Forms.GroupBox grpNCONotice;
        private System.Windows.Forms.Label lbNCONotice;
        private System.Windows.Forms.PictureBox picNCONotice;
    }
}
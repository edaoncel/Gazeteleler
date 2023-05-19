namespace gazeteler
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.clgazeteler = new System.Windows.Forms.CheckedListBox();
            this.lblokunanalar = new System.Windows.Forms.ListBox();
            this.btnsec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clgazeteler
            // 
            this.clgazeteler.FormattingEnabled = true;
            this.clgazeteler.Items.AddRange(new object[] {
            "milliyet",
            "hürriyet",
            "sabah",
            "radikal",
            "posta",
            "fotomac",
            "fanatik",
            "tercüman"});
            this.clgazeteler.Location = new System.Drawing.Point(12, 12);
            this.clgazeteler.Name = "clgazeteler";
            this.clgazeteler.Size = new System.Drawing.Size(335, 372);
            this.clgazeteler.TabIndex = 0;
            // 
            // lblokunanalar
            // 
            this.lblokunanalar.FormattingEnabled = true;
            this.lblokunanalar.ItemHeight = 20;
            this.lblokunanalar.Location = new System.Drawing.Point(425, 12);
            this.lblokunanalar.Name = "lblokunanalar";
            this.lblokunanalar.Size = new System.Drawing.Size(340, 364);
            this.lblokunanalar.TabIndex = 1;
            // 
            // btnsec
            // 
            this.btnsec.Location = new System.Drawing.Point(320, 154);
            this.btnsec.Name = "btnsec";
            this.btnsec.Size = new System.Drawing.Size(134, 46);
            this.btnsec.TabIndex = 2;
            this.btnsec.Text = ">>";
            this.btnsec.UseVisualStyleBackColor = true;
            this.btnsec.Click += new System.EventHandler(this.btnsec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsec);
            this.Controls.Add(this.lblokunanalar);
            this.Controls.Add(this.clgazeteler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clgazeteler;
        private System.Windows.Forms.ListBox lblokunanalar;
        private System.Windows.Forms.Button btnsec;
    }
}


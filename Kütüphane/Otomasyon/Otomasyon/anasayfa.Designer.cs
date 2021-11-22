namespace Otomasyon
{
    partial class anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.kitapkayit = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.uyekayit = new System.Windows.Forms.Button();
            this.kitapkiralama = new System.Windows.Forms.Button();
            this.tumuye = new System.Windows.Forms.Button();
            this.tumkitap = new System.Windows.Forms.Button();
            this.tumkira = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1091, 100);
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // kitapkayit
            // 
            this.kitapkayit.BackColor = System.Drawing.Color.AntiqueWhite;
            this.kitapkayit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.kitapkayit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.kitapkayit.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapkayit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kitapkayit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.kitapkayit.ImageIndex = 0;
            this.kitapkayit.ImageList = this.ımageList1;
            this.kitapkayit.Location = new System.Drawing.Point(12, 132);
            this.kitapkayit.Name = "kitapkayit";
            this.kitapkayit.Size = new System.Drawing.Size(250, 150);
            this.kitapkayit.TabIndex = 50;
            this.kitapkayit.Text = "Kitap Kayıt İşlemleri";
            this.kitapkayit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kitapkayit.UseVisualStyleBackColor = false;
            this.kitapkayit.Click += new System.EventHandler(this.kitapkayit_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "kitapekle.png");
            this.ımageList1.Images.SetKeyName(1, "uyeekleme.png");
            this.ımageList1.Images.SetKeyName(2, "kiralama.png");
            this.ımageList1.Images.SetKeyName(3, "cikis.png");
            this.ımageList1.Images.SetKeyName(4, "tumuye.png");
            this.ımageList1.Images.SetKeyName(5, "tumkitap.png");
            this.ımageList1.Images.SetKeyName(6, "tumkiralama.png");
            // 
            // uyekayit
            // 
            this.uyekayit.BackColor = System.Drawing.Color.AntiqueWhite;
            this.uyekayit.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyekayit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uyekayit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.uyekayit.ImageIndex = 1;
            this.uyekayit.ImageList = this.ımageList1;
            this.uyekayit.Location = new System.Drawing.Point(291, 132);
            this.uyekayit.Name = "uyekayit";
            this.uyekayit.Size = new System.Drawing.Size(250, 150);
            this.uyekayit.TabIndex = 51;
            this.uyekayit.Text = "Üye Kayıt İşlemleri";
            this.uyekayit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.uyekayit.UseVisualStyleBackColor = false;
            this.uyekayit.Click += new System.EventHandler(this.uyekayit_Click);
            // 
            // kitapkiralama
            // 
            this.kitapkiralama.BackColor = System.Drawing.Color.AntiqueWhite;
            this.kitapkiralama.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapkiralama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kitapkiralama.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.kitapkiralama.ImageIndex = 2;
            this.kitapkiralama.ImageList = this.ımageList1;
            this.kitapkiralama.Location = new System.Drawing.Point(571, 132);
            this.kitapkiralama.Name = "kitapkiralama";
            this.kitapkiralama.Size = new System.Drawing.Size(250, 150);
            this.kitapkiralama.TabIndex = 52;
            this.kitapkiralama.Text = "Kitap Kiralama İşlemleri";
            this.kitapkiralama.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kitapkiralama.UseVisualStyleBackColor = false;
            this.kitapkiralama.Click += new System.EventHandler(this.kitapkiralama_Click);
            // 
            // tumuye
            // 
            this.tumuye.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tumuye.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tumuye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tumuye.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tumuye.ImageIndex = 4;
            this.tumuye.ImageList = this.ımageList1;
            this.tumuye.Location = new System.Drawing.Point(12, 299);
            this.tumuye.Name = "tumuye";
            this.tumuye.Size = new System.Drawing.Size(250, 150);
            this.tumuye.TabIndex = 53;
            this.tumuye.Text = "Tüm Üyeler";
            this.tumuye.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tumuye.UseVisualStyleBackColor = false;
            this.tumuye.Click += new System.EventHandler(this.tumuye_Click);
            // 
            // tumkitap
            // 
            this.tumkitap.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tumkitap.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tumkitap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tumkitap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tumkitap.ImageIndex = 5;
            this.tumkitap.ImageList = this.ımageList1;
            this.tumkitap.Location = new System.Drawing.Point(291, 299);
            this.tumkitap.Name = "tumkitap";
            this.tumkitap.Size = new System.Drawing.Size(250, 150);
            this.tumkitap.TabIndex = 54;
            this.tumkitap.Text = "Tüm Kitaplar";
            this.tumkitap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tumkitap.UseVisualStyleBackColor = false;
            this.tumkitap.Click += new System.EventHandler(this.tumkitap_Click);
            // 
            // tumkira
            // 
            this.tumkira.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tumkira.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tumkira.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tumkira.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tumkira.ImageIndex = 6;
            this.tumkira.ImageList = this.ımageList1;
            this.tumkira.Location = new System.Drawing.Point(571, 299);
            this.tumkira.Name = "tumkira";
            this.tumkira.Size = new System.Drawing.Size(250, 150);
            this.tumkira.TabIndex = 55;
            this.tumkira.Text = "Tüm Kiralama Bilgileri";
            this.tumkira.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tumkira.UseVisualStyleBackColor = false;
            this.tumkira.Click += new System.EventHandler(this.tumkira_Click);
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cikis.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cikis.ImageIndex = 3;
            this.cikis.ImageList = this.ımageList1;
            this.cikis.Location = new System.Drawing.Point(843, 132);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(220, 317);
            this.cikis.TabIndex = 56;
            this.cikis.Text = "Çıkış Yap";
            this.cikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.BackColor = System.Drawing.Color.Transparent;
            this.X.Font = new System.Drawing.Font("Arial Narrow", 15.25F, System.Drawing.FontStyle.Bold);
            this.X.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.X.Location = new System.Drawing.Point(1052, 9);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(23, 25);
            this.X.TabIndex = 57;
            this.X.Text = "X";
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.X);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.tumkira);
            this.Controls.Add(this.tumkitap);
            this.Controls.Add(this.tumuye);
            this.Controls.Add(this.kitapkiralama);
            this.Controls.Add(this.uyekayit);
            this.Controls.Add(this.kitapkayit);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "anasayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button kitapkayit;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button uyekayit;
        private System.Windows.Forms.Button kitapkiralama;
        private System.Windows.Forms.Button tumuye;
        private System.Windows.Forms.Button tumkitap;
        private System.Windows.Forms.Button tumkira;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Label X;
    }
}
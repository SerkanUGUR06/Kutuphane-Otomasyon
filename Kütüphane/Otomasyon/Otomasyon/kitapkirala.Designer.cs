namespace Otomasyon
{
    partial class kitapkirala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitapkirala));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kiralananki = new System.Windows.Forms.ComboBox();
            this.Kiralananuy = new System.Windows.Forms.ComboBox();
            this.kiragoster = new System.Windows.Forms.DataGridView();
            this.kiraekle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.kiraguncel = new System.Windows.Forms.Button();
            this.iptal = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.kitapara = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kimlik = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.datee = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiragoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1091, 100);
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(68, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 56;
            this.label7.Text = "Alım Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(55, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Teslim Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(53, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Kiralanan Üye :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(42, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Kiralanan Kitap :";
            // 
            // kiralananki
            // 
            this.kiralananki.FormattingEnabled = true;
            this.kiralananki.Location = new System.Drawing.Point(160, 229);
            this.kiralananki.Name = "kiralananki";
            this.kiralananki.Size = new System.Drawing.Size(160, 21);
            this.kiralananki.TabIndex = 57;
            // 
            // Kiralananuy
            // 
            this.Kiralananuy.FormattingEnabled = true;
            this.Kiralananuy.Location = new System.Drawing.Point(160, 265);
            this.Kiralananuy.Name = "Kiralananuy";
            this.Kiralananuy.Size = new System.Drawing.Size(160, 21);
            this.Kiralananuy.TabIndex = 58;
            // 
            // kiragoster
            // 
            this.kiragoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kiragoster.Location = new System.Drawing.Point(350, 198);
            this.kiragoster.Name = "kiragoster";
            this.kiragoster.Size = new System.Drawing.Size(722, 247);
            this.kiragoster.TabIndex = 61;
            this.kiragoster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kiragoster_CellClick);
            // 
            // kiraekle
            // 
            this.kiraekle.BackColor = System.Drawing.Color.AntiqueWhite;
            this.kiraekle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kiraekle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kiraekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kiraekle.ImageIndex = 2;
            this.kiraekle.ImageList = this.ımageList1;
            this.kiraekle.Location = new System.Drawing.Point(237, 380);
            this.kiraekle.Name = "kiraekle";
            this.kiraekle.Size = new System.Drawing.Size(105, 65);
            this.kiraekle.TabIndex = 64;
            this.kiraekle.Text = "Kiralama  Ekle";
            this.kiraekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kiraekle.UseVisualStyleBackColor = false;
            this.kiraekle.Click += new System.EventHandler(this.kiraekle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "iptal.png");
            this.ımageList1.Images.SetKeyName(1, "guncelle.png");
            this.ımageList1.Images.SetKeyName(2, "ekle.png");
            this.ımageList1.Images.SetKeyName(3, "silme.png");
            this.ımageList1.Images.SetKeyName(4, "kitap.png");
            // 
            // kiraguncel
            // 
            this.kiraguncel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.kiraguncel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kiraguncel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kiraguncel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kiraguncel.ImageIndex = 1;
            this.kiraguncel.ImageList = this.ımageList1;
            this.kiraguncel.Location = new System.Drawing.Point(126, 380);
            this.kiraguncel.Name = "kiraguncel";
            this.kiraguncel.Size = new System.Drawing.Size(105, 65);
            this.kiraguncel.TabIndex = 63;
            this.kiraguncel.Text = "Kiralama  Güncelle";
            this.kiraguncel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kiraguncel.UseVisualStyleBackColor = false;
            this.kiraguncel.Click += new System.EventHandler(this.kiraguncel_Click);
            // 
            // iptal
            // 
            this.iptal.BackColor = System.Drawing.Color.AntiqueWhite;
            this.iptal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iptal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iptal.ImageIndex = 0;
            this.iptal.ImageList = this.ımageList1;
            this.iptal.Location = new System.Drawing.Point(12, 380);
            this.iptal.Name = "iptal";
            this.iptal.Size = new System.Drawing.Size(105, 65);
            this.iptal.TabIndex = 62;
            this.iptal.Text = "İptal Et";
            this.iptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iptal.UseVisualStyleBackColor = false;
            this.iptal.Click += new System.EventHandler(this.iptal_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageIndex = 4;
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(961, 124);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 65);
            this.button4.TabIndex = 69;
            this.button4.Text = "Kitap     Teslim Al";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Otomasyon.Properties.Resources.arama1;
            this.pictureBox1.Location = new System.Drawing.Point(797, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(349, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 65;
            this.label8.Text = "Tüm Kiralar";
            // 
            // kitapara
            // 
            this.kitapara.BackColor = System.Drawing.SystemColors.Window;
            this.kitapara.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapara.Location = new System.Drawing.Point(643, 163);
            this.kitapara.Name = "kitapara";
            this.kitapara.Size = new System.Drawing.Size(148, 26);
            this.kitapara.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(500, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 70;
            this.label4.Text = "Kiralanan Kitap Ara :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(97, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 72;
            this.label5.Text = "Kimlik :";
            // 
            // kimlik
            // 
            this.kimlik.Enabled = false;
            this.kimlik.Location = new System.Drawing.Point(160, 199);
            this.kimlik.Name = "kimlik";
            this.kimlik.Size = new System.Drawing.Size(160, 20);
            this.kimlik.TabIndex = 73;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(160, 298);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(160, 20);
            this.date.TabIndex = 74;
            // 
            // datee
            // 
            this.datee.Location = new System.Drawing.Point(160, 334);
            this.datee.Name = "datee";
            this.datee.Size = new System.Drawing.Size(160, 20);
            this.datee.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(1049, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 25);
            this.label6.TabIndex = 76;
            this.label6.Text = "X";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 17.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(7, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 29);
            this.label10.TabIndex = 77;
            this.label10.Text = "<";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // kitapkirala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1081, 472);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.datee);
            this.Controls.Add(this.date);
            this.Controls.Add(this.kimlik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kitapara);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.kiraekle);
            this.Controls.Add(this.kiraguncel);
            this.Controls.Add(this.iptal);
            this.Controls.Add(this.kiragoster);
            this.Controls.Add(this.Kiralananuy);
            this.Controls.Add(this.kiralananki);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kitapkirala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kitapkirala";
            this.Load += new System.EventHandler(this.kitapkirala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiragoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox kiralananki;
        private System.Windows.Forms.ComboBox Kiralananuy;
        private System.Windows.Forms.DataGridView kiragoster;
        private System.Windows.Forms.Button kiraekle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button kiraguncel;
        private System.Windows.Forms.Button iptal;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox kitapara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kimlik;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.DateTimePicker datee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
    }
}
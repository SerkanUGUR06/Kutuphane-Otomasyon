namespace Otomasyon
{
    partial class tumkiralama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tumkiralama));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tümkira = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.kiraara = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.arabuton = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tümkira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabuton)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1091, 100);
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // tümkira
            // 
            this.tümkira.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tümkira.Location = new System.Drawing.Point(12, 176);
            this.tümkira.Name = "tümkira";
            this.tümkira.Size = new System.Drawing.Size(724, 312);
            this.tümkira.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Tüm Kiralananlar Listesi";
            // 
            // kiraara
            // 
            this.kiraara.BackColor = System.Drawing.SystemColors.Window;
            this.kiraara.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kiraara.Location = new System.Drawing.Point(808, 293);
            this.kiraara.Name = "kiraara";
            this.kiraara.Size = new System.Drawing.Size(148, 26);
            this.kiraara.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(804, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 75;
            this.label4.Text = "Kiralanan Kitap Ara :";
            // 
            // arabuton
            // 
            this.arabuton.BackgroundImage = global::Otomasyon.Properties.Resources.arama1;
            this.arabuton.Location = new System.Drawing.Point(983, 289);
            this.arabuton.Name = "arabuton";
            this.arabuton.Size = new System.Drawing.Size(30, 30);
            this.arabuton.TabIndex = 74;
            this.arabuton.TabStop = false;
            this.arabuton.Click += new System.EventHandler(this.arabuton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 15.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(1049, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 25);
            this.label12.TabIndex = 78;
            this.label12.Text = "X";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 17.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(7, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 29);
            this.label10.TabIndex = 79;
            this.label10.Text = "<";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // listele
            // 
            this.listele.BackColor = System.Drawing.Color.AntiqueWhite;
            this.listele.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listele.Location = new System.Drawing.Point(808, 336);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(148, 32);
            this.listele.TabIndex = 80;
            this.listele.Text = "Tekrar Listele";
            this.listele.UseVisualStyleBackColor = false;
            this.listele.Click += new System.EventHandler(this.listele_Click);
            // 
            // tumkiralama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1084, 511);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.kiraara);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.arabuton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tümkira);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tumkiralama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tumkiralama";
            this.Load += new System.EventHandler(this.tumkiralama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tümkira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabuton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView tümkira;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kiraara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox arabuton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button listele;
    }
}
namespace kutuphane_otomasyonu
{
    partial class frmKitaplar
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
            this.dgKitaplar = new System.Windows.Forms.DataGridView();
            this.kitapID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmkitapAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmkitapTur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmkitapYazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmkitapAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbEkle = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEkleKitapAd = new System.Windows.Forms.TextBox();
            this.txtEkleKitapYazar = new System.Windows.Forms.TextBox();
            this.txtEkleKitapTur = new System.Windows.Forms.TextBox();
            this.txtEkleKitapAdet = new System.Windows.Forms.TextBox();
            this.btnKitapKaydet = new System.Windows.Forms.Button();
            this.gbGuncelle = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtKitapAdet = new System.Windows.Forms.TextBox();
            this.txtKitapTur = new System.Windows.Forms.TextBox();
            this.txtKitapYazar = new System.Windows.Forms.TextBox();
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgKitaplar)).BeginInit();
            this.gbEkle.SuspendLayout();
            this.gbGuncelle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgKitaplar
            // 
            this.dgKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKitaplar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapID,
            this.clmkitapAd,
            this.clmkitapTur,
            this.clmkitapYazar,
            this.clmkitapAdet});
            this.dgKitaplar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgKitaplar.Location = new System.Drawing.Point(0, 202);
            this.dgKitaplar.Name = "dgKitaplar";
            this.dgKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKitaplar.Size = new System.Drawing.Size(693, 189);
            this.dgKitaplar.TabIndex = 0;
            // 
            // kitapID
            // 
            this.kitapID.DataPropertyName = "kitapID";
            this.kitapID.HeaderText = "kitapID";
            this.kitapID.Name = "kitapID";
            this.kitapID.Visible = false;
            // 
            // clmkitapAd
            // 
            this.clmkitapAd.DataPropertyName = "kitapAd";
            this.clmkitapAd.HeaderText = "kitap Ad";
            this.clmkitapAd.Name = "clmkitapAd";
            // 
            // clmkitapTur
            // 
            this.clmkitapTur.DataPropertyName = "kitapTur";
            this.clmkitapTur.HeaderText = "kitap Tur";
            this.clmkitapTur.Name = "clmkitapTur";
            // 
            // clmkitapYazar
            // 
            this.clmkitapYazar.DataPropertyName = "kitapYazar";
            this.clmkitapYazar.HeaderText = "kitap Yazar";
            this.clmkitapYazar.Name = "clmkitapYazar";
            // 
            // clmkitapAdet
            // 
            this.clmkitapAdet.DataPropertyName = "kitapAdet";
            this.clmkitapAdet.HeaderText = "kitap Adet";
            this.clmkitapAdet.Name = "clmkitapAdet";
            // 
            // gbEkle
            // 
            this.gbEkle.Controls.Add(this.btnKitapKaydet);
            this.gbEkle.Controls.Add(this.txtEkleKitapAdet);
            this.gbEkle.Controls.Add(this.txtEkleKitapTur);
            this.gbEkle.Controls.Add(this.txtEkleKitapYazar);
            this.gbEkle.Controls.Add(this.txtEkleKitapAd);
            this.gbEkle.Controls.Add(this.label4);
            this.gbEkle.Controls.Add(this.label3);
            this.gbEkle.Controls.Add(this.label2);
            this.gbEkle.Controls.Add(this.label1);
            this.gbEkle.Location = new System.Drawing.Point(345, 12);
            this.gbEkle.Name = "gbEkle";
            this.gbEkle.Size = new System.Drawing.Size(342, 192);
            this.gbEkle.TabIndex = 1;
            this.gbEkle.TabStop = false;
            this.gbEkle.Text = "Kitap Ekle";
            this.gbEkle.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Yazarı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kitap Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kitap Adet";
            // 
            // txtEkleKitapAd
            // 
            this.txtEkleKitapAd.Location = new System.Drawing.Point(146, 9);
            this.txtEkleKitapAd.Name = "txtEkleKitapAd";
            this.txtEkleKitapAd.Size = new System.Drawing.Size(160, 20);
            this.txtEkleKitapAd.TabIndex = 4;
            // 
            // txtEkleKitapYazar
            // 
            this.txtEkleKitapYazar.Location = new System.Drawing.Point(146, 50);
            this.txtEkleKitapYazar.Name = "txtEkleKitapYazar";
            this.txtEkleKitapYazar.Size = new System.Drawing.Size(160, 20);
            this.txtEkleKitapYazar.TabIndex = 5;
            // 
            // txtEkleKitapTur
            // 
            this.txtEkleKitapTur.Location = new System.Drawing.Point(146, 85);
            this.txtEkleKitapTur.Name = "txtEkleKitapTur";
            this.txtEkleKitapTur.Size = new System.Drawing.Size(160, 20);
            this.txtEkleKitapTur.TabIndex = 6;
            // 
            // txtEkleKitapAdet
            // 
            this.txtEkleKitapAdet.Location = new System.Drawing.Point(146, 126);
            this.txtEkleKitapAdet.Name = "txtEkleKitapAdet";
            this.txtEkleKitapAdet.Size = new System.Drawing.Size(160, 20);
            this.txtEkleKitapAdet.TabIndex = 7;
            // 
            // btnKitapKaydet
            // 
            this.btnKitapKaydet.Location = new System.Drawing.Point(146, 161);
            this.btnKitapKaydet.Name = "btnKitapKaydet";
            this.btnKitapKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKitapKaydet.TabIndex = 8;
            this.btnKitapKaydet.Text = "Kitap Kaydet";
            this.btnKitapKaydet.UseVisualStyleBackColor = true;
            this.btnKitapKaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbGuncelle
            // 
            this.gbGuncelle.Controls.Add(this.btnGuncelle);
            this.gbGuncelle.Controls.Add(this.txtKitapAdet);
            this.gbGuncelle.Controls.Add(this.txtKitapTur);
            this.gbGuncelle.Controls.Add(this.txtKitapYazar);
            this.gbGuncelle.Controls.Add(this.txtKitapAd);
            this.gbGuncelle.Controls.Add(this.label5);
            this.gbGuncelle.Controls.Add(this.label6);
            this.gbGuncelle.Controls.Add(this.label7);
            this.gbGuncelle.Controls.Add(this.label8);
            this.gbGuncelle.Enabled = false;
            this.gbGuncelle.Location = new System.Drawing.Point(0, 12);
            this.gbGuncelle.Name = "gbGuncelle";
            this.gbGuncelle.Size = new System.Drawing.Size(339, 192);
            this.gbGuncelle.TabIndex = 2;
            this.gbGuncelle.TabStop = false;
            this.gbGuncelle.Text = "Kitap Güncelle";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(150, 161);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 17;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // txtKitapAdet
            // 
            this.txtKitapAdet.Location = new System.Drawing.Point(150, 122);
            this.txtKitapAdet.Name = "txtKitapAdet";
            this.txtKitapAdet.Size = new System.Drawing.Size(160, 20);
            this.txtKitapAdet.TabIndex = 16;
            // 
            // txtKitapTur
            // 
            this.txtKitapTur.Location = new System.Drawing.Point(150, 85);
            this.txtKitapTur.Name = "txtKitapTur";
            this.txtKitapTur.Size = new System.Drawing.Size(160, 20);
            this.txtKitapTur.TabIndex = 15;
            // 
            // txtKitapYazar
            // 
            this.txtKitapYazar.Location = new System.Drawing.Point(150, 54);
            this.txtKitapYazar.Name = "txtKitapYazar";
            this.txtKitapYazar.Size = new System.Drawing.Size(160, 20);
            this.txtKitapYazar.TabIndex = 14;
            this.txtKitapYazar.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.Location = new System.Drawing.Point(150, 20);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(160, 20);
            this.txtKitapAd.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kitap Adet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kitap Türü";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Kitap Yazarı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Kitap Adı";
            // 
            // frmKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(693, 391);
            this.Controls.Add(this.gbGuncelle);
            this.Controls.Add(this.gbEkle);
            this.Controls.Add(this.dgKitaplar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKitaplar";
            this.Text = "Kitaplar";
            ((System.ComponentModel.ISupportInitialize)(this.dgKitaplar)).EndInit();
            this.gbEkle.ResumeLayout(false);
            this.gbEkle.PerformLayout();
            this.gbGuncelle.ResumeLayout(false);
            this.gbGuncelle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgKitaplar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmkitapAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmkitapTur;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmkitapYazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmkitapAdet;
        private System.Windows.Forms.GroupBox gbEkle;
        private System.Windows.Forms.Button btnKitapKaydet;
        private System.Windows.Forms.TextBox txtEkleKitapAdet;
        private System.Windows.Forms.TextBox txtEkleKitapTur;
        private System.Windows.Forms.TextBox txtEkleKitapYazar;
        private System.Windows.Forms.TextBox txtEkleKitapAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbGuncelle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtKitapAdet;
        private System.Windows.Forms.TextBox txtKitapTur;
        private System.Windows.Forms.TextBox txtKitapYazar;
        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
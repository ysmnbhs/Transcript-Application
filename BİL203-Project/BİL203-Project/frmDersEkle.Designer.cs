namespace BİL203_Project
{
    partial class frmDersEkle
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
            this.cmbNewDonem = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewHarfNotu = new System.Windows.Forms.TextBox();
            this.txtNewOgrUyesi = new System.Windows.Forms.TextBox();
            this.txtNewDersAdi = new System.Windows.Forms.TextBox();
            this.txtNewKredi = new System.Windows.Forms.TextBox();
            this.txtNewDersKodu = new System.Windows.Forms.TextBox();
            this.txtDersEkle = new System.Windows.Forms.Button();
            this.btnNewDersGoruntule = new System.Windows.Forms.Button();
            this.dtgwMevcut = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwMevcut)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbNewDonem
            // 
            this.cmbNewDonem.FormattingEnabled = true;
            this.cmbNewDonem.Items.AddRange(new object[] {
            "2021/2",
            "2022/1",
            "2022/2"});
            this.cmbNewDonem.Location = new System.Drawing.Point(497, 30);
            this.cmbNewDonem.Name = "cmbNewDonem";
            this.cmbNewDonem.Size = new System.Drawing.Size(100, 23);
            this.cmbNewDonem.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 51;
            this.label7.Text = "DÖNEMİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 50;
            this.label6.Text = "ÖĞRETİM ÜYESİ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 49;
            this.label5.Text = "HARF NOTU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 48;
            this.label4.Text = "DERS KODU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 47;
            this.label3.Text = "KREDİSİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 46;
            this.label2.Text = "DERS ADI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 45;
            this.label1.Text = "DERS TABLOSU";
            // 
            // txtNewHarfNotu
            // 
            this.txtNewHarfNotu.Location = new System.Drawing.Point(497, 77);
            this.txtNewHarfNotu.Name = "txtNewHarfNotu";
            this.txtNewHarfNotu.Size = new System.Drawing.Size(100, 23);
            this.txtNewHarfNotu.TabIndex = 44;
            // 
            // txtNewOgrUyesi
            // 
            this.txtNewOgrUyesi.Location = new System.Drawing.Point(185, 151);
            this.txtNewOgrUyesi.Name = "txtNewOgrUyesi";
            this.txtNewOgrUyesi.Size = new System.Drawing.Size(195, 23);
            this.txtNewOgrUyesi.TabIndex = 43;
            // 
            // txtNewDersAdi
            // 
            this.txtNewDersAdi.Location = new System.Drawing.Point(185, 74);
            this.txtNewDersAdi.Name = "txtNewDersAdi";
            this.txtNewDersAdi.Size = new System.Drawing.Size(195, 23);
            this.txtNewDersAdi.TabIndex = 42;
            // 
            // txtNewKredi
            // 
            this.txtNewKredi.Location = new System.Drawing.Point(185, 112);
            this.txtNewKredi.Name = "txtNewKredi";
            this.txtNewKredi.Size = new System.Drawing.Size(83, 23);
            this.txtNewKredi.TabIndex = 41;
            // 
            // txtNewDersKodu
            // 
            this.txtNewDersKodu.Location = new System.Drawing.Point(185, 35);
            this.txtNewDersKodu.Name = "txtNewDersKodu";
            this.txtNewDersKodu.Size = new System.Drawing.Size(83, 23);
            this.txtNewDersKodu.TabIndex = 40;
            // 
            // txtDersEkle
            // 
            this.txtDersEkle.Location = new System.Drawing.Point(503, 146);
            this.txtDersEkle.Name = "txtDersEkle";
            this.txtDersEkle.Size = new System.Drawing.Size(94, 35);
            this.txtDersEkle.TabIndex = 39;
            this.txtDersEkle.Text = "Ders Ekle";
            this.txtDersEkle.UseVisualStyleBackColor = true;
            this.txtDersEkle.Click += new System.EventHandler(this.txtDersEkle_Click);
            // 
            // btnNewDersGoruntule
            // 
            this.btnNewDersGoruntule.Location = new System.Drawing.Point(160, 207);
            this.btnNewDersGoruntule.Name = "btnNewDersGoruntule";
            this.btnNewDersGoruntule.Size = new System.Drawing.Size(141, 29);
            this.btnNewDersGoruntule.TabIndex = 38;
            this.btnNewDersGoruntule.Text = "Güncel Tabloyu Listele";
            this.btnNewDersGoruntule.UseVisualStyleBackColor = true;
            this.btnNewDersGoruntule.Click += new System.EventHandler(this.btnNewDersGoruntule_Click);
            // 
            // dtgwMevcut
            // 
            this.dtgwMevcut.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtgwMevcut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwMevcut.Location = new System.Drawing.Point(51, 252);
            this.dtgwMevcut.Name = "dtgwMevcut";
            this.dtgwMevcut.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtgwMevcut.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Violet;
            this.dtgwMevcut.RowTemplate.Height = 25;
            this.dtgwMevcut.Size = new System.Drawing.Size(722, 283);
            this.dtgwMevcut.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(758, 544);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 53;
            this.label8.Text = "Ysmnbhs";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 35);
            this.button1.TabIndex = 54;
            this.button1.Text = "İptal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDersEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(825, 564);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbNewDonem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewHarfNotu);
            this.Controls.Add(this.txtNewOgrUyesi);
            this.Controls.Add(this.txtNewDersAdi);
            this.Controls.Add(this.txtNewKredi);
            this.Controls.Add(this.txtNewDersKodu);
            this.Controls.Add(this.txtDersEkle);
            this.Controls.Add(this.btnNewDersGoruntule);
            this.Controls.Add(this.dtgwMevcut);
            this.Name = "frmDersEkle";
            this.Text = "Ders Ekleme Ekranı";
            this.Load += new System.EventHandler(this.frmDersEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgwMevcut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbNewDonem;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNewHarfNotu;
        private TextBox txtNewOgrUyesi;
        private TextBox txtNewDersAdi;
        private TextBox txtNewKredi;
        private TextBox txtNewDersKodu;
        private Button txtDersEkle;
        private Button btnNewDersGoruntule;
        private DataGridView dtgwMevcut;
        private Label label8;
        private Button button1;
    }
}
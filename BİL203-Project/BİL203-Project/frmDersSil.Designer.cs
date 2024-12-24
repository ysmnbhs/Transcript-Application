namespace BİL203_Project
{
    partial class frmDersSil
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
            this.btnDersiSil = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSilinecekDers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveDersGoruntule = new System.Windows.Forms.Button();
            this.dtgwMevcut = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwMevcut)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDersiSil
            // 
            this.btnDersiSil.Location = new System.Drawing.Point(461, 43);
            this.btnDersiSil.Name = "btnDersiSil";
            this.btnDersiSil.Size = new System.Drawing.Size(94, 35);
            this.btnDersiSil.TabIndex = 60;
            this.btnDersiSil.Text = "Dersi Sil";
            this.btnDersiSil.UseVisualStyleBackColor = true;
            this.btnDersiSil.Click += new System.EventHandler(this.btnDersiSil_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 15);
            this.label4.TabIndex = 59;
            this.label4.Text = "Silinecek Dersin Kodunu Giriniz";
            // 
            // txtSilinecekDers
            // 
            this.txtSilinecekDers.Location = new System.Drawing.Point(337, 50);
            this.txtSilinecekDers.Name = "txtSilinecekDers";
            this.txtSilinecekDers.Size = new System.Drawing.Size(83, 23);
            this.txtSilinecekDers.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 57;
            this.label1.Text = "DERS TABLOSU";
            // 
            // btnRemoveDersGoruntule
            // 
            this.btnRemoveDersGoruntule.Location = new System.Drawing.Point(162, 123);
            this.btnRemoveDersGoruntule.Name = "btnRemoveDersGoruntule";
            this.btnRemoveDersGoruntule.Size = new System.Drawing.Size(141, 29);
            this.btnRemoveDersGoruntule.TabIndex = 56;
            this.btnRemoveDersGoruntule.Text = "Güncel Tabloyu Listele";
            this.btnRemoveDersGoruntule.UseVisualStyleBackColor = true;
            this.btnRemoveDersGoruntule.Click += new System.EventHandler(this.btnRemoveDersGoruntule_Click);
            // 
            // dtgwMevcut
            // 
            this.dtgwMevcut.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtgwMevcut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwMevcut.Location = new System.Drawing.Point(51, 179);
            this.dtgwMevcut.Name = "dtgwMevcut";
            this.dtgwMevcut.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtgwMevcut.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Violet;
            this.dtgwMevcut.RowTemplate.Height = 25;
            this.dtgwMevcut.Size = new System.Drawing.Size(722, 342);
            this.dtgwMevcut.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(758, 544);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "Ysmnbhs";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(576, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 35);
            this.button1.TabIndex = 62;
            this.button1.Text = "İptal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDersSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(825, 564);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDersiSil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSilinecekDers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveDersGoruntule);
            this.Controls.Add(this.dtgwMevcut);
            this.Name = "frmDersSil";
            this.Text = "Ders Silme Ekranı";
            this.Load += new System.EventHandler(this.frmDersSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgwMevcut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDersiSil;
        private Label label4;
        private TextBox txtSilinecekDers;
        private Label label1;
        private Button btnRemoveDersGoruntule;
        private DataGridView dtgwMevcut;
        private Label label2;
        private Button button1;
    }
}
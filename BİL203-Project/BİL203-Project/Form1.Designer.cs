namespace BİL203_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgwMevcut = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kayıtEklemeEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gANOGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMevcutGoruntule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwMevcut)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Mevcut Ders Tablosu";
            // 
            // dtgwMevcut
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Violet;
            this.dtgwMevcut.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgwMevcut.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgwMevcut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgwMevcut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwMevcut.Location = new System.Drawing.Point(27, 115);
            this.dtgwMevcut.Name = "dtgwMevcut";
            this.dtgwMevcut.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtgwMevcut.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Violet;
            this.dtgwMevcut.RowTemplate.Height = 25;
            this.dtgwMevcut.Size = new System.Drawing.Size(726, 330);
            this.dtgwMevcut.TabIndex = 20;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtEklemeEkranıToolStripMenuItem,
            this.kayıtSilToolStripMenuItem,
            this.kayıtGüncelleToolStripMenuItem,
            this.gANOGörüntüleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kayıtEklemeEkranıToolStripMenuItem
            // 
            this.kayıtEklemeEkranıToolStripMenuItem.Name = "kayıtEklemeEkranıToolStripMenuItem";
            this.kayıtEklemeEkranıToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.kayıtEklemeEkranıToolStripMenuItem.Text = "Ders Ekle";
            this.kayıtEklemeEkranıToolStripMenuItem.Click += new System.EventHandler(this.kayıtEklemeEkranıToolStripMenuItem_Click);
            // 
            // kayıtSilToolStripMenuItem
            // 
            this.kayıtSilToolStripMenuItem.Name = "kayıtSilToolStripMenuItem";
            this.kayıtSilToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.kayıtSilToolStripMenuItem.Text = "Ders Sil";
            this.kayıtSilToolStripMenuItem.Click += new System.EventHandler(this.kayıtSilToolStripMenuItem_Click);
            // 
            // kayıtGüncelleToolStripMenuItem
            // 
            this.kayıtGüncelleToolStripMenuItem.Name = "kayıtGüncelleToolStripMenuItem";
            this.kayıtGüncelleToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.kayıtGüncelleToolStripMenuItem.Text = "Ders Güncelle";
            this.kayıtGüncelleToolStripMenuItem.Click += new System.EventHandler(this.kayıtGüncelleToolStripMenuItem_Click);
            // 
            // gANOGörüntüleToolStripMenuItem
            // 
            this.gANOGörüntüleToolStripMenuItem.Name = "gANOGörüntüleToolStripMenuItem";
            this.gANOGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.gANOGörüntüleToolStripMenuItem.Text = "GANO Görüntüle";
            this.gANOGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.gANOGörüntüleToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(758, 544);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Ysmnbhs";
            // 
            // btnMevcutGoruntule
            // 
            this.btnMevcutGoruntule.Location = new System.Drawing.Point(194, 72);
            this.btnMevcutGoruntule.Name = "btnMevcutGoruntule";
            this.btnMevcutGoruntule.Size = new System.Drawing.Size(75, 23);
            this.btnMevcutGoruntule.TabIndex = 40;
            this.btnMevcutGoruntule.Text = "Görüntüle";
            this.btnMevcutGoruntule.UseVisualStyleBackColor = true;
            this.btnMevcutGoruntule.Click += new System.EventHandler(this.btnMevcutGoruntule_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(825, 564);
            this.Controls.Add(this.btnMevcutGoruntule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgwMevcut);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Transkript Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgwMevcut)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private DataGridView dtgwMevcut;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem kayıtEklemeEkranıToolStripMenuItem;
        private ToolStripMenuItem kayıtSilToolStripMenuItem;
        private ToolStripMenuItem kayıtGüncelleToolStripMenuItem;
        private ToolStripMenuItem gANOGörüntüleToolStripMenuItem;
        private Label label2;
        private Button btnMevcutGoruntule;
    }
}
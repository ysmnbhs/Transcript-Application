namespace BİL203_Project
{
    partial class frmTranskript
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
            this.dtgwMevcut = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTranskript = new System.Windows.Forms.Button();
            this.roGano = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwMevcut)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgwMevcut
            // 
            this.dtgwMevcut.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtgwMevcut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwMevcut.Location = new System.Drawing.Point(33, 54);
            this.dtgwMevcut.Name = "dtgwMevcut";
            this.dtgwMevcut.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtgwMevcut.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Violet;
            this.dtgwMevcut.RowTemplate.Height = 25;
            this.dtgwMevcut.Size = new System.Drawing.Size(755, 359);
            this.dtgwMevcut.TabIndex = 38;
            this.dtgwMevcut.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgwMevcut_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(33, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 73;
            this.label4.Text = "Tranksript";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(605, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 74;
            this.label1.Text = "GANO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(758, 544);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 76;
            this.label2.Text = "Ysmnbhs";
            // 
            // btnTranskript
            // 
            this.btnTranskript.Location = new System.Drawing.Point(119, 21);
            this.btnTranskript.Name = "btnTranskript";
            this.btnTranskript.Size = new System.Drawing.Size(75, 23);
            this.btnTranskript.TabIndex = 77;
            this.btnTranskript.Text = "Görüntüle";
            this.btnTranskript.UseVisualStyleBackColor = true;
            this.btnTranskript.Click += new System.EventHandler(this.btnTranskript_Click);
            // 
            // roGano
            // 
            this.roGano.Location = new System.Drawing.Point(664, 436);
            this.roGano.Multiline = true;
            this.roGano.Name = "roGano";
            this.roGano.ReadOnly = true;
            this.roGano.Size = new System.Drawing.Size(92, 39);
            this.roGano.TabIndex = 78;
            // 
            // frmTranskript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(825, 564);
            this.Controls.Add(this.roGano);
            this.Controls.Add(this.btnTranskript);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgwMevcut);
            this.Name = "frmTranskript";
            this.Text = "Transkript Görüntüleme Ekranı";
            this.Load += new System.EventHandler(this.frmTranskript_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgwMevcut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgwMevcut;
        private Label label4;
        private Label label1;
        private Label label2;
        private Button btnTranskript;
        private TextBox roGano;
    }
}
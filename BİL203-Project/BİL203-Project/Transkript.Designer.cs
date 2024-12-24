namespace BİL203_Project
{
    partial class Transkript
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
            this.btnTranskript = new System.Windows.Forms.Button();
            this.roGano = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgwMevcut = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwMevcut)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTranskript
            // 
            this.btnTranskript.Location = new System.Drawing.Point(113, 18);
            this.btnTranskript.Name = "btnTranskript";
            this.btnTranskript.Size = new System.Drawing.Size(75, 23);
            this.btnTranskript.TabIndex = 82;
            this.btnTranskript.Text = "Görüntüle";
            this.btnTranskript.UseVisualStyleBackColor = true;
            // 
            // lwGANO
            // 
            this.roGano.Location = new System.Drawing.Point(659, 436);
            this.roGano.Name = "lwGANO";
            this.roGano.Size = new System.Drawing.Size(83, 33);
            this.roGano.TabIndex = 81;
            this.roGano.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(599, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 80;
            this.label1.Text = "GANO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(27, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 79;
            this.label4.Text = "Tranksript";
            // 
            // dtgwMevcut
            // 
            this.dtgwMevcut.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtgwMevcut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwMevcut.Location = new System.Drawing.Point(27, 51);
            this.dtgwMevcut.Name = "dtgwMevcut";
            this.dtgwMevcut.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtgwMevcut.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Violet;
            this.dtgwMevcut.RowTemplate.Height = 25;
            this.dtgwMevcut.Size = new System.Drawing.Size(755, 359);
            this.dtgwMevcut.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(757, 544);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 83;
            this.label2.Text = "Ysmnbhs";
            // 
            // Transkript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(825, 564);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTranskript);
            this.Controls.Add(this.roGano);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgwMevcut);
            this.Name = "Transkript";
            this.Text = "Transkript";
            ((System.ComponentModel.ISupportInitialize)(this.dtgwMevcut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnTranskript;
        private ListView roGano;
        private Label label1;
        private Label label4;
        private DataGridView dtgwMevcut;
        private Label label2;
    }
}
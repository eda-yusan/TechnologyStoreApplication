namespace TeknolojiMagazasi
{
    partial class Kampanya
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
            this.txtKampanyaID = new System.Windows.Forms.TextBox();
            this.txtKampanyaAd = new System.Windows.Forms.TextBox();
            this.txtIndirimOran = new System.Windows.Forms.TextBox();
            this.btnKampanyaEkle = new System.Windows.Forms.Button();
            this.btnKampanyaSil = new System.Windows.Forms.Button();
            this.dataGridViewKampanya = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKampanya)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKampanyaID
            // 
            this.txtKampanyaID.Location = new System.Drawing.Point(154, 355);
            this.txtKampanyaID.Margin = new System.Windows.Forms.Padding(4);
            this.txtKampanyaID.Name = "txtKampanyaID";
            this.txtKampanyaID.Size = new System.Drawing.Size(155, 31);
            this.txtKampanyaID.TabIndex = 0;
            // 
            // txtKampanyaAd
            // 
            this.txtKampanyaAd.Location = new System.Drawing.Point(165, 96);
            this.txtKampanyaAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtKampanyaAd.Name = "txtKampanyaAd";
            this.txtKampanyaAd.Size = new System.Drawing.Size(155, 31);
            this.txtKampanyaAd.TabIndex = 1;
            // 
            // txtIndirimOran
            // 
            this.txtIndirimOran.Location = new System.Drawing.Point(165, 158);
            this.txtIndirimOran.Margin = new System.Windows.Forms.Padding(4);
            this.txtIndirimOran.Name = "txtIndirimOran";
            this.txtIndirimOran.Size = new System.Drawing.Size(155, 31);
            this.txtIndirimOran.TabIndex = 5;
            // 
            // btnKampanyaEkle
            // 
            this.btnKampanyaEkle.Location = new System.Drawing.Point(180, 219);
            this.btnKampanyaEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnKampanyaEkle.Name = "btnKampanyaEkle";
            this.btnKampanyaEkle.Size = new System.Drawing.Size(118, 36);
            this.btnKampanyaEkle.TabIndex = 6;
            this.btnKampanyaEkle.Text = "Ekle";
            this.btnKampanyaEkle.UseVisualStyleBackColor = true;
            this.btnKampanyaEkle.Click += new System.EventHandler(this.btnKampanyaEkle_Click);
            // 
            // btnKampanyaSil
            // 
            this.btnKampanyaSil.Location = new System.Drawing.Point(180, 412);
            this.btnKampanyaSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnKampanyaSil.Name = "btnKampanyaSil";
            this.btnKampanyaSil.Size = new System.Drawing.Size(118, 36);
            this.btnKampanyaSil.TabIndex = 7;
            this.btnKampanyaSil.Text = "Sil";
            this.btnKampanyaSil.UseVisualStyleBackColor = true;
            this.btnKampanyaSil.Click += new System.EventHandler(this.btnKampanyaSil_Click);
            // 
            // dataGridViewKampanya
            // 
            this.dataGridViewKampanya.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKampanya.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKampanya.Location = new System.Drawing.Point(492, 56);
            this.dataGridViewKampanya.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewKampanya.Name = "dataGridViewKampanya";
            this.dataGridViewKampanya.RowHeadersWidth = 51;
            this.dataGridViewKampanya.RowTemplate.Height = 29;
            this.dataGridViewKampanya.Size = new System.Drawing.Size(796, 434);
            this.dataGridViewKampanya.TabIndex = 8;
            this.dataGridViewKampanya.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKampanya_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "İndirim Oranı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 359);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "KampanyaID:";
            // 
            // Kampanya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1378, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewKampanya);
            this.Controls.Add(this.btnKampanyaSil);
            this.Controls.Add(this.btnKampanyaEkle);
            this.Controls.Add(this.txtIndirimOran);
            this.Controls.Add(this.txtKampanyaAd);
            this.Controls.Add(this.txtKampanyaID);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Kampanya";
            this.Text = "Kampanya";
            this.Load += new System.EventHandler(this.Kampanya_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKampanya)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtKampanyaID;
        private TextBox txtKampanyaAd;
        private TextBox txtIndirimOran;
        private Button btnKampanyaEkle;
        private Button btnKampanyaSil;
        private DataGridView dataGridViewKampanya;
        private Label label1;
        private Label label5;
        private Label label2;
    }
}
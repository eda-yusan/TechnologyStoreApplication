namespace TeknolojiMagazasi
{
    partial class KullaniciAyar
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.BtnGeri1 = new System.Windows.Forms.Button();
            this.BtnCikis3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.BtnEkle3 = new System.Windows.Forms.Button();
            this.btnSil3 = new System.Windows.Forms.Button();
            this.txtKullaniciID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(15, 26);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 29;
            this.dataGridView3.Size = new System.Drawing.Size(508, 506);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // BtnGeri1
            // 
            this.BtnGeri1.Location = new System.Drawing.Point(714, -1);
            this.BtnGeri1.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGeri1.Name = "BtnGeri1";
            this.BtnGeri1.Size = new System.Drawing.Size(118, 36);
            this.BtnGeri1.TabIndex = 1;
            this.BtnGeri1.Text = "Geri";
            this.BtnGeri1.UseVisualStyleBackColor = true;
            this.BtnGeri1.Click += new System.EventHandler(this.BtnGeri1_Click);
            // 
            // BtnCikis3
            // 
            this.BtnCikis3.Location = new System.Drawing.Point(839, -1);
            this.BtnCikis3.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCikis3.Name = "BtnCikis3";
            this.BtnCikis3.Size = new System.Drawing.Size(118, 36);
            this.BtnCikis3.TabIndex = 2;
            this.BtnCikis3.Text = "Çıkış Yap";
            this.BtnCikis3.UseVisualStyleBackColor = true;
            this.BtnCikis3.Click += new System.EventHandler(this.BtnCikis3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(639, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(695, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre:";
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(765, 174);
            this.txtKullanici.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(155, 31);
            this.txtKullanici.TabIndex = 5;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(765, 230);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(155, 31);
            this.txtSifre.TabIndex = 6;
            // 
            // BtnEkle3
            // 
            this.BtnEkle3.Location = new System.Drawing.Point(714, 321);
            this.BtnEkle3.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEkle3.Name = "BtnEkle3";
            this.BtnEkle3.Size = new System.Drawing.Size(118, 36);
            this.BtnEkle3.TabIndex = 7;
            this.BtnEkle3.Text = "Ekle";
            this.BtnEkle3.UseVisualStyleBackColor = true;
            this.BtnEkle3.Click += new System.EventHandler(this.BtnEkle3_Click);
            // 
            // btnSil3
            // 
            this.btnSil3.Location = new System.Drawing.Point(839, 321);
            this.btnSil3.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil3.Name = "btnSil3";
            this.btnSil3.Size = new System.Drawing.Size(118, 36);
            this.btnSil3.TabIndex = 8;
            this.btnSil3.Text = "Sil";
            this.btnSil3.UseVisualStyleBackColor = true;
            this.btnSil3.Click += new System.EventHandler(this.btnSil3_Click);
            // 
            // txtKullaniciID
            // 
            this.txtKullaniciID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtKullaniciID.Location = new System.Drawing.Point(765, 121);
            this.txtKullaniciID.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullaniciID.Name = "txtKullaniciID";
            this.txtKullaniciID.Size = new System.Drawing.Size(155, 31);
            this.txtKullaniciID.TabIndex = 9;
            this.txtKullaniciID.Visible = false;
            // 
            // KullaniciAyar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.txtKullaniciID);
            this.Controls.Add(this.btnSil3);
            this.Controls.Add(this.BtnEkle3);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCikis3);
            this.Controls.Add(this.BtnGeri1);
            this.Controls.Add(this.dataGridView3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KullaniciAyar";
            this.Text = "Kullanıcı İşlemleri";
            this.Load += new System.EventHandler(this.KullaniciAyar_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView3;
        private Button BtnGeri1;
        private Button BtnCikis3;
        private Label label1;
        private Label label2;
        private TextBox txtKullanici;
        private TextBox txtSifre;
        private Button BtnEkle3;
        private Button btnSil3;
        private TextBox txtKullaniciID;
    }
}
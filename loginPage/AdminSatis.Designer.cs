namespace TeknolojiMagazasi
{
    partial class AdminSatis
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtMusteriTC = new System.Windows.Forms.TextBox();
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUrunListele = new System.Windows.Forms.Button();
            this.dataGridViewSatis = new System.Windows.Forms.DataGridView();
            this.btnMusteriListele = new System.Windows.Forms.Button();
            this.btnIadeler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSatis)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1529, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Çıkış Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1390, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtMusteriTC
            // 
            this.txtMusteriTC.Location = new System.Drawing.Point(29, 139);
            this.txtMusteriTC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMusteriTC.Name = "txtMusteriTC";
            this.txtMusteriTC.Size = new System.Drawing.Size(142, 31);
            this.txtMusteriTC.TabIndex = 7;
            // 
            // txtUrunID
            // 
            this.txtUrunID.Location = new System.Drawing.Point(208, 139);
            this.txtUrunID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.Size = new System.Drawing.Size(142, 31);
            this.txtUrunID.TabIndex = 8;
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.Location = new System.Drawing.Point(381, 134);
            this.btnSatisYap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(108, 39);
            this.btnSatisYap.TabIndex = 9;
            this.btnSatisYap.Text = "Satış Yap";
            this.btnSatisYap.UseVisualStyleBackColor = true;
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "MüşteriTC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "ÜrünID:";
            // 
            // btnUrunListele
            // 
            this.btnUrunListele.Location = new System.Drawing.Point(208, 182);
            this.btnUrunListele.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUrunListele.Name = "btnUrunListele";
            this.btnUrunListele.Size = new System.Drawing.Size(142, 71);
            this.btnUrunListele.TabIndex = 19;
            this.btnUrunListele.Text = "Ürünleri Listele";
            this.btnUrunListele.UseVisualStyleBackColor = true;
            this.btnUrunListele.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridViewSatis
            // 
            this.dataGridViewSatis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSatis.Location = new System.Drawing.Point(18, 426);
            this.dataGridViewSatis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewSatis.Name = "dataGridViewSatis";
            this.dataGridViewSatis.RowHeadersWidth = 51;
            this.dataGridViewSatis.RowTemplate.Height = 25;
            this.dataGridViewSatis.Size = new System.Drawing.Size(1049, 520);
            this.dataGridViewSatis.TabIndex = 20;
            // 
            // btnMusteriListele
            // 
            this.btnMusteriListele.Location = new System.Drawing.Point(29, 182);
            this.btnMusteriListele.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMusteriListele.Name = "btnMusteriListele";
            this.btnMusteriListele.Size = new System.Drawing.Size(142, 71);
            this.btnMusteriListele.TabIndex = 21;
            this.btnMusteriListele.Text = "Müşteri Listele";
            this.btnMusteriListele.UseVisualStyleBackColor = true;
            this.btnMusteriListele.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnIadeler
            // 
            this.btnIadeler.Location = new System.Drawing.Point(510, 134);
            this.btnIadeler.Margin = new System.Windows.Forms.Padding(4);
            this.btnIadeler.Name = "btnIadeler";
            this.btnIadeler.Size = new System.Drawing.Size(108, 39);
            this.btnIadeler.TabIndex = 25;
            this.btnIadeler.Text = "İade Yap";
            this.btnIadeler.UseVisualStyleBackColor = true;
            this.btnIadeler.Click += new System.EventHandler(this.btnIadeler_Click);
            // 
            // AdminSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1881, 966);
            this.Controls.Add(this.btnIadeler);
            this.Controls.Add(this.btnMusteriListele);
            this.Controls.Add(this.dataGridViewSatis);
            this.Controls.Add(this.btnUrunListele);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSatisYap);
            this.Controls.Add(this.txtUrunID);
            this.Controls.Add(this.txtMusteriTC);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminSatis";
            this.Text = "Satış";
            this.Load += new System.EventHandler(this.AdminSatis_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSatis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtMusteriTC;
        private TextBox txtUrunID;
        private Button btnSatisYap;
        private Label label1;
        private Label label2;
        private Button btnUrunListele;
        private DataGridView dataGridViewSatis;
        private Button btnMusteriListele;
        private Button btnIadeler;
    }
}
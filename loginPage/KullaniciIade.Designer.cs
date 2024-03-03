namespace TeknolojiMagazasi
{
    partial class KullaniciIade
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
            this.dataGridViewIade2 = new System.Windows.Forms.DataGridView();
            this.txtSatisID2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIadeEt2 = new System.Windows.Forms.Button();
            this.btnGeri4 = new System.Windows.Forms.Button();
            this.btnCikisYap4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIade2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewIade2
            // 
            this.dataGridViewIade2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIade2.Location = new System.Drawing.Point(15, 289);
            this.dataGridViewIade2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewIade2.Name = "dataGridViewIade2";
            this.dataGridViewIade2.RowHeadersWidth = 51;
            this.dataGridViewIade2.RowTemplate.Height = 29;
            this.dataGridViewIade2.Size = new System.Drawing.Size(786, 520);
            this.dataGridViewIade2.TabIndex = 0;
            this.dataGridViewIade2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewIade2_CellContentClick);
            // 
            // txtSatisID2
            // 
            this.txtSatisID2.Location = new System.Drawing.Point(56, 124);
            this.txtSatisID2.Margin = new System.Windows.Forms.Padding(4);
            this.txtSatisID2.Name = "txtSatisID2";
            this.txtSatisID2.Size = new System.Drawing.Size(155, 31);
            this.txtSatisID2.TabIndex = 1;
            this.txtSatisID2.TextChanged += new System.EventHandler(this.txtSatisID2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "SatışID:";
            // 
            // btnIadeEt2
            // 
            this.btnIadeEt2.Location = new System.Drawing.Point(259, 121);
            this.btnIadeEt2.Margin = new System.Windows.Forms.Padding(4);
            this.btnIadeEt2.Name = "btnIadeEt2";
            this.btnIadeEt2.Size = new System.Drawing.Size(118, 36);
            this.btnIadeEt2.TabIndex = 3;
            this.btnIadeEt2.Text = "İade Et";
            this.btnIadeEt2.UseVisualStyleBackColor = true;
            this.btnIadeEt2.Click += new System.EventHandler(this.btnIadeEt2_Click);
            // 
            // btnGeri4
            // 
            this.btnGeri4.Location = new System.Drawing.Point(833, 27);
            this.btnGeri4.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeri4.Name = "btnGeri4";
            this.btnGeri4.Size = new System.Drawing.Size(118, 36);
            this.btnGeri4.TabIndex = 4;
            this.btnGeri4.Text = "Geri";
            this.btnGeri4.UseVisualStyleBackColor = true;
            this.btnGeri4.Click += new System.EventHandler(this.btnGeri4_Click);
            // 
            // btnCikisYap4
            // 
            this.btnCikisYap4.Location = new System.Drawing.Point(973, 27);
            this.btnCikisYap4.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikisYap4.Name = "btnCikisYap4";
            this.btnCikisYap4.Size = new System.Drawing.Size(118, 36);
            this.btnCikisYap4.TabIndex = 5;
            this.btnCikisYap4.Text = "Çıkış Yap";
            this.btnCikisYap4.UseVisualStyleBackColor = true;
            this.btnCikisYap4.Click += new System.EventHandler(this.btnCikisYap4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Satış Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KullaniciIade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1137, 828);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCikisYap4);
            this.Controls.Add(this.btnGeri4);
            this.Controls.Add(this.btnIadeEt2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSatisID2);
            this.Controls.Add(this.dataGridViewIade2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KullaniciIade";
            this.Text = "KullaniciIade";
            this.Load += new System.EventHandler(this.KullaniciIade_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIade2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewIade2;
        private TextBox txtSatisID2;
        private Label label1;
        private Button btnIadeEt2;
        private Button btnGeri4;
        private Button btnCikisYap4;
        private Button button1;
    }
}
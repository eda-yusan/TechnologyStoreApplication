namespace TeknolojiMagazasi
{
    partial class AdminIade
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
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.dataGridViewIade = new System.Windows.Forms.DataGridView();
            this.txtSatisID = new System.Windows.Forms.TextBox();
            this.btnIadeEt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIade)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(1390, 15);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(118, 36);
            this.btnGeri.TabIndex = 0;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(1529, 15);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(118, 36);
            this.btnCikis.TabIndex = 1;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // dataGridViewIade
            // 
            this.dataGridViewIade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIade.Location = new System.Drawing.Point(15, 289);
            this.dataGridViewIade.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewIade.Name = "dataGridViewIade";
            this.dataGridViewIade.RowHeadersWidth = 51;
            this.dataGridViewIade.RowTemplate.Height = 29;
            this.dataGridViewIade.Size = new System.Drawing.Size(1049, 520);
            this.dataGridViewIade.TabIndex = 2;
            // 
            // txtSatisID
            // 
            this.txtSatisID.Location = new System.Drawing.Point(56, 124);
            this.txtSatisID.Margin = new System.Windows.Forms.Padding(4);
            this.txtSatisID.Name = "txtSatisID";
            this.txtSatisID.Size = new System.Drawing.Size(155, 31);
            this.txtSatisID.TabIndex = 3;
            // 
            // btnIadeEt
            // 
            this.btnIadeEt.Location = new System.Drawing.Point(259, 121);
            this.btnIadeEt.Margin = new System.Windows.Forms.Padding(4);
            this.btnIadeEt.Name = "btnIadeEt";
            this.btnIadeEt.Size = new System.Drawing.Size(118, 36);
            this.btnIadeEt.TabIndex = 5;
            this.btnIadeEt.Text = "İade Et";
            this.btnIadeEt.UseVisualStyleBackColor = true;
            this.btnIadeEt.Click += new System.EventHandler(this.btnIadeEt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "SatışID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Satış Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminIade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1881, 966);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIadeEt);
            this.Controls.Add(this.txtSatisID);
            this.Controls.Add(this.dataGridViewIade);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeri);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminIade";
            this.Text = "AdminIade";
            this.Load += new System.EventHandler(this.AdminIade_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGeri;
        private Button btnCikis;
        private DataGridView dataGridViewIade;
        private TextBox txtSatisID;
        private Button btnIadeEt;
        private Label label2;
        private Button button1;
    }
}
namespace TeknolojiMagazasi
{
    partial class SilinenUrulerKullanici
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
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.btnGeri2 = new System.Windows.Forms.Button();
            this.btnCikisYap2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView7
            // 
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Location = new System.Drawing.Point(8, 278);
            this.dataGridView7.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.RowHeadersWidth = 51;
            this.dataGridView7.RowTemplate.Height = 29;
            this.dataGridView7.Size = new System.Drawing.Size(1162, 550);
            this.dataGridView7.TabIndex = 0;
            this.dataGridView7.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView7_CellContentClick);
            // 
            // btnGeri2
            // 
            this.btnGeri2.Location = new System.Drawing.Point(1044, 15);
            this.btnGeri2.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeri2.Name = "btnGeri2";
            this.btnGeri2.Size = new System.Drawing.Size(118, 36);
            this.btnGeri2.TabIndex = 1;
            this.btnGeri2.Text = "Geri";
            this.btnGeri2.UseVisualStyleBackColor = true;
            this.btnGeri2.Click += new System.EventHandler(this.btnGeri2_Click);
            // 
            // btnCikisYap2
            // 
            this.btnCikisYap2.Location = new System.Drawing.Point(1169, 15);
            this.btnCikisYap2.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikisYap2.Name = "btnCikisYap2";
            this.btnCikisYap2.Size = new System.Drawing.Size(118, 36);
            this.btnCikisYap2.TabIndex = 2;
            this.btnCikisYap2.Text = "Çıkış Yap";
            this.btnCikisYap2.UseVisualStyleBackColor = true;
            this.btnCikisYap2.Click += new System.EventHandler(this.btnCikisYap2_Click);
            // 
            // SilinenUrulerKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1385, 966);
            this.Controls.Add(this.btnCikisYap2);
            this.Controls.Add(this.btnGeri2);
            this.Controls.Add(this.dataGridView7);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SilinenUrulerKullanici";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.SilinenUrulerKullanici_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView7;
        private Button btnGeri2;
        private Button btnCikisYap2;
    }
}
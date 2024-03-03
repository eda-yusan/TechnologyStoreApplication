namespace TeknolojiMagazasi
{
    partial class UrunListele
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
            this.dataGridView10 = new System.Windows.Forms.DataGridView();
            this.btnUrunAra = new System.Windows.Forms.Button();
            this.txtUrunAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView10
            // 
            this.dataGridView10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView10.Location = new System.Drawing.Point(18, 60);
            this.dataGridView10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView10.Name = "dataGridView10";
            this.dataGridView10.RowHeadersWidth = 51;
            this.dataGridView10.RowTemplate.Height = 25;
            this.dataGridView10.Size = new System.Drawing.Size(376, 670);
            this.dataGridView10.TabIndex = 0;
            // 
            // btnUrunAra
            // 
            this.btnUrunAra.Location = new System.Drawing.Point(222, 11);
            this.btnUrunAra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUrunAra.Name = "btnUrunAra";
            this.btnUrunAra.Size = new System.Drawing.Size(76, 39);
            this.btnUrunAra.TabIndex = 4;
            this.btnUrunAra.Text = "ARA";
            this.btnUrunAra.UseVisualStyleBackColor = true;
            this.btnUrunAra.Click += new System.EventHandler(this.btnUrunAra_Click);
            // 
            // txtUrunAra
            // 
            this.txtUrunAra.Location = new System.Drawing.Point(71, 11);
            this.txtUrunAra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUrunAra.Name = "txtUrunAra";
            this.txtUrunAra.Size = new System.Drawing.Size(142, 31);
            this.txtUrunAra.TabIndex = 3;
            // 
            // UrunListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(569, 750);
            this.Controls.Add(this.btnUrunAra);
            this.Controls.Add(this.txtUrunAra);
            this.Controls.Add(this.dataGridView10);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UrunListele";
            this.Text = "UrunListele";
            this.Load += new System.EventHandler(this.UrunListele_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView10;
        private Button btnUrunAra;
        private TextBox txtUrunAra;
    }
}
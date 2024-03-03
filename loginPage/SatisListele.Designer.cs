namespace TeknolojiMagazasi
{
    partial class SatisListele
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
            this.txtMusteriIsim = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewSatis = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSatis)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMusteriIsim
            // 
            this.txtMusteriIsim.Location = new System.Drawing.Point(12, 25);
            this.txtMusteriIsim.Name = "txtMusteriIsim";
            this.txtMusteriIsim.Size = new System.Drawing.Size(150, 31);
            this.txtMusteriIsim.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Arama";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewSatis
            // 
            this.dataGridViewSatis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSatis.Location = new System.Drawing.Point(12, 83);
            this.dataGridViewSatis.Name = "dataGridViewSatis";
            this.dataGridViewSatis.RowHeadersWidth = 62;
            this.dataGridViewSatis.RowTemplate.Height = 33;
            this.dataGridViewSatis.Size = new System.Drawing.Size(448, 343);
            this.dataGridViewSatis.TabIndex = 2;
            // 
            // SatisListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewSatis);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMusteriIsim);
            this.Name = "SatisListele";
            this.Text = "SatisListele";
            this.Load += new System.EventHandler(this.SatisListele_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSatis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtMusteriIsim;
        private Button button1;
        private DataGridView dataGridViewSatis;
    }
}
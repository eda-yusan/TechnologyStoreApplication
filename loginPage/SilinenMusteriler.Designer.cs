namespace TeknolojiMagazasi
{
    partial class SilinenMusteriler
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
            this.dataGridViewSilinenMusteri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSilinenMusteri)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSilinenMusteri
            // 
            this.dataGridViewSilinenMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSilinenMusteri.Location = new System.Drawing.Point(64, 74);
            this.dataGridViewSilinenMusteri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewSilinenMusteri.Name = "dataGridViewSilinenMusteri";
            this.dataGridViewSilinenMusteri.RowHeadersWidth = 51;
            this.dataGridViewSilinenMusteri.RowTemplate.Height = 29;
            this.dataGridViewSilinenMusteri.Size = new System.Drawing.Size(1099, 426);
            this.dataGridViewSilinenMusteri.TabIndex = 0;
            // 
            // SilinenMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1422, 586);
            this.Controls.Add(this.dataGridViewSilinenMusteri);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SilinenMusteriler";
            this.Text = "SilinenMusteriler";
            this.Load += new System.EventHandler(this.SilinenMusteriler_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSilinenMusteri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewSilinenMusteri;
    }
}
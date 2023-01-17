namespace WindowsFormsApp_FinalProject.STForms
{
    partial class STDersListeForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kredi_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ogretmen_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bolum_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Devamsizlik_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToplamHafta_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaslangicTarih_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitisTarih_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guncelle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Column,
            this.Ad_Column,
            this.Aciklama_Column,
            this.Kredi_Column,
            this.Ogretmen_Column,
            this.Bolum_Column,
            this.Devamsizlik_Column,
            this.ToplamHafta_Column,
            this.BaslangicTarih_Column,
            this.BitisTarih_Column,
            this.Guncelle});
            this.dataGridView1.Location = new System.Drawing.Point(0, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1009, 490);
            this.dataGridView1.TabIndex = 13;
            // 
            // Id_Column
            // 
            this.Id_Column.HeaderText = "Id";
            this.Id_Column.Name = "Id_Column";
            // 
            // Ad_Column
            // 
            this.Ad_Column.HeaderText = "Ad";
            this.Ad_Column.Name = "Ad_Column";
            // 
            // Aciklama_Column
            // 
            this.Aciklama_Column.HeaderText = "Açıklama";
            this.Aciklama_Column.Name = "Aciklama_Column";
            // 
            // Kredi_Column
            // 
            this.Kredi_Column.HeaderText = "Kredi";
            this.Kredi_Column.Name = "Kredi_Column";
            // 
            // Ogretmen_Column
            // 
            this.Ogretmen_Column.HeaderText = "Öğretmen";
            this.Ogretmen_Column.Name = "Ogretmen_Column";
            // 
            // Bolum_Column
            // 
            this.Bolum_Column.HeaderText = "Bölüm";
            this.Bolum_Column.Name = "Bolum_Column";
            // 
            // Devamsizlik_Column
            // 
            this.Devamsizlik_Column.HeaderText = "Devamsızlık";
            this.Devamsizlik_Column.Name = "Devamsizlik_Column";
            // 
            // ToplamHafta_Column
            // 
            this.ToplamHafta_Column.HeaderText = "Toplam Hafta";
            this.ToplamHafta_Column.Name = "ToplamHafta_Column";
            // 
            // BaslangicTarih_Column
            // 
            this.BaslangicTarih_Column.HeaderText = "Başlangıç Tarihi";
            this.BaslangicTarih_Column.Name = "BaslangicTarih_Column";
            // 
            // BitisTarih_Column
            // 
            this.BitisTarih_Column.HeaderText = "BitisTarih";
            this.BitisTarih_Column.Name = "BitisTarih_Column";
            // 
            // Guncelle
            // 
            this.Guncelle.HeaderText = "Güncelle";
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Text = "Güncelle";
            this.Guncelle.ToolTipText = "Güncelle";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 59);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders Listeleme";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // STDersListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "STDersListeForm";
            this.Text = "Ders Liste";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kredi_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ogretmen_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bolum_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Devamsizlik_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToplamHafta_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaslangicTarih_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitisTarih_Column;
        private System.Windows.Forms.DataGridViewButtonColumn Guncelle;
    }
}
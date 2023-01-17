namespace WindowsFormsApp_FinalProject.STForms
{
    partial class STPersonelListeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdSoyad_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogumTarih_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisTarih_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bolum_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guncelle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 370);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Listeleme ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Column,
            this.AdSoyad_Column,
            this.DogumTarih_Column,
            this.GirisTarih_Column,
            this.Bolum_Column,
            this.Guncelle});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(796, 329);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id_Column
            // 
            this.Id_Column.DataPropertyName = "Id";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Id_Column.DefaultCellStyle = dataGridViewCellStyle2;
            this.Id_Column.HeaderText = "Id";
            this.Id_Column.Name = "Id_Column";
            // 
            // AdSoyad_Column
            // 
            this.AdSoyad_Column.DataPropertyName = "AdSoyad";
            this.AdSoyad_Column.HeaderText = "Ad Soyad";
            this.AdSoyad_Column.Name = "AdSoyad_Column";
            // 
            // DogumTarih_Column
            // 
            this.DogumTarih_Column.DataPropertyName = "DogumTarih";
            this.DogumTarih_Column.HeaderText = "Doğum Tarih";
            this.DogumTarih_Column.Name = "DogumTarih_Column";
            // 
            // GirisTarih_Column
            // 
            this.GirisTarih_Column.DataPropertyName = "GirisTarih";
            this.GirisTarih_Column.HeaderText = "Giriş Tarih";
            this.GirisTarih_Column.Name = "GirisTarih_Column";
            // 
            // Bolum_Column
            // 
            this.Bolum_Column.DataPropertyName = "Bolum";
            this.Bolum_Column.HeaderText = "Bölüm";
            this.Bolum_Column.Name = "Bolum_Column";
            // 
            // Guncelle
            // 
            this.Guncelle.HeaderText = "Güncelle";
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Text = "Güncelle";
            this.Guncelle.ToolTipText = "Güncelle";
            // 
            // STPersonelListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 371);
            this.Controls.Add(this.panel1);
            this.Name = "STPersonelListeForm";
            this.Text = "Personel Liste";
            this.Load += new System.EventHandler(this.STPersonelListeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdSoyad_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogumTarih_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisTarih_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bolum_Column;
        private System.Windows.Forms.DataGridViewButtonColumn Guncelle;
    }
}
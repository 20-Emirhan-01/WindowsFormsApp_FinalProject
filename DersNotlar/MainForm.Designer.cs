namespace WindowsFormsApp_FinalProject
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersListeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altMenüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelListeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciGriişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciListeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciDerslerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.dosyaToolStripMenuItem,
            this.altMenüToolStripMenuItem,
            this.öğrenciToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1221, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.BackColor = System.Drawing.SystemColors.Menu;
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem1});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.programToolStripMenuItem.Text = "Dosya";
            // 
            // çıkışToolStripMenuItem1
            // 
            this.çıkışToolStripMenuItem1.Name = "çıkışToolStripMenuItem1";
            this.çıkışToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.çıkışToolStripMenuItem1.Text = "Çıkış          Alt+F4";
            this.çıkışToolStripMenuItem1.Click += new System.EventHandler(this.çıkışToolStripMenuItem1_Click);
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.BackColor = System.Drawing.SystemColors.Menu;
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dersGirişToolStripMenuItem,
            this.dersListeToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.dosyaToolStripMenuItem.Text = "Ders";
            this.dosyaToolStripMenuItem.Click += new System.EventHandler(this.dosyaToolStripMenuItem_Click);
            // 
            // dersGirişToolStripMenuItem
            // 
            this.dersGirişToolStripMenuItem.Name = "dersGirişToolStripMenuItem";
            this.dersGirişToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.dersGirişToolStripMenuItem.Text = "Ders Giriş";
            this.dersGirişToolStripMenuItem.Click += new System.EventHandler(this.dersGirişToolStripMenuItem_Click);
            // 
            // dersListeToolStripMenuItem
            // 
            this.dersListeToolStripMenuItem.Name = "dersListeToolStripMenuItem";
            this.dersListeToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.dersListeToolStripMenuItem.Text = "Ders Liste";
            this.dersListeToolStripMenuItem.Click += new System.EventHandler(this.dersListeToolStripMenuItem_Click);
            // 
            // altMenüToolStripMenuItem
            // 
            this.altMenüToolStripMenuItem.BackColor = System.Drawing.SystemColors.Menu;
            this.altMenüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelGirişToolStripMenuItem,
            this.personelListeToolStripMenuItem});
            this.altMenüToolStripMenuItem.Name = "altMenüToolStripMenuItem";
            this.altMenüToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.altMenüToolStripMenuItem.Text = "Personel";
            // 
            // personelGirişToolStripMenuItem
            // 
            this.personelGirişToolStripMenuItem.Name = "personelGirişToolStripMenuItem";
            this.personelGirişToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.personelGirişToolStripMenuItem.Text = "Personel Giriş";
            this.personelGirişToolStripMenuItem.Click += new System.EventHandler(this.personelGirişToolStripMenuItem_Click);
            // 
            // personelListeToolStripMenuItem
            // 
            this.personelListeToolStripMenuItem.Name = "personelListeToolStripMenuItem";
            this.personelListeToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.personelListeToolStripMenuItem.Text = "Personel Liste";
            this.personelListeToolStripMenuItem.Click += new System.EventHandler(this.personelListeToolStripMenuItem_Click);
            // 
            // öğrenciToolStripMenuItem
            // 
            this.öğrenciToolStripMenuItem.BackColor = System.Drawing.SystemColors.Menu;
            this.öğrenciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciGriişToolStripMenuItem,
            this.öğrenciListeToolStripMenuItem,
            this.öğrenciDerslerToolStripMenuItem});
            this.öğrenciToolStripMenuItem.Name = "öğrenciToolStripMenuItem";
            this.öğrenciToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.öğrenciToolStripMenuItem.Text = "Öğrenci";
            // 
            // öğrenciGriişToolStripMenuItem
            // 
            this.öğrenciGriişToolStripMenuItem.Name = "öğrenciGriişToolStripMenuItem";
            this.öğrenciGriişToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.öğrenciGriişToolStripMenuItem.Text = "Öğrenci Griiş";
            this.öğrenciGriişToolStripMenuItem.Click += new System.EventHandler(this.öğrenciGriişToolStripMenuItem_Click);
            // 
            // öğrenciListeToolStripMenuItem
            // 
            this.öğrenciListeToolStripMenuItem.Name = "öğrenciListeToolStripMenuItem";
            this.öğrenciListeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.öğrenciListeToolStripMenuItem.Text = "Öğrenci Liste";
            this.öğrenciListeToolStripMenuItem.Click += new System.EventHandler(this.öğrenciListeToolStripMenuItem_Click);
            // 
            // öğrenciDerslerToolStripMenuItem
            // 
            this.öğrenciDerslerToolStripMenuItem.Name = "öğrenciDerslerToolStripMenuItem";
            this.öğrenciDerslerToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.öğrenciDerslerToolStripMenuItem.Text = "Öğrenci Dersler";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 625);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1221, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel1.Text = "Durum";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1221, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Deneme formu 1",
            "Deneme formu 2",
            "Deneme formu 3"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1221, 647);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem altMenüToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersGirişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersListeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelGirişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelListeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciGriişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciListeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciDerslerToolStripMenuItem;
    }
}
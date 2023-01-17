using WindowsFormsApp_FinalProject.STForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_FinalProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            SetStatus((ToolStripMenuItem)sender);

        }

        private void childFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SetStatus((ToolStripMenuItem)sender);
        }
        private void form1FormToolStripMenuItem_Click(object sender, EventArgs e)
        {            

            SetStatus((ToolStripMenuItem)sender);
        }

        private void SetStatus(ToolStripMenuItem toolStripMenuItem)
        {
            toolStripStatusLabel1.Text = toolStripMenuItem.Text + " Tıklandı";
        }

        private void mdiparentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SetStatus((ToolStripMenuItem)sender);
        }

        private void dosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulamadan Çıkılsın mı", "MainForm Yanıt Mesajı");

            this.Hide();
        }

        private void dersGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var stDersGiris = new STDersGirisForm();
            stDersGiris.MdiParent = this;
            stDersGiris.Show();
            SetStatus((ToolStripMenuItem)sender);
        }

        private void personelGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var prsGirisForm = new STPersonelGirisForm();
            prsGirisForm.MdiParent = this;
            prsGirisForm.Show();            
            SetStatus((ToolStripMenuItem)sender);
        }

        private void öğrenciGriişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ogrGirisForm = new STOgrenciGirisForm();
            ogrGirisForm.MdiParent = this;
            ogrGirisForm.Show();
            SetStatus((ToolStripMenuItem)sender);
        }

        private void dersListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dersListeForm = new STDersListeForm();
            dersListeForm.MdiParent = this;
            dersListeForm.Show();
            SetStatus((ToolStripMenuItem)sender);
        }

        private void öğrenciListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ogrenciListeForm = new STOgrenciListeForm();
            ogrenciListeForm.MdiParent = this;
            ogrenciListeForm.Show();
            SetStatus((ToolStripMenuItem)sender);
        }

        private void personelListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var personelListeForm = new STPersonelListeForm();
            personelListeForm.MdiParent = this;
            personelListeForm.Show();
            SetStatus((ToolStripMenuItem)sender);
        }
    }
}

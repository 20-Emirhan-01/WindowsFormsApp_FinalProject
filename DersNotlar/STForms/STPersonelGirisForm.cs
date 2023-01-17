using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_FinalProject.STForms
{
    public partial class STPersonelGirisForm : Form
    {
        public STPersonelGirisForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text == string.Empty)
            { 
                MessageBox.Show("Lütfen Ad Soyad Giriniz");
                return;
            }
            if (txtDogumTarih.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Doğum Tarihini Giriniz");
                return;
            }
            if (comboBolum.SelectedItem is null)
            {
                MessageBox.Show("Lütfen Bölüm Giriniz");
                return;
            }
            if (txtGirisTarih.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Giriş Tarihini Giriniz");
                return;
            }

            try
            {
                var ctx = new YeniEntities();
                var stprs = new STPersonel()
                {
                    AdSoyad = txtAdSoyad.Text,
                    DogumTarih = DateTime.Parse(txtDogumTarih.Text),
                    Bolum = comboBolum.SelectedIndex,
                    GirisTarih = DateTime.Parse(txtGirisTarih.Text).Year,
                };
                ctx.STPersonels.Add(stprs);
                ctx.SaveChanges();
                MessageBox.Show("Personel başarıyla kaydedilmiştir :) ");
                txtAdSoyad.Text = string.Empty;
                txtDogumTarih.Text = string.Empty;
                comboBolum.SelectedItem = null;
                txtGirisTarih.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydedilirken bir sorun oluştu !! => "  + ex.ToString());
            }           

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}

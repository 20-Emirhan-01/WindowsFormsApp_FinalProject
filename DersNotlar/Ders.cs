using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_FinalProject
{
    public class Ders
    {
        public string Ad { get; set; }

        public int OgrenciSayi { get; set; }

        public DateTime DersSaati;

        public string Ogretmen { get; set; }

        public string icerikDegistir { get; private set; } = "degistir";

        // yapici method
        public Ders() {
        
        }

        public string SadeceBurdaDegisir()
        {
            return this.icerikDegistir = "degisti :)";
        }

        public int OgrenciSayisiGoster()
        {
            return OgrenciSayi;
        }

        public void OgrenciSayiEkle(int s)
        {
            this.OgrenciSayi +=  s;
        }
    }


    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    public class DersKullan
    {

        //yapici method
        public DersKullan() 
        { 
            Ders d = new Ders();
            d.Ad = "lesson";
            //d.icerikDegistir = "23";
            d.SadeceBurdaDegisir();
            d.OgrenciSayiEkle(10);
            var kacOgrenci = d.OgrenciSayisiGoster(); 
        }
    }
}

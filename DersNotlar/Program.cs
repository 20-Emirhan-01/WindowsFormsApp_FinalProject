using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_FinalProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
       
        [STAThread]
        static void Main()
        {
            //Test();
            Donguler();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            //Application.Run(new Form1());
            //Application.Run(new Yeni());
            //Application.Run(new MDIParent1());
        }

        private static void Test()
        {            
            var ctx = new YeniEntities();



        }

        private static void Donguler()
        {
            //var deger = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    deger = i;
            //}

            //int j = 0;
            //while (j < 11)
            //{ 
            //    deger = j;
            //    j++;
            //}           
            //var t = deger;

            string s = "degiskin";
            
            List<string> strings = new List<string>();
            strings.Add("Melih");
            strings.Add("Ozan");
            strings.Add("Mehmet");

            List<string> strings1 = new List<string>() { "Ayşe", "İrem", "Hüseyin" };

            List<int> sayilar = new List<int>() { 1, 2, 3, 4 };

            Ders d = new Ders();
            d.Ad = "lesson";

            List<object> list = new List<object>();
            list.Add(1);
            list.Add("deneme");
            list.Add(strings);
            list.Add(d);

            list.RemoveAt(2);

            list.Remove(1);
            list.Remove(d);            

            //var ilkdeger = list[3];

            foreach (var item in list)
            {
                
            }

            string[] strings2 = new string[2];
            strings2[0] = "12";
            strings2[1] = "123";

            foreach (var item in strings2)
            {

            }            

        }

        private static void degiskenler()
        {
            #region Sayisal Degisken
            //8-bit unsigned integer.
            byte by = 255;

            //8-bit signed integer.
            sbyte sb = sbyte.MaxValue;

            //int 16 bit
            short s = short.MinValue;

            // 16-bit unsigned integer.
            ushort u = ushort.MinValue;

            //int 32 bit
            int i = int.MinValue;

            //32 - bit unsigned integer
            uint ui = uint.MinValue;

            // 64-bit signed integer
            long l = long.MinValue;            

            //32 - bit unsigned integer
            uint k = uint.MinValue;

            float f = 2f;

            double d = 2.2;

            //variable set double
            var fk = 1d;
            #endregion

            #region Sozel Degisken
            string t = "test";

            var td = "test";
            #endregion

            bool b = true;
            bool bd = false;

            DateTime dateTime = DateTime.Now;

            object o = new object();
            o = 2;
            o = "12";
            

        }
    }
}

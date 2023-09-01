using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELEGATE
{
    internal class Program
    {
        private const char V = 'a';

        static void Main()
        {
            DosyaIslemleri islem = new DosyaIslemleri("abc.txt");
            islem.DosyaSilindiginde += MetotCalistir;
            islem.DosyayiSil();
            String str = new String('c', 20);
            Console.WriteLine(str);
            Console.ReadKey();
        }

        static void MetotCalistir(object sender, SonucArgs e)
        {
            Console.WriteLine("Dosya: {0}", e.Dosya);
            Console.WriteLine("Mesaj: {0}", e.Mesaj);
            Console.WriteLine("Tarih: {0}", e.Tarih);
        }
    }

    class SonucArgs : EventArgs
    {
        public string Dosya;
        public string Mesaj;
        public DateTime Tarih;

        public SonucArgs(string dosya, string mesaj, DateTime tarih)
        {
            this.Dosya = dosya;
            this.Mesaj = mesaj;
            this.Tarih = tarih;
        }
    }

    class DosyaIslemleri
    {
        private string Dosya;
        public EventHandler<SonucArgs> DosyaSilindiginde;  // event

        public DosyaIslemleri(string dosya)
        {
            this.Dosya = dosya;
        }

        public void DosyayiSil()
        {
            if (File.Exists(this.Dosya))
            {

                File.Delete(this.Dosya);
                if (this.DosyaSilindiginde != null)
                {
                    this.DosyaSilindiginde(this, new SonucArgs(this.Dosya, "Dosya silindi.", DateTime.Now));
                }
            }
            else
            {
                if (this.DosyaSilindiginde != null)
                {
                    this.DosyaSilindiginde(this, new SonucArgs(this.Dosya, "Dosya olmadığından dolayı silinemedi.", DateTime.Now));
                }
                // this.DosyaSilindiginde?.Invoke(this, new SonucArgs(this.Dosya, "Dosya olmadığından silinemedi.", DateTime.Now));
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_PersonelUygulamasi
{
    class Personel
    {
        public static string domainAdres;
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        private string emailAdres;
        public string EmailAdres
        {
            get
            {
                return this.emailAdres;
            }
            set
            {
                this.emailAdres = value.ToLower() + "@" + Personel.domainAdres;
            }
        }

        public int Cinsiyet { get; set; }

        public Personel()
        {
            Console.WriteLine("Her örneklemede çalışan metod");
        }
        static Personel()
        {
            domainAdres = "firmam.com";
        }
    }
}

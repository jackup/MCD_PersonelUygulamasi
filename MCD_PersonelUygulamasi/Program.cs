using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_PersonelUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Helper g = new Helper(); static class'tan instance oluşturulamaz.
            Personel p1 = new Personel();
            p1.Isim = "Yakup";
            p1.Soyisim = "Kömük";
            p1.EmailAdres = "yakup.komuk";
            p1.Cinsiyet = 717770001; //-->Bay, 717770002 -->Bayan

            Personel p2 = new Personel();
            p1.Isim = "Ali";
            p1.Soyisim = "Gel";
            p1.EmailAdres = "ali.gel";
            p1.Cinsiyet = 717770001;

            Helper.EmailGonder("ik.firmam.com", "Yeni Personel Bilgilendirme", p1.Isim + p1.Soyisim);
            Helper.EmailGonder("ik.firmam.com", "Yeni Personel Bilgilendirme", p2.Isim + p2.Soyisim);


        }
    }
}

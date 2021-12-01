using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_PersonelUygulamasi
{
    public static class Helper
    {
        //public void Test() { } Static class içinde static olmayan metod oluşturulamaz.
        //public string Tanim { get; set; } Static class içinde static olmayan field - property tanımlamaları yapılamaz.

        static Helper()
        {
            //Uygulama içerisinde ne kadar çağırılırsa çağırılsın sadece ilk çağrılmada çalışırlar.
            Console.WriteLine("Helper => Static Class => Static CTOR");
        }



        public static void EmailGonder(string aliciEmailAdres, string konu, string icerik)
        {
            //Mail gönderme işlemleri devam edecek..
            Console.WriteLine("Mail gönderim işlemi başarılı");
        }
    }
}

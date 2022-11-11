using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " Eklendi");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("\n"+"Ad: "+musteri.Ad + "\n" + "Soyad: "+musteri.SoyAd + "\n" + "Id: "+musteri.Id+"\n"+"Meslek :"+musteri.Meslek);            
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id+" ID'li müşteri silindi ");
        }
    }
}

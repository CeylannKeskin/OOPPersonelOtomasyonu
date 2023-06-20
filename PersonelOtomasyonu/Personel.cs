using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelOtomasyonu
{
    public class Personel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCKN { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Email { get; set; }
        public string TelefonNumarasi { get; set; }
        public string Adres { get; set; }
        public DateTime IseGirisTarihi { get; set; }
        public Unvan Unvan { get; set; }
        public string PersonelResmi { get; set; }
        public object Tag { get; set; }//satıra eklenen personelin bilgilerinin bir kopyasını veya herhangi bir bilginin kopyasını içerisinde tutacak.
    }

    
}

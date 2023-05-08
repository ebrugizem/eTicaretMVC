using eticaretMVC.Models;

namespace eticaretMVC.Data
{
    public class FakeData
    {
        public List<Urun> Urunler = new List<Urun>
        {
            new Urun{Barkod= 1111 , Marka="Lenovo", Ad="Dizüstü Bilgisayar",Kategori="Elektronik", Fiyat=17.999 ,Resim="Lenovo.jpg"},    // Urunler[0]
            new Urun{Barkod= 1112 , Marka="Bosch", Ad="Buzdolabı",Kategori="Beyaz Eşya", Fiyat=20.599 ,Resim="Bosch.jpg"},              // Urunler[1]
            new Urun{Barkod= 1113 , Marka="Giorgio Armani", Ad="Si Parfume",Kategori="Kozmetik", Fiyat=1.792 ,Resim="Giorgio Armani.jpg"},
            new Urun{Barkod= 1114 , Marka="Albert Camus", Ad="Veba",Kategori="Kitap", Fiyat=25.00 ,Resim="Kitap.jpg"},
            new Urun{Barkod= 1115 , Marka="Uni Baby", Ad="Bebek Arabası",Kategori="Anne-Bebek", Fiyat=2.999 ,Resim="Bebek arabası.jpg"}
        };
    }
}

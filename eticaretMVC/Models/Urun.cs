namespace eticaretMVC.Models
{
    public class Urun
    {
        public int Barkod { get; set; } // ID 
        public string Marka { get; set; }
        public string Ad { get; set; }
        public string Kategori { get; set; }
        public double Fiyat { get; set; }
        //public string Aciklama { get; set; }
        public string Resim { get; set; }   // wwwroot/Resimler/ ().jpg
    }
}

namespace SQLRelations.BireCok
{

    /// <summary>
    ///         
    ///     Bire çok ilişkimizde çok olan modelimiz Ürün modelimizdeyiz.
    ///     Görüldüğü gibi sadece bir adet Kategori propertysi tanımlanmış.(25.Satır) Çünkü bir ürün sadece bir kategoriye ait olabilir.
    ///     Hangi ürün hangi kategoriye ait olduğunu belirleyebilmek ve bir ürünü ait olduğu kategoriye bağlayabilmek için;
    ///     
    ///         FOREIGN KEY'imizi burada tanımlıyoruz. (Bkz.KategoriId) => 21.Satır
    ///    
    ///     Artık iki Modelimiz de birbirine Bire çok ilişkiyle bağlandı. EF Core bu propertyleri bu şekilde tanımladığımız anda aralarındaki ilişkinin
    ///     nasıl olduğunu anlayabiliyor.
    ///     Olur da Foreign Key'imizi KategoriId olarak değil de başka bir isimle tanımlamak istersek de aralarındaki ilişkiyi FluentAPI yardımıyla da yapabiliriz.
    ///     (DataContext sınıfımızda FLUENTAPI ile de ilişkileri tanımlanmıştır.)
    ///     
    ///     DataContext sınıfı 31-34.satırlar.
    ///     
    /// </summary>

    public class Urun
    {
        public int Id { get; set; }
        public int KategoriId { get; set; } // Foreign Key
        public string Ad { get; set; }
        public string Tanim { get; set; }

        public Kategori Kategori { get; set; } //Navigation Property 
    }
}

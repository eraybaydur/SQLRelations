namespace SQLRelations.BireCok
{

    /// <summary>
    ///     Bire çok ya da One-to-many İlişki
    ///     -Eğer bir entity(model), başka bir entity'nin birden fazla kaydıyla ilişkili olacaksa; bu ilişkiye biz bire çok ilişki diyoruz.
    ///        Örneğin;
    ///             Bir üniversite düşünün, o üniversitenin birden fazla Fakültesi olabilirken, o fakültelerin sadece bir tane üniversitesi olabilir.
    ///             Modellerimiz ;
    ///                         
    ///                     - Universite  -->> Birden fazla Fakülteye sahip olacak > List<\Fakulte> Fakulteler {get;set;]
    ///                     - Fakulte     -->> Sadece bir üniversiteye sahip olabilir. >>>> Universite Universite {get;set;}
    ///             
    ///                                             #### ULUDAĞ ÜNİVERSİTESİ ####
    ///                                             -Eğitim Fakültesi
    ///                                             -İktisadi ve İdari Bilimler Fakültesi
    ///                                             -Mühendislik Fakültes
    ///                                             -Tıp Fakültesi
    ///                                             
    ///     Yukarıdaki örnekte Uludağ Üniversitesinin birden fazla Fakülteye sahip olduğunu ama fakültelerin Üniversitesinin de Uludağ Üniversitesi olduğunu görüyoruz.
    ///     Bu gibi ilişkilere Bire çok One-to-many ilişki diyoruz. Örnekler arttırılabilir. 
    ///     
    ///         => İl-İlçe
    ///         => Ülke - Şehir
    ///         => Mahalle - Seçmen
    ///         
    ///     Ve bu örneğimizde yaptığımız gibi Kategori-Ürün;
    ///         Burada mantık şu;
    ///             Bir Kategori'ye ait birden fazla ürün olabilir ama bir ürünün sadece bir kategorisi olabilir.
    ///             Elektronik adında bir kategorimiz olduğunu varsayalım:
    ///                 Elektronik kategorisi içerisinde : Televizyon, Akıllı Saat, Bilgisayar vs gibi birden fazla ürünü barındırabilirken
    ///                 bu ürünler sadece Elektronik kategorisine sahip olabilir.
    ///            Bu minvalde; aşağıda da görüldüğü gibi Ürün tipinde ICollection Urunler yapısını tanımlayarak, Kategoriye birden fazla Ürün tutacağını söylemiş
    ///            olduk.
    /// </summary>

    public class Kategori
    {
        public int Id { get; set; }
        public string Ad { get; set; } //Kategori Adı

        public ICollection<Urun> Urunler { get; set; } //Navigation Property
    }
}

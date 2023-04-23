namespace SQLRelations
{

    /// <summary>
    /// Bire bir ilişki (One-to-one)
    /// ->1.Bu örnekte her kullanıcının bir profile sahip olduğunu varsayıyoruz;
    ///      -Dolayısıyla her profilin de bir kullanıcısı olacak.
    ///      -Bunu Vatandaş - Kimlik kartı arasındaki ilişkiyi örnek alarak da metaforlaştırabiliriz.
    ///      -Her vatandaş bir ülkenin sadece bir kimlik kartına sahip olabilirken; her bir kimlik kartına sahip olabilecek de bir
    ///       vatandaş olabilir.
    ///       
    ///    İşte bu gibi birbirleri arasındaki ilişkileri tekil olabilen ilişki türüne "Bire bir (One-to-one)" diyoruz.
    ///    
    /// -> 2. İlişkiyi oluşturmak için her iki modelde de, ilişki kurulacak olan modelin "Navigation Property"'leri oluşturulur. 
    ///       (Bkz. Bu modelde Profil sınıfını navigation property olarak tanımladık.)
    ///       
    /// -> 3. Dependent Entity (Bağımlı Entity) -> Bir profil oluşturmak için öncelikle bir kullanıcıya ihtiyacımız var. Buradaki ilişkiyi
    ///       her ne kadar biz algılayabilsek de (Hangisi hangisine bağımlı) EF Core anlamlandıramıyor. Sonuçta modellerimiz X ve Y isimlerine
    ///       sahip de olabilirdi. Bu yüzden bizim bu ilişkiyi EF Core'un anlayabileceği şekilde oluşturmamız gerek.
    ///       
    ///       Peki bunu nasıl oluşturacağız ?
    ///         -İşte burada bize kolaylık sağlayan "FOREIGN KEY" özelliği.
    ///         
    ///       FOREIGN KEY: İkincil anahtar da denir.Bize hangi entity'nin hangi entity'e bağımlı olduğunu gösteren özelliktir. Bir modele
    ///       baktığımızda eğer bir FOREIGN KEY özelliği görüyorsak bu, o modelin bir dependent(bağımlı) entity olduğunu gösterir.
    ///       
    ///     Bu örnekte, herhangi bir bağımlılığımız yok, o yüzden FOREIGN KEY oluşturmadık.
    ///       
    /// </summary>


    public class Kullanici // Principal Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Profil Profil{ get; set; }
    }
}

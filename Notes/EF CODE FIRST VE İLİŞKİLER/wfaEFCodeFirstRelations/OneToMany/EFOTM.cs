//using Microsoft.EntityFrameworkCore;
//using System.ComponentModel.DataAnnotations.Schema;

//ESirketDbContext context = new();
/*
 * Bir Çalışanın bir departmanı olabilir.
 * Bir departmanın birden çok çalışanı olabilir.
 * Bu durumda 1 e çok ilişki kuracağız.
 */
#region Default Convetion
/*
 * 1 e çok ilişkilerde, Dependent entity'lerde foreign key tanımlamaya gerek yoktur.
 * Eğer biz navigation property'lerde bir çok ilişkiyi belirlersek entity framework foreignkey'e kendisi tanır ve oluşturur.
 * add-migraton komutundan sonra migration komutları incelenirde "Calisan" tablosunda DepartmanId kolonunun eklendiği görülebilir.
 * Anlaşılan o ki DepartmanId prop'unu Eklesekte Eklemesekte kendisi oluşturur.
 */
//class Calisan  //Dependent entity
//{
//    public int Id { get; set; }
//    public string Adi { get; set; }

//    //public int DepartmanId { get; set; } bu propu tanımlamak zorunda değiliz. ef core kendisi zaten tanımlar.

//    //Departman navigation prop'u.
//    //Dikkat edilmelidir ki tekil. Yani her bir çalışanın 1 departmanı olabilir.
//    public Departman Departman { get; set; }
//}

//class Departman
//{
//    public int Id { get; set; }
//    public string DepartmanAdi { get; set; }
//    //Buradaki navigation prop önemli
//    //ICollection veri tipi olmak zorunda (Doğrudan list<Calisan> demek doğru değildir. Bunun yerine liste özelliğine sahiptir demiş oluyoruz.)
//    //       ||         ICollection "generic type" olmak zorunda ve generic type = Calisan yani 1 e çok              ||         ilişkili tablo(entity)
//    //       ||          ||
//    //       ||          || Artık Değiken adı çoğul olmalı
//    //       ||          ||         ||
//    //       \/          \/         \/
//    public ICollection<Calisan> Calisanlar { get; set; }
//}
#endregion

#region Data Annotations
/*
 * Bilindiği üzere data annotations attribute'lar ile çalışır.
 * Ancak attribute kullanacaksak foreign key prop'unu tanımlamamız gerekir.
 * Eğer foreign key prop'u entitynameId olacaksa zaten data annotations yöntemine gerek yoktur.
 * ancak foreign key kolonunu adı farklı olacaksa o zaman data annotations kullanmak mantıklıdır.
 * Örnek (1)
 */
//class Calisan  //Dependent entity
//{
//    public int Id { get; set; }

//    [ForeignKey(nameof(Departman))] //Satır 59'da ki navigation prop'un adı olduğu unutulmamalı.
//    public int DId { get; set; }
//    public string Adi { get; set; }
//    public Departman Departman { get; set; }
//}

//class Departman
//{
//    public int Id { get; set; }
//    public string DepartmanAdi { get; set; }
//    public ICollection<Calisan> Calisanlar { get; set; }
//}
#endregion

#region Fluent API
/*
 * Sınıflarımızı (entity) tanımladıktan sonra yapmamız gereken tek şey navigation propları yazmaktır.
 * Ardından sınıflara (entity) dokunmuyoruz.
 * her şeyi context sınıfı içerisinde ki "OnModelConfigurations" metodunu ezerek yapıyoruz.
 */
//class Calisan  //Dependent entity
//{
//    public int Id { get; set; }
//    //public int DId { get; set; } eğer bu prop'u (Kolonu) fk yapmak istersek
//    public string Adi { get; set; }
//    public Departman Departman { get; set; }
//}

//class Departman
//{
//    public int Id { get; set; }
//    public string DepartmanAdi { get; set; }
//    public ICollection<Calisan> Calisanlar { get; set; }
//}
#endregion

//class ESirketDbContext : DbContext
//{
//    public DbSet<Calisan> Calisanlar { get; set; }
//    public DbSet<Departman> Departmanlar { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//    {
//        optionsBuilder.UseSqlServer("Data Source=desktop-ff31an2\\sqlexpress;InitCatalog=ESirketDb;TrustServerCertificate=True;Integrated Security=True;");
//    }

//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {

//        /*
//         * Yine burada dikkat edilmelidirki foreign key tanımlamasına ihtiyaç yoktur. 
//         * Hatta yapılmaması daha iyidir.
//         * Yine ef core bir çok ilişkiyi görünce kendisi otomatik olarak foreign key'i atayacaktır.
//         * Yine migrations sınıfında görülebilir
//         * Ancak Data Annotations'ta ki gibi foreign key'i biz veriyorsak. O zaman burada da Foreign Key'i tanımlamak zorundayız. Şu Şekilde (2)
//         * 
//         */
//        modelBuilder.Entity<Calisan>()
//            .HasOne(c => c.Departman) // Calısan, Departman'a 1 e şeklinde bağlı.
//            .WithMany(d => d.Calisanlar); // Departman, Calisanlar'a çok şeklinde bağlı.
//        //  .HasForeignKey(c => c.DId)
//        /*
//         * Burada fonksiyonların içi kafa karıştırıcı olabilir. Kısaca özetlersek
//         * 
//         * .HasOne(c => c.Departman) burada ki "c" ile Calisan sınıfına gittik ve özelliklerde gezindik. Bu sınıftaki Departman prop'unun 1 e çok ilişkide 1'i temsil ettiğini HasOne() metodu sayesinde söyledik.
//         * 
//         * bunu söyledikten sonra eğer biz fonksiyon daha eklemek istersek navigationpropun götürdüğü yere gitmiş oluruz.
//         * 
//         * c => c.Departman şartı; c.Departman navigation prop'u bizi artık Departman sınıfına götürdü
//         * 
//         * .WithMany(d => d.Calisanlar); metodu sayesinde "Departman" sınıfında ki "Calisanlar" navigation prop'unun 1 e çok ilişkide çoku temsil ettiğini .WithMany() metodu sayesinde söyledik.
//         * 
//         * d => d.Calisanlar şartı; d.Calisanlar navigation prop'u yüzünden bizi tekrar calisanlar sınıfına geri götürdü.
//         * 
//         * Çalışanlar sınıfına geri döndüğümüz için istersek veya eklemişsek foreign key'i burada .HasForeignKey() metodu ile tanımlayabiliriz. .HasForeignKey(c => c.DId) şeklinde.
//         */
//    }

//}
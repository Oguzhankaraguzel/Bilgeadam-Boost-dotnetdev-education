//using Microsoft.EntityFrameworkCore;
//using System.ComponentModel.DataAnnotations;

//EKitapDbContext context = new();

/*
 * Çoka çok ilişkilerde üçüncü bir tabloya ihtiyaç duyulur ve bu tabloya cross table denir.
 * Burada kitap sınıfına ya da yazar sınıfına bir fk ekleyemeyiz.
 * eklediğimiz an 1 e çok ilişkiye dönüşür.
 * burada bir cross table'a ihtiyacımız vardır. 
 * Bu tabloya kitap yazarları ya da yazar kitapları diyebiliriz.
 * Buradan elde edilen üçüncü tablo ile geri kalan iki tablo arasında 1 e çok ilişki kurularak dolaylı yoldan çoka çok ilişki kurulmuş olur.
 * Cross table'da primary key composite'tir. Yani 1 kitabı 1 den fazla yazar yaşmış olabilir ama o kitap için aynı yazar 1 den fazla kez tekrar edemez. Örnek;
 * kitap yazarları
 * kitapId  YazarId
 * 1            1
 * 1            2
 * 2            3
 * 2            1
 * 2            2
 * 2            1 Bu satır olamaz. Bunda dolayı composite pk gereklidir.
 */

#region Default Convention
/*
 * Burada çokka çok ilişki kuracakken
 * navigation proplar ile çoka çok olduğunu belli eden bir bağ kur.
 * ef core burada çoka çok ilişki olduğunu anlar.
 * ef core kendiliğinde cross table'ı oluşturur.
 * migration dosyası incelenirse kitapyazar adında bir cross table oluştuğu açıkca görülür. Orada şu sütuna oldukça dikkat edilmelidir.
 * 
 * table.PrimaryKey("PK_KitapYazar", x => new { x.KitaplarId, x.YazarlarId });
 * 
 * işte composite pk
 */
//class Kitap
//{
//    public int Id { get; set; }
//    public string KitapAdi { get; set; }
//    //public Yazar Yazar { get; set; } tekil bağı temsil eder. kullanamayız.
//    public ICollection<Yazar> Yazarlar { get; set; }
//}

//class Yazar
//{
//    public int Id { get; set; }
//    public string YazarAdi { get; set; }
//    public ICollection<Kitap> Kitaplar { get; set; }
//}
#endregion

#region Data Annotations
///*
// * Data Annotations kullanacaksak cross table'ı burada bizim oluşturmamız gerekiyor.
// * Artık biz navigation prop'larla çoka çok ilişki yapmayacağız. 1 e çok ilişki ile oluşturacağız.
// * Cross Table'a karşılık bir entity oluşturursak bunu context sınıfı içerisinde DbSet<> olarak tanımlamak zorunda değiliz.
// */
//class Kitap
//{
//    public int Id { get; set; }
//    public string KitapAdi { get; set; }
//    public ICollection<KitapYazar> Yazarlar { get; set; } //Burada değişken ismini KitapYazar olarak verebilirdik. Ancak kitabın bir özelliği olduğundan yazarlar adını vermek daha doğru olacaktır.
//}

////Cross table
////Burada composite key oluşturmak için her iki id prop'una da [Key] attribute'unu vermemiz gerekir.
////ancak bunu yapsak bile data annotations composite key oluşturmaz.
////hatta iki tane key olduğu için hata verir
////bunun için fluent api de çalışmamız gerekir. Ancak biz yinede bir çok ilişkilerde eğer crosstable'da sadece 1 pk ya sahipsek data annotations'u kullanabiliriz.
////Son olara kitapyazar cross table'ı içerisinde id proplarımızı entitynameId olarak tanımlarsak tepelerine fk attribute'u yazmak zorunda kalmayız
////Eğer biz bu propları KitapId ve YazarId olarak değilde KId ve YId olarak tanımlarsak ve tepelerine fk attribute'unu yazmazsak ef bize cross table'da KitapId ve YazarId olarak iki yeni sütun oluşturur.
//class KitapYazar
//{
//    //[Key] bunları sildikten sonra fluent api de ihtiyacımız olan kodları yazarız (1)
//    public int KitapId { get; set; }
//    //[Key]
//    public int YazarId { get; set; }
//    public Kitap Kitap { get; set; } //\\
//                                     //--> 1 e çok ilişkiye sağlayan navigation prop'lar
//    public Yazar Yazar { get; set; } ////
//}

//class Yazar
//{
//    public int Id { get; set; }
//    public string YazarAdi { get; set; }
//    public ICollection<KitapYazar> Kitaplar { get; set; }
//}
#endregion

#region Fluent API
///*
// * yine cross table manuel olarak oluşturulmalı.
// * Aynı şekilde DbSet<> oluşturmaya gerek yoktur
// * composite pk, haskey metodu ile oluşturulmalıdır.
// * Gerekli sınıflar (entity) oluşturulduktan sonra artık her şeyi context sınıfında fluent api ile yaparız.
// */
//class Kitap
//{
//    public int Id { get; set; }
//    public string KitapAdi { get; set; }
//    public ICollection<KitapYazar> Yazarlar { get; set; }
//}

//class KitapYazar
//{
//    public int KitapId { get; set; }
//    public int YazarId { get; set; }
//    public Kitap Kitap { get; set; } 
//    public Yazar Yazar { get; set; } 
//}

//class Yazar
//{
//    public int Id { get; set; }
//    public string YazarAdi { get; set; }
//    public ICollection<KitapYazar> Kitaplar { get; set; }
//}
#endregion

//class EKitapDbContext : DbContext
//{
//    public DbSet<Kitap> Kitaplar { get; set; }
//    public DbSet<Yazar> Yazarlar { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//    {
//        optionsBuilder.UseSqlServer("Data Source=desktop-ff31an2\\sqlexpress;InitCatalog=ESirketDb;TrustServerCertificate=True;Integrated Security=True;");
//    }

//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        //(Data annotations)
//        //modelBuilder.Entity<KitapYazar>() //(1) 
//        //    .HasKey(ky => new { ky.KitapId, ky.YazarId });
//        ///*
//        // * Burası kafa karıştırıcı olabilir.
//        // * Eğer burada .HasKey(ky => ky.YazarId ) deseydik YazarId pk olurdu
//        // * .HasKey(ky => ky.KitapId ) deseydik KitapId pk olurdu
//        // * .HasKey(ky => new { ky.KitapId, ky.YazarId }); yazarak bu yapı sayesinde yeni bir pk oluştururuz.
//        // */

//        modelBuilder.Entity<KitapYazar>() 
//            .HasKey(ky => new { ky.KitapId, ky.YazarId }); //Composite pk oluşturulur.

//        modelBuilder.Entity<KitapYazar>()//bu metot sayesinde 1 e çok ilişki kurulur.
//            .HasOne(ky => ky.Kitap)//KitapYazar sınıfında ki kitap navigation prop'u ilişki de 1 e kısmıdır
//            .WithMany(k => k.Yazarlar)//Kitap sınıfında ki Yazarlar Navigation prop'u ilişki de çok kısmıdır
//            .HasForeignKey(ky => ky.KitapId);//burada da kitapId nin fk olduğu belirtilir.

//        modelBuilder.Entity<KitapYazar>()//yukarıda ki açıklamanın aynısı burada da geçerlidir.
//            .HasOne(ky => ky.Yazar)//tabikide sınıf isimleri farklıdır.
//            .WithMany(k => k.Kitaplar)//navigation proplar sayesinde diğer sınıflara gittiğimiz unutulmamalı
//            .HasForeignKey(ky => ky.YazarId);//açıkça görülür ki kitaplar yazarlarla, yazarlar kitaplarla çoka çok ilişkiye sahiptir.
//    }
//}
//using Microsoft.EntityFrameworkCore;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//ESirketDbContext context = new();

#region Default Convetion

/*
 * Bu yaklaşımda da "navigation property" özelliklerini tanımlamamız gerekiyor.
 * 
 * Calisan sınıfında navigatin için diğer sınıfın türünde ve adında prop oluşturulmalı. (1)
 * Aynısı adres sınıfı içinde yapılmalı (1)
 * 
 * hangisi bağımlıysa bağımlı olduğu bir foreign key tanımlamamız gerekir (2)
 * Bu yöntemde ıd yazan proplar key olarak algılanır. Diğer Sınıfın ismi (entity) ve yanına ıd yazarsak foreign key olarak algılanır (2).
 * 
 * Her iki entity'de Navigation property ile birbirlerini tekil olarak referans ederek fiziksel bir ilişkinin olacağı ifade edilir.
 * 
 * one to one ilişki türünde, dependent entity'nin hangisi olduğunu default olarak belirleyebilmek pek kolay değildir. Bu durumda fiziksel olarak bir foreign key'e karşılık property/kolon tanımlayarak çözüm getirebiliyoruz.
 * 
 * Böylece foreign key'e karşılık property tanımlayarak lüzumsuz bir kolon oluşturmuş oluyoruz.
 */
//class Calisan
//{
//    public int Id { get; set; }

//    public string Adi { get; set; }

//    public CalisanAdresi CalisanAdresi { get; set; } //(1)
//}

//class CalisanAdresi
//{
//    public int Id { get; set; }

//    public int CalisanId { get; set; }//(2)
//    public string Adres { get; set; }

//    public Calisan Calisan { get; set; }
//}
#endregion

#region Data Annotations
///*
// * Bu yöntemde iki tablo arasındaki bağlantıyı kurmak için attribute kullanılır.
// * navigation property'ler yine kullanılır. Çünkü entityler arası fiziksel tanımlamalar sağlanmalı
// * foreign key için bir prop ekliyorduk. bu propa artık gerek yok. istersek ekleyebiliriz.
// * bu propu ekleyerek yaparsak (1)
// * Ancak bu propu eklemek ekstra bir kolon eklemek demektir ki bu da database'in maliyetini arttırır.
// * 
// * bunun yerine adreslerdeki ıd ile calisanlarda ki ıd ilişkilendirirsek maliyeti kısmış oluruz.
// * Ayrıca calisanlarda ki ıd'nin primar key olmasından gelen unique ve ıd özelliklerini kullanmış oluruz (2)
// * 
// * Bu sayede ıd'ler hem key olarak kullanılır ve unique sağlanır.
// * hem bire bir ilişki garanti altına alınır.
// * hem de maliyet kısılır.
// * 
// * Navigation property ler tanımlanmalıdır.
// * 
// * Eğer Foreign kolonunun ismi default convetion'ın dışında bir kolon olacaksa, Foreign key attribute'u ile bunu bildirebiliriz.
// * 
// * Foreign key kolonu oluşturulmak zorunda değildir.
// * 
// * 1'e 1 ilişkide fazladan foreign key kolonuna ihtiyaç olmayacağından dolayı dependent entity'deki Id kolonunun hem foreign key hem de primary key olarak kullanmayı tercih ediyoruz. Bu duruma özen gösterilmelidir.
// * 
// */
//class Calisan
//{
//    public int Id { get; set; }

//    public string Adi { get; set; }

//    public CalisanAdresi CalisanAdresi { get; set; } 
//}

//class CalisanAdresi
//{
//    //[ForeignKey(nameof(Calisan))]//(2)
//    //Yukarıda ki satır işe yarar. ancak primary key özelliği olmaz bunun için "key" attribute'u eklememiz gerekir.
//    //"key" attribute'unu kullanmak için
//    //using System.ComponentModel.DataAnnotations;
//    //using System.ComponentModel.DataAnnotations.Schema;
//    //ekli olmalı

//    [Key, ForeignKey(nameof(Calisan))]//(2)
//    public int Id { get; set; }
//    ////[ForeignKey("Calisan")](1)
//    ////[ForeignKey("Ahmet")](1)(1)
//    //[ForeignKey(nameof(Calisan))] //(1) en çok kullanılan yöntem
//    //public int CalisanId { get; set; }//(1)
//    //     ||
//    //     ||
//    //     \/
//    ////[ForeignKey("Calisan")](1)
//    ////[ForeignKey("Ahmet")](1)(1)
//    //[ForeignKey(nameof(Calisan))] //(1) en çok kullanılan yöntem
//    //public int C { get; set; }//(1)
//    /*
//     * Burada şu bilinmelidir ki; yukarıda ki şekilde yaparsak default convetion yontemi ile aynı şeyi yapmış oluruz ve gereksiz olur. 
//     * 
//     * buradaki asıl amaç foreign key adını değiştirebilmektir. Örnek olarak;
//     * 
//     * [ForeignKey(nameof(Calisan))] 
//        public int bicibici { get; set; }
//     *
//     * Burada da görüldüğü gibi foreign key adını zorunlu olarak CalisanId Diye vermek zorunda değiliz.
//     * 
//     * Artık default convetion'dan çıktık ve attribute kullanarak Data Annotations yöntemini kullandık.
//     * 
//     * bu yöntem bize daha fazla esneklik sağlar
//     *
//     */
//    public string Adres { get; set; }

//    public Calisan Calisan { get; set; } // public Calisan Ahmet { get; set; }(1)(1)
//}
#endregion

#region Fluent API
/*
 * Buradaki tüm işlemleri fluent api metodları üzerinden yapmaya çalışırız.
 * burada gerekli navigation propları açarız.(1)
 * Ardından sınıflarda hiç bir işlem yapmayız.
 * Doğrudan database'imizi temsil eden sınıfa (Context) gideriz ve orada "OnModelCreating" metodu ile gerekli pk fk tanımlamalarını yaparız (override edilmesi mecburi).(2)
 */
//class Calisan
//{
    
//    public int Id { get; set; }

//    public string Adi { get; set; }

//    public CalisanAdresi CalisanAdresi { get; set; }//(1)
//}

//class CalisanAdresi
//{
    
//    public int Id { get; set; }
   
//    public string Adres { get; set; }

//    public Calisan Calisan { get; set; } //(1)
//}
#endregion

//class ESirketDbContext : DbContext
//{
//    public DbSet<Calisan> Calisanlar { get; set; }
//    public DbSet<CalisanAdresi> CalisanAdresleri { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//    {
//        optionsBuilder.UseSqlServer("Data Source=desktop-ff31an2\\sqlexpress;InitCatalog=ESirketDb;TrustServerCertificate=True;Integrated Security=True;");
//    }

//    //Eğer Data annotation veya Default Convetion'u çalıştıracaksak bu metoda gerek yok. Yorum satırına alınmalı
//    //Model'ların(entity) veri tabanında "generate" edilecek yapılarının konfigürasyonları bu fonksiyon içerisinde tanımlanır.

//    protected override void OnModelCreating(ModelBuilder modelBuilder) //(2)
//    {
//        //                                                   /\
//        //                                                   ||
//        //burada ki yapılan çalışmaya fluent api denir.
//        //  ||      Entity = böyle tablo gibin bişey
//        //  ||        ||    Tablomuzun ismi
//        //  ||        ||       ||
//        //  \/        \/       \/
//        modelBuilder.Entity<Calisan>()
//        //Bire bir ilişki için aşağıdaki metod kullanılır. Ancak dikkat edilmelidir ki entity fonksiyonu "generic type" 'olarak kullanılmıştır.
//        //bunun sebebi üzerinde çalıştığımız tablo "Calisan". 
//        //ardından hasone metodu ile ilişli belirtilir. hasone(c = Calisan, c.CalisanAdresi = navigation prop)
//            .HasOne(c => c.CalisanAdresi)//Dikkat burada 1 e dedik ve kaldık. Burada navigation propun gosterdiği tabloya gittik.
//        //WithOne metodunu kullanarak 1 e 1 demiş olduk.
//        //Dikkat edilmelidir ki bu metodun içinde ki c artık değişti. Şöyleki
//        //Yukarıda ki metotda c.CalisanAdresi artık bizi "CalisanAdresi" sınıfına götürdü.
//        //.WithOne(c => c.); noktayı yazdığınız an açılan pencereden bakarsanız artık adres prop'unu görebilirsiniz.
//        //Ancak burada da sunu yapıcaz ve "CalisanAdresi" entity'sine gittikten sonra orada ki navigation prop'u kullanacağız. Böylece 1 e 1 ilişki kurulmuş olacak.
//            .WithOne(c => c.Calisan)
//        //Ancak burada hala Hangisinin bağımlı "dependent" olduğu belirtilmedi. Ancak anlaşılması çok kolay;
//        //burada ki c hala "CalisanAdresi" sınıfı ya da entity'sindedir.
//        //Bu metod ile Calisan adresinin içerisinde ki Id kolonunun foreign key olduğunu bildirdik.
//        //Ancak burada Calisan adresinin içerisinde ki Id kolonunun primary key özelliği ezilir.
//        //bunu önlemek için onun bir pk olduğu başka bir modelbuilder'da tanımlanır.(2)
//            .HasForeignKey<CalisanAdresi>(c => c.Id);

//        modelBuilder.Entity<CalisanAdresi>()
//            .HasKey(c => c.Id); //(2)

//        /*
//         * Burada kafa karışmasın fluent api de Id sütunlarının key özellikleri sütunun ismini Id olarak vermemiz sayesinde sağlanır.
//         * 
//         * ancak biz bu Id sütununu fk olarak tanımlarsak pk özelliği ezilir.
//         * 
//         * fk olarak tanımladıktan sonra pk olduğunu (2) ayriyetten tanımlamamız gerekir. 
//         */
//    }
//}

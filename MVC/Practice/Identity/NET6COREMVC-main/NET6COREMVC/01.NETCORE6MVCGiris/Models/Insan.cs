namespace _01.NETCORE6MVCGiris.Models
{
    public class Insan
    {
        public int Id { get; set; }
        public string AdiSoyadi { get; set; }
        public int DogumYili { get; set; }

        public Insan()
        {

        }
        public Insan(int id,string adiSoyadi, int dogumYili)
        {
            Id = id;
            AdiSoyadi = adiSoyadi;
            DogumYili = dogumYili;
        }
        public Insan(string adiSoyadi, int dogumYili)
        {
            AdiSoyadi = adiSoyadi;
            DogumYili = dogumYili;
        }
    }
}

namespace KitapYazarApi.Model
{
    public class BookTypeOfBook
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public TypeOfBook TypeOfBook { get; set; }
    }
}

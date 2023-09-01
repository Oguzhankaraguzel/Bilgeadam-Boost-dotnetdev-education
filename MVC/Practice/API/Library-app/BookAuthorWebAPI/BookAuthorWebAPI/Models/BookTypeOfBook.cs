namespace BookAuthorWebAPI.Models
{
    public class BookTypeOfBook
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public TypeOfBook TypeOfBook { get; set; }
    }
}

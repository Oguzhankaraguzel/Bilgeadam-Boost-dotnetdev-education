namespace KitapYazarApi.Model
{
    public class Book
    {
        public Book()
        {
            BookTypeOfBooks = new HashSet<BookTypeOfBook>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<BookTypeOfBook> BookTypeOfBooks { get; set; }
        public Author Author { get; set; }
    }
}

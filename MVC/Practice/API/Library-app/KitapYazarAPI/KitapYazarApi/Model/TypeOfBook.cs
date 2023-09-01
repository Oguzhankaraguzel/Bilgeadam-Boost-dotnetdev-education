namespace KitapYazarApi.Model
{
    public class TypeOfBook
    {
        public TypeOfBook()
        {
            BookTypeOfBooks = new HashSet<BookTypeOfBook>();
        }
        public int Id { get; set; }
        public string Type { get; set; }
        public virtual ICollection<BookTypeOfBook> BookTypeOfBooks  { get; set; }
    }
}

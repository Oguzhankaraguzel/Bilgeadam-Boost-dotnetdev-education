namespace KitapYazarApi.DTO
{
    public class EditBookDTO
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public List<string> Type { get; set; }
    }
}

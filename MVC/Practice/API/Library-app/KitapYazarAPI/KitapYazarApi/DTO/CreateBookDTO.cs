namespace KitapYazarApi.DTO
{
    public class CreateBookDTO
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public List<string> Type { get; set; }
    }
}

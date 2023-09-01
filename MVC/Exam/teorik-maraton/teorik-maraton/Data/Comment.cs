namespace teorik_maraton.Data
{
    public class Comment
    {
        public int Id { get; set; }
        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public int VideoId { get; set; }
        public virtual Video Video { get; set; }
    }
}

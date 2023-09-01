namespace teorik_maraton.Data
{
    public class VideoCategory
    {
        public int Id { get; set; }
        public int VideoId { get; set; }
        public int CategoryId { get; set; }
        public virtual Video Video { get; set; }
        public virtual Category Category { get; set; }

    }
}

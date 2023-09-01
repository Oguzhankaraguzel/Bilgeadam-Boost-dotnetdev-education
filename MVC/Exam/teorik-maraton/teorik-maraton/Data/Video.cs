namespace teorik_maraton.Data
{
    public class Video
    {
        public Video()
        {
            VideoCategory = new HashSet<VideoCategory>();
        }
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public virtual ICollection<VideoCategory> VideoCategory { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}

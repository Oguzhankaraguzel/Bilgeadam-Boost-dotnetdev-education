namespace teorik_maraton.Data
{
    public class Category
    {
        public Category()
        {
            VideoCategory = new HashSet<VideoCategory>();
        }
        public int Id { get; set; }
        public virtual ICollection<VideoCategory> VideoCategory { get; set; }
    }
}

namespace azicloud.wiki.DTOs
{
    public class PostWikiCategoryDto
    {
        public int Id { get; set; }
        public long uId { get; set; }
        public long parent_id { get; set; }
        public long image_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
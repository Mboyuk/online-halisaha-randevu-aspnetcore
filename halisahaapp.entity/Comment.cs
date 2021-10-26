namespace halisahaapp.entity
{
    public class Comment
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string CommentContent { get; set; }
        public double point { get; set; }
        public string ImgUrl { get; set; }
        public string NickName { get; set; }
        public int HalisahaId { get; set; }

        public Halisaha Halisaha { get; set; }
    }
}
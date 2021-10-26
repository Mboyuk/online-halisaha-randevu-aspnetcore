using System.Collections.Generic;
using halisahaapp.entity;
using halisahaapp.webui.Identity;

namespace halisahaapp.webui.Models
{
    public class CommentAndUserModel
    {
         public string UserId { get; set; }
        public string CommentContent { get; set; }
        public double point { get; set; }
        public int HalisahaId { get; set; }
        public string   UserName { get; set; }
        public string ImgUrl { get; set; }
        public List<Comment> Comments { get; set; }
        public List<User> Users {get;set;}
    }
}
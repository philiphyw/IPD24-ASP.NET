using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace day04RazorBlog.Model
{
    public class Article
    {
        [Key] public int Id { get; set; }
        //public User Author { get; set; }
        public IdentityUser Author { get; set; }

        public string Title { get; set; }
        public string Body { get; set; }
        public System.DateTime CreatedIn { get; set; }
    }
}
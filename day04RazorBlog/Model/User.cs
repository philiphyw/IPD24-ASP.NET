using System.ComponentModel.DataAnnotations;

namespace day04RazorBlog.Model
{
    public class User
    {
        [Key]public int Id { get; set; }

        [Required, StringLength(50, MinimumLength = 3,ErrorMessage = "UserName should be minimum 3 characters and a maximum of 50 characters")]public string UserName { get; set; }

        [Required, DataType(DataType.Password)] public string Password { get; set; }

        [Compare("User.Password", ErrorMessage = "The fields Password and PasswordConfirmation should be equals")]  
        public string PasswordConfirmation { get; set; }  
        public bool isAdmin { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Day04RazorBlog.Pages
{
    public class RegisterModel : PageModel
    {
        UserManager<IdentityUser> userManager;
        SignInManager<IdentityUser> signInManager;

        [BindProperty] public InputModel Input { get; set; }
        public string ReturnUrl { get; set; }

        public RegisterModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public class InputModel{
            [Required]
            [EmailAddress]
            [Display(Name="Email")]
            public string Email { get; set; }
        }


        public void OnGet()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using day01RazorPageUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace day01RazorPageUI.Pages.Forms
{
    public class AddAddressModel : PageModel
    {
        [BindProperty]
        public AddressModel Address { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }
            return Page();
            //return RedirectToPage("Index", new {City = Address.City});
        }
    }
}

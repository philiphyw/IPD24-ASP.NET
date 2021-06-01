using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using day02RazorMyFriends.Data;
using day02RazorMyFriends.Models;

namespace day02RazorMyFriends.Pages_Friends
{
    public class CreateModel : PageModel
    {
        private readonly day02RazorMyFriends.Data.FriendsContext _context;

        public CreateModel(day02RazorMyFriends.Data.FriendsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Friend Friend { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Friends.Add(Friend);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

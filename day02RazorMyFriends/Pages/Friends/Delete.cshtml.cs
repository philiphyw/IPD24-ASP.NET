using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using day02RazorMyFriends.Data;
using day02RazorMyFriends.Models;

namespace day02RazorMyFriends.Pages_Friends
{
    public class DeleteModel : PageModel
    {
        private readonly day02RazorMyFriends.Data.FriendsContext _context;

        public DeleteModel(day02RazorMyFriends.Data.FriendsContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Friend Friend { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Friend = await _context.Friends.FirstOrDefaultAsync(m => m.Id == id);

            if (Friend == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Friend = await _context.Friends.FindAsync(id);

            if (Friend != null)
            {
                _context.Friends.Remove(Friend);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using day02RazorMyFriends.Data;
using day02RazorMyFriends.Models;

namespace day02RazorMyFriends.Pages_Friends
{
    public class EditModel : PageModel
    {
        private readonly day02RazorMyFriends.Data.FriendsContext _context;

        public EditModel(day02RazorMyFriends.Data.FriendsContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Friend).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FriendExists(Friend.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FriendExists(int id)
        {
            return _context.Friends.Any(e => e.Id == id);
        }
    }
}

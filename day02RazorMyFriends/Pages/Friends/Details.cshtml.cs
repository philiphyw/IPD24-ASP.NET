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
    public class DetailsModel : PageModel
    {
        private readonly day02RazorMyFriends.Data.FriendsContext _context;

        public DetailsModel(day02RazorMyFriends.Data.FriendsContext context)
        {
            _context = context;
        }

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
    }
}

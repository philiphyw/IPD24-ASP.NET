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
    public class IndexModel : PageModel
    {
        private readonly day02RazorMyFriends.Data.FriendsContext _context;

        public IndexModel(day02RazorMyFriends.Data.FriendsContext context)
        {
            _context = context;
        }

        public IList<Friend> Friend { get;set; }

        public async Task OnGetAsync()
        {
            Friend = await _context.Friends.ToListAsync();
        }
    }
}

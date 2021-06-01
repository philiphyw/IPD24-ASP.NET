using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using day02RazorBookList.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace day02RazorBookList.Pages.BookList
{
    public class IndexModel : PageModel
    {
        //since the DbContext has been injected into the configuration pipeline in the Startup.cs, it can be call from IOC by following command
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Book> Books { get; set; }

        //When using Async method in EF, the return indicator "void" need to change to "async Task" 
        // public void OnGet() = >  public async Task OnGet()
        public async Task OnGet()
        {
            Books = await _db.Book.ToListAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using day02RazorBookList.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace day02RazorBookList.Pages.BookList
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Book Book { get; set; }

        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task OnGet(int id)
        {
            Book = await _db.Book.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                 _db.Book.Remove(Book);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                //show the page agian and error msg will show automatically
                return Page();
            }
        }
    }
}

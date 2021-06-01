using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using day01RazorBakery.Data;
using day01RazorBakery.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
namespace day01RazorBakery.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Day01RazorBakeryContext db;  
        public IndexModel(Day01RazorBakeryContext db) => this.db = db;
        public List<Product> Products { get; set; } = new List<Product>();  
        public Product FeaturedProduct { get; set; }  
        public async Task OnGetAsync()
        {
            Products = await db.Products.ToListAsync();
            FeaturedProduct = Products.ElementAt(new Random().Next(Products.Count));
        }
    }
}
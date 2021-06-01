using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace day01RazorPageUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                firstName = "Guest User";
            }

            if (Id==0)
            {
                Id = 99;
            }
        }

        [BindProperty(SupportsGet =true)]
        public int Id { get; set; }

        [BindProperty(SupportsGet = true)]
        public string firstName { get; set; }

        public void OnPost()
        {
      
        }

    }
}

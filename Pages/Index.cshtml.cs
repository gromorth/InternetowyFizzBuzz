using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternetowyFizzBuzz.Models;
using InternetowyFizzBuzz.Data;

namespace InternetowyFizzBuzz.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly FizzContex _context;

        public IList<FizzBuzz> FizBuz { get; set; }

        [BindProperty]
        public FizzBuzz Fizbuz { get; set; }

        public IndexModel(ILogger<IndexModel> logger, FizzContex context)
        {
            _logger = logger;
            _context = context;
        }
         public void OnGet()
        {
            FizBuz = _context.FizzBuzz.ToList();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                Fizbuz.Fizzbuzz();
                HttpContext.Session.SetString("FizzBazz",JsonConvert.SerializeObject(Fizbuz));
               
                _context.FizzBuzz.Add(Fizbuz);
                await _context.SaveChangesAsync();

                return RedirectToPage("./OstatnioSzukane");
            }
            return Page();
        }

    }
}

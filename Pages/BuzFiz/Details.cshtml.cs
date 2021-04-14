using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InternetowyFizzBuzz.Data;
using InternetowyFizzBuzz.Models;

namespace InternetowyFizzBuzz.Pages.BuzFiz
{
    public class DetailsModel : PageModel
    {
        private readonly InternetowyFizzBuzz.Data.FizzContex _context;

        public DetailsModel(InternetowyFizzBuzz.Data.FizzContex context)
        {
            _context = context;
        }

        public FizzBuzz FizzBuzz { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FizzBuzz = await _context.FizzBuzz.FirstOrDefaultAsync(m => m.Id == id);

            if (FizzBuzz == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

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
    public class IndexModel : PageModel
    {
        private readonly InternetowyFizzBuzz.Data.FizzContex _context;

        public IndexModel(InternetowyFizzBuzz.Data.FizzContex context)
        {
            _context = context;
        }

        public IList<FizzBuzz> FizzBuzz { get;set; }

        //public FizzBuzz Fizbuz { get; set; }

        public async Task OnGetAsync()
        {
            FizzBuzz = await _context.FizzBuzz.OrderByDescending(x=>x.Data).Take(10).ToListAsync();
        }
    }
}

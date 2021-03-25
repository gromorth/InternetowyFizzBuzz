﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternetowyFizzBuzz.Models;

namespace InternetowyFizzBuzz.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public FizzBuzz Fizbuz { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Fizbuz.Fizzbuzz();
                HttpContext.Session.SetString("FizzBazz",JsonConvert.SerializeObject(Fizbuz));

                return RedirectToPage("./OstatnioSzukane");
            }
            return Page();
        }

    }
}

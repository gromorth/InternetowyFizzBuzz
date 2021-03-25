using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using InternetowyFizzBuzz.Models;

namespace InternetowyFizzBuzz.Pages
{
    public class OstatnioSzukaneModel : PageModel
    {
        public FizzBuzz CzySesja { get; set; }
    
        public void OnGet()
        {
            var SessionAddress = HttpContext.Session.GetString("FizzBazz"); 
            if (SessionAddress != null)
                CzySesja = JsonConvert.DeserializeObject<FizzBuzz>(SessionAddress);

        }
    }
}

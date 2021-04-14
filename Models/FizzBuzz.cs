using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using InternetowyFizzBuzz.Models;


namespace InternetowyFizzBuzz.Models
{
    public class FizzBuzz
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = " ")]
        [Range(1, 1000),]

        public int Numerek { get; set; }

        [Display(Name =" ")]
        public string Odpowiedz { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name =" ")]
        public DateTime Data { get; set; }

        public void Fizzbuzz()
        {        
            if (Numerek % 15 == 0) Odpowiedz = "FizzBuzz";
            else if (Numerek % 5 == 0) Odpowiedz = "Buzz";
            else if (Numerek % 3 == 0) Odpowiedz = "Fizz";
            else Odpowiedz = Numerek.ToString();

            Data = DateTime.Now;
        }
    }
}

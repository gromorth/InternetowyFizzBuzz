using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetowyFizzBuzz.Models
{
    public class Container
    {
        public int Id { get; set; }

        public ICollection<FizzBuzz> FizzBuzzes { get; set; }
    }
}

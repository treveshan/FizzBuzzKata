using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public string GetFizzBuzz(int input)
        {
            if (input%3 == 0 && input%5 == 0)
            {
                return "FizzBuzz";
            }
            if (input%3 == 0)
            {
                return "Fizz";
            }
            else if (input%5 == 0)
            {
                return "Buzz";
            }

            return input.ToString();
        }

        public List<string> GetFizzBuzzList(int numberOfEnties)
        {

            var fizzBuzzList = new List<string>();
            for (var counter = 1; counter <= numberOfEnties; counter++)
            {
                fizzBuzzList.Add(GetFizzBuzz(counter));
            }
            return fizzBuzzList;
        }
    }
}

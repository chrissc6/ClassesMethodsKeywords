using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMethodsKeywords
{
    class ParamsKeyword
    {
        public void PK(params int[] numbers)
        {
            int x = 0;

            foreach (var i in numbers)
            {
                x += i;
            }

            Console.WriteLine($"The sum is {x}");
        }


    }
}

//By using the params keyword, you can specify a method parameter that takes a variable number of arguments
//No additional parameters are permitted after the params keyword in a method declaration, 
//and only one params keyword is permitted in a method declaration.
//The declared type of the params parameter must be a single-dimensional array
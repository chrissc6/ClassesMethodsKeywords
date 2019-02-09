using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMethodsKeywords
{
    class OutParameter
    {
        public void OP()
        {
            string name, gender;

            getData(out name, out gender); //put data into the variables

            int age = getAge();

            Console.WriteLine($"Data is name- {name}, age- {age}, gender- {gender}");
        }

        private int getAge()
        {
            bool valid = false;
            int number = 0;

            while(!valid)
            {
                Console.WriteLine("Enter age: ");
                if(int.TryParse(Console.ReadLine(), out number))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number for age");
                }
            }
            return number;
        }

        private void getData(out string name, out string gender)
        {
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter gender: ");
            gender = Console.ReadLine();
        }//now data gets passed back to the variables
    }
}
//The out keyword causes arguments to be passed by reference
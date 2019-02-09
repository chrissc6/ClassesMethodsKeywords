using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMethodsKeywords
{
    class valueVSreference
    {
        public int A { get; set; }
        public int B { get; set; }

        public void ReferenceType()
        {
            valueVSreference x1 = new valueVSreference();
            x1.A = 5;
            x1.B = 10;

            valueVSreference x2 = x1;
            valueVSreference x3 = x2;

            x3.B = 100; //changes x1 x2 and x3 B value, because they all point to the same data

            Console.WriteLine(x2.B);
        }


        public void ValueType()
        {
            int x = 5; //x is a value type, stored on the stack

            ChangeValue(x); //passing a copy of the value

            Console.WriteLine($"X is {x}"); //original x only one to remain
        }

        private void ChangeValue(int x)
        {
            x = 100; //change copy of x to 100
        } //now the copy goes away


        public void ValueTypeRef()
        {
            int x = 5; //x is a value type, stored on the stack

            ChangeValue2(ref x); //passing a reference of the value

            Console.WriteLine($"X is {x}"); 
        }

        private void ChangeValue2(ref int x)
        {
            x = 100; //change reference of x to 100
        }
    }
}
//Value vs Reference types determine where something is going to be stored (the stack or the heap)
//Value types are stored on the stack (int, double, long)
//Reference types require 2 segments of memory storage (the data, the address)
//1- The actual data (stored on the heap)
//2- The memory address of the data (stored on the stack) "memory pointer to where the data is"

//When the program runs, the data is stored in memory
//C# uses 2 regions of memory storage: The stack, and The heap
//Stack- is an array of memory that acts as a (last-in, first-out) "LIFO" structure,
//stores: values of certain variables (value types), programs current execution environment, parameters passed into methods
//system handles all stack manipulation, pushing- placing item onto stack, popping- deleting item from the stack
//Heap- is organized into memory chunks and can accessed in any order,
//uses pointers to reference memory locations that are currently in use

//.Net has a garbage collector that determines which heap objects are no longer being used and deletes them
//older languages need manual cleanup, or youll eventually overflow and crash the system

//When assigning reference types or pass them as parameters to methods, the data is not passed, the pointer to
//the data is passed. Any changes will affect all others also pointed to that data.
//When passing value types a copy is made of the value. Any changes made dont impact the outer value

//The "ref" keyword can be used to force a value type to be treated like a reference type
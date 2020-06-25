using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {

            // String datatype
            string myString = "Hello I am a string";

            // String datatype
            int myInt = 42;

            // double datatype
            double myDouble = 33.666;

            // bool datatype
            bool myBool = true;

            // Multiplication operator
            Console.WriteLine(myInt * 2); // 84

            // Subtraction operator is "-" (minus.)
            Console.WriteLine(myInt - 10);

            // Division operator
            Console.WriteLine(myInt / 2);

            // Modulus operator
            Console.WriteLine(myInt % 13);

            // Addition operator
            // Note: This is ALSO the concatenation operator.
            Console.WriteLine(myInt + 8);

            // Addition operator
            Console.WriteLine(myInt + 8);

            Console.WriteLine("3" + "3"); // 33

            Console.WriteLine("3" + 3); // 33

            Console.WriteLine(3 + 6 + "3"); // 93

            myInt = myInt + 2; // 44
            Console.WriteLine(myInt); // 44

            
            // *** Shorthands

            // Increment
            myInt++; // Same as typing myInt = myInt + 1;
            Console.WriteLine(myInt); 

            // Decrement
            myInt--; // Same as typing myInt = myInt - 1;
            Console.WriteLine(myInt); 

            myInt += 3; // Same as typing myInt = myInt + 3;
            Console.WriteLine(myInt);


            myInt -= 6; // Same as typing myInt = myInt - 6;
            Console.WriteLine(myInt);

        }
    }
}

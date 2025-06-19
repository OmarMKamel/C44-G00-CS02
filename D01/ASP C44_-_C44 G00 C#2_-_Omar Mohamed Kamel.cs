/* 
	🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠
	    C44 G00 C#2
	Omar Mohamed Kamel 
	🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠🟠
*/


                                                            // Assignment 2 //

using System;

namespace Assignment02
{
    class Program
    {

        static void Main(string[] args)
        {
            {
                // Note: I will wrap each solution in an if-statement to be able to reuse Variable names without conflicts 
                // and to see only one output at a time.

                Console.Write("Enter problem number: ");
                string Problem_Number = Console.ReadLine();

//__________________________________________________________________________________________________________________________________________//
                //1- Write a program that allows the user to enter a number then print it.
                if (Problem_Number == "1")
                {
                    Console.Write("Enter a number: ");
                    int Number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Wow good job! You entered: " + Number);
                }

//__________________________________________________________________________________________________________________________________________//
                //2- Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 
                else if (Problem_Number == "2")
                {
                    string Str = "Omar";
                    int Result = Convert.ToInt32(Str);
                    Console.WriteLine(Result);  // ⚠️💀 Unhandled exception. System.FormatException: The input string 'Omar' was not in a correct format.
                }

//__________________________________________________________________________________________________________________________________________//
                //3- Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
                else if (Problem_Number == "3")
                {
                    float a = 1.5f;
                    float b = 3.5f;
                    float Result = a + b;
                    Console.WriteLine("Result: " + Result); //5
                }

//__________________________________________________________________________________________________________________________________________//
                //4- Write C# program that Extract a substring from a given string.
                else if (Problem_Number == "4")
                {
                    Console.WriteLine("Enter a string of 6 chars minimum: ");
                    string Str = Console.ReadLine();
                    string Sub = Str.Substring(2, 4); // Starts at index 2 and takes 4 characters -> 3rd char to 6th 
                    Console.WriteLine(Sub);
                }

//__________________________________________________________________________________________________________________________________________//
                //5- Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
                else if (Problem_Number == "5")
                {
                    int x = 1;
                    int y = x;
                    y = 2;
                    Console.WriteLine("x: " + x);  // Output: 1
                    Console.WriteLine("y: " + y);  // Output: 2 (Changed)
                }

//__________________________________________________________________________________________________________________________________________//
                //6- Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
                else if (Problem_Number == "6")
                {
                    int[] arr1 = { 1, 2, 3 };
                    int[] arr2 = arr1;

                    arr2[0] = 1000000;

                    Console.WriteLine(arr1[0]);  // Outputs: 1000000
                    Console.WriteLine(arr2[0]);  // Outputs: 1000000 
                                                 // Variables of reference types copy references.. both refer to the same object.
                }

//__________________________________________________________________________________________________________________________________________//
                //7- Write C# program that take two string variables and print them as one variable 
                else if (Problem_Number == "7")
                {
                    string Str1 = "Omar";
                    string Str2 = "Kamel";
                    string OneStr = Str1 + " " + Str2;
                    Console.WriteLine(OneStr);
                }

//__________________________________________________________________________________________________________________________________________//
                //8- Which of the following statements is correct about the C#.NET code snippet given below?
                else if (Problem_Number == "8")
                {
                    int d;
                    d = Convert.ToInt32(!(30 < 20));

                    Console.WriteLine(d); //1
                                          //(30 < 20) = false ... !false = true = 1
                }

                //A value 0 will be assigned to d.
                //▶️▶️▶️▶️▶️▶️▶️▶️▶️▶️▶️ A value 1 will be assigned to d.
                //A value -1 will be assigned to d.
                //The code reports an error.
                //The code snippet will work correctly if ! is replaced by Not.

//__________________________________________________________________________________________________________________________________________//
                //9- Which of the following is the correct output for the C# code given below?
                else if (Problem_Number == "9")
                {
                    Console.WriteLine(13 / 2 + " " + 13 % 2); // 6 1
                }
                /*   13/2 = 6 (decimal is truncated) ... 13 % 2 = 1 ... " " turns the result into string    */

                //6.5 1
                //6.5 0
                //6 0
                //▶️▶️▶️▶️▶️▶️▶️▶️▶️▶️▶️▶️ 6 1
                //6.5 6.5

//__________________________________________________________________________________________________________________________________________//
                //10 - What will be the output of the C# code given below?
                else if (Problem_Number == "10")
                {
                    int num = 1, z = 5;

                    if (!(num <= 0))
                        Console.WriteLine(++num + z++ + " " + ++z);
                    else
                        Console.WriteLine(--num + z-- + " " + --z);
                }
                // (num <= 0) = false ... !(false) = true ... if(true) = do first Console.WriteLine(++num + z++ + " " + ++z)
                // Remember: ++x -> increment then do operation .. x++ -> do operation then increment
                // (++num + z++ + " " + ++z)
                // ++num = 2 
                // z++ = 5 then increment by 1
                // ++z = 6
                // ( 2 + 5 + " " + 6 ) & z++ ... ( 7 + " " + 7 ) ... "7 7" 

                //5 6
                //6 5
                //6 6
                //▶️▶️▶️▶️▶️▶️▶️▶️▶️ //7 7

//__________________________________________________________________________________________________________________________________________//
            }
        }
    }
}
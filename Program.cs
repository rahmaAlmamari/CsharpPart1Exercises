using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CsharpPart1Exercises
{
    internal class Program
    {
        //main method ..
        static void Main(string[] args)
        {

            //C# Part1 Exercises 


            ///*
            // 1. Even or Odd 
            // Ask the user to enter a number and check whether it is even or odd using an if-else statement.
            // */
            //int number;
            //Console.WriteLine("\n Enter your number: \n");
            //number = int.Parse(Console.ReadLine());
            //float result = number % 2;

            //if(result == 0)
            //{
            //    Console.WriteLine("\n Your number is even \n");
            //}
            //else
            //{
            //    Console.WriteLine("\n Your number is odd \n");
            //}

            //-----------------------------------------------------------------------------------

            ////2.Largest of Three Numbers
            ////Write a program that takes three numbers as input and prints the largest one using if-else.
            //int number1, number2, number3;
            //Console.WriteLine("\n Enter your first number: \n");
            //number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("\n Enter your second number: \n");
            //number2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("\n Enter your thired number: \n");
            //number3 = int.Parse(Console.ReadLine());

            //int largest = number1;
            //if(largest > number2)
            //{
            //    if (largest > number3)
            //    {
            //        Console.WriteLine("\n Your largest number is:" + largest);
            //    }
            //    else
            //    {
            //        largest = number3;
            //        Console.WriteLine("\n Your largest number is:" + largest);
            //    }
            //}
            //else
            //{
            //    largest = number2;
            //    if(largest > number3)
            //    {
            //        Console.WriteLine("\n Your largest number is:" + largest);
            //    }
            //    else
            //    {
            //        largest = number3;
            //        Console.WriteLine("\n Your largest number is:" + largest);
            //    }
            //}


            //faster soluation:
            //if (number2 > largest)
            //{
            //    largest = number2;
            //}
            //if(number3 > largest)
            //{
            //    largest = number3;
            //}


            //Console.WriteLine("\n Your largest number is:" + largest);

            //------------------------------------------------------------------------------------------------

            ////3.Temperature Converter
            ////Convert a given temperature from Celsius to Fahrenheit using the formula: 
            ////F = (C×9 / 5)+32

            //float Celsius, Fahrenheit;
            //Console.WriteLine("\n Enter your temperature in Celsius: \n");
            //Celsius = float.Parse(Console.ReadLine());

            //Fahrenheit = (Celsius * 9 / 5) + 32;
            //Console.WriteLine("\n Enter your temperature in Fahrenheit is:" + Fahrenheit);

            //--------------------------------------------------------------------------------------------

            ////4.Simple Discount Calculator
            ////Ask the user to enter the price of an item. If the price is above $100, apply a 10 % discount; otherwise, no discount
            ////applies.Print the final price. 

            //double price, discount, final_price;
            //Console.WriteLine("\n Enter your item price: \n");
            //price = double.Parse(Console.ReadLine());

            //if (price > 100)
            //{
            //    discount = 0.10 * price;
            //    //discount = (price/100) * 10;
            //    final_price = price - discount;
            //    Console.WriteLine("\n Your price is above 100$ so you will get 10% discount \n");
            //    Console.WriteLine("\n Your final price is: \n" + final_price);
            //}
            //else
            //{
            //    final_price = price;
            //    Console.WriteLine("\n Your price is not above 100$ so you will not get 10% discount \n");
            //    Console.WriteLine("\n Your final price is: \n" + final_price);
            //}


            //-----------------------------------------------------------------------------------------------

            ////5.Grading System
            ////Take a student's score as input and print the corresponding grade: 
            ////• 90 - 100: A
            ////• 80 - 89: B
            ////• 70 - 79: C
            ////• 60 - 69: D
            ////• Below 60: F

            //float score;
            //Console.WriteLine("\n Enter your score: \n");
            //score = float.Parse(Console.ReadLine());

            //if(score >= 90)
            //{
            //    Console.WriteLine("\n Your grade is : A \n");
            //}
            //else if(score >= 80)
            //{
            //    Console.WriteLine("\n Your grade is : B \n");
            //}
            //else if (score >= 70)
            //{
            //    Console.WriteLine("\n Your grade is : C \n");
            //}
            //else if (score >= 60)
            //{
            //    Console.WriteLine("\n Your grade is : D \n");
            //}
            //else
            //{
            //    Console.WriteLine("\n Your grade is : F \n");
            //}

            //-------------------------------------------------------------

            ////6.Swap Two Numbers
            ////Ask the user to enter two numbers and swap them. 

            //int number1, number2, number_hold;
            //Console.WriteLine("\n Enter your first number: \n");
            //number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("\n Enter your second number: \n");
            //number2 = int.Parse(Console.ReadLine());

            //number_hold = number1;
            //number1 = number2;
            //number2 = number_hold;

            //Console.WriteLine("\n Your numbers after swap: \n");
            //Console.WriteLine("\n first number:" + number1);
            //Console.WriteLine("\n second number:" + number2);

            //---------------------------------------------------------------------

            ////7.Days to Weeks and Days Converter
            ////Ask the user to enter a number of days and convert it into weeks and remaining days.
            ///
            //soluation 1:
            //int number, weeks, days;
            //Console.WriteLine("\n Enter your the number of days: \n");
            //number = int.Parse(Console.ReadLine());
            //weeks = number / 7;
            //days = number % 7;

            //Console.WriteLine("\n Then number of weeks you have is:" + weeks);
            //Console.WriteLine("\n Then number of days you have is:" + days);


            //soluation 2:
            //Decimal weeks, weeks_output, number, days;

            //Console.WriteLine("\n Enter your the number of days: \n");
            //number = decimal.Parse(Console.ReadLine());

            //weeks = number / 7;
            //weeks_output = Decimal.Truncate(weeks);
            //days = number % 7;

            //Console.WriteLine("\n Then number of weeks you have is:" + weeks_output);
            //Console.WriteLine("\n Then number of days you have is:" + days);

            //----------------------------------------------------------

            ////8.Electricity Bill Calculator
            ////Ask the user for the number of units consumed and calculate the electricity bill based on these rules: 
            ////• Up to 100 units → $0.5 per unit 
            ////• 101 - 300 units → $0.75 per unit 
            ////• 301 + units → $1 per unit

            //float units;
            //double bill;
            //Console.WriteLine("\n Enter the number of your units: \n");
            //units = float.Parse(Console.ReadLine());

            //if (units <= 100)
            //{
            //    bill = 0.5 * units;
            //    Console.WriteLine("\n Your electricity bill is:" + bill);
            //}
            //else if (units <= 300)
            //{
            //    bill = 0.75 * units;
            //    Console.WriteLine("\n Your electricity bill is:" + bill);
            //}
            //else
            //{
            //    bill = 1 * units;
            //    Console.WriteLine("\n Your electricity bill is:" + bill);
            //}

            //----------------------------------------------------------------------------

            ////9.Simple Calculator
            ////Write a program that takes two numbers and an operator (+, -, *, /) as input and performs the operation. 

            //float number1, number2, result;
            //char signal;

            //Console.WriteLine("\n Enter your first number: \n");
            //number1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("\n Enter your second number: \n");
            //number2 = float.Parse(Console.ReadLine());

            //Console.WriteLine("\n Enter your operator (+, -, *, /): \n");
            //signal = char.Parse(Console.ReadLine());

            //if (signal == '+')
            //{
            //    result = number1 + number2;
            //    Console.WriteLine("\n Your result is:" + result);
            //}
            //else if (signal == '-')
            //{
            //    result = number1 - number2;
            //    Console.WriteLine("\n Your result is:" + result);
            //}
            //else if (signal == '/')
            //{
            //    if (number2 == 0)
            //    {
            //        Console.WriteLine("\n You can not divide by ZERO");
            //    }
            //    else
            //    {
            //        result = number1 / number2;
            //        Console.WriteLine("\n Your result is:" + result);
            //    }
            //}
            //else if (signal == '*')
            //{
            //    result = number1 * number2;
            //    Console.WriteLine("\n Your result is:" + result);
            //}
            //else
            //{
            //    Console.WriteLine("\n You enter unaccepted operator!");
            //}

            //---------------------------------------------------------------------------------------




            //C# Part2 Exercises 





            ////1.Simple Calculator(Switch - Case)
            ////• Ask the user for two numbers and an operator (+, -, *, /).
            ////• Use switch-case to perform the selected operation.
            //char choice;
            //do
            //{
            //    double num1, num2, op;
            //    double result = 0;
            //    bool flag = false;
            //    Console.WriteLine("\n Enter your operation:" +
            //        "\n 1. Addition \n 2. Subtraction \n 3. Multiplication \n 4. Division");
            //    op = double.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter your first number:");
            //    num1 = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter your second number:");
            //    num2 = double.Parse(Console.ReadLine());

            //    switch (op)
            //    {
            //        case 1:
            //            result = num1 + num2;
            //            break;

            //        case 2:
            //            result = num1 - num2;
            //            break;

            //        case 3:
            //            result = num1 * num2;
            //            break;
            //        case 4:
            //            if (num2 == 0)
            //            {
            //                Console.WriteLine("You can not divide by ZERO!");
            //                flag = true;
            //            }
            //            else
            //            {
            //                result = num1 / num2;
            //            }
            //            break;
            //        default:
            //            Console.WriteLine("\n You enter unaccepted operator!");
            //            flag = true;
            //            break;

            //    }

            //    if (!flag)
            //    {
            //        Console.WriteLine("Your result is: " + result);
            //    }

            //    Console.WriteLine("Do you want another operation ? y / n");
            //    choice = Console.ReadKey().KeyChar;

            //} while (choice == 'y' || choice == 'Y');
            //Console.WriteLine("Have a nice day!");


            //------------------------------------------------------------------------------------

            ////2.Basic ATM System 
            ////• Use a starting balance of $1000.
            ////• Allow users to Deposit, Withdraw, or Check Balance.  
            ////• Withdraw should check if funds are available. 
            ////• Display a menu with options:
            ////   o 1.Withdraw Money
            ////   o 2.Deposit Money
            ////   o 3.Check Balance
            ////   o 4.Exit
            ////• Use switch-case to process the selected operation.
            //char choice;
            //do
            //{
            //    double balance = 1000;
            //    double user_Emoney, available;
            //    int options;
            //    Console.WriteLine("Select Options: \n 1.Withdraw Money \n 2.Deposit Money \n 3.Check Balance \n 4.Exit");
            //    options = int.Parse(Console.ReadLine());

            //    switch (options)
            //    {
            //        case 1:
            //            Console.WriteLine("Enter the amount you want to Withdraw:");
            //            user_Emoney = double.Parse(Console.ReadLine());
            //            available = balance - user_Emoney;
            //            if (available <= 0)
            //            {
            //                Console.WriteLine("Sorry, but you do not have this amount of money");
            //            }
            //            else
            //            {
            //                balance = balance - user_Emoney;
            //                Console.WriteLine("The money has been successfully withdeawn from your account" +
            //                                  "\n Your remaining balance is: " + balance);
            //            }
            //            break;
            //        case 2:
            //            Console.WriteLine("Enter the amount you want to deposit:");
            //            user_Emoney = double.Parse(Console.ReadLine());
            //            balance = balance + user_Emoney;
            //            Console.WriteLine("The money has been successfully deposit to your account" +
            //                                  "\n Your new balance is: " + balance);
            //            break;
            //        case 3:
            //            Console.WriteLine("Your balance is: " + balance);
            //            break;
            //        case 4:
            //            Console.WriteLine("Until we meet again ... Have a nice day!");
            //            break;
            //        default:
            //            Console.WriteLine("Wrong Choice!");
            //            break;
            //    }

            //    Console.WriteLine("Do you want another operation ? y / n");
            //    choice = Console.ReadKey().KeyChar;

            //} while (choice == 'y' || choice == 'Y');
            //Console.WriteLine("Have a nice day!");


            //-------------------------------------------------------------------------------------

            ////3.Geometry Calculator
            ////• Ask the user to choose a shape:
            ////   o 1.Circle(Calculate Area & Circumference)
            ////   o 2.Square(Calculate Area & Perimeter)
            ////   o 3.Triangle(Calculate Area)
            ////• Use switch-case to perform the corresponding calculation.
            //char choice;
            //do
            //{
            //    int shap;
            //    double length, width, radius, Area, perimeter, Circumference;
            //    double p = 3.14;
            //    Console.WriteLine("Select a shape: \n 1.Circle(Calculate Area & Circumference)" +
            //                      " \n 2.Square(Calculate Area & Perimeter)" +
            //                      " \n 3.Triangle(Calculate Area)");
            //    shap = int.Parse(Console.ReadLine());

            //    switch (shap)
            //    {
            //        case 1:
            //            Console.WriteLine("Enter your circle radius: ");
            //            radius = double.Parse(Console.ReadLine());
            //            Area = p * (radius * radius);
            //            Circumference = 2 * p * radius;
            //            Console.WriteLine("Your circle area is: " + Area +
            //                              "\nYour circle Circumference is: " + Circumference);
            //            break;
            //        case 2:
            //            Console.WriteLine("Enter your square side length: ");
            //            length = double.Parse(Console.ReadLine());
            //            Area = length * length;
            //            perimeter = 4 * length;
            //            Console.WriteLine("Your square area is: " + Area +
            //                              "\n Your square perimeter is: " + perimeter);
            //            break;
            //        case 3:
            //            Console.WriteLine("Enter your triangle length: ");
            //            length = double.Parse(Console.ReadLine());
            //            Console.WriteLine("Enter your triangle width: ");
            //            width = double.Parse(Console.ReadLine());
            //            Area = length * width;
            //            Console.WriteLine("Your triangle area is: " + Area);
            //            break;
            //        default:
            //            Console.WriteLine("Wrong Choice!");
            //            break;
            //    }

            //    Console.WriteLine("Do you want another operation ? y / n");
            //    choice = Console.ReadKey().KeyChar;

            //} while (choice == 'y' || choice == 'Y');
            //Console.WriteLine("Have a nice day!");


            //---------------------------------------------------------------------------

            ////4.Factorial of a Number
            ////• Ask the user for a number N and calculate its factorial(N!).

            //int N;
            //int y = 2;
            //int result = 1;
            //Console.WriteLine("Enter your number: ");
            //N = int.Parse(Console.ReadLine());

            //if (N == 1 || N == 0)
            //{
            //    Console.WriteLine("Your factorial of " + N + " is: " + result);
            //}
            //else if(N < 0)
            //{
            //    Console.WriteLine("Wrong input!");
            //}
            //else
            //{
            //    for (int i = 1; i < N; i++)
            //    {
            //        result = result * y;
            //        y++;
            //    }
            //    Console.WriteLine("Your factorial of " + N + " is: " + result);
            //}

            //------------------------------------------------------------------------

            ////5.Sum of Even and Odd Numbers
            ////• Ask the user to enter N. 
            ////• Find the sum of all even and odd numbers from 1 to N . 

            //int N, check;
            //int sum_even = 0;
            //int sum_odd = 0;
            //Console.WriteLine("Enter your number: ");
            //N = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= N; i++)
            //{
            //    check = i % 2;
            //    if(check == 0)
            //    {
            //        sum_even = sum_even + i;
            //    }
            //    else
            //    {
            //        sum_odd = sum_odd + i;
            //    }
            //}

            //Console.WriteLine("The sum of all even numbers in your number is: " + sum_even +
            //                  "\nThe sum of all odd numbers in your number is: " + sum_odd);

            //----------------------------------------------------------------------------

            ////6.Scientific Calculator(Switch - Case & Math Functions)
            ////• Ask for an operation (sin, cos, tan, sqrt, log, pow). 
            ////• Use switch-case to compute results using Math functions. 
            //char choice;
            //do
            //{
            //    Console.Clear();
            //    double operation, number, power;
            //    Console.WriteLine("Enter your number: ");
            //    number = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Select operation: \n1. sin \n2. cos \n3. tan \n4. sqrt \n5. log \n6. pow");
            //    operation = double.Parse(Console.ReadLine());

            //    switch (operation)
            //    {
            //        case 1:
            //            Console.WriteLine(Math.Sin(number));
            //            break;
            //        case 2:
            //            Console.WriteLine(Math.Cos(number));
            //            break;
            //        case 3:
            //            Console.WriteLine(Math.Tan(number));
            //            break;
            //        case 4:
            //            Console.WriteLine(Math.Sqrt(number));
            //            break;
            //        case 5:
            //            Console.WriteLine(Math.Log(number));
            //            break;
            //        case 6:
            //            Console.WriteLine("Enter your power: ");
            //            power = double.Parse(Console.ReadLine());
            //            Console.WriteLine(Math.Pow(number, power));
            //            break;
            //        default:
            //            Console.WriteLine("Wrong input!");
            //            break;
            //    }

            //    Console.WriteLine("Do you want another operation ? y / n");
            //    choice = Console.ReadKey().KeyChar;

            //} while (choice == 'y' || choice == 'Y');

            //Console.WriteLine("Have a nice day!");

            //------------------------------------------------------------------------------------

            ////10.Guess Game with helper
            ////Generate a random number(1 - 100) and ask the user to guess the number.  
            ////• If guess is too high → "Try Lower!"
            ////• If guess is too low → "Try Higher!"
            ////• If guess is correct → "You Win!"
            ////Use a while loop to keep asking:
            //char choice;
            //int count = 0;
            //do
            //{
            //    int g_number;
            //    //to generate a random number ...
            //    Random rnd = new Random();
            //    int num = rnd.Next(100);
            //    // Console.WriteLine(num);
            //    do
            //    {
            //        Console.WriteLine("Guess my number: ");
            //        g_number = int.Parse(Console.ReadLine());

            //        if (g_number < num)
            //        {
            //            Console.WriteLine("Try Higher! ... ");
            //        }
            //        else if (g_number > num)
            //        {
            //            Console.WriteLine("Try Lower! ... ");
            //        }
            //        else
            //        {
            //            Console.WriteLine("You Win! ... in the " + (count + 1) + "try ...");
            //        }

            //        count = count + 1;

            //    } while (g_number != num);


            //    Console.WriteLine("Do you want another operation ? y / n");
            //    choice = Console.ReadKey().KeyChar;

            //} while (choice == 'y' || choice == 'Y');
            //Console.WriteLine("Have a nice day!");

            //---------------------------------------------------------------------------

            ////7.Print Pattern(For Loop)
            ////• Ask the user for a number N and print a right - angled triangle
            ////Example: (for N = 5)
            ////        *
            ////        **
            ////        ***
            ////        ****
            ////        *****

            //int N;
            //string output = "*";
            //Console.WriteLine("Enter number:");
            //N = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= N; i++)
            //{
            //    Console.WriteLine(output);
            //    output = output + "*";

            //}
            //-------------------- soluation 2: using nested loop (2 loop)
            //int N; // Number of rows
            //Console.WriteLine("Enter number:");
            //N = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= N; i++) // Controls rows
            //{
            //    for (int j = 1; j <= i; j++) // Controls columns
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine(); // Move to next line
            //}

            //-----------------------------------------------------------------------

            ////8.Print a Pyramid Pattern(For Loop)
            ////• Ask the user for N and print a pyramid
            ////Example: (for N = 4)
            ////        *
            ////       ***
            ////      *****
            ////     *******

            //int N;
            //string output = "*";
            //string space = " ";
            //Console.WriteLine("Enter number:");
            //N = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= N; i++)
            //{
            //    space += " ";


            //}
            //for (int r = N; r > 1; r--)
            //{
            //    space = space.Remove(space.Length - 1);
            //    Console.WriteLine(space + output);
            //    output = output + "**";

            //}

            //-------------------- soluation 2: using nested loop (2 loop)
            //int N; // Number of rows
            //Console.WriteLine("Enter number:");
            //N = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= N; i++) // Controls rows
            //{
            //    for (int j = 1; j <= N - i; j++) // Prints spaces
            //    { Console.Write(" "); }
            //    for (int k = 1; k <= 2 * i - 1; k++) // Prints stars
            //    { Console.Write("*"); }
            //    Console.WriteLine(); // Move to the next line
            //}

            //--------------------------------------------------------------------------

            ////9.Print a Diamond Pattern(For Loop)
            ////• Ask for N, then print a diamond shape.
            ////Example: (for N = 3 )
            ////        *
            ////       ***
            ////      *****
            ////       ***
            ////        *


            //int N;
            //string output = "*";
            //string space = " ";
            //Console.WriteLine("Enter number:");
            //N = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= N; i++)
            //{
            //    space += " ";


            //}
            //for (int r = N; r > 1; r--)
            //{
            //    space = space.Remove(space.Length - 1);
            //    Console.WriteLine(space + output);
            //    output = output + "**";

            //}
            //space = space.Remove(space.Length - 1);
            //for (int r = N; r > 1; r--)
            //{

            //    Console.WriteLine(space + output);
            //    output = output.Remove(output.Length - 2);
            //    space = space.Insert(1, " ");

            //}
            //Console.WriteLine(space + output);

            //-------------------- soluation 2: using nested loop (6 loop)
            //int N;
            //Console.WriteLine("Enter number:");
            //N = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= N; i++) // to go to the next line in the upper part
            //{
            //    for (int j = N - i; j >= 1; j--) // to print space
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int r = 1; r <= (i*2 - 1); r++) // to print start "*"
            //    {
            //        Console.Write("*");
            //    }  

            //    Console.WriteLine(); // go to next line 'row' .....
            //}

            //for (int i = 1; i <= N - 1; i++)// to go to the next line in the lower part
            //{
            //    for (int j = i; j <= (i * 2 - 1); j++) // to print space
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int r = (N*2 - 3); r >= (i * 2 - 1); r--) // to print start "*"
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}




            //---------------------------- soluation 3: using nested loop (5 loop)
            //int N;
            //Console.WriteLine("Enter number:");
            //N = int.Parse(Console.ReadLine());
            //int row = N + (N - 1);
            //for (int i = 1; i <= row; i++) //to go to the next line ...
            //{
            //    if(i <= N)
            //    {
            //        for (int j = N - i; j >= 1; j--)
            //        {
            //            Console.Write(" ");
            //        }
            //        for (int r = 1; r <= (i * 2 - 1); r++)
            //        {
            //            Console.Write("*");
            //        }
            //    }
            //    else
            //    {
            //        for (int j = i-N; j <= ((i-N) * 2 - 1); j++)
            //        {
            //            Console.Write(" ");
            //        }
            //        for (int r = (N * 2 - 3); r >= ((i - N) * 2 - 1); r--)
            //        {
            //            Console.Write("*");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //-------------------- soluation 3: using nested loop (6 loop) ... easy one
            //int N;
            //Console.WriteLine("Enter number:");
            //N = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= N; i++) // to go to the next line in the upper part
            //{
            //    //for (int j = N - i; j >= 1; j--) // to print space
            //    //{
            //    //    Console.Write(" ");
            //    //}

            //    //for (int r = 1; r <= (i * 2 - 1); r++) // to print start "*"
            //    //{
            //    //    Console.Write("*");
            //    //}

            //    //Console.WriteLine(); // go to next line 'row' .....

            //    //calling PrintSpaceStart function ...
            //    PrintSpaceStart(N, i);
            //}

            //for (int i = N-1; i >= 1; i--) // to go to the next line in the lower part
            //{
            //    //for (int j = N - i; j >= 1; j--) // to print space
            //    //{
            //    //    Console.Write(" ");
            //    //}

            //    //for (int r = 1; r <= (i * 2 - 1); r++) // to print start "*"
            //    //{
            //    //    Console.Write("*");
            //    //}

            //    //Console.WriteLine(); // go to next line 'row' .....

            //    //calling PrintSpaceStart function ...
            //    PrintSpaceStart(N, i);
            //}

            // combain all task in exercises 2 togather .............


            //while (true) // we use while loop to repeat the process and we set true so it will not stop ... 
            //{
            //    Console.Clear();
            //    Console.WriteLine("Select program: ");
            //    Console.WriteLine("1. Simple Calculator");
            //    Console.WriteLine("2. Basic ATM System");
            //    Console.WriteLine("3. Geometry Calculator");
            //    Console.WriteLine("4. Factorial of a Number");
            //    Console.WriteLine("5. Sum of Even and Odd Numbers");
            //    Console.WriteLine("6. Scientific Calculator");
            //    Console.WriteLine("7. Print Right Angled Triangle Pattern");
            //    Console.WriteLine("8. Print a Pyramid Pattern");
            //    Console.WriteLine("9. Print a Diamond Pattern");
            //    Console.WriteLine("10. Guess Number Game");
            //    Console.WriteLine("0. Exit");

            //    Console.Write("Enter your choice: ");
            //    int choice = int.Parse(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case 1: SimpleCalculator();  break;
            //        case 2: BasicATMSystem();  break;
            //        case 3: GeometryCalculator();  break;
            //        case 4: FactorialOfNumber();  break;
            //        case 5: SumEvenOdd();  break;
            //        case 6: ScientificCalculator(); break;
            //        case 7: RightAngledTrianglePattern();  break;
            //        case 8: PyramidPattern(); break;
            //        case 9: DiamondPattern(); break;
            //        case 10: GuessGame(); break;
            //        case 0: Console.WriteLine("Have a nice day ..."); return;
            //        default: Console.WriteLine("\n You enter unaccepted choice! ... try again"); break;
            //    }
            //    Console.ReadLine();// we add this line just to stop the program from clear 'Console.Clear();' the screen before the user see the result ...

            //}





            /// C# Part3 Exercises  
            /// 





            ////1. Array Initialization & Output
            //    o Declare an array of 5 integers.
            //    o Assign values and print them using a for loop.

            //int[] array_int = new int[5]; //declare the array ....
            //for (int i=0; i<5; i++) ///input array elements .....
            //{
            //    Console.WriteLine("enter the element " + (i + 1) + " in your array");
            //    array_int[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < 5; i++)//print array elements .......
            //{
            //    Console.WriteLine("Your element " + (i+1) + " is: " + array_int[i]);

            //}

            //-----------------------------------------------------------------------------------

            //2.Find Maximum & Minimum in an Array
            //  o Ask the user to enter 10 numbers.
            //  o Find and display the maximum and minimum values.

            //int[] number = new int[10];
            //Console.WriteLine("Enter 1o number: ");
            //for(int i=0; i<10; i++)
            //{
            //    number[i] = int.Parse(Console.ReadLine());
            //}
            //Array.Sort(number);
            //Console.WriteLine("Your maximum number is: " + number[9]);
            //Console.WriteLine("Your minimum number is: " + number[0]);

            //---------------------------------------------------------------------------------------

            //3.Count Even & Odd Numbers
            // o Ask the user to input N numbers into an array. 
            // o Count and display how many numbers are even and odd.

            //int N;
            //Console.WriteLine("Enter the number of element you want: ");
            //N = int.Parse(Console.ReadLine());
            //int[] element = new int[N];
            //int odd = 0;
            //int even = 0;
            //Console.WriteLine("Enter the element:");

            //for(int i=0; i<N; i++)
            //{
            //    element[i] = int.Parse(Console.ReadLine());
            //    if(element[i] % 2 == 0)
            //    {
            //        even = even + 1;
            //    }
            //    else
            //    {
            //        odd = odd + 1;
            //    }
            //}

            //Console.WriteLine("You have " + even + " even element in your array");
            //Console.WriteLine("You have " + odd + " odd element in your array");

            //--------------------------------------------------------------------------------

            //4.Reverse an Array
            //o Ask the user for N numbers. 
            //o Reverse the array and print the result.

            //int N;
            //Console.WriteLine("Enter the number of element you want: ");
            //N = int.Parse(Console.ReadLine());
            //int[] array_x = new int[N];

            //InsertArrayElement(N, array_x);
            //Array.Reverse(array_x);
            //Console.WriteLine("Your array after reverse is: ");
            //for (int i = 0; i < N; i++)
            //{
            //    Console.WriteLine("Element " + i + "is " + array_x[i]);

            //}

            //-------------------------------------------------------------------------------

            //5.Search for a Number in an Array
            //  o Input N numbers into an array.
            //  o Ask for a number to search for and check if it exists in the array. 
            //  o If found, display its index.

            //int N;
            //Console.WriteLine("Enter the number of element you want: ");
            //N = int.Parse(Console.ReadLine());
            //int[] array_x = new int[N];
            //InsertArrayElement(N, array_x);
            //int search_num;
            //int count_exit = 0;
            //Console.WriteLine("Enter a number to search in your array:");
            //search_num = int.Parse(Console.ReadLine());
            //for (int i = 0; i < N; i++)
            //{
            //    if (array_x[i] == search_num)
            //    {
            //        count_exit = count_exit + 1;
            //    }
            //}
            //if (count_exit > 0)
            //{
            //    Console.WriteLine("The number you are searching for exit " + count_exit + " time in the array");
            //    Console.WriteLine("Your number is in index " + Array.IndexOf(array_x, search_num));
            //}
            //else
            //{
            //    Console.WriteLine("The number you are searching for is not exit in the array ... sory!");
            //}


            //------------------------------------------------------------------------

            //6.Sorting an Array(Ascending Order)
            //  o Ask the user for N numbers. 
            //  o Sort them in ascending order(using Bubble Sort or Array.Sort()). 

            //int N;
            //Console.WriteLine("Enter the number of element you want: ");
            //N = int.Parse(Console.ReadLine());
            //int[] array_x = new int[N];
            //InsertArrayElement(N, array_x);
            //Array.Sort(array_x);

            ////int temp;
            ////int r = 0;
            ////for(int j=0; j<N-r; j++)
            ////{
            ////    for (int i = 0; i < array_x.Length -1; i++)
            ////    {
            ////        if (array_x[i] > array_x[i + 1])
            ////        {
            ////            temp = array_x[i];
            ////            array_x[i] = array_x[i + 1];
            ////            array_x[i + 1] = temp;
            ////        }

            ////    }
            ////    r++;
            ////}
            //Console.WriteLine("Your array after sorte 'Ascending': ");
            //for (int y = 0; y < N; y++)
            //{
            //    Console.WriteLine(array_x[y]);

            //}

            //-----------------------------------------------------------------

            //7.Merging Two Arrays
            //  o Ask the user for two arrays of the same size.
            //  o Merge them into one larger array.
            //  o Print the final array.

            //int N;
            //Console.WriteLine("Enter the size of your arrays:");
            //N = int.Parse(Console.ReadLine());
            //int[] array_x = new int[N];
            //int[] array_y = new int[N];

            //Console.WriteLine("Array X:");
            //InsertArrayElement(N, array_x);

            //Console.WriteLine("Array Y:");
            //InsertArrayElement(N, array_y);
            ////int[] result = array1.Concat(array2).ToArray();
            //int[] final_array = array_x.Concat(array_y).ToArray();
            ////for(int i=0; i<N*2; i++)
            ////{
            ////    if(i < N)
            ////    {

            ////            final_array[i] = array_x[i];

            ////    }
            ////    else
            ////    {

            ////            if(i>=N || i < N * 2)
            ////        {
            ////            final_array[i] = array_y[i];
            ////        }                      



            ////    }
            ////}

            //Console.WriteLine("Your final array is: ");
            //for (int i = 0; i < N * 2; i++)
            //{
            //    Console.WriteLine(final_array[i]);

            //}

            //----------------------------------------------------------------------------------

            //8.Remove Duplicates from an Array
            // o Ask the user to enter N numbers. 
            // o Remove duplicate values and print the unique numbers.

            //int N;
            //Console.WriteLine("Enter the number of element you want: ");
            //N = int.Parse(Console.ReadLine());
            //int[] array_x = new int[N];
            //InsertArrayElement(N, array_x);
            ////int[] distinct = arr.Distinct().ToArray();
            //int[] new_array = array_x.Distinct().ToArray();
            //Console.WriteLine("Your array without duplicates:");
            //for (int i = 0; i < new_array.Length; i++)
            //{
            //    Console.WriteLine(new_array[i]);

            //}

            //--------------------------------------------------------------------------------

            //9.Second Largest Number in an Array 
            // • Input N numbers into an array. 
            // • Find and display the second - largest number.

            //int N;
            //Console.WriteLine("Enter the number of element you want: ");
            //N = int.Parse(Console.ReadLine());
            //int[] array_x = new int[N];
            //InsertArrayElement(N, array_x);
            //Array.Sort(array_x);
            //Console.WriteLine("Your second largest number is:" + array_x[N - 2]);










            ///end of main method ............................................
        }




        //1. Simple Calculator method ...
        static void SimpleCalculator()
        {
            char choice;
            do
            {
                double num1, num2, op;
                double result = 0;
                bool flag = false;
                Console.WriteLine("\n Enter your operation:" +
                    "\n 1. Addition \n 2. Subtraction \n 3. Multiplication \n 4. Division");
                op = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter your first number:");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter your second number:");
                num2 = double.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        result = num1 + num2;
                        break;

                    case 2:
                        result = num1 - num2;
                        break;

                    case 3:
                        result = num1 * num2;
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("You can not divide by ZERO!");
                            flag = true;
                        }
                        else
                        {
                            result = num1 / num2;
                        }
                        break;
                    default:
                        Console.WriteLine("\n You enter unaccepted operator!");
                        flag = true;
                        break;

                }

                if (!flag)
                {
                    Console.WriteLine("Your result is: " + result);
                }

                Console.WriteLine("Do you want another operation ? y / n");
                choice = Console.ReadKey().KeyChar;

            } while (choice == 'y' || choice == 'Y');
            Console.WriteLine("Have a nice day!");
        }
        //2. Basic ATM System method ...
        static void BasicATMSystem()
        {
            char choice;
            double balance = 1000;
            do
            {
                
                double user_Emoney, available;
                int options;
                Console.WriteLine("Select Options: \n 1.Withdraw Money \n 2.Deposit Money \n 3.Check Balance \n 4.Exit");
                options = int.Parse(Console.ReadLine());

                switch (options)
                {
                    case 1:
                        Console.WriteLine("Enter the amount you want to Withdraw:");
                        user_Emoney = double.Parse(Console.ReadLine());
                        available = balance - user_Emoney;
                        if (available <= 0)
                        {
                            Console.WriteLine("Sorry, but you do not have this amount of money");
                        }
                        else
                        {
                            balance = balance - user_Emoney;
                            Console.WriteLine("The money has been successfully withdeawn from your account" +
                                              "\n Your remaining balance is: " + balance);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the amount you want to deposit:");
                        user_Emoney = double.Parse(Console.ReadLine());
                        balance = balance + user_Emoney;
                        Console.WriteLine("The money has been successfully deposit to your account" +
                                              "\n Your new balance is: " + balance);
                        break;
                    case 3:
                        Console.WriteLine("Your balance is: " + balance);
                        break;
                    case 4:
                        Console.WriteLine("Until we meet again ... Have a nice day!");
                        break;
                    default:
                        Console.WriteLine("Wrong Choice!");
                        break;
                }

                Console.WriteLine("Do you want another operation ? y / n");
                choice = Console.ReadKey().KeyChar;

            } while (choice == 'y' || choice == 'Y');
            Console.WriteLine("Have a nice day!");

        }
        //3. Geometry Calculator  method ...
        static void GeometryCalculator()
        {
            char choice;
            do
            {
                int shap;
                double length, width, radius, Area, perimeter, Circumference;
                double p = 3.14;
                Console.WriteLine("Select a shape: \n 1.Circle(Calculate Area & Circumference)" +
                                  " \n 2.Square(Calculate Area & Perimeter)" +
                                  " \n 3.Triangle(Calculate Area)");
                shap = int.Parse(Console.ReadLine());

                switch (shap)
                {
                    case 1:
                        Console.WriteLine("Enter your circle radius: ");
                        radius = double.Parse(Console.ReadLine());
                        Area = p * (radius * radius);
                        Circumference = 2 * p * radius;
                        Console.WriteLine("Your circle area is: " + Area +
                                          "\nYour circle Circumference is: " + Circumference);
                        break;
                    case 2:
                        Console.WriteLine("Enter your square side length: ");
                        length = double.Parse(Console.ReadLine());
                        Area = length * length;
                        perimeter = 4 * length;
                        Console.WriteLine("Your square area is: " + Area +
                                          "\n Your square perimeter is: " + perimeter);
                        break;
                    case 3:
                        Console.WriteLine("Enter your triangle length: ");
                        length = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your triangle width: ");
                        width = double.Parse(Console.ReadLine());
                        Area = length * width;
                        Console.WriteLine("Your triangle area is: " + Area);
                        break;
                    default:
                        Console.WriteLine("Wrong Choice!");
                        break;
                }

                Console.WriteLine("Do you want another operation ? y / n");
                choice = Console.ReadKey().KeyChar;

            } while (choice == 'y' || choice == 'Y');
            Console.WriteLine("Have a nice day!");


        }
        //4. Factorial of a Number  method ...
        static void FactorialOfNumber()
        {
            int N;
            int y = 2;
            int result = 1;
            Console.WriteLine("Enter your number: ");
            N = int.Parse(Console.ReadLine());

            if (N == 1 || N == 0)
            {
                Console.WriteLine("Your factorial of " + N + " is: " + result);
            }
            else if (N < 0)
            {
                Console.WriteLine("Wrong input!");
            }
            else
            {
                for (int i = 1; i < N; i++)
                {
                    result = result * y;
                    y++;
                }
                Console.WriteLine("Your factorial of " + N + " is: " + result);
            }
        }
        //5. Sum of Even and Odd Numbers   method ...
        static void SumEvenOdd()
        {
            int N, check;
            int sum_even = 0;
            int sum_odd = 0;
            Console.WriteLine("Enter your number: ");
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                check = i % 2;
                if (check == 0)
                {
                    sum_even = sum_even + i;
                }
                else
                {
                    sum_odd = sum_odd + i;
                }
            }

            Console.WriteLine("The sum of all even numbers in your number is: " + sum_even +
                              "\nThe sum of all odd numbers in your number is: " + sum_odd);
        }
        //6. Scientific Calculator (Switch-Case & Math Functions)  method ...
        static void ScientificCalculator()
        {
            char choice;
            do
            {
                Console.Clear();
                double operation, number, power;
                Console.WriteLine("Enter your number: ");
                number = double.Parse(Console.ReadLine());
                Console.WriteLine("Select operation: \n1. sin \n2. cos \n3. tan \n4. sqrt \n5. log \n6. pow");
                operation = double.Parse(Console.ReadLine());

                switch (operation)
                {
                    case 1:
                        Console.WriteLine(Math.Sin(number));
                        break;
                    case 2:
                        Console.WriteLine(Math.Cos(number));
                        break;
                    case 3:
                        Console.WriteLine(Math.Tan(number));
                        break;
                    case 4:
                        Console.WriteLine(Math.Sqrt(number));
                        break;
                    case 5:
                        Console.WriteLine(Math.Log(number));
                        break;
                    case 6:
                        Console.WriteLine("Enter your power: ");
                        power = double.Parse(Console.ReadLine());
                        Console.WriteLine(Math.Pow(number, power));
                        break;
                    default:
                        Console.WriteLine("Wrong input!");
                        break;
                }

                Console.WriteLine("Do you want another operation ? y / n");
                choice = Console.ReadKey().KeyChar;

            } while (choice == 'y' || choice == 'Y');

            Console.WriteLine("Have a nice day!");

        }
        //7. Print Pattern (For Loop)  method ...
        static void RightAngledTrianglePattern()
        {
            int N; // Number of rows
            Console.WriteLine("Enter number:");
            N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++) // Controls rows
            {
                for (int j = 1; j <= i; j++) // Controls columns
                {
                    Console.Write("* ");
                }
                Console.WriteLine(); // Move to next line
            }
        }
        //8. Print a Pyramid Pattern (For Loop)  method ...
        static void PyramidPattern()
        {
            int N; // Number of rows
            Console.WriteLine("Enter number:");
            N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++) // Controls rows
            {
                for (int j = 1; j <= N - i; j++) // Prints spaces
                { Console.Write(" "); }
                for (int k = 1; k <= 2 * i - 1; k++) // Prints stars
                { Console.Write("*"); }
                Console.WriteLine(); // Move to the next line
            }
        }
        //9. Print a Diamond Pattern (For Loop)  method ...
        static void DiamondPattern()
        {
            int N;
            Console.WriteLine("Enter number:");
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) // to go to the next line in the upper part
            {
                //calling PrintSpaceStart function ...
                PrintSpaceStart(N, i);
            }

            for (int i = N - 1; i >= 1; i--) // to go to the next line in the lower part
            {
                //calling PrintSpaceStart function ...
                PrintSpaceStart(N, i);
            }
        }
        //10. Guess Game with helper  method ...
        static void GuessGame()
        {
            char choice;
            int count = 0;
            do
            {
                int g_number;
                //to generate a random number ...
                Random rnd = new Random();
                int num = rnd.Next(100);
                // Console.WriteLine(num);
                do
                {
                    Console.WriteLine("Guess my number: ");
                    g_number = int.Parse(Console.ReadLine());

                    if (g_number < num)
                    {
                        Console.WriteLine("Try Higher! ... ");
                    }
                    else if (g_number > num)
                    {
                        Console.WriteLine("Try Lower! ... ");
                    }
                    else
                    {
                        Console.WriteLine("You Win! ... in the " + (count + 1) + "try ...");
                    }

                    count = count + 1;

                } while (g_number != num);


                Console.WriteLine("Do you want to play again? y / n");
                choice = Console.ReadKey().KeyChar;

            } while (choice == 'y' || choice == 'Y');
            Console.WriteLine("Have a nice day!");

        }






        //method for print space and start //
        static void PrintSpaceStart(int N, int i)
        {
            for (int j = N - i; j >= 1; j--) // to print space
            {
                Console.Write(" ");
            }

            for (int r = 1; r <= (i * 2 - 1); r++) // to print start "*"
            {
                Console.Write("*");
            }

            Console.WriteLine(); // go to next line 'row' .....
        }
        //method for insert elements value to array ...
        static void InsertArrayElement(int N, int[] array_x)
        {
            Console.WriteLine("Enter the element:");

            for (int i = 0; i < N; i++)
            {
                array_x[i] = int.Parse(Console.ReadLine());

            }
        }
    }
}

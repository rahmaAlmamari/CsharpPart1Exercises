namespace CsharpPart1Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

        }
    }
}

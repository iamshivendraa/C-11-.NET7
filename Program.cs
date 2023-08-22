using static System.Console;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Net.Cache;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Diagnostics;

namespace CSTutorial
{
    class Program
    {
        public string? Name;
        public List<Child> Children = new List<Child>();
        DateTime DateOfBirth = new(1965, 12, 12);

        //Writing Methods
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}");
        }

        public string GetOrigin()
        {
            return $"{Name} was born on {DateOfBirth:yyyy}";
        }


        //Optional Parameter

        public string optionalParameters(string command = "Run", double number = 0.0, bool active = true)
        {
            return $"Command is {command}, number is {number} and active is {active} ";
        }

        public static void Addition(out int i)
        {
            i = 30 ;
            i += i;
        }



        static void Main(string[] args)
        {
            Program bob = new Program();
            bob.Name = "Bob Smith";

            bob.Children.Add(new Child { Name = "Zoe" });
            bob.Children.Add(new Child { Name = "Alfred" });

            WriteLine($"{bob.Name} have {bob.Children.Count} children");

            foreach (Child child in bob.Children)
            {
                WriteLine(child.Name);
            }





            Person person1 = new Person("Shivendra", "Software Eng 1");
            Person person2 = new Person();

            Console.WriteLine($"Name of the person is {person1.Name} and his designation is {person1.Designation}");
            Console.WriteLine($"Name of the person is {person2.Name} and his designation is {person2.Designation}");


            //calling methods

            bob.WriteToConsole();
            WriteLine(bob.GetOrigin());


            //Tuples--> data structure that holds a fixed numner of elements of differernt types.

            var Employee = (Name: "Shivendra", Age: 22, IsEmployee: true);

            WriteLine($"Name of the employee is : {Employee.Name}");
            WriteLine($"Age of the employee is : {Employee.Age}");
            WriteLine($"Employee : {Employee.IsEmployee}");


            //Using tuples for methods return value

            var result = Divide(10, 3);
            WriteLine($"Quotient : {result.Quotient} and Remainder : {result.Remainder}");

            //Deconstructing tuples

             var person = (Name: "Alice", Age: 30);

             var (name, age) = person;

             WriteLine($"Name : {name}");
             WriteLine($"Age : {age}"); 

            //Overloading function call
            Calcultaor calculator = new Calcultaor();

            int result1 = calculator.Add(5, 3);
            double result2 = calculator.Add(5, 3);
            string result3 = calculator.Add("Shivendra", "Kumar");

            WriteLine(result1);
            WriteLine(result2);
            WriteLine(result3);

            WriteLine(bob.optionalParameters());

            //ref and out
            void ModifyValue(ref int value)
            {
                value = 42;
            }

            int number = 10;

            ModifyValue(ref number);

            WriteLine(number);

            //out

            int i;

            Addition(out i);

            WriteLine("The addition of the value is : {0}", i);







            



            
        }

        //Method returning a tuple
        static (int Quotient, int Remainder) Divide(int dividend, int divisor)
        { 
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            return (quotient, remainder);
        }

        }
  }


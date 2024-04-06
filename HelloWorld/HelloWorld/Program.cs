using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        //Methods
        static void MyMethod(int x,int y,int z = 10/*default parameter*/) //Unlike Java, it's better to start methods with uppercase letter.
        {
            Console.WriteLine(Math.Pow(x+y,z));
        }//void type methods just do a function.
        //Overloading
        static int MyMethod(int score)
        { return score; }
        // int type method returns value which can be stored in a variable.

        

        static void Main(string[] args)
        {
            MyMethod(y:2, x:3);
            //Unlike Java, the name of the C# file does not have to match the class name.
            const int age = 22;//The const keyword is useful when you want a variable to always store the same value.
            Convert.ToString(age);
            string name = Console.ReadLine();//Input
            Math.Min(2, 10);//Math class
            Console.WriteLine(name.Length);//Length here is property and name is object.
            string bio = $"My name is: {name} and I'm {age}.";//Interpolation
            Console.WriteLine(bio[1]);//Find letter with index number.
            Console.WriteLine(bio.Substring(3));//Delete all letters before index 3!
            // Create an array of four elements, and add values later
            string[] cars = new string[4];
            // Create an array of four elements and add values right away 
            string[] cars1 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };
            // Create an array of four elements without specifying the size 
            string[] cars2 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };
            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] cars3 = { "Volvo", "BMW", "Ford", "Mazda" };
            //Property Length is also availble here because cars is an object of class string[]/Array. 
            Console.WriteLine(cars1.Length);
            Console.WriteLine(cars2[0]);
            //Loop through arrays 
            foreach (string car in cars1)
            {  Console.WriteLine(car); }
            //Sort method
            Array.Sort(cars1);
            //System.linq namespace --> Max,Min,Sum
            int[] nums = { 1, 8, 4, 10 };
            Array.Sort(nums);
            Console.WriteLine(nums.Max());
            //2D Arrays and loop through it.
            int[,] numbers = { { 4, 6 }, { 1, 10 } };
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }
            }
            
        }
    }
}

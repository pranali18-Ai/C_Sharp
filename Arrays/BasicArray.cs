using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class BasicArray
    {
        static void Main(string[] args)
        {
            //FIRST WAY 
            //string Array
            string[] Languages = { "Marathi", "English", "Spanish", "Japanese" };

            //Integer Arrays
            int[] num = { 10, 20, 30, 40 };

            

            //Change the element in Array
            Languages[0] = "Hindi";

            //To Count the Length of Array
            Console.WriteLine("Length of Languages Array: " + Languages.Length);

            //Acess the elements of Array
            Console.WriteLine("Language: " + Languages[0] + "\nnum: " + num[0]);
            Console.ReadKey();



            //SECOND WAY
            // Create an array of four elements, and add values later
            string[] Fruits = new string[4];
            Fruits[0] = "Mango"; // and so on

            // Create an array of four elements and add values right away 
            string[] Car = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements without specifying the size 
            string[] Cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] Language = { "Marathi", "English", "Spanish", "Japanese" };
        }
    }
}

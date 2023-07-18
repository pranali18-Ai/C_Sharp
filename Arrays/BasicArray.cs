using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq; //for Arrays

namespace Arrays
{
    class BasicArray
    {
        static void Main(string[] args)
        {
            //    **SINGLE DIMENSIONAL ARRAY **

            //        //FIRST WAY 
            //        //string Array
            //        string[] Languages = { "Marathi", "English", "Spanish", "Japanese" };

            //        //Integer Arrays
            //int[] num = { 20, 40, 10, 50 };



            //        //Change the element in Array
            //        Languages[0] = "Hindi";

            //        //To Count the Length of Array
            //        Console.WriteLine("Length of Languages Array: " + Languages.Length);

            //        //Acess the elements of Array
            //        Console.WriteLine("Language: " + Languages[0] + "\nnum: " + num[0]);




            //        //SECOND WAY
            //        // Create an array of four elements, and add values later
            //        string[] Fruits = new string[4];
            //        Fruits[0] = "Mango"; // and so on

            //        // Create an array of four elements and add values right away 
            //        string[] Car = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            //        // Create an array of four elements without specifying the size 
            //string[] Cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            //        // Create an array of four elements, omitting the new keyword, and without specifying the size
            //        string[] Language = { "Marathi", "English", "Spanish", "Japanese" };



            //Loop through an Array
            //for Language
            //string[] Lang = { "Marathi", "English", "Spanish", "Japanese" };
            //for (int i = 0; i<Lang.Length; i++)
            //{                
            //    Console.WriteLine( Lang[i] );
            //}
            //Console.WriteLine(); //new Line

            ////For Cars
            //string[] Cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };
            //for (int j = 0; j < Cars.Length; j++)
            //{
            //    Console.WriteLine(Cars[j]);
            //}


            //foreach loop
            /*
              Syntax
              foreach(type variableName in arrayName)
                {
                    code of block to be executed
                }
            */
            //foreach(string i in Lang)
            //{
            //    Console.WriteLine(i);
            //}


            //Sorting the Array
            //string
            //Array.Sort(Lang);
            //foreach(string i in Lang)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(); //new Line
            ////Integer
            //Array.Sort(num);
            //foreach(int j in num)
            //{
            //    Console.WriteLine(j);
            //}
            //Console.ReadLine();

            ////Other useful Array Methods--------> will be found in the System.Linq namespace
            ////Min, Max, and Sum
            //int[] numbers = { 2, 4, 5, 10, 1 };
            //Console.WriteLine("Maximum element: " + numbers.Max());  
            //Console.WriteLine("Smallest element: " + numbers.Min());   
            //Console.WriteLine("Sum of the elements: "+ numbers.Sum());

            //Console.ReadLine();

            //   **MULTIDIMENSIONAL ARRAY** ---------> Arrays can have any number of dimension
            //       2D Array

            int[,] n = { { 1, 4, 2 }, { 3, 5, 8 } };
            //int[,,] n1 = { { 1, 4, 2 }, { 3, 6, 8 }, { 3, 5, 6 } };  ------>3D Array
            
            ////Acess the element
            //Console.WriteLine(n[0,0]);

            ////Change the element
            //n[0, 0] = 5;
            //Console.WriteLine(n[0, 0]);

            //Loop through 3D Array
            //foreach(int i in n)   //by using foreach loop
            //{
            //    Console.WriteLine(i);
            //}

            //by using for Loop
            for(int i = 0; i < n.GetLength(0); i++)
            {
                for(int j = 0; j< n.GetLength(0); j++)
                {
                    Console.WriteLine(i);

                }
            }
            Console.ReadLine();
        }

    }
    
}

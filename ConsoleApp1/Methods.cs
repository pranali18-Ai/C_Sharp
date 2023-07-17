
// Passing by value--->doesn't change the value and store in the different memory Location
//Passing by reference-------> change the value of each other and store in same Location

using System;
class CSharp {
  static void Main() {
      
      //PASSING BY VALUE AND REFERENCE
//     int i = 0;
    
//     SimpleMethod(ref i);   //----->reference
//     // SimpleMethod(i); //------->value
    
//     Console.WriteLine(i);
//   }
  
//   static void SimpleMethod(ref int j) //----->reference
// //   static void SimpleMethod(int j) //------->value
//   {
//       j = 101;
 
//  //PARAMETERS ARRAYS
    int [] Numbers = new int[3];
    Numbers[0] = 20;
    Numbers[1] = 32;
    Numbers[2] = 44;
    ParamsArray(0,1,2);

  }
  
  
  //PARAMETERS ARRAYS
  static void ParamsArray(params int [] Numbers)
  {
    Console.WriteLine("There are {0} elements in array", Numbers.Length);
    foreach(int i in Numbers){
        Console.WriteLine(i);
    }
  }
 

// // OUT PARAMETERS
//         int Total = 0;
//         int Product = 0;
//         OutParameter(4,2, out Total, out Product);
//         Console.WriteLine("Sum = {0}  && Total = {1} ", Total, Product);
//   }


// //   OUT PARAMETERS
// static void OutParameter(int FN, int SN, out int Sum, out int Product)
// {
//     Sum = FN + SN;
//     Product = FN * SN;
// }

}


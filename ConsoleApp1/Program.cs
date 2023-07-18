using System;

//NAMESPACE
//using PATA = ProjectA.TeamA;
//using PATB = ProjectA.TeamB;

//class Program
//{
//    public static void Main()
//    {
//        PATA.ClassA.Print();
//        PATB.ClassA.Print();
//        Console.ReadKey();
//    }
//}

//CLASSES
class Customer
{
    string _FirstName;
    string _LastName;


    public Customer(string FirstName, string LastName)  //constructor
    {
        this._FirstName = FirstName;
        this._LastName = LastName;
    }
    public void PrintFullName()
    {
        Console.WriteLine("Full Name = {0} {1}",  this._FirstName + " ", this._LastName);

    }
    ~Customer()   //destructor same name as class
    {
        //Clean up code
    }
}

class Program
{
    public static void Main()
    {
        Customer c1 = new Customer("Pragim", "Technologies");
        c1.PrintFullName();
        Console.ReadKey();
    }
}



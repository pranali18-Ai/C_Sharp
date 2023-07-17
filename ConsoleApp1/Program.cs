using System;
using PATA = ProjectA.TeamA;  //using alies directive
using PATB = ProjectA.TeamB;
//using ProjectA.TeamA; ------->For Not fully Qualified Name 
using System.Collections;
using System.Configuration;


class Program
{
    public static void Main()
    {
        PATA.ClassA.Print();
        PATB.ClassA.Print();
        //ProjectA.TeamA.ClassA.Print();  //-------->Fully Qualified Name
        Console.ReadKey();
        //ClassA.Print();  //--------->Not fully Qualified Name 
    }
}

namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team A");
            }
        }
    }
}

namespace ProjectA
{
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team B");
            }
        }
    }
}

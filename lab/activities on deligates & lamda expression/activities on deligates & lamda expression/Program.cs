// -------activity 1 ----- 
// multicast deligate example
using System;
using System.Diagnostics;
class Program
{
    delegate void myDelegate();

    static void MethodA()
    {
        Console.WriteLine("Method A calling");
    }
    static void MethodB()
    {
        Console.WriteLine("Method B calling");
    }
    static void MethodC()
    {
        Console.WriteLine("Method  C calling");
    }
    static void Main()
    {
        myDelegate del = MethodA;

        del += MethodB;
        del += MethodC;

        del();
    }
}

//----------------activity 2-------
//replace methods with lambda expressions
//using System;
//class Program
//{
//    delegate void MyDelegate();
//    static void Main()
//    {
//        MyDelegate del = () => Console.WriteLine("Lamda A Executed");
//        del += () => Console.WriteLine("Lamda B Executed");
//        del += () => Console.WriteLine("Lamda C Executed");

//        del();

//    }
//}


//------activity 3---------------
// sort list using lambda expression
//using System;
//using System.Collections.Generic;

//class Student { 
//    public String Name {  get; set; }
//    public int Marks { get; set; }
//}
//class Program
//{
//    static void Main()
//    {
//        List<Student> students = new List<Student>
//        {
//            new Student { Name = "Shweta", Marks = 88 },
//            new Student { Name = "Kishori", Marks = 87 }
//        };
//        students.Sort((s1, s2) => s1.Marks.CompareTo(s2.Marks));

//        foreach (var s in students)
//            Console.WriteLine($"{s.Name} -{s.Marks}" );

//    }
//}

// -------activity 4-----
//where we use deligates and lambda expressions in industries or companies

//deligates:
//It used in event handling  like button click , API response,payment success
//used in callbacks
//used in Async Programming

//Lambda Expression:
//It is used in LINQ 
//Used in Sorting and filtering data


//---------activity 5-------------
//What is LINQ queries

//LINQ means Language Integrated Query 
//LINQ queries means Writing  collections Queries (List,Array,DB,XML)using C#


//class Car
//{
//    string color = "red";
//    static void Main(string[] args)
//    {
//        Car myObj = new Car();
//        Car myObj1 = new Car();
//        Console.WriteLine(myObj.color);
//        Console.WriteLine(myObj1.color);
//    }

//}
//class Myclass
//{
//    string color = "red";
//    int maxspeed = 200;
//    public void accelerate2()
//    {
//        Console.WriteLine("This car goes faster as it can!!");
//    }
//    static void Main(string[] args)
//    {
//        Myclass obj=new Myclass();
//        Console.WriteLine(obj.color);
//        Console.WriteLine(obj.maxspeed);
//        obj.accelerate2();
//    }
//}

//class Car1
//{
//    string color2;
//    string model;
//    int year;

//    static void Main(string[] args)
//    {
//        Car1 Kia = new Car1();
//        Kia.color2 = "Black";
//        Kia.model = "new";
//        Kia.year = 2024;
//        Car1 suzuki = new Car1();
//        suzuki.color2 = "white";
//        suzuki.model = "old";
//        suzuki.year = 2023;
//        Console.WriteLine(Kia.model);
//        Console.WriteLine(suzuki.color2);

//    }
//}

class Car
{
    public string model;

    public Car()
    {
        model = "KIA";
    }
    static void Main(string[] args)
    {
        Car Ford = new Car();
        Console.WriteLine(Ford.model);
    }
}

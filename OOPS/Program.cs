using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string name = "hammesh";

            //singHappyBirthday(name);
            //singHappyBirthday(name);
            //singHappyBirthday(name);


            //Messages.Hello();
            //Messages.Bye();
            //Messages.Wait();

            //human h1 = new human();
            //h1.name = "miguel";
            //h1.age = 20;

            //h1.eat();

            //human h2 = new human();
            //h2.name = "sam";
            //h2.age = 20;

            //h2.eat();

            //human h3 = new human("daniel", 60);
            //h3.eat();
            //h3.sleep();

            Car c1 = new Car();
            c1.go();
            Console.WriteLine("car has " + c1.wheels + " wheels");

            Bicycle b1 = new Bicycle();
            Boat bb1 = new Boat();

            b1.speed = 20;
            Console.WriteLine(b1.speed);



        }

        //static void singHappyBirthday(string name)
        //{
        //    Console.WriteLine("Happy birthday to you !!!");
        //    Console.WriteLine("Happy birthday to you !!!");
        //    Console.WriteLine("Happy birthday to dear " + name);
        //    Console.WriteLine();
        //}
    }

    //class human
    //{
    //    public string name;
    //    public int age;

    //    public human()
    //    {

    //    }
    //    public human(string name,int age)
    //    {
    //        this.name = name;
    //        this.age = age;
    //    }

    //    public void eat()
    //    {
    //        Console.WriteLine(name + " is eating");
    //    }

    //    public void sleep()
    //    {
    //        Console.WriteLine(name + " is sleeping");
    //    }
    //}

    class Vehicle {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("this vehicle is moving");
        }
    }

    class Car : Vehicle
    {
        public int wheels = 4;
    }
    class Bicycle: Vehicle
    {
        public int wheels = 2;
    }

    class Boat : Vehicle
    {
        public int wheels = 0;
    }

}

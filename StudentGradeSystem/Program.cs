using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Maths's Marks : ");
            int maths = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Physics's Marks : ");
            int physics = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Chemistry's Marks : ");
            int chemistry = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the English's Marks : ");
            int english = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Computer's Marks : ");
            int computer = Convert.ToInt32(Console.ReadLine());

            int total_marks = maths + physics + chemistry + english + computer;

            double percentage = (total_marks * 100) / 500.0;

            if (percentage >= 90)
            {
                Console.WriteLine("congratulations!!");
                Console.WriteLine("your total marsk is : " + total_marks);
                Console.WriteLine("your total percentage is : " + percentage);
                Console.WriteLine("your grade is : O (outstanding)");
            }
            else if(percentage>=80 && percentage < 90)
            {
                Console.WriteLine("congratulations!");
                Console.WriteLine("your total marsk is : " + total_marks);
                Console.WriteLine("your total percentage is : " + percentage);
                Console.WriteLine("your grade is : A (very good)");
            }
            else if(percentage>=70 && percentage < 80)
            {
                Console.WriteLine("keep it up");
                Console.WriteLine("your total marsk is : " + total_marks);
                Console.WriteLine("your total percentage is : " + percentage);
                Console.WriteLine("your grade is : B (good)");
            }
            else if(percentage>=60 && percentage < 70)
            {
                Console.WriteLine("you need to work hard");
                Console.WriteLine("your total marsk is : " + total_marks);
                Console.WriteLine("your total percentage is : " + percentage);
                Console.WriteLine("your grade is : C (Average)");
            }
            else if(percentage>=50 && percentage < 60)
            {
                Console.WriteLine("you need to work hard please start to study daily");
                Console.WriteLine("your total marsk is : " + total_marks);
                Console.WriteLine("your total percentage is : " + percentage);
                Console.WriteLine("your grade is : D (just pass)");
            }
            else
            {
                Console.WriteLine("you are fail");
                Console.WriteLine("your total marsk is : " + total_marks);
                Console.WriteLine("your total percentage is : " + percentage);
                Console.WriteLine("your grade is : F (Fail)");
            }

        }
    }
}

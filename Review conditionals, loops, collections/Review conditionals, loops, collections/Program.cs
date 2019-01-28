using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_conditionals__loops__collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //int age=0;


            //string messageForUser = "Please enter yo age>> ";
            //Console.WriteLine(messageForUser); //asks user to input their age
            //age = Convert.ToInt32(Console.ReadLine());
            //if (age == 18)
            //{
            //    Console.WriteLine("Congrats you are 18");
            //}
            //if (age == 16)
            //{
            //    Console.WriteLine("vroom vroom you can drive");
            //}

            ////Console.WriteLine("Your age is " + age.ToString("N0")); //concatenate a string with the value of our variable age, formatted number with 0 decimals
            //Console.ReadKey();

            //string[] firstNames = new string[15];
            //string[] lastNames = new string[15];
            //firstNames[0] = "Adam";
            //lastNames[0] = "Ackerman";
            //firstNames[1] = "Steve";
            //lastNames[1] = "Jobs";
            //for(int i=0; i < firstNames.Length; i++)
            //{
            //    if (lastNames[i]==null&& firstNames[i] == null)
            //    {

            //    }
            //    else
            //    {
            //       Console.WriteLine($"{lastNames[i]}, {firstNames[i]}");
            //    }

            //}
            //Console.ReadKey();

            //List<double> examScores = new List<double>();
            //examScores.Add(75.5);
            //examScores.Add(50);
            //examScores.Add(25.5);
            //examScores.Add(7);
            //examScores.Add(100);
            //double average = 0;

            //foreach (var item in examScores)
            //{
            //    average += item;
            //    Console.WriteLine(item);
            //}
            //Console.Write($"average exam score is {(average / examScores.Count).ToString}");

            //Console.ReadKey();

            Dictionary<int, double> studentgrades = new Dictionary<int, double>(); //hw will be string,double for the fruit dict problem
            studentgrades.Add(1, 0.97);
            studentgrades.Add(2, 0.47);
            Console.WriteLine(studentgrades[1].ToString("p2"));
            if (studentgrades.ContainsKey(0)==true)
            {
                Console.WriteLine(studentgrades[0]);
            }
            else
            {
                studentgrades.Add(0, 1.0);
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.IO;
using System.Text;

namespace numberGen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers");
            long number = long.Parse(Console.ReadLine());

            Console.WriteLine("Upper bound");
            int UB = int.Parse(Console.ReadLine());

            Random rng = new Random();
            int randomNumber = 0;
            StringBuilder output = new StringBuilder();
            for(int i = 0; i < number; i++){
                randomNumber = rng.Next(1, UB+1);
                output.Append(randomNumber.ToString() + ",");

                if(i % 1000 == 0)
                    Console.WriteLine(i);
            }
            //Console.WriteLine(output);

            File.WriteAllText("numbers.txt" , output.ToString().Substring(0, output.Length - 1));
            Console.WriteLine("Complete writing to file");
        }
    }
}

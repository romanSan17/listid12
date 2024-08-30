using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //5

            Random random = new Random();
            int secretNumber = random.Next(1, 51);

            int attempts = 5; 
            bool guessed = false; 

            Console.WriteLine("arvake ära number");

            for (int i = 1; i <= attempts; i++)
            {
                Console.Write($"püüe {i}: ");
                int userGuess = int.Parse(Console.ReadLine());

                if (userGuess == secretNumber)
                {
                    Console.WriteLine("Sa arvasid ära!");
                    guessed = true;
                    break;
                }
                else if (userGuess < secretNumber)
                {
                    Console.WriteLine("number suurem kui+");
                }
                else
                {
                    Console.WriteLine("number väiksem kui-");
                }
            }

            if (!guessed)
            {
                Console.WriteLine($"Arvatav arv oli: {secretNumber}");
            }


            //4

            string vastus;

            while (true)
            {

                Console.WriteLine("Osta elevant!");


                vastus = Console.ReadLine();

                if (vastus.ToLower() == "elevant")
                {

                    break;
                }
                else
                {
                    Console.WriteLine("ei");
                }
            }


            //3

            string[] names = new string[5];
            int[] ages = new int[5];

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Sisestage nimi {0}: ", i + 1);
                names[i] = Console.ReadLine();

                Console.Write("Sisestage vanus {0}: ", i + 1);
                ages[i] = int.Parse(Console.ReadLine());
            }

            int totalAge = ages.Sum();

            double averageAge = totalAge / (double)ages.Length;

            int youngestIndex = Array.IndexOf(ages, ages.Min());

            int oldestIndex = Array.IndexOf(ages, ages.Max());

            Console.WriteLine("\nsumm: " + totalAge);
            Console.WriteLine("Keskmine vanus: " + averageAge);
            Console.WriteLine("Noorim: " + names[youngestIndex] + ", vanusega: " + ages[youngestIndex]);
            Console.WriteLine("Vanim: " + names[oldestIndex] + ", vanusega: " + ages[oldestIndex]);



            //2
            int[] numbers = new int[5];
            int sum = 0;
            double average = 0;
            int product = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Sisestage arv {0}: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            sum = numbers.Sum();

            average = sum / (double)numbers.Length;

            foreach (int number in numbers)
            {
                product *= number;
            }

            Console.WriteLine("summa: " + sum);
            Console.WriteLine("aritmeetiline keskmine: " + average);
            Console.WriteLine("korrutis: " + product);

            //1

            //Random random = new Random();
            //int N = random.Next(-10, 10);
            //int M = random.Next(-10, 10);
            //int[] arvud;

            //if (N > M)
            //{
            //    arvud = Funktsioonid.Arvude_massiv(N, M);
            //}
            //else
            //{
            //    arvud = Funktsioonid.Arvude_massiv(N, M);
            //}
            //foreach (int item in arvud)
            //{
            //    Console.WriteLine(item * item);
            //}
        }
    }
}

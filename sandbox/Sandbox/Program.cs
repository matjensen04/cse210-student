using System;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        //short x = 32700;
        //Console.WriteLine(x);

        //for (int i = 0; i < 100; i++)
        //{
            //x++;
            //Console.WriteLine(x);
        //}

        //Console.Write("Enter first name: ");
        //string firstname = Console.ReadLine();
        //Console.WriteLine($"Hello {firstname}!");

        //Multiple ways to convert, I prefer Parse
        //string age_string = "34";
        //int age2 = int.Parse(age_string);
        //int age3 = Convert.ToInt32(age2);
        //Console.WriteLine($"{age3}");

        //int age = 20;
        //bool canVote = false;
        //if (age >= 18)
        //{
        //    canVote = true;
        //}
        //else
        //{
        //    canVote = false;
        //}
        //Console.WriteLine(canVote);

        // Python version vote = Trueif age >= 18 else False
        //bool vote = (age >= 18) ? true : false;
        //string vote_string = vote ? "Yes" : "No";

        // --------------------------------------------
        // AND , OR, And Not operators
        // &&, ||, !
        
        //bool citizen = false;
        //if (age >= 18 && citizen);

        //------------------------------
        //While loops

        //int count = 0;
        //while (count < 10);
        //{
        //    Console.WriteLine($"Count is {count}");
        //    count++;
        //}

        //string name;
        //do
        //{
        //    Console.WriteLine("Enter your name: ");
        //    name = Console.ReadLine();
        //} while (name.Length < 5);

        //Lists

        List<int> numbers = new List<int>();
        Console.WriteLine(numbers.Count);

        numbers.Add(1);
        numbers.Add(10);
        numbers.Add(100);
        numbers.Add(1000);

        Console.WriteLine(string.Join(", ", numbers));
        numbers.Reverse();
        Console.WriteLine(string.Join(", ", numbers));

    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please tell me what you scored on your exam to determine your grade.");
        int scored = int.Parse(Console.ReadLine());

        string win = "Perfect, you pass the exam. Your grade is:";
        string lose = "Nooo way, you did not pass the examen, better luck in the next one. Your grade is:";

        int A = 90;
        int B = 80;
        int C = 70;
        int D = 60;

        string sign = "";

        int lastDigit = scored % 10;

        if (scored >= 97)
        {
            sign = "";
        }
        else if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        
        if (scored >= A)
        {
            Console.WriteLine($"{win} A{sign}");
        }
        else if (scored >= B && scored < A )
        {
            Console.WriteLine($"{win} B{sign}");
        }
        else if (scored >= C && scored < B )
        {
            Console.WriteLine($"{win} C{sign}");
        }
        else if (scored >= D && scored < C )
        {
            Console.WriteLine($"{lose} D{sign}");
        }
        else
        {
            Console.WriteLine($"{lose} F");
        }
    }
}
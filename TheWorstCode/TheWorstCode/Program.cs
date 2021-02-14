using System;

namespace TheWorstCode
{
    class Program
    {
        static void Main(string[] args)
        {try{bool gogo = true; while (gogo) {Console.WriteLine("Please write the two number you want to add");Console.WriteLine("To quit, press enter 2 times");int shell = Convert.ToInt32(Console.ReadLine());int body = Convert.ToInt32(Console.ReadLine());if (shell == body){int bigTurtle = (shell + body) * 3; Console.WriteLine("Gz they were Identical, you get tripple the the candy!");Console.WriteLine("Result: " + bigTurtle);} else if (shell != body){int turtle = shell + body; Console.WriteLine(turtle); }else Console.WriteLine("Why am I even here");}}catch (Exception e){Console.WriteLine("Error: Must be a number, restart!!!");Console.WriteLine("Error message" + e);}
        }        
    }
}

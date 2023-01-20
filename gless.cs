
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Enter first number");
       int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine ("Enter second number");
       int b = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Enter Third number");
       int c = Convert.ToInt32(Console.ReadLine());
        if(a>b&&a>c){
            Console.WriteLine("First number is greater");
        }
        else if(b>a&&b>c){
            Console.WriteLine("Second number is greater");
        }
        else{
            Console.WriteLine("Third number is greater");
        }
    }
}
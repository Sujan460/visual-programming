
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      Console.WriteLine("How many numbers to sum :");
      int n= int.Parse(Console.ReadLine());
        int b=0;
        for(int i=0;i<=n;i++){
          b=b+i;
        }
        Console.WriteLine("The sum is : "+b);
        }
    }

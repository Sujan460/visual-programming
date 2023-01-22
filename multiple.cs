using System;
public class Program{
    public static void Main(){
        Console.WriteLine("Enter any number for multiplication table");
        int num1=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number till you want the multiplication");
        int num2=int.Parse(Console.ReadLine());
        for(int i=1;i<=num2;i++){
            int num3=num1*i;
            Console.WriteLine(num3);

        }


        }

    }

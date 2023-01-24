using System;
public class Check{
    public static void Main(){
        Console.WriteLine("Enter Any Number");
        int num=Convert.ToInt32(Console.ReadLine());
        if(num%5==0&&num%7!=0){
            Console.Write("It is exactly dividible by 5 not by 7");
        }
        else if(num%5==0&&num%7==0){
            Console.Write("It is divisible by both 5 and 7");
        }
        else if(num%7==0){
            Console.Write("It is exactly divisible by 7");
        }
        else{
            Console.Write("Its is neither divisible by 5 nor by 7");
        }

    }

    
}
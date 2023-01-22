
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       int num = 2;
       int count = 0;
       
       for(int i=1; i<=num; i++){
                  if(num%i==0){
           count ++;
       }
       }
       if(count==2){
           Console.WriteLine("Prime number");
       }
       else{
           Console.WriteLine("Not prime number");
       }
        }
}
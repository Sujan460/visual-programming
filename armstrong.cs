
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num=153;
        int result=0;
        int cube;
        int rem;
        int temp=num;
        
        while(num!=0){
            rem=num%10;
            cube=rem*rem*rem;
            result=result+cube;
            num=num/10;
        }
        if(temp==result){
            Console.Write("Armstrong number");
        }
        else{
            Console.Write("Not a armstrong number");
        }
    }
}
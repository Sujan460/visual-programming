using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num=121;
        int result=0;
        int rem;
        int temp=num;
        while(num!=0){
            rem=num%10;
            result=result*10+rem;
            num=num/10;
        }
        if(temp==result){
            Console.WriteLine(temp+": is a pallindrome number");
        }
        else{
            Console.WriteLine(temp+": is not a pallindrome number");
        }
    }
}
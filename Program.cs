// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld{
    public class Sum{
        static void Main(string[]args){
            int a = 3;
            int b = 5;
            int temp;
            Console.WriteLine("Before Swapping the value of a={0},b={1}",a,b);
            temp=a;
            a=b;
            b=temp;
            Console.WriteLine("After Swapping The value of a={0},b={1}",a,b);
        }
    }
}
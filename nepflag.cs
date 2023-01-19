//Pattern program using forloop
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        for(int i=1;i<=4;i++){
           if(i==3){
               continue;
            }
            for(int j=1;j<=i;j++){
                Console.Write("*");
            }
            Console.WriteLine();
        }
        for(int i=1;i<=4;i++){
           if(i==3){
               continue;
            }
            for(int j=1;j<=i;j++){
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
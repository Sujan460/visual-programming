using System;
public class Program{
    public static void Main(){
        int a=0;
        int b=1;
        for(int i=0;i<10;i++){
        int c=a+b;
        a=b;
        b=c;
        Console.WriteLine(c);
        }

    }
}
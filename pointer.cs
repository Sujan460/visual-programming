
using System;
public class Program{
    public static void Main(){
        unsafe{
            int a=15;
            int*b=&a;
            Console.Write("Value :"+*b);
            Console.Write("address:"+(int)b);
        }
    }
}
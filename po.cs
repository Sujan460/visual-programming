using System;
public class Pro{
    public static void Main(){
        unsafe{
            int a=10;
            int*b=&a;
            Console.Write("Value :"+*b);
            Console.Write("address:"+(int)b);
        }
    }
}
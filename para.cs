using System;
    class Don{
        int m;
        int n;
        Don(int a , int b ){
            m =a;
            n = b;
        }
        static void Main(string[]ars){
            Don d = new Don(1,2);
            Console.WriteLine(d.m);
            Console.WriteLine(d.n);
        }
}
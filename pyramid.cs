using System;
public class Program{
    public static void Main(){
        for(int i=1;i<=5;i++){
            for(int j=i;j<=4;j++){
                Console.Write(" ");
            }
                for(int k=1;k<=i;k++){
                    Console.Write("*");
                }
                for(int l=2;l<=i;l++){
                    Console.Write("*");
                }

            Console.WriteLine();
        }
    }
}
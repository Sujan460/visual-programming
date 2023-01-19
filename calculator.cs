//Simple Program to make calculator using Switch statement
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string cont;
        do{
       int num1;
       int num2;
       string symbol;
       Console.WriteLine("Enter first Number");
       num1=int.Parse(Console.ReadLine());
       Console.WriteLine("Enter second Number");
       num2=int.Parse(Console.ReadLine());
       Console.WriteLine("Enter a Symbol(+,-,*,%,/)");
       symbol=Console.ReadLine();
       switch(symbol){
           case "+":
           int add=num1+num2;
           Console.WriteLine("Addition:"+" "+add);
           break;
           case "-":
           int sub =num1-num2;
           Console.WriteLine("Subtraction:"+" "+sub);
           break;
           case "*" :
           int multi =num1*num2;
           Console.WriteLine("Multliplication:"+" "+multi);
           break;
           case "/":
           int div=num1/num2;
           Console.WriteLine("Division:"+" "+div);
           break;
           case "%":
          int rem=num1%num2;
           Console.WriteLine("Remainder:"+rem);
           break;
       }
       Console.WriteLine("If you want to continue press Y for yes and Press N for No");
       cont=Console.ReadLine();
        }while(cont=="y"||cont=="Y");
       
    }
}
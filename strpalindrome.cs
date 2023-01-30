using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       string str="";
       Console.WriteLine("Enter any string to reverse");
       str=Console.ReadLine();
       char[] arr=str.ToCharArray();
       Array.Reverse(arr);
       string str1=new string (arr);
       if(str.Equals(str1)){
        Console.WriteLine("Palindrome string");
       }
       else{
        Console.Write("Not a palindrome string");
       }
       
    }
}
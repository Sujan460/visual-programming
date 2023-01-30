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
        Console.WriteLine("String is palindrome");
       }
       else{
        Console.Write("string is not palindrome");
       }
       
    }
}
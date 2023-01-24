
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      int b;
      Console.WriteLine("Enter Any string");
      string letter=Console.ReadLine();
      int vowel=0;
     b=letter.Length;
      for(int i=0;i<b;i++){
          if(letter[i]=='a'||letter[i]=='e'||letter[i]=='i'||letter[i]=='o'||letter[i]=='u'||letter[i]=='A'||letter[i]=='E'||letter[i]=='I'||letter[i]=='O'||letter[i]=='U'){
             vowel++;
          }
      }
    Console.WriteLine("There are "+" " +vowel+" "+" vowels in the word"+" "+letter);
        
        }
    }

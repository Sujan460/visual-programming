using System;
public struct Student{
   public string name;
   public int rollno;
   public string address;

}
public class Program{
    public static void Main(){
    
    
Student s1;
Student s2;
Student s3;

s1.name="Sushil";
s1.address="Ghar bata";
s1.rollno=11;

s2.name="Sujan";
s2.address="Sishuwa";
s2.rollno=20;

s3.name="Messi";
s3.address="Argentina";
s3.rollno=10;
Console.WriteLine("Name:"+" "+s1.name+" "+", address:"+" "+s1.address+" "+", rollno:"+" "+s1.rollno);
Console.WriteLine("Name:"+" "+s2.name+" "+", address:"+" "+s2.address+" "+", rollno:"+" "+s2.rollno);
Console.WriteLine("Name:"+" "+s3.name+" "+", address:"+" "+s3.address+" "+", rollno:"+" "+s3.rollno);

}
}
 
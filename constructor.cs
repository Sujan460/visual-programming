using System;
public class Program{
  string carname;
  int carnum;
  public Program(string name,int num){
    carname=name;
    carnum=num;
  }
    public static void Main(){
      Program p1=new Program("Mustang",1028);
      Console.WriteLine("Car Name:"+" "+p1.carname);
      Console.WriteLine("Car Number:"+" " +p1.carnum);
       
}
}
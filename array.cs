using System;
public class Pain{
public static void Main(){
    string[][] str=new string[6][];
    str[0]=new string[1] {"*"};
    str[1]=new string[2]{"*","*"};
    str[2]=new string [4]{"*","*","*","*"};
    str[3]=new string [1]{"*"};
    str[4]=new string [2]{"*","*"};
    str[5]=new string [4]{"*","*","*","*"};
    foreach( string[] row in str){
        foreach(string column in row){
            Console.Write(column);
        }
        Console.WriteLine();
    }
}
}




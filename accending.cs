using System;
class HelloWorld {
  static void Main() {
    char[] arr={'a','m','e','z','d'};
    Array.Sort(arr);
    foreach(var item in arr){
        Console.WriteLine(item);
    }
  }
}

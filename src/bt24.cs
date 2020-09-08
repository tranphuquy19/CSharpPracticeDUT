using System;
using System.Text.RegularExpressions;

class MainClass {
  public static void Main (string[] args) {
    Console.Write("Nhập chuỗi: ");

    string inputs = Console.ReadLine();
    
    foreach(char c in inputs) {
      if(c >= 'A' && c <= 'Z')
        Console.WriteLine(c);
    }

    Console.ReadKey();
  }
}
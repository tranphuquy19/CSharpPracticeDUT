using System;
using System.Text.RegularExpressions;

class MainClass {
  public static void Main (string[] args) {
    Console.Write("Nhập chuỗi: ");

    string[] inputs = Console.ReadLine().Trim().Split(" ");
    
    foreach(string inp in inputs) {
      Console.WriteLine(inp);
    }

    Console.ReadKey();
  }
}
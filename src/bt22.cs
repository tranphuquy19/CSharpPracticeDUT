using System;
using System.Text.RegularExpressions;

class MainClass {
  public static void Main (string[] args) {
    Console.Write("Nhập chuỗi: ");

    string input = Console.ReadLine();
    string result = Regex.Replace(input, @"(^\w)|(\s\w)", m => m.Value.ToUpper());

    Console.WriteLine(result);

    Console.ReadKey();
  }
}
using System;

class MainClass {
  public static String reverseNumber(string n) {
    int _n;
    
    if(int.TryParse(n, out _n) && _n >= 0) {
      String result = String.Empty;
      for(int i = n.Length - 1; i >= 0; i--) {
        char temp = n[i];
        if(temp >= '0' && temp <= '9')
          result += temp;
      }

      return result;
    } else throw new Exception("Bạn đã nhập không thỏa đề!");
  }

  public static void Main (string[] args) {
    Console.Write("Nhập n: ");

    String n = Console.ReadLine();

    String result = reverseNumber(n);

    Console.WriteLine("Result = {0}", result);

    Console.ReadKey();
  }
}
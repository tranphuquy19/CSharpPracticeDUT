using System;

class MainClass {
  public static char findMaxChar(String n) {
    int _n;
    if(int.TryParse(n, out _n)) {
      char max = n[0];
      for(int i = 1; i < n.Length; i++) {
        char temp = n[i];
        if(temp > max) max = temp;
      }

      return max;
    } else throw new Exception("Bạn đã nhập không phải là số!");
  }

  public static void Main (string[] args) {
    Console.Write("Nhập n: ");

    String n = Console.ReadLine();

    char maxChar = findMaxChar(n);

    Console.WriteLine("Kí tự có giá trị nguyên lớn nhất: {0}", maxChar);

    Console.ReadKey();
  }
}
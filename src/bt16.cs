using System;

class MainClass {
  public static double giaiThua(int n) {
    if (n == 1) return 1;
    else return n * giaiThua(n - 1);
  }

  public static double sum(string x, string n) {
    int _n, _x;
    
    if(int.TryParse(n, out _n) && int.TryParse(x, out _x)) {
     double result = 0;

     for (int i = 1; i <= _n; i++) {
      result += Math.Pow(_x, i) / giaiThua(i);
     }

     return result;
    } else throw new Exception("Bạn đã nhập không thỏa đề!");
  }

  public static void Main(string[] args) {
    Console.Write("Nhập n: ");
    string n = Console.ReadLine();

    Console.Write("Nhập x: ");
    string x = Console.ReadLine();

    double result = sum(x, n);

    Console.WriteLine("sum({0}) = {1}", n, result);

    Console.ReadKey();
  }
}
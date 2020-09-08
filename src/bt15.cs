using System;

class MainClass {
  public static double sum(string n) {
    int _n;
    
    if(int.TryParse(n, out _n)) {
     double result = 0;

     for (int i = 1; i <= _n; i = i + 2)
      {
        result += ((Math.Pow((-1), ((i - 1) / 2))) / i);
      }

      return result * 4;
    } else throw new Exception("Bạn đã nhập không thỏa đề!");
  }

  public static void Main(string[] args) {
    Console.Write("Nhập n: ");

    string n = Console.ReadLine();

    double result = sum(n);

    Console.WriteLine("sum({0}) = {1}", n, result);

    Console.ReadKey();
  }
}
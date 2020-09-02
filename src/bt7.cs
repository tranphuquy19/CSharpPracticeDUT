
using System;

class MainClass {
  public static int UCLN(int a, int b) {
    while (a != b) {
      if (a > b) a -= b;
      else b -= a;
    }

    return a;
  }

  public static int BCNN(int a, int b) {
    int result = UCLN(a, b);
    return a * b / result;
  }

  public static void Main(string[] args) {
    Console.Write("Nhập a: ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Nhập b: ");
    int b = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("UCLN({0}, {1}) = {2}; BCNN({0}, {1}) = {3}", a, b, UCLN(a, b), BCNN(a, b));

    Console.ReadKey();
  }
}
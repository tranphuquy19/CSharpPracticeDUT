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
}using System;

class MainClass {
  // Bài 3 (2nd)
  public static void Main (string[] args) {
    Console.Write("Nhập a: ");
    float a = Convert.ToSingle(Console.ReadLine());

    Console.Write("Nhập b: ");
    float b = Convert.ToSingle(Console.ReadLine());

    Console.Write("Nhập c: ");
    float c = Convert.ToSingle(Console.ReadLine());

    bool result = (((a + b) > c) && ((b + c) > a) && ((c + a) > b));

    String _result = result ? "" : "không phải ";

    Console.WriteLine("a = {0}, b = {1}, c = {2} {3}là ba cạnh của tam giác", a, b, c, _result);

    Console.ReadKey();
  }
}
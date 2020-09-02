using System;

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
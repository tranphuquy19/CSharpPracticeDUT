using System;

class MainClass {
  // Bài 5
  public static float max(float a, float b, float c) {
    return (a > b && a > c) ? a : (b > a && b > c) ? b : c;
  }

  public static void Main (string[] args) {
    Console.Write("Nhập a: ");
    float a = Convert.ToSingle(Console.ReadLine());

    Console.Write("Nhập b: ");
    float b = Convert.ToSingle(Console.ReadLine());

    Console.Write("Nhập c: ");
    float c = Convert.ToSingle(Console.ReadLine());

    float result = max(a, b, c);

    Console.WriteLine("Số lớn nhất: {0}", result);

    Console.ReadKey();
  }
}
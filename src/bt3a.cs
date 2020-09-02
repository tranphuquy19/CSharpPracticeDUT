using System;

class BT3 {
  public static void Main (string[] args) {
    const double PI = 3.14159;
    Console.Write("Nhập độ: ");
    double d = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Radian: {0}", (d / 180.0) * PI);

    Console.ReadKey();
  }
}
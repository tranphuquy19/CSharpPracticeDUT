using System;

class BT4 {
  public static void Main (string[] args) {
    Console.Write("Nhập độ C: ");
    double dC = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Radian: {0} oF", ((dC * 1.8) + 32));

    Console.ReadKey();
  }
}
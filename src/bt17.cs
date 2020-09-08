using System;

class MainClass {
  public static void swap(ref int x,ref int y) {
    int temp = x;
    x = y;
    y = temp;
  }

  public static void Main(string[] args) {
    Console.Write("Nhập a: ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Nhập b: ");
    int b = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("AFTER: a = {0}, b = {1}", a, b);

    swap(ref a, ref b);

    Console.WriteLine("BEFORE: a = {0}, b = {1}", a, b);

    Console.ReadKey();
  }
}
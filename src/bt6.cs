using System;

class MainClass {
  // Bài 2 (2nd)
  public static void Main(string[] args) {
    int a, b, c;

    double d, x1, x2;

    Console.Write("Nhập giá trị của a: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.Write("\nNhập giá trị của b: ");
    b = Convert.ToInt32(Console.ReadLine());
    Console.Write("\nNhập giá trị của c: ");
    c = Convert.ToInt32(Console.ReadLine());

    d = b * b - 4 * a * c;
    if (d == 0) {
      x1 = -b / (2.0 * a);
      x2 = x1;
      Console.Write("Phương trình có nghiệm kép: x1 = x2 = {0}\n", x1);
    }
    else if (d > 0) {
      x1 = ( - b + Math.Sqrt(d)) / (2 * a);
      x2 = ( - b - Math.Sqrt(d)) / (2 * a);

      Console.WriteLine("Phương trình có hai nghiệm phân biệt: x1 = {0}; x2 = {1}", x1, x2);
    }
    else Console.WriteLine("Phương trình không có nghiệm thực nào!");

    Console.ReadKey();
  }
}
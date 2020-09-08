using System;

class MainClass {
  public static bool isNhuan(int n) {
    return (((n % 4 == 0) && (n % 100 != 0)) || (n % 400 == 0));       
  }

  public static void Main(string[] args) {
    Console.Write("Nhập n: ");

    int n = Convert.ToInt32(Console.ReadLine());

    bool result = isNhuan(n);

    string _result = result ? "" : "không phải ";

    Console.WriteLine("Năm {0} {1}là năm nhuận", n, _result);

    Console.ReadKey();
  }
}
using System;

class MainClass {
  public static bool isPrime(int number) {
    if (number <= 1) return false;
    if (number == 2) return true;
    if (number % 2 == 0) return false;

    var boundary = (int) Math.Floor(Math.Sqrt(number));

    for (int i = 3; i <= boundary; i += 2)
      if (number % i == 0) return false;

    return true;
  }

  public static void Main(string[] args) {
    Console.Write("Nhập n: ");

    int n = Convert.ToInt32(Console.ReadLine());

    String result = isPrime(n) ? "" : "không phải ";

    Console.WriteLine("{0} {1}là số nguyên tố!", n, result);

    Console.ReadKey();
  }
}
using System;

class MainClass {
  public static int fibonacci(int n) {
      if (n == 1 || n == 2) return 1;
      else return fibonacci(n - 1) + fibonacci(n - 2);          
  }

  public static void Main(string[] args) {
    Console.Write("Nhập n: ");

    int n = Convert.ToInt32(Console.ReadLine());

    int result = fibonacci(n);

    Console.WriteLine("fibo({0}) = {1}", n, result);

    Console.ReadKey();
  }
}
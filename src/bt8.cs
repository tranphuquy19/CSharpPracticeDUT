using System;

class MainClass {
  public static String convertToBinary(int n) {
    string result = String.Empty;

    int temp;
    while (n > 0) {
      temp = n % 2;
      n /= 2;
      result = temp.ToString() + result;
    }

    return result;
  }

  public static void Main(string[] args) {
    Console.Write("Nhập n: ");

    int n = Convert.ToInt32(Console.ReadLine());

    String result = convertToBinary(n);

    Console.WriteLine("{0} = 0b{1}", n, result);

    Console.ReadKey();
  }
}
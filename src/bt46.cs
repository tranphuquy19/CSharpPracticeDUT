using System;

class Program {
  public static void showPrimes(int number, int[] numbers) {
    Console.WriteLine("Những số nguyên tố trong dãy nhỏ hơn " + number + " là:");
    foreach(int x in numbers) {
      if (x < number && isPrime(x)) {
        Console.Write(x + "  ");
      }
    }
  }

  private static bool isPrime(int number) {
    if (number <= 1) return false;
    for (int i = 2; i < Math.Sqrt(number); i++) {
      if (number % i == 0) return false;
    }
    return true;
  }

  public static void Main(string[] args) {
    Console.Write("[?]Số lượng phần tử: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[n];

    for (int i = 0; i < arr.Length; i++) {
      Console.Write("Arr[{0}]: ", i);
      numbers[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.Write("[?]Index: ");
    int index = Convert.ToInt32(Console.ReadLine());
    
    int number = numbers[index];
    string result = isPrime(number) ? " ": " không phải";
    Console.WriteLine("Vị trí {0} = {1} {2}là số nguyên tố!", index, number, result);
    showPrimes(number, numbers);
  }
}
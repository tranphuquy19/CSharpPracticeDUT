using System;

class Program {
  private static void showPrimes(int number, int[] numbers) {
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

  static void Main(string[] args) {
    int[] numbers = {1, 5, 3, 10, 288, 54, 17, 39, 117, 401};
    int number = numbers[8];
    Console.WriteLine("So " + number + (isPrime(number) ? " ": " không phải") + " là số nguyên tố!");
    showPrimes(number, numbers);
  }
}
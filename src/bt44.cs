using System;
class Program {

  private static int getSum(int[] numbers) {
    int sum = 0;
    for (int i = 0; i < numbers.Length; i += 2) {
      sum += numbers[i];
    }
    return sum;
  }

  private static int getProduct(int[] numbers) {
    int product = 1;
    foreach(int number in numbers) {
      if (number % 2 == 0) product *= number;
    }
    return product;
  }

  private static int[] input() {
    Console.Write("[?]Số lượng phần tử: ");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[length];
    for (int i = 0; i < length; i++) {
      Console.Write($ "numbers[{i}] = ");
      numbers[i] = Convert.ToInt32(Console.ReadLine());
    }

    return numbers;
  }
  static void Main(string[] args) {
    int[] numbers = input();
    Console.WriteLine("Tích các số chẵn trong mảng: " + getProduct(numbers));
    Console.WriteLine("Tổng các phần tử vị trí lẻ trong mảng: " + getSum(numbers));
  }
}
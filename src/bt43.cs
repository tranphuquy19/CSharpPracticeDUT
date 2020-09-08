using System;

class Program {

  private static int getSum(int[] numbers) {
    int sum = 0;
    foreach(int number in numbers) {
      sum += number;
    }

    return sum;
  }

  private static int[] input() {
    Console.Write("[?]Số lượng phần tử: ");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[length];
    for (int i = 0; i < length; i++) {
      Console.Write($ "Arr[{i}] = ");
      numbers[i] = Convert.ToInt32(Console.ReadLine());
    }

    return numbers;
  }
  static void Main(string[] args) {
    int[] numbers = input();
    int sum = getSum(numbers);
    Console.Write("Tổng giá trị của mảng: " + sum);
  }
}
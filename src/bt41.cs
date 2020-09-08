using System;

class Program {
  private static int sum(int[] numbers) {
    int total = 0;
    foreach(int number in numbers) {
      total += number;
    }
    return total;
  }
  static void Main(string[] args) {
    int[] numbers = { 1,2,3,4,5 };
    int total = sum(numbers);
    Console.WriteLine("Tổng giá trị mảng: " + total);
  }
}
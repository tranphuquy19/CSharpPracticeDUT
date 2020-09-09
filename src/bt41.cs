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
    Console.Write("[?]Số lượng phần tử: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[n];

    for (int i = 0; i < arr.Length; i++) {
      Console.Write("Arr[{0}]: ", i);
      numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    
    int total = sum(numbers);
    Console.WriteLine("Tổng giá trị mảng: " + total);
  }
}
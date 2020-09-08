using System;

class Program {
  public static void sort(int[] numbers) {
    for (int i = 0; i < numbers.Length - 1; i++) {
      for (int j = i + 1; j < numbers.Length; j++) {
        if (numbers[i] > numbers[j]) {
          int tmp = numbers[i];
          numbers[i] = numbers[j];
          numbers[j] = tmp;
        }
      }
    }
  }

  static void Main(string[] args) {
    int[] numbers = {1,6,67,23,7,23};
    sort(numbers);
    Console.WriteLine("Mảng sau khi sort: ");
    foreach(int number in numbers) {
      Console.Write(number + " ");
    }
  }

}
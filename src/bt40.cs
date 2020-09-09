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

  public static void Main(string[] args) {
    Console.Write("[?]Số lượng phần tử: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[n];

    for (int i = 0; i < arr.Length; i++) {
      Console.Write("Arr[{0}]: ", i);
      numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    
    sort(numbers);
    Console.WriteLine("Mảng sau khi sort: ");
    foreach(int number in numbers) {
      Console.Write(number + " ");
    }

    Console.ReadKey();
  }
}
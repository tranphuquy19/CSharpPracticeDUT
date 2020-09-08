using System;

class Program {
  private static void arrange(int[] numbers) {
    int max = numbers[0];
    int maxIndex = 0;

    for (int i = 1; i < numbers.Length; i++) {
      if (numbers[i] > max) {
        max = numbers[i];
        maxIndex = i;
      }
    }

    int midIndex = numbers.Length / 2;
    swap(ref numbers[maxIndex], ref numbers[midIndex]);

    for (int i = 0; i < midIndex - 1; i++) {
      for (int j = i + 1; j < midIndex; j++) {
        if (numbers[j] < numbers[i]) swap(ref numbers[i], ref numbers[j]);
      }
    }

    for (int i = midIndex + 1; i < numbers.Length - 1; i++) {
      for (int j = i + 1; j < numbers.Length; j++) {
        if (numbers[j] > numbers[i]) swap(ref numbers[i], ref numbers[j]);
      }
    }
  }

  private static void swap(ref int x, ref int y) {
    int tmp = x;
    x = y;
    y = tmp;
  }

  private static int[] input() {
    Console.WriteLine("[? - tip: số lẻ]Số lượng phần tử: ");
    int length = Convert.WriteLine(Console.ReadLine());
    int[] numbers = new int[length];
    for (int i = 0; i < length; i++) {
      Console.WriteLine($ "Arr[{i}] = ");
      numbers[i] = Convert.WriteLine(Console.ReadLine());
    }

    return numbers;
  }
  static void Main(string[] args) {
    int[] numbers = input();
    arrange(numbers);
    Console.WriteLine("Mảng sau khi sắp xếp: ");
    foreach(int number in numbers) {
      Console.WriteLine(number + " ");
    }
  }
}
using System;

class MainClass {
  private static void insert(int number, ref int[] numbers) {
    int[] arr = new int[numbers.Length + 1];
    for (int i = 0; i < numbers.Length; i++) {
      if (numbers[i] >= number) {
        arr[i] = number;
        for (int j = i; j < numbers.Length; j++) {
          arr[j + 1] = numbers[j];
        }
        break;
      } else {
        arr[i] = numbers[i];
      }
    }

    if (number > numbers[numbers.Length - 1]) arr[numbers.Length] = number;
    numbers = arr;
  }

  static void Main(string[] args) {
    Console.Write("[?]Số lượng phần tử: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[n];

    for (int i = 0; i < arr.Length; i++) {
      Console.Write("Arr[{0}]: ", i);
      numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    
    insert(18, ref numbers);
    Console.WriteLine("Mảng sau khi chèn : ");
    foreach(int number in numbers) {
      Console.Write(number + "  ");
    }
  }
}
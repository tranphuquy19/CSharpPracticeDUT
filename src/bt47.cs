using System;

class Program {
  public static bool isPrime(int number) {
    if (number <= 1) return false;
    for (int i = 2; i < Math.Sqrt(number); i++) {
      if (number % i == 0) return false;
    }
    return true;
  }

  public static int[] input() {
    Console.Write("[?]Số lượng phần tử: ");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[length];
    for (int i = 0; i < length; i++) {
      Console.Write($ "Arr[{i}] = ");
      numbers[i] = Convert.ToInt32(Console.ReadLine());
    }

    return numbers;
  }

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
    int[] numbers = input();
    Console.WriteLine("Mảng: ");
    foreach(int num in numbers) {
      Console.Write(num + " ");
    }
    sort(numbers);
    Console.WriteLine("\nMảng sau khi sắp xếp: ");
    foreach(int num in numbers) {
      Console.Write(num + " ");
    }

    Console.Write("\nChọn ví trí phần tử cần kiểm tra: ");
    int index = Convert.ToInt32(Console.ReadLine());
    int number = numbers[index];

    string result = isPrime(number) ? " ": " không phải ";
    Console.WriteLine("Vị trí {0} = {1} {2}là số nguyên tố!", index, number, result);
  }
}
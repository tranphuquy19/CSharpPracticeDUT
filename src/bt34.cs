using System;

class Program {
  public static void sort(ref int[] numbers) {
    int evenIndex = 0,
    oddIndex = numbers.Length - 1;
    for (int i = 0; i < oddIndex; i++) {
      if (numbers[i] % 2 == 0) {
        if (evenIndex != i) {
          swap(ref numbers[i], ref numbers[evenIndex]);
        }
        evenIndex++;
      } else {
        swap(ref numbers[i], ref numbers[oddIndex]);
        oddIndex--;
      }
    }
  }

  public static void swap(ref int a, ref int b) {
    int tmp = a;
    a = b;
    b = tmp;
  }

  static void Main(string[] args) {
    int[] numbers = {1,45,123,46,12,65,2134};
    sort(ref numbers);
    Console.WriteLine("Mảng sau khi sort: ");
    foreach(int number in numbers) {
      Console.Write(number + "  ");
    }
  }
}
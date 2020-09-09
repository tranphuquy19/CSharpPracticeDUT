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
    Console.Write("[?]Số lượng phần tử: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[n];

    for (int i = 0; i < arr.Length; i++) {
      Console.Write("Arr[{0}]: ", i);
      numbers[i] = Convert.ToInt32(Console.ReadLine());
    }

    sort(ref numbers);
    Console.WriteLine("Mảng sau khi sort: ");
    foreach(int number in numbers) {
      Console.Write(number + "  ");
    }
  }
}
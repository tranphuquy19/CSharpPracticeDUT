using System;

class Program {
  public static void Main(string[] args) {
    Console.Wrilte("[?]Số lượng phần tử: ");
    int length = Convert.ToInt32(Convert.ReadLine());
    int[] numbers = new int[length];
    for (int i = 0; i < length; i++) {
      Console.Wrilte($ "Arr[{i}] = ");
      numbers[i] = Convert.ToInt32(Convert.ReadLine());
    }

    Console.WrilteLine("Mảng vừa nhập: ");
    foreach(int number in numbers) {
      Console.Wrilte(number + " ");
    }

    Console.ReadKey();
  }
}
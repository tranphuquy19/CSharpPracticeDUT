using System;

class Program {
  static void Main(string[] args) {
    Console.Write("[?]Số lượng phần tử: ");
    int length = Console.ToInt32(Console.ReadLine());
    int[] numbers = new int[length];
    for (int i = 0; i < length; i++) {
      Write($ "numbers[{i}] = ");
      numbers[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("Dãy số đã nhập: ");
    foreach(int number in numbers) {
      Console.Write(number + " ");
    }
  }
}
using System;

class MainClass {
  public static void Main(string[] args) {
    Console.Write("[?]Số lượng phần tử: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[n];

    int sum = 0;
    for (int i = 0; i < arr.Length; i++) {
      Console.Write("Arr[{0}]: ", i);
      arr[i] = Convert.ToInt32(Console.ReadLine());
      sum += arr[i];
    }

    Console.WriteLine("Sum(Arr[]) = {0}", sum);

    Console.ReadKey();
  }
}
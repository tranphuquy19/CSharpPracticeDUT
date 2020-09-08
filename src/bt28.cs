using System;

class MainClass {
  public static void Main(string[] args) {
    Console.Write("[?]Số lượng phần tử: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[n];

    for (int i = 0; i < arr.Length; i++) {
      Console.Write("Arr[{0}]: ", i);
      arr[i] = Convert.ToInt32(Console.ReadLine());
    }

    foreach(int i in arr) {
      if (i % 2 == 0) Console.WriteLine("{0}", i);
    }

    Console.ReadKey();
  }
}
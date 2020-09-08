using System;

class MainClass {
  public static void Main(string[] args) {
    Console.Write("[?]Số lượng phần tử: ");
    int n = Convert.ToInt32(Console.ReadLine());
    double[] arr = new double[n];

    double max = double.NegativeInfinity;
    for (int i = 0; i < arr.Length; i++) {
      Console.Write("Arr[{0}]: ", i);
      arr[i] = Convert.ToDouble(Console.ReadLine());
      if(arr[i] > max) max = arr[i];
    }

    Console.WriteLine("Max(Arr[]) = {0}", max);

    Console.ReadKey();
  }
}
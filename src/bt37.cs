using System;

class Program {
  public static bool isSymmetry(int[] numbers) {
    for (int i = 0; i < numbers.Length / 2; i++) {
      if (numbers[i] != numbers[numbers.Length - i - 1]) return false;
    }

    return true;
  }

  public static void Main(string[] args) {
    Console.Write("[?]Số lượng phần tử: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[n];

    for (int i = 0; i < arr.Length; i++) {
      Console.Write("Arr[{0}]: ", i);
      numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    
    string result = (isSymmetry(numbers) ? "": "không phải ";

    Console.WriteLine("Mảng trên {0}là mảng đối xứng", result);
  }
}
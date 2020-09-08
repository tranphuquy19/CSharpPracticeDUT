using System;

class Program {
  private static bool isSymmetry(int[] numbers) {
    for (int i = 0; i < numbers.Length / 2; i++) {
      if (numbers[i] != numbers[numbers.Length - i - 1]) return false;
    }

    return true;
  }

  static void Main(string[] args) {
    int[] numbers = {1,2,3,2,1};
    Console.WriteLine("Mảng trên " + (isSymmetry(numbers) ? "": "không phải ") + "là mảng đối xứng");
  }
}
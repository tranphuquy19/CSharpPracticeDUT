using System;

class MainClass {
  public static string reverseString(char[] input) {
    char[] arr = input;
    for (int i = 0; i < arr.Length / 2; i++) {
      char tmp = arr[i];
      arr[i] = arr[arr.Length - i - 1];
      arr[arr.Length - i - 1] = tmp;
    }
    return new String(arr);
  }

  public static void Main (string[] args) {
    Console.Write("Nhập chuỗi: ");

    char[] input = Console.ReadLine().ToCharArray();

    Console.WriteLine(reverseString(input));

    Console.ReadKey();
  }
}
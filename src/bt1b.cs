using System;

class MainClass {
  // Bài 1 (2nd)
  public static void Main (string[] args) {
    Console.Write("Nhập số nguyên: ");
    int n = Convert.ToInt32(Console.ReadLine());

    String result = n % 2 == 0 ? "Số chẵn" : "Số lẻ";

    Console.WriteLine(result);

    Console.ReadKey();
  }
}
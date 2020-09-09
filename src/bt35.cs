using System;
using System.Collections.Generic;

class MainClass {
  public static void delete(int number, ref int[] numbers) {
    List < int > array = new List < int > ();
    foreach(int x in numbers) {
      if (x != number) {
        array.Add(x);
      }
    }
    numbers = array.ToArray();
  }

  public static void Main(string[] args) {
    Console.Write("[?]Số lượng phần tử: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[n];

    for (int i = 0; i < arr.Length; i++) {
      Console.Write("Arr[{0}]: ", i);
      numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    
    delete(10, ref numbers);
    Console.WriteLine("Mảng sau khi xóa: ");
    foreach(int number in numbers) {
      Console.Write(number + "  ");
    }
  }
}
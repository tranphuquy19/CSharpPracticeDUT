using System;
using System.Collections.Generic;

class MainClass {
  private static void delete(int number, ref int[] numbers) {
    List < int > array = new List < int > ();
    foreach(int x in numbers) {
      if (x != number) {
        array.Add(x);
      }
    }
    numbers = array.ToArray();
  }

  static void Main(string[] args) {
    int[] numbers = {
      1,
      346,
      123,
      56,
      123,
      436
    };
    delete(10, ref numbers);
    Console.WriteLine("Mảng sau khi xóa: ");
    foreach(int number in numbers) {
      Console.Write(number + "  ");
    }
  }
}
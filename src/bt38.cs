using System;
using System.Collections.Generic;

class Program {
  private static int findLargestNumber(int[] numbers) {
    List < int > arr = new List < int > ();
    List < int > counts = new List < int > ();

    foreach(int number in numbers) {
      if (arr.Contains(number)) {
        counts[arr.IndexOf(number)]++;
      } else {
        arr.Add(number);
        counts.Add(0);
      }
    }

    int max = 0;
    int maxIndex = 0;
    for (int i = 0; i < counts.Count; i++) {
      if (counts[i] > max) {
        max = counts[i];
        maxIndex = i;
      }
    }

    return arr[maxIndex];
  }

  static void Main(string[] args) {
    Console.Write("[?]Số lượng phần tử: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[n];

    for (int i = 0; i < arr.Length; i++) {
      Console.Write("Arr[{0}]: ", i);
      numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    
    int largestNumber = findLargestNumber(numbers);
    Console.WriteLine("Số xuất hiện nhiều nhất trong dãy là: " + largestNumber);
  }
}
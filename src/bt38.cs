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
    int[] numbers = {1,46,12,651,2,125,12,2,12,1};
    int largestNumber = findLargestNumber(numbers);
    Console.WriteLine("Số xuất hiện nhiều nhất trong dãy là: " + largestNumber);
  }
}
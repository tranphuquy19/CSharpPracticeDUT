using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Write("[?] Số phần tử mảng thứ 1: ");
    int count1 = int.Parse(Console.ReadLine());

    Console.Write("[?] Số phần tử mảng thứ 2: ");
    int count2 = int.Parse(Console.ReadLine());
    int[] array1 = new int[count1];
    int[] array2 = new int[count2];

    
    for (int i = 0; i < count1; i++) {
      Console.Write("Arr1[{0}]: ", i);
      array1[i] = int.Parse(Console.ReadLine());
    }

    for (int i = 0; i < count2; i++) {
      Console.Write("Arr2[{0}]: ", i);
      array2[i] = int.Parse(Console.ReadLine());
    }

    int[] arrayResult = new int[count1 + count2];

    int a = 0,
    b = 0;
    int e = 0;

    while (a < count1 && b < count2) {
      if (array1[a] <= array2[b]) {
        arrayResult[e++] = array1[a++];
      }
      else {
        arrayResult[e++] = array2[b++];
      }
    }

    if (a < count1) {
      for (int j = a; j < count1; j++) {
        arrayResult[e++] = array1[j];
      }
    }
    else {
      for (int j = b; j < count2; j++) {
        arrayResult[e++] = array2[j];
      }
    }

    Console.Write("{");
    foreach(int el in arrayResult) {
      Console.Write("{0} ", el);
    }
    Console.Write("}");

    Console.ReadKey();
  }
}
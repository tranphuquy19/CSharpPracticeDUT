using System;

class MainClass {
  public static int[] concat(int[] a, int[] b) {
    int[] c = new int[a.Length + b.Length];
    int i, j;

    for (i = 0; i < a.Length; i++) {
      c[i] = a[i];
    }

    for (j = 0; j < b.Length; j++) {
      c[i] = b[j];
      i++;
    }

    return c;
  }

  public static void Main (string[] args) {
    Console.Write("[?] Số phần tử mảng thứ 1: ");
    int size1st = int.Parse(Console.ReadLine());

    Console.Write("[?] Số phần tử mảng thứ 2: ");
    int size2nd = int.Parse(Console.ReadLine());
    int[] a = new int[size1st];
    int[] b = new int[size2nd];

    
    for (int i = 0; i < size1st; i++){
      Console.Write("Arr1[{0}]: ", i);
      a[i] = int.Parse(Console.ReadLine());
    }

    for (int i = 0; i < size2nd; i++) {
      Console.Write("Arr2[{0}]: ", i);
      b[i] = int.Parse(Console.ReadLine());
    }

    Console.Write("Arr1 + Arr2: ");

    int[] c = concat(a, b);
    for (int i = 0; i < c.Length; i++)
    {
        Console.Write(c[i] + " ");
    }
  }
}
using System;

class MainClass {
  public static int indexOf(int[] arr, int x) { 
    for(int i = 0; i < arr.Length; i++) {
      if(arr[i] == x) return i;
    }
    return -1;
  } 

  public static void Main(string[] args) {
    Console.Write("[?]Số lượng phần tử: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[n];

    for (int i = 0; i < arr.Length; i++) {
      Console.Write("Arr[{0}]: ", i);
      arr[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.Write("[?]Số cần tìm: ");
    int x = Convert.ToInt32(Console.ReadLine());

    int e = indexOf(arr, x);

    if(e == -1) {
      Console.WriteLine("Không tìm thấy {0} trong mảng", x);
    } else {
      Console.WriteLine("Tìm thấy {0} tại vị trí: {1}", x, e);
    }

    Console.ReadKey();
  }
}
using System;

class MainClass {
  static void bubbleSort(float[] arr) { 
    int n = arr.Length; 
    for (int i = 0; i < n - 1; i++) 
      for (int j = 0; j < n - i - 1; j++) 
        if (arr[j] > arr[j + 1]) 
        { 
            float temp = arr[j]; 
            arr[j] = arr[j + 1]; 
            arr[j + 1] = temp; 
        } 
    } 

  public static void Main(string[] args) {
    Console.Write("[?]Số lượng phần tử: ");
    int n = Convert.ToInt32(Console.ReadLine());
    float[] arr = new float[n];

    for (int i = 0; i < arr.Length; i++) {
      Console.Write("Arr[{0}]: ", i);
      arr[i] = Convert.ToSingle(Console.ReadLine());
    }

    bubbleSort(arr);

    foreach(float i in arr) {
      Console.WriteLine("{0}", i);
    }

    Console.ReadKey();
  }
}
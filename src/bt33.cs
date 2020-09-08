using System;

class MainClass {
  private static void insert(int number, int index, ref int[] numbers) {
    int[] array = new int[numbers.Length + 1];
    for(int i = 0; i < index; i++)
    {
        array[i] = numbers[i];
    }
    array[index] = number;
    for (int i = index + 1; i <= numbers.Length; i++)
    {
        array[i] = numbers[i - 1];
    }
    
    numbers = array;
  }

  public static void Main (string[] args) {
    Console.Write("[?]Số lượng phần tử: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[n];

    for (int i = 0; i < arr.Length; i++) {
      Console.Write("Arr[{0}]: ", i);
      arr[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.Write("[?]Số cần chèn: ");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.Write("[?]Tại vị trí: ");
    int index = Convert.ToInt32(Console.ReadLine());

    insert(x, index, ref arr);

    Console.WriteLine("Chuoi sau khi chen them so: ");
    foreach (int number in arr)
    {
        Console.Write(number + "  ");
    }

    Console.ReadKey();
  }
}
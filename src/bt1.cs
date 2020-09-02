using System;

class BT1 {
  public static void Main (string[] args) {
    const int vndToDolar = 20_000;
    Console.Write("Nhập $: ");
    int dolar = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("$ {0}", dolar * vndToDolar);
    
    Console.ReadKey();
  }
}
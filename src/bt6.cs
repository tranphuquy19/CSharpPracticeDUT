using System;

class MainClass {
  public static void Main(string[] args) {
    int h;
    int q = 0;
    char hint = '*';

    Console.Write("Nhập chiều cao: ");
    h = Convert.ToInt32(Console.ReadLine());

    while (h > 0) {
      for (int i = 1; i < h; i++) {
        Console.Write(" ");
      }
      for (int j = 0; j <= q; j++) {
        Console.Write(hint);
      }
      for (int j = 0; j < q; j++) {
        Console.Write(hint);
      }
      h--;
      q++;
      Console.Write("\n");
    }
    Console.ReadKey();
  }
}
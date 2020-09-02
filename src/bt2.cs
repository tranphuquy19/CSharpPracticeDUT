using System;

class BT2 {
  public static void Main (string[] args) {
    Console.Write("Nhập toán: ");
    float toan = Convert.ToInt32(Console.ReadLine());

    Console.Write("Nhập lý: ");
    float ly = Convert.ToInt32(Console.ReadLine());

    Console.Write("Nhập hóa: ");
    float hoa = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Điểm trung bình: {0}", (toan + ly + hoa) / 3);

    Console.ReadKey();
  }
}
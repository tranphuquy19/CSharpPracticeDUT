using System;

class MainClass {
  // Bài 4 (2nd)
  public static char classify(float point) {
    if(point > 10.0 || point < 0)
      throw new Exception("Điểm không hợp lệ");
    else {
      return point >= 8.0 ? 'A' : (point >= 6.5 ? 'B' : (point >= 5.5 ? 'C' : (point >= 4.0 ? 'D' : 'F'))) ;
    }
  }

  public static void Main (string[] args) {
    Console.Write("Nhập điểm: ");

    float point = Convert.ToSingle(Console.ReadLine());

    char result = classify(point);

    Console.WriteLine("Xếp loại: {0}", result);

    Console.ReadKey();
  }
}
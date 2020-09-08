using System;

class MainClass {
  public static void Main (string[] args) {
    double c;
    for (int a = 1; a <= 30; a++) {
      for (int b = 0; b < a; b++) {
        c = Math.Sqrt(a * a - b * b);
        if ((c - (int)c == 0) && (c <= b)) Console.WriteLine("({0})^2 = ({1})^2 + ({2})^2", a, b, c);
      }
    }

    Console.ReadKey();
  }
}
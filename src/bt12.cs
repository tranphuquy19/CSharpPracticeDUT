using System;

class MainClass {
  public static double giaiThua(string n) {
    int _n;
    
    if(int.TryParse(n, out _n) && _n >= 0) {
     double result = 1;

     if(_n == 1 || _n == 0) return 1;
     else {
       for(int i = 2; i <= _n; i++) {
         result *= i;
       }
     }

      return result;
    } else throw new Exception("Bạn đã nhập không thỏa đề!");
  }

  public static void Main(string[] args) {
    Console.Write("Nhập n: ");

    string n = Console.ReadLine();

    double result = giaiThua(n);

    Console.WriteLine("{0}! = {1}", n, result);

    Console.ReadKey();
  }
}
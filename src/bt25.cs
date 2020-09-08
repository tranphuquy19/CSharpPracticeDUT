using System;

class MainClass {
  public static int calc(string item1, string item2, string item3) {
    int _item1 = Convert.ToInt32(item1);
    int _item2 = Convert.ToInt32(item2);
    char ope = item3[0];

    switch(ope) {
      case '+':
        return _item1 + _item2;
      case '-':
        return _item1 - _item2;
      case '*':
        return _item1 * _item2;
      case '/':
        if(_item2 == 0) throw new Exception("Exception: chia cho 0!");
        return _item1 / _item2;
    }
    return 0;
  }

  public static void Main (string[] args) {
    string[] expressOpera = {"", "", ""};
    char[] operators = {'+', '-', '*', '/'};
    int index = 0;

    Console.Write("Nhập biểu thức: ");

    string input = Console.ReadLine().Trim();

    foreach(char c in input) {
      if(c == ' ') continue;
      else if (c >= '0' && c <= '9' && (index == 0 || index == 2)) {
        expressOpera[index] = expressOpera[index] + c;
      }
      else if (Array.IndexOf(operators, c) > -1 && index == 0) {
        expressOpera[1] = c + "";
        index = 2;
      }
      else {
        throw new Exception("Biểu thức không hợp lệ!");
      }
    }
    
    Console.WriteLine("{0} {1} {2} = {3}", expressOpera[0], expressOpera[1], expressOpera[2], calc(expressOpera[0], expressOpera[2], expressOpera[1]));

    Console.ReadKey();
  }
}
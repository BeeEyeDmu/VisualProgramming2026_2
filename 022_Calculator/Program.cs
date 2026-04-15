namespace _022_Calculator
{
  class Calculator
  {
    public static double Add(double a, double b) { return a + b; }
    public static double Subtract(double a, double b) { return a - b; }
    public static double Multiply(double a, double b) { return a * b; }
    public static double Divide(double a, double b)
    {
      if (b == 0)
      {
        Console.WriteLine("0으로 나눌 수 없습니다.");
        return 0;
      }
      else
        return a / b;
    }
  }
  internal class Program
  {
    static void Main(string[] args)
    {
      double a = 10;
      double b = 5;

      // Calculator 클래스는 static 메소드를 가지고 있으므로
      // 객체를 만들지 않고, 클래스 이름으로 메소드를 호출한다
      double sum = Calculator.Add(a, b);
      double diff = Calculator.Subtract(a, b);
      double prod = Calculator.Multiply(a, b);
      double quot = Calculator.Divide(a, b);

      Console.WriteLine("덧셈 : " + sum);
      Console.WriteLine("뺄셈 : " + diff);
      Console.WriteLine("곱셈 : " + prod);
      Console.WriteLine("나눗셈 : " + quot);
    }
  }
}

namespace _004_format
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int i;
      double x;

      i = 5;
      x = 3.141592;

      Console.WriteLine("i = " + i + ", x = " + x);
      Console.WriteLine("i = {0}, x = {1}", i, x);

      Console.WriteLine("10 이하의 소수 : {0}, {1}, {2}, {3}", 
        2, 3, 5, 7);

      string p;

      p = string.Format("10 이하의 소수 : {0}, {1}, {2}, {3}",
        2, 3, 5, 7);

      Console.WriteLine(p);

      int v1 = 100;
      double v2 = 1.234;

      // Console.WriteLine(v1, v2);
      Console.WriteLine(v1 + ", " + v2);
      Console.WriteLine("v1 = {0}, v2 = {1}", v1, v2);
      Console.WriteLine($"v1 = {v1}, v2 = {v2}");

      // 11장
      Console.WriteLine("{0:N2}", 1234.5678); // 1,234.57
      Console.WriteLine("{0:D8}", 1234);      // 00001234
      Console.WriteLine("{0,8}", 1234);       //     1234
      Console.WriteLine("{0,-8}", 1234);      // 1234____
      Console.WriteLine("{0:F3}", 1234.56);   // 1234.560

      string s;
      // String.Format을 사용
      s = string.Format("{0:N2}", 1234.5678);
      Console.WriteLine(s);

      // ToString() : 문자열로 바꿀 때 사용(포맷을 쓸 수 있다)
      s = 1234.5678.ToString("N2");
      Console.WriteLine(s);

      Console.WriteLine("{0:#.##}", 1234.5678);   // 1234.57
      Console.WriteLine("{0:#,#.##}", 1234.5678); // 1,234.57
    }
  }
}

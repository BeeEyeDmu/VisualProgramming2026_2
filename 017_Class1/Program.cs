namespace _017_Class1
{
  class Date
  {
    private int year, month, day; // field(필드)

    // 생성자 메소드 : 리턴값이 없고 클래스와 이름이 같다
    public Date(int y, int m, int d)
    {
      year = y;
      month = m;
      day = d;
    }

    // 생성자 오버로딩
    public Date()
    {
      year = 1;
      month = 1;
      day = 1;
    }

    // setter
    public void SetYear(int year)
    {
      if (year < 0)
      {
        Console.WriteLine("year must be larger than 0");
        return;
      }
      this.year = year;
    }

    // getter
    public int GetYear() { return year; }

    // 출력 메소드 
    public void PrintDate()
    {
      Console.WriteLine("{0}년 {1}월 {2}일", year, month, day);
      Console.WriteLine($"{year}년 {month}월 {day}일");

      string s = string.Format("{0}년 {1}월 {2}일", year, month, day);
      string t = string.Format($"{year}년 {month}월 {day}일");
      
      Console.WriteLine(s);
      Console.WriteLine(t);
    }
  }


  internal class Program
  {
    static void Main(string[] args)
    {
      // Date 클래스의 객체 a를 만들자
      Date a = new Date();

      // a.year = 2026;
      a.SetYear(2026);  // 안전한 프로그램을 위해서
      Console.WriteLine("a의 년도는 {0}입니다.", 
        a.GetYear());

      // 생성자 함수(메소드) = 생성자 메소드 활용
      Date myBirthday = new Date(2006, 11, 22);

      Console.WriteLine("myBirthday");
      myBirthday.PrintDate();

      // Date myBirthday = new Date();
      //myBirthday.SetYear(2006);
      //myBirthday.SetMonth(11);
      //myBirthday.SetDay(22);

    }
  }
}

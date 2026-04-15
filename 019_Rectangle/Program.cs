namespace _019_Rectangle
{
  class Rectangle
  {
    private int width, height;  // 필드

    public Rectangle(int width, int height)  // 생성자 메소드
    {
      this.width = width;
      this.height = height;
    }

    public int GetArea() // 메소드
    {
      return width * height;
    }

    public int GetPerimeter() // 메소드
    {
      return 2*(width + height);
    }
  }
  internal class Program
  {
    static void Main(string[] args)
    {
      Rectangle rect = new Rectangle(5, 3);

      int area = rect.GetArea();
      Console.WriteLine("넓이 = " + area);
      int peri = rect.GetPerimeter();
      Console.WriteLine("둘레 = " + peri);
    }
  }
}

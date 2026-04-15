namespace _018_property
{
  class Rect
  {
    // 필드로 선언 -> getter/setter가 필요
    private double width;
    private double height;
  }

  class Rectangle
  {
    // 속성(property)으로 
    public double Width { get; set; }
    public double Height { get; set; }
  }

  class Rectangle2
  {
    private double width;

    public double Width
    {
      get { return width; }
      set { if (value > 0) width = value; }
    }
  }

  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello, World!");
    }
  }
}

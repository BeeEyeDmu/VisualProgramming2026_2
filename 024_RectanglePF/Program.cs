namespace _024_RectanglePF
{
  class Rectangle
  {
    private int width;

    public int Width
    {
      get { return width; }
      set { 
        if (value >= 0) 
          width = value;
        else
          throw new ArgumentException("Width는 음수일 수 없습니다");
      }
    }

    private int height;

    public int Height
    {
      get { return height; }
      set {
        if (value >= 0)
          height = value;
        else
          throw new ArgumentException("Height는 음수일 수 없습니다.");
      }
    }

    public int GetArea()
    {
      return width * height;
    }
  }
  internal class Program
  {
    static void Main(string[] args)
    {
      Rectangle r = new Rectangle();
      r.Width = 10;
      r.Height = 10;
      Console.WriteLine("면적 = " + r.GetArea());
    }
  }
}

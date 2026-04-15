namespace _023_RectangleP
{
  class Rectangle
  {
    public int Width { get; set; }  // 속성(Property)
    public int Height { get; set; } // 속성

    public int GetArea()
    {
      return Width * Height;
    }
  }
  internal class Program
  {
    static void Main(string[] args)
    {
      Rectangle r = new Rectangle();
      r.Width = 10;
      r.Height = 5;
      Console.WriteLine("면적 : " + r.GetArea()); 
    }
  }
}

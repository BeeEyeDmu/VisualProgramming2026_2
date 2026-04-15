namespace _021_Circle
{
  class Circle
  {
    private string? color;
    private double radius;

    public Circle(string? color, double radius)
    {
      this.color = color;
      this.radius = radius;
    }

    public double GetArea()
    {
      return 3.14 * radius * radius;
    }

    public void PrCircle()
    {
      Console.WriteLine("색깔 : " + color);
      Console.WriteLine("반지름 : " + radius);
    }
  }
  internal class Program
  {
    static void Main(string[] args)
    {
      Circle c = new Circle("빨간색", 10);

      Console.WriteLine("면적 = {0}", c.GetArea());
      c.PrCircle();
    }
  }
}

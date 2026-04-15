namespace _020_Student
{
  class Student
  {
    private string? name;   // nullable
    private int age;
    private string? major;

    public Student(string? name, int age, string? major)
    {
      this.name = name;
      this.age = age;
      this.major = major;
    }

    public void DisplayInfo()
    {
      Console.WriteLine("이름 : {0}\n나이 : {1}\n전공 : {2}",
        this.name, this.age, this.major);
      Console.WriteLine($"이름 : {this.name}\n" +
        $"나이 : {this.age}\n" +
        $"전공 : {this.major}");
    }
  }
  internal class Program
  {
    static void Main(string[] args)
    {
      Student s = new Student("강병익", 21, "의료IT공학");
      s.DisplayInfo();
    }
  }
}

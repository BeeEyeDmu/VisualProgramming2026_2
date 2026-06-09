namespace _027_Mid
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //ComboBox[] crds = new ComboBox[] { crd1, crd2, ..., crd7 };
      //ComboBox[] crds = { crd1, crd2, ..., crd7 };

      int[] a = new int[10];
      int[] b = { 1, 2, 3, 4 };
      int[] c = new int[] { 1, 2, 3, 4 };
      Random r = new Random();

      for (int i = 0; i < 10; i++)
        a[i] = r.Next(100);

      int min = a[0];
      int max = a[0];
      int sum = 0;

      foreach(var i in a)
      {
        if (i < min)
          min = i;
        else if(i > max)
          max = i;
        sum += i;
      }

    }
  }
}

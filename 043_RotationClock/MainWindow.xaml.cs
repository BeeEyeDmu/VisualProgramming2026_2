using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading; // DispathcherTimer를 쓸 수 있다

namespace _043_RotationClock
{
  /// <summary>
  /// MainWindow.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()  // 생성자 메소드
    {
      InitializeComponent();

      DrawFace(); // 시계판 그리기
      MakeClockHands(); // 시계바늘 만들기

      // Timer 세팅
      DispatcherTimer dt = new DispatcherTimer();
      dt.Interval = new TimeSpan(0, 0, 1);  // 1초 
      dt.Tick += Dt_Tick;
      dt.Start();
    }

    private void MakeClockHands()
    {
      int w = 300;

      secHand.X1 = w / 2;
      secHand.Y1 = w / 2;
      secHand.X2 = w / 2;
      secHand.Y2 = 20;

      minHand.X1 = w / 2;
      minHand.Y1 = w / 2;
      minHand.X2 = w / 2;
      minHand.Y2 = 40;

      hourHand.X1 = w / 2;
      hourHand.Y1 = w / 2;
      hourHand.X2 = w / 2;
      hourHand.Y2 = 60;
    }

    private void DrawFace()
    {
      // 눈금 60개
      Line[] marking = new Line[60];
      int w = 300;  // 시계의 지름

      for(int i=0; i<60; i++)
      {
        marking[i] = new Line();
        marking[i].Stroke = Brushes.LightSteelBlue;
        marking[i].X1 = w / 2;
        marking[i].Y1 = 2;
        marking[i].X2 = w / 2;
        if (i % 5 == 0)
        {
          marking[i].StrokeThickness = 5;
          marking[i].Y2 = 20;
        }
        else
        {
          marking[i].StrokeThickness = 2;
          marking[i].Y2 = 10;
        }

        RotateTransform rt = new RotateTransform(6*i);
        rt.CenterX = w / 2;
        rt.CenterY = w / 2;

        marking[i].RenderTransform = rt;
        aClock.Children.Add(marking[i]);

      }
    }

    private void Dt_Tick(object sender, EventArgs e)
    {
      DateTime ct = DateTime.Now;

      int hour = ct.Hour;
      int min = ct.Minute;
      int sec = ct.Second;

      double hourDeg = hour % 12 * 30 + min * 0.5;
      double minDeg = min * 6 + sec * 0.1;
      double secDeg = sec * 6;


      // 시침
      aClock.Children.Remove(hourHand);
      RotateTransform hrt = new RotateTransform(hourDeg);
      hrt.CenterX = hourHand.X1;
      hrt.CenterY = hourHand.Y1;
      hourHand.RenderTransform = hrt;
      aClock.Children.Add(hourHand);

      // 분침
      aClock.Children.Remove(minHand);
      RotateTransform mrt = new RotateTransform(minDeg);
      mrt.CenterX = minHand.X1;
      mrt.CenterY = minHand.Y1;
      minHand.RenderTransform = mrt;
      aClock.Children.Add(minHand);

      // 초침
      aClock.Children.Remove(secHand);
      RotateTransform srt = new RotateTransform(secDeg);
      srt.CenterX = secHand.X1;
      srt.CenterY = secHand.Y1;
      secHand.RenderTransform = srt;
      aClock.Children.Add(secHand);

      aClock.Children.Remove(center);
      aClock.Children.Add(center);
    }
  }
}

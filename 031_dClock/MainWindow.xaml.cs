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
using System.Windows.Threading;

namespace _031_dClock
{
  /// <summary>
  /// MainWindow.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class MainWindow : Window
  {
    DispatcherTimer timer;  // 타이머 객체의 선언
    public MainWindow()
    {
      InitializeComponent();

      timer = new DispatcherTimer();
      timer.Interval = new TimeSpan(0, 0, 1); // 시 분 초
      timer.Tick += Timer_Tick;
      timer.Start();
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
      txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
      txtTime.Text = DateTime.Now.ToString("tt h:mm:ss");
    }
  }
}

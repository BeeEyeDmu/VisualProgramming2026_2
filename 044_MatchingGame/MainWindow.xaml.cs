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

namespace _044_MatchingGame
{
  /// <summary>
  /// MainWindow.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class MainWindow : Window
  {
    private int[] rnd = new int[16];
    private Button first = null;
    private Button second = null;
    private int matched = 0;  // 맞춘 그림 개수
    private DispatcherTimer timer = new DispatcherTimer();

    public MainWindow() // 생성자 메소드
    {
      InitializeComponent();

      BoardSet();
      timer.Interval = new TimeSpan(0, 0, 0, 0, 750);
      timer.Tick += Timer_Tick;
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
      timer.Stop();
      first.Content = MakeImage("../../Images/check.png");
      second.Content = MakeImage("../../Images/check.png");
      first = null;
      second = null;
    }

    // 16개의 버튼을 만들어서 board에 넣는다
    private void BoardSet()
    {
      for(int i=0; i<16; i++)
      {
        Button b = new Button();
        b.Background = Brushes.White;
        b.Margin = new Thickness(10);
        b.Content = MakeImage("../../Images/check.png");
        b.Tag = TagSet();
        //b.Content = b.Tag;  // 테스트용
        // 클릭 이벤트 등록
        b.Click += B_Click;
        board.Children.Add(b);
      }
    }

    private void B_Click(object sender, RoutedEventArgs e)
    {
      Button btn = sender as Button;  // (Button)sender

      string[] icon = {"딸기", "레몬", "모과", "배",
        "사과", "수박", "파인애플", "포도" };

      btn.Content 
        = MakeImage("../../Images/" + icon[(int)btn.Tag] + ".png");

      if(first == null) // 이 카드가 첫번째 카드라면
      {
        first = btn;
        return;
      }

      second = btn;

      // 두 버튼이 같은지 체크(Tag로 체크)
      if ((int)first.Tag == (int)second.Tag) // 매치가 됨
      {
        first = null;
        second = null;
        matched += 2; // 16개가 되면 끝
        if(matched == 16)
        {
          MessageBox.Show("성공했습니다!", "Success!");
          this.Close();
        }
      }
      else  // 매치가 안됨
      {
        timer.Start();
      }

    }

    private Image MakeImage(string v)
    {
      BitmapImage bi = new BitmapImage();
      bi.BeginInit();
      bi.UriSource = new Uri(v, UriKind.Relative);
      bi.EndInit();

      Image img = new Image();
      img.Source = bi;
      img.Margin = new Thickness(10);
      img.Stretch = Stretch.Fill;

      return img;
    }

   
    private int TagSet()
    {
      int i;
      Random r = new Random();

      while(true)
      {
        i = r.Next(16); // 0 ~15
        if (rnd[i] == 0) // 숫자가 처음 나왔으면
        {
          rnd[i] = 1; // 이미 나왔다고 표시
          break;
        }
      }
      return i % 8;
    }
  }
}

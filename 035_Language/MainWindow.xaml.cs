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

namespace _035_Language
{
  /// <summary>
  /// MainWindow.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class MainWindow : Window
  {
    CheckBox[] cbs;
    public MainWindow()
    {
      InitializeComponent();

      cbs = new CheckBox[] { cbC, cbCPP, cbCS, cbPython, cbJava };
    }

    private void btnSubmit_Click(object sender, RoutedEventArgs e)
    {
      string str = String.Empty;  // 빈 문자열("")

      foreach (var cb in cbs)
      {
        if (cb.IsChecked == true)
          str += cb.Content + ", ";   // WinForm에서는 Text 속성
      }
      MessageBox.Show(str + "선택함!", "좋아하는 언어!");
    }

    private void btnQuit_Click(object sender, RoutedEventArgs e)
    {
      this.Close();
    }
  }
}

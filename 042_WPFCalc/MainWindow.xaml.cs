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

namespace _042_WPFCalc
{
  /// <summary>
  /// MainWindow.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class MainWindow : Window
  {
    private double saved = 0;
    private string op;
    private bool opFlag = false;

    public MainWindow()
    {
      InitializeComponent();
    }

    //  숫자 버튼
    private void btn1_Click(object sender, RoutedEventArgs e)
    {      
      Button btn = sender as Button;  //Button btn = (Button)sender;

      if (txtResult.Text == "0" || opFlag == true)
      {
        txtResult.Text = (string)btn.Content;
        opFlag = false;
      }
      else
        txtResult.Text += btn.Content as String; ;
    }

    // 소수점 버튼
    private void btnDot_Click(object sender, RoutedEventArgs e)
    {
      if(txtResult.Text.Contains(".") == false)  // !
        txtResult.Text += ".";
    }

    private void btnPlsMinus_Click(object sender, RoutedEventArgs e)
    {
      txtResult.Text = (-double.Parse(txtResult.Text)).ToString();
    }

    // 이항연산자 버튼
    private void btnPlus_Click(object sender, RoutedEventArgs e)
    {
      // (1) 결과창의 숫자를 saved에 저장
      // (2) 연산자를 op에 저장
      // (3) opFlag를 true 만든다 -> 숫자가 처음부터 새로 써진다
      
      saved = double.Parse(txtResult.Text);
      Button btn = sender as Button;
      op = (string)btn.Content;
      opFlag = true ;

      txtExp.Text = txtResult.Text + op;

    }

    // = 버튼
    private void btnEqual_Click(object sender, RoutedEventArgs e)
    {
      txtExp.Text += txtResult.Text + "=";

      switch (op)
      {
        case "+":          
          txtResult.Text = (saved + double.Parse(txtResult.Text)).ToString();          
          break;
        case "-":
          txtResult.Text = (saved - double.Parse(txtResult.Text)).ToString();
          break;
        case "×":
          txtResult.Text = (saved * double.Parse(txtResult.Text)).ToString();
          break;
        case "÷":
          txtResult.Text = (saved / double.Parse(txtResult.Text)).ToString();
          break;
        default:
          break;
      }     
    }

    // 1/x(역수) 버튼
    private void btnRecip_Click(object sender, RoutedEventArgs e)
    {
      if (txtExp.Text == "")
        txtExp.Text = "1/(" + txtResult.Text + ")";
      else
        txtExp.Text = "1/(" + txtExp.Text + ")";

      txtResult.Text = (1 / double.Parse(txtResult.Text)).ToString();
      //double x = double.Parse(txtResult.Text);
      //double y = 1 / x;
      //txtResult.Text = y.ToString();
    }

    // 제곱 버튼
    private void btnSqr_Click(object sender, RoutedEventArgs e)
    {
      if (txtExp.Text == "")
        txtExp.Text = "sqr(" + txtResult.Text + ")";
      else
        txtExp.Text = "sqr(" + txtExp.Text + ")";

      double x = double.Parse(txtResult.Text);
      txtResult.Text = (x*x).ToString();
    }

    private void btnSqrt_Click(object sender, RoutedEventArgs e)
    {
      if (txtExp.Text == "")
        txtExp.Text = "√(" + txtResult.Text + ")";
      else
        txtExp.Text = "√(" + txtExp.Text + ")";

      double x = double.Parse(txtResult.Text);
      txtResult.Text = Math.Sqrt(x).ToString();
    }
  }
}

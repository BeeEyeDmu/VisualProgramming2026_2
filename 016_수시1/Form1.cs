using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _016_수시1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      double sum = double.Parse(txt3.Text) + double.Parse(txt4.Text) + double.Parse(txt5.Text);
      double avg = sum / 3;
      
      txtR.Text = string.Format("학번 : {0}\r\n이름 : {1}\r\n총점 : {2}\r\n평균 : {3}\r\n",
        txt1.Text, txt2.Text, sum, avg.ToString("0.00"));

      if (avg >= 90) txtR.Text += "학점 : A";
      else if (avg >= 80) txtR.Text += "학점 : B";
      else if (avg >= 70) txtR.Text += "학점 : C";
      else if (avg >= 60) txtR.Text += "학점 : D";
      else txtR.Text += "학점 : F";
    }

    private void button2_Click(object sender, EventArgs e)
    {
      txt1.Text = "";
      txt2.Text = "";
      txt3.Text = "";
      txt4.Text = "";
      txt5.Text = "";
      txtR.Text = "";
    }
  }
}

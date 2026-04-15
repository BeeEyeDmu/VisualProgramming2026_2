using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _014_TwoChart
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      chart1.Titles.Add("성적");

      chart1.Series.Add("Series2");

      chart1.Series[0].LegendText = "영어";
      chart1.Series[1].LegendText = "수학";

      Random r = new Random();

      for(int i=1; i<=10; i++)
      {
        chart1.Series[0].Points.AddXY(i, r.Next(101));
        chart1.Series[1].Points.AddXY(i, r.Next(101));
      }
      btnOnChartArea.Enabled = false;
    }

    private void btnTwoChartArea_Click(object sender, EventArgs e)
    {
      chart1.ChartAreas.Add("ChartArea2");
      chart1.Series[1].ChartArea = "ChartArea2";

      btnTwoChartArea.Enabled = false;
      btnOnChartArea.Enabled = true;
    }

    private void btnOnChartArea_Click(object sender, EventArgs e)
    {
      chart1.ChartAreas.RemoveAt(1);
      chart1.Series[1].ChartArea = "ChartArea1";

      btnTwoChartArea.Enabled = true;
      btnOnChartArea.Enabled = false;
    }
  }
}

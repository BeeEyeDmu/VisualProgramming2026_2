using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002_bmiForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // button1이 클릭될때 실행되는 이벤트 처리 함수
        private void button1_Click(object sender, EventArgs e)
        {
            double h = double.Parse(txtH.Text);
            double w = double.Parse(txtW.Text);

            h /= 100;

            double bmi = w / (h * h);
            label3.Text = "BMI = " + bmi.ToString();
        }
    }
}

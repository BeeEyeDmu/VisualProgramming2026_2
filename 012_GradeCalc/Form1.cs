using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _012_GradeCalc
{
  public partial class Form1 : Form
  {
    TextBox[] titles; // 과목명 배열을 선언
    ComboBox[] crds;  // 학점수 배열
    ComboBox[] grds;  // 성적 배열
    public Form1()
    {
      InitializeComponent();
    }

    // 프로그램이 시작할 때 실행되는 이벤트 함수
    private void Form1_Load(object sender, EventArgs e)
    {
      txt1.Text = "비주얼프로그래밍";
      txt2.Text = "설계및프로젝트심화1";
      txt3.Text = "전기전자공학및실험";
      txt4.Text = "인체의구조와기능";
      txt5.Text = "기업가정신과리더십";
      txt6.Text = "디지털기술입문";

      titles = new TextBox[] { txt1, txt2, txt3, txt4, txt5, txt6, txt7 };
      crds = new ComboBox[] { crd1, crd2, crd3, crd4, crd5, crd6, crd7};
      grds = new ComboBox[] { grd1, grd2, grd3, grd4, grd5, grd6, grd7 };

      // 학점수의 배열
      int[] arrCredit = { 1, 2, 3, 4, 5 };

      // 학점의 리스트
      List<string> lstGrade 
        = new List<string> { "A+", "A0", "B+", "B0", "C+", "C0", "D+", "D0", "F", };

      // crds 콤보박스 각각에 학점수 1,2,3,4,5를 추가하고
      // 디폴트로 3학점을 선택하게 함
      //foreach (var combo in crds)
      //{
      //  foreach (var i in arrCredit)
      //    combo.Items.Add(i);
      //  combo.SelectedItem = 3;
      //}

      // 조금 쉬운 버전
      foreach (var combo in crds)
      {
        for (int i = 1; i <= 5; i++)
          combo.Items.Add(i);
        combo.SelectedItem = 2;
      }

      // 이중반복문으로 grds 콤보박스 전체에
      // A+, A0, ... , ~F까지의 문자열을 추가
      foreach(var grd in grds)
      {
        foreach (var str in lstGrade)
          grd.Items.Add(str);
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      double totalScore = 0;
      int totalCredits = 0;

      for(int i=0; i<titles.Length; i++)
      {
        if (titles[i].Text != "")
        {
          int crd = int.Parse(crds[i].Text);
                //= int.Parse(crds[i].SelectedItem.ToString());
          totalCredits += crd;
          totalScore += crd * GetGrade(grds[i].Text);
        }
      }

      txtGrade.Text 
        = (totalScore/totalCredits).ToString("0.00");
    }

    private double GetGrade(string text)
    {
      double grade = 0;

      if (text == "A+")       grade = 4.5;
      else if (text == "A0")  grade = 4.0;
      else if (text == "B+")  grade = 3.5;
      else if (text == "B0")  grade = 3.0;
      else if (text == "C+")  grade = 2.5;
      else if (text == "C0")  grade = 2.0;
      else if (text == "D+")  grade = 1.5;
      else if (text == "D0")  grade = 1.0;
      else                    grade = 0;

      return grade;
    }
  }
}

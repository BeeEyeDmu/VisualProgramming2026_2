using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;

namespace _026_firebaseCRUD
{
  public partial class Form1 : Form
  {
    IFirebaseConfig config = new FirebaseConfig
    {
      AuthSecret = "WHaEMRMnj1Y7nBF3M1GERmEPpfuhq5MBw5sVTgEx",
      BasePath = "https://pbook2-4bce8-default-rtdb.firebaseio.com/"
    };

    IFirebaseClient client;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      client = new FireSharp.FirebaseClient(config);

      if (client != null)
      {
        //MessageBox.Show("C#에서 Firebase 데이터베이스를 대행하는 client 생성!");
      }

      try
      {
        var r = client.Set("연결 test", "OK");
        MessageBox.Show("연결 성공!");
      }
      catch (Exception ex) 
      {
        MessageBox.Show("연결 실패!" + ex.Message);
      }
       
    }

    // 추가
    private async void btnInsert_Click(object sender, EventArgs e)
    {
      if (txtID.Text == "")
        return;

      var d = new Data
      {
        Id = txtID.Text,
        SId = txtSId.Text,
        Name = txtName.Text,
        Phone = txtPhone.Text
      };

      SetResponse r = await client.SetAsync("pBook2/"+txtID.Text, d);

      Data result = r.ResultAs<Data>();
      MessageBox.Show("Insert : Id = " + result.Id);
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      txtID.Text = string.Empty;  // ""
      txtSId.Text = string.Empty;
      txtName.Text = string.Empty;
      txtPhone.Text = string.Empty;
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    // 검색은 ID로 할 것임
    private async void btnSearch_Click(object sender, EventArgs e)
    {
      if (txtID.Text == string.Empty)
        return;

      FirebaseResponse r = await client.GetAsync("pBook2/" + txtID.Text);

      Data d = r.ResultAs<Data>();

      if (d != null)
      {
        txtID.Text = d.Id;
        txtName.Text = d.Name;
        txtSId.Text = d.SId;
        txtPhone.Text = d.Phone;
        MessageBox.Show("검색 완료!");
      }
      else
      {
        MessageBox.Show("찾는 값이 없습니다!");
      }
      
    }

    private async void btnUpdate_Click(object sender, EventArgs e)
    {
      if (txtID.Text == string.Empty)
        return;

      var d = new Data
      {
        Id = txtID.Text,
        SId = txtSId.Text,
        Name = txtName.Text,
        Phone = txtPhone.Text
      };

      FirebaseResponse r 
        = await client.UpdateAsync("pBook2/" + txtID.Text, d);

      Data result = r.ResultAs<Data>();
      MessageBox.Show("데이터 수정!");
    }

    private async void btnDelete_Click(object sender, EventArgs e)
    {
      if (txtID.Text == string.Empty)
        return;

      FirebaseResponse r = await client.DeleteAsync("pBook2/"+txtID.Text);

      MessageBox.Show("삭제 완료!");
    }

    private async void btnDeleteAll_Click(object sender, EventArgs e)
    {
      DialogResult dr = MessageBox.Show("정말 모두 삭제합니까?", "확인!",
        MessageBoxButtons.YesNo);

      if(dr == DialogResult.Yes)
      {
        FirebaseResponse r = await client.DeleteAsync("pBook2");
        MessageBox.Show("모두 삭제 완료!");
      }
        
    }
  }
}

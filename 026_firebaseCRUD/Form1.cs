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
        MessageBox.Show("Firebase 연결 성공!");
      }
    }
  }
}

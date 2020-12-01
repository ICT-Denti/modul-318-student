using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeineTransoprtApp
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void Suchen_btn_Click(object sender, EventArgs e)
    {
      Verbindungen v = new Verbindungen();
      v.ShowDialog();
    }
  }
}

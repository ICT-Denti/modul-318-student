using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace MeineTransoprtApp
{
  public partial class Verbindungen : Form
  {
    public Verbindungen()
    {
      InitializeComponent();
    }
    public Connections Gesucht { get; set; }
    private void Verbindungen_Load(object sender, EventArgs e)
    {

    }

    private void station1_txt_TextChanged(object sender, EventArgs e)
    {

    }
  }
}

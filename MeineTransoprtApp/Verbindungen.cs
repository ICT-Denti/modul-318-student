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
    public StationBoardRoot Lulu { get; set; }
    private void Verbindungen_Load(object sender, EventArgs e)
    {
      station1_txt.Text = Gesucht.ConnectionList.ElementAt(0).From.Station.Name;
      gleis1_txt.Text = Gesucht.ConnectionList.ElementAt(0).From.Platform;
      zeit1_txt.Text = Gesucht.ConnectionList.ElementAt(0).From.Departure;
      ankuft1_txt.Text = Gesucht.ConnectionList.ElementAt(0).To.Station.Name;
      dauer1_txt.Text = Gesucht.ConnectionList.ElementAt(0).Duration;

      //station1_txt.Text = Gesucht.ConnectionList.ElementAt(1).From.Station.Name;
      //gleis1_txt.Text = Gesucht.ConnectionList.ElementAt(1).From.Platform;
      //abfahrtzeit1_txt.Text = Gesucht.ConnectionList.ElementAt(1).From.Departure;
      //ankuft1_txt.Text = Gesucht.ConnectionList.ElementAt(1).To.Station.Name;
      //dauer1_txt.Text = Gesucht.ConnectionList.ElementAt(1).Duration;

      tafel1_txt.Text = Lulu.Station.Name;
      tafel2_txt.Text = Lulu.Entries.ElementAt(0).Operator;

    }

    private void station1_txt_TextChanged(object sender, EventArgs e)
    {
        
    }

  }
}

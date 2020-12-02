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
    public StationBoardRoot Tafel { get; set; }
    private void Verbindungen_Load(object sender, EventArgs e)
    {
      // Start- & Endstation max 4
      // Zeile 1
      station1_txt.Text = Gesucht.ConnectionList.ElementAt(0).From.Station.Name;
      gleis1_txt.Text = Gesucht.ConnectionList.ElementAt(0).From.Platform;
      zeit1_txt.Text = Gesucht.ConnectionList.ElementAt(0).From.Departure;
      ankuft1_txt.Text = Gesucht.ConnectionList.ElementAt(0).To.Station.Name;
      dauer1_txt.Text = Gesucht.ConnectionList.ElementAt(0).Duration;

      // Zeile 2
      station2_txt.Text = Gesucht.ConnectionList.ElementAt(1).From.Station.Name;
      gleis2_txt.Text = Gesucht.ConnectionList.ElementAt(1).From.Platform;
      zeit2_txt.Text = Gesucht.ConnectionList.ElementAt(1).From.Departure;
      ankuft2_txt.Text = Gesucht.ConnectionList.ElementAt(1).To.Station.Name;
      dauer2_txt.Text = Gesucht.ConnectionList.ElementAt(1).Duration;

      // Zeile 3
      station3_txt.Text = Gesucht.ConnectionList.ElementAt(2).From.Station.Name;
      gleis3_txt.Text = Gesucht.ConnectionList.ElementAt(2).From.Platform;
      zeit3_txt.Text = Gesucht.ConnectionList.ElementAt(2).From.Departure;
      ankuft3_txt.Text = Gesucht.ConnectionList.ElementAt(2).To.Station.Name;
      dauer3_txt.Text = Gesucht.ConnectionList.ElementAt(2).Duration;

      // Zeile 4
      station4_txt.Text = Gesucht.ConnectionList.ElementAt(3).From.Station.Name;
      gleis4_txt.Text = Gesucht.ConnectionList.ElementAt(3).From.Platform;
      zeit4_txt.Text = Gesucht.ConnectionList.ElementAt(3).From.Departure;
      ankuft4_txt.Text = Gesucht.ConnectionList.ElementAt(3).To.Station.Name;
      dauer4_txt.Text = Gesucht.ConnectionList.ElementAt(3).Duration;

      // Abfahrtstafel
      // Spalte 1
      tafel1_txt.Text = Tafel.Station.Name;
      tafel2_txt.Text = Tafel.Station.Name;
      tafel3_txt.Text = Tafel.Station.Name;
      tafel4_txt.Text = Tafel.Station.Name;
      tafel5_txt.Text = Tafel.Station.Name;
      tafel6_txt.Text = Tafel.Station.Name;
      tafel7_txt.Text = Tafel.Station.Name;
      tafel8_txt.Text = Tafel.Station.Name;

      // Spalte 2
      tafelzeit1_txt.Text = Tafel.Entries.ElementAt(0).Operator;

    }

    private void station1_txt_TextChanged(object sender, EventArgs e)
    {
        
    }
  }
}

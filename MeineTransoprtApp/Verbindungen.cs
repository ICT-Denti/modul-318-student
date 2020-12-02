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
    public string Stationen;
    public Connections Gesucht { get; set; }
    public StationBoardRoot Tafel { get; set; }
    private void Verbindungen_Load(object sender, EventArgs e)
    {
      // Start- & Endstation max 4
      Start_txt.Text = Gesucht.ConnectionList.ElementAt(0).From.Station.Name;
      End_txt.Text = Gesucht.ConnectionList.ElementAt(0).To.Station.Name;
      // Abfahrtstation
      station1_txt.Text = Gesucht.ConnectionList.ElementAt(0).From.Station.Name;
      station2_txt.Text = Gesucht.ConnectionList.ElementAt(1).From.Station.Name;
      station3_txt.Text = Gesucht.ConnectionList.ElementAt(2).From.Station.Name;
      station4_txt.Text = Gesucht.ConnectionList.ElementAt(3).From.Station.Name;
      // Gleise
      gleis1_txt.Text = Gesucht.ConnectionList.ElementAt(0).From.Platform;
      gleis2_txt.Text = Gesucht.ConnectionList.ElementAt(1).From.Platform;
      gleis3_txt.Text = Gesucht.ConnectionList.ElementAt(2).From.Platform;
      gleis4_txt.Text = Gesucht.ConnectionList.ElementAt(3).From.Platform;
      // Abfahrtszeit
      zeitab1_txt.Text = Gesucht.ConnectionList.ElementAt(0).From.Departure;
      zeitab2_txt.Text = Gesucht.ConnectionList.ElementAt(1).From.Departure;
      zeitab3_txt.Text = Gesucht.ConnectionList.ElementAt(2).From.Departure;
      zeitab4_txt.Text = Gesucht.ConnectionList.ElementAt(3).From.Departure;
      // Ankuftsstation
      ankuft1_txt.Text = Gesucht.ConnectionList.ElementAt(0).To.Station.Name;
      ankuft2_txt.Text = Gesucht.ConnectionList.ElementAt(1).To.Station.Name;
      ankuft3_txt.Text = Gesucht.ConnectionList.ElementAt(2).To.Station.Name;
      ankuft4_txt.Text = Gesucht.ConnectionList.ElementAt(3).To.Station.Name;
      // Dauer der Fahrt
      dauer1_txt.Text = Gesucht.ConnectionList.ElementAt(0).Duration;
      dauer2_txt.Text = Gesucht.ConnectionList.ElementAt(1).Duration;
      dauer3_txt.Text = Gesucht.ConnectionList.ElementAt(2).Duration;
      dauer4_txt.Text = Gesucht.ConnectionList.ElementAt(3).Duration;
      // Ankuftszeit
      zeitan1_txt.Text = Gesucht.ConnectionList.ElementAt(0).To.Arrival;
      zeitan2_txt.Text = Gesucht.ConnectionList.ElementAt(1).To.Arrival;
      zeitan3_txt.Text = Gesucht.ConnectionList.ElementAt(2).To.Arrival;
      zeitan4_txt.Text = Gesucht.ConnectionList.ElementAt(3).To.Arrival;

      // Abfahrtstafel
      tafel1_txt.Text = Tafel.Station.Name;
      tafel2_txt.Text = Tafel.Station.Name;
      tafel3_txt.Text = Tafel.Station.Name;
      tafel4_txt.Text = Tafel.Station.Name;
      tafel5_txt.Text = Tafel.Station.Name;
      tafel6_txt.Text = Tafel.Station.Name;
      tafel7_txt.Text = Tafel.Station.Name;
      tafel8_txt.Text = Tafel.Station.Name;

      // Ankuftstafel
      tafelzeit1_txt.Text = Tafel.Entries.ElementAt(0).Stop.Departure.ToString();
      tafelzeit2_txt.Text = Tafel.Entries.ElementAt(1).Stop.Departure.ToString();
      tafelzeit3_txt.Text = Tafel.Entries.ElementAt(2).Stop.Departure.ToString();
      tafelzeit4_txt.Text = Tafel.Entries.ElementAt(3).Stop.Departure.ToString();
      tafelzeit5_txt.Text = Tafel.Entries.ElementAt(4).Stop.Departure.ToString();
      tafelzeit6_txt.Text = Tafel.Entries.ElementAt(5).Stop.Departure.ToString();
      tafelzeit7_txt.Text = Tafel.Entries.ElementAt(6).Stop.Departure.ToString();
      tafelzeit8_txt.Text = Tafel.Entries.ElementAt(7).Stop.Departure.ToString();

    }

    private void Mail_pic_Click(object sender, EventArgs e)
    {
      Mail m = new Mail();
      // Hier wird das neue Fenster aufgerufen
      m.ShowDialog();
    }
  }
}

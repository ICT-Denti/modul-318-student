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

// Autor: Alexander Denti 
// Bearbeitung: 01.12.2020


namespace MeineTransoprtApp
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }
    // Schritt 1
    /* Eingabe von Start und Endstation ermöglicht den Button zu drücken,
       es darf aber nicht vorher möglich sein. Fehlermeldung vielleicht mit rein? */

    // Schritt 2
    /* Start und Endstation werden abgeglichen und 
       es werden auf dem nexten Fenster die Verbindungen dazu gezeigt. */
    private void Suchen_btn_Click(object sender, EventArgs e)
    {
      // Variabeln
      // Zuerst Text von txt Start in eine variable speichern

      string Start = Start_txt.Text;

      // Zweitens Text von txt End in eine variable speichern
      string End = End_txt.Text;

      // Transpoort klassse instanzieren in ITransport
      ITransport t = new Transport();

 
      // Getconation aufrufen von der ITransport Klasse und in eine variable speichern
      Connections c = t.GetConnections(Start, End);
      StationBoardRoot s = t.GetStationBoard(Start, "");
      // Nun werden den Variable dem neuen Fenster Verbindungen mitschicken
      Verbindungen v = new Verbindungen();
      v.Gesucht = c;
      v.Tafel = s;
      // Hier wird das neue Fenster aufgerufen
      v.ShowDialog();
    }
  }
}

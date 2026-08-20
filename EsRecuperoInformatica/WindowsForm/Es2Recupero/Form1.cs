using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Es2Recupero
{
    public partial class Form1 : Form
    {
        List<tabella> tb = new List<tabella>();
        List<giocatore> g = new List<giocatore>();

        public Form1()
        {
            InitializeComponent();
        }

        private void CaricaDati()
        {
            tb.Clear();
            g.Clear();
            string riga;
            string[] spl;
            StreamReader sr = new StreamReader("statistiche.txt");
            while ((riga = sr.ReadLine()) != null)
            {
                tabella t = new tabella();
                spl = riga.Split(';');
                t.cod = spl[0].Trim();
                t.mGol = float.Parse(spl[1]);
                t.mAssist = float.Parse(spl[2]);
                t.mVoti = float.Parse(spl[3]);
                tb.Add(t);
            }
            sr.Close();
            StreamReader sr2 = new StreamReader("giocatore.txt");
            while ((riga = sr2.ReadLine()) != null)
            {
                giocatore gi = new giocatore();
                spl = riga.Split(';');
                gi.cod = spl[0].Trim();
                gi.nome = spl[1].Trim();
                gi.squadra = spl[2].Trim();
                g.Add(gi);
            }
            sr2.Close();
        }

        private void btnVis1_Click(object sender, EventArgs e)
        {
            CaricaDati();
            float sommaVoti = 0, mediaVoti, sJ = 0, sM = 0, cntJ = 0, cntM = 0;
            foreach (tabella t in tb)
            {
                sommaVoti += t.mVoti;
                foreach (giocatore gi in g)
                {
                    if (t.cod == gi.cod)
                    {
                        if (cmbSquadre.SelectedItem == "Juventus")
                        {
                            sJ += t.mVoti;
                            cntJ++;
                        }
                        else if (cmbSquadre.SelectedItem == "Milan")
                        {
                            sM += t.mVoti;
                            cntM++;
                        }
                    }
                }
            }
            mediaVoti = sommaVoti / tb.Count;
            float mJ = sJ / cntJ;
            float mM = sM / cntM;
            MessageBox.Show("Media generale: " + mediaVoti + "\nMedia Juventus: " + mJ + "\nMedia Milan: " + mM);
        }

        private void btnOrdCresc_Click(object sender, EventArgs e)
        {
            CaricaDati();
            float sJ = 0, sM = 0, cntJ = 0, cntM = 0;
            foreach (tabella t in tb)
            {
                foreach (giocatore gi in g)
                {
                    if (t.cod == gi.cod)
                    {
                        if (gi.squadra == "Juventus")
                        {
                            sJ += t.mVoti;
                            cntJ++;
                        }
                        else if (gi.squadra == "Milan")
                        {
                            sM += t.mVoti;
                            cntM++;
                        }
                    }
                }
            }
            float mJ = sJ / cntJ;
            float mM = sM / cntM;
            if (mJ > mM)
            {
                MessageBox.Show("Juventus: " + mJ + "\nMilan: " + mM + "\nLa squadra con la media più alta è la Juventus.");
            }
            else
            {
                MessageBox.Show("Juventus: " + mJ + "\nMilan: " + mM + "\nLa squadra con la media più alta è il Milan.");
            }
        }

        private void btnStatistiche_Click(object sender, EventArgs e)
        {
            CaricaDati();
            string nome = cmbGiocatori.Text.Trim();
            string codice = "";
            foreach (giocatore gi in g)
            {
                if (gi.nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
                {
                    codice = gi.cod;
                    break;
                }
            }
            if (codice == "")
            {
                MessageBox.Show("Giocatore non trovato.");
                return;
            }
            float max = 0, min = 10, somma = 0, gol = 0, assist = 0;
            int cont = 0;
            foreach (tabella t in tb)
            {
                if (t.cod == codice)
                {
                    if (t.mVoti > max)
                        max = t.mVoti;
                    if (t.mVoti < min)
                        min = t.mVoti;
                    somma += t.mVoti;
                    gol += t.mGol;
                    assist += t.mAssist;
                    cont++;
                }
            }
            if (cont == 0)
            {
                MessageBox.Show("Nessun dato trovato.");
                return;
            }
            float media = somma / cont;
            MessageBox.Show( "Giocatore: " + nome + "\nMedia voti: " + media + "\nVoto massimo: " + max + "\nVoto minimo: " + min + "\nGol totali: " + gol + "\nAssist totali: " + assist);
        }
    }
}
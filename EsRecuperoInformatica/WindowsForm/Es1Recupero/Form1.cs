using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es1Recupero
{
    public partial class Form1 : Form
    {
        List<lista> listaToner = new List<lista>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("file.txt");
            foreach(lista l in listaToner)
            {
                sw.WriteLine("Nome: " + l.nome + " | Numero Toner: " + l.nToner);
            }
            sw.Close();
            MessageBox.Show("Inserimento terminato");
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            lista lst = new lista();
            lst.nome = txtNome.Text;
            lst.nToner = (int) nudToner.Value;
            listaToner.Add(lst);
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            int somma = 0, min = 100, max = 0, media, cnt = 0 ;
            lista lst = new lista();
            foreach(lista l in listaToner)
            {
                if(l.nToner > max)
                    max = l.nToner;
                if(l.nToner < min)
                    min = l.nToner;
                somma = somma + l.nToner;
                cnt++;
            }
            if(cmbStatistica.SelectedItem == "Min")
            {
                lblStampa.Text = "Il valore minimo di tutta la lista è " + min;
            } else if (cmbStatistica.SelectedItem == "Max")
            {
                lblStampa.Text = "Il valore massimo di tutta la lista è " + max;
            } else if(cmbStatistica.SelectedItem == "Med")
            {
                media = somma / cnt;
              lblStampa.Text = "Il valore medio trovato nella lista è " + media;
            }
        }
    }
}

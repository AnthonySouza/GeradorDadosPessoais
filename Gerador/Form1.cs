using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador
{
    public partial class Form1 : Form
    {

        string JSONSaida;
        Gerador gerador;

        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfdlg = new SaveFileDialog();
            sfdlg.Filter = "json (* .json) | * .json | Todos os arquivos (*. *) | *. *";
            sfdlg.Title = "Salvar Arquivo Json";

            if(sfdlg.ShowDialog() == DialogResult.OK)
            {

                JSONSaida = sfdlg.FileName;

            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            gerador = new Gerador();



            MessageBox.Show(gerador.GerarLocal().ToString()) ;

        }
    }
}

using AULAMVC01Tarde.Control;
using AULAMVC01Tarde.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AULAMVC01Tarde.View
{
    public partial class Exec02 : Form
    {
        public Exec02()
        {
            InitializeComponent();
        }

        private void Exec02_Load(object sender, EventArgs e)
        {
            AtualizaTudo();
            List<string[]> teste = DBConnection.GenericSelectAll("Vaga");
            foreach (var item in teste)
            {
                dgTeste01.Rows.Add(item);
            }
        }

        private void AtualizaCBVaga()
        {
            List<string> lista = Controller2.AtualizaCBVaga();
            cbPlacas.Items.Clear();
            foreach (var item in lista)
            {
                cbPlacas.Items.Add(item);
            }
        }

        private void AtualizaVagaLivre()
        {
            List<string> lista = Controller2.AtualizaVagaLivre();
            cbVagas.Items.Clear();
            foreach (var item in lista)
            {
                cbVagas.Items.Add(item);
            }
        }


        private void AtualizaDG()
        {
            List<string[]> elementos = Controller2.AtualizaDG();
            dgVagas.Rows.Clear();
            foreach (var item in elementos)
            {
                dgVagas.Rows.Add(item);
            }
        }
        private void AtualizaTudo()
        {
            AtualizaDG();
            AtualizaCBVaga();
            AtualizaVagaLivre();
            txtHrSaida.Clear();
            txtHrEntrada.Clear();
            txtPlaca.Clear();
            cbVagas.Text = null;
            cbPlacas.Text = null;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Controller2.Saida(cbPlacas.Text, txtHrSaida.Text, rbSim.Checked).ToString());
            AtualizaTudo();
        }

        private void btnEncerra_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (Controller2.Entrar(txtPlaca.Text, txtHrEntrada.Text, cbVagas.Text))
            {
                MessageBox.Show("Carro estacionado!!!");
            }
            else
            {
                MessageBox.Show("Faltou informações");
            }
            AtualizaTudo();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(lblTeste.Text);
            if (temp < 5)
            {
                temp++;
            }
            lblTeste.Text = temp.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(lblTeste.Text);
            if (temp > -5)
            {
                temp--;
            }
            lblTeste.Text = temp.ToString();
        }
    }
}

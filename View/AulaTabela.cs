using AULAMVC01Tarde.Control;
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
    public partial class AulaTabela : Form
    {
        public AulaTabela()
        {
            InitializeComponent();
        }

        private void btnExecuta_Click(object sender, EventArgs e)
        {
            if (rbPessoa.Checked)
            {
                if (ControllerTabela.AdicionaPessoa(txtNome.Text, txtCpf.Text, txtRg.Text))
                {
                    MessageBox.Show("Deu bom ☺");
                }
                else
                {
                    MessageBox.Show("Deu Ruim :c");
                }
            }
            else if (rbFuncionario.Checked)
            {
                if(ControllerTabela.AdicionaFuncionario(txtNome.Text,txtCpf.Text,txtRg.Text,txtSalario.Text))
                {
                    MessageBox.Show("Acerto Miseravi");
                }
                else
                {
                    MessageBox.Show("O processo falhou com êxito");
                }
            }

            LimpaTudo();
        }
        private void btnConfere_Click(object sender, EventArgs e)
        {
            if(rbPessoa.Checked)
            {
                List<string[]> lista = ControllerTabela.SelecionaPessoas();

                string acumuladora = "";
                foreach (var item in lista)
                {
                    foreach (var item1 in item)
                    {
                        acumuladora += item1 + "\t";
                    }
                    acumuladora += "\n";
                }   
                MessageBox.Show(acumuladora);
            }
            else if (rbFuncionario.Checked)
            {
                List<string[]> lista = ControllerTabela.SelecionaFucionarios();
                string acumuladora = "";
                foreach (var item in lista)
                {
                    foreach (var item1 in item)
                    {
                        acumuladora += item1 + "\t";
                    }
                    acumuladora += "\n";
                }
                MessageBox.Show(acumuladora);
            }

        }

        private void AulaTabela_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LimpaTudo()
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtRg.Clear();
            txtSalario.Clear();
            checkVip.Checked = false;
            rbPessoa.Checked = false;
            rbCliente.Checked = false;
            rbFuncionario.Checked = false;
        }
    }
}

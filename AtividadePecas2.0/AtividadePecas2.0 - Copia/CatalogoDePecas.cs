using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadePecas2._0
{
    public partial class CP : Form
    {
        //Puxa a lista
        List<Carro> carros;
        public CP()
        {
            InitializeComponent();
            //Determina o objeto
            this.carros = new List<Carro>();
        }
        private void AtualizarCarros()
        {
            //Inclui na lista Carro uma nova informação (marca, nome, ano)
            cbCarro.Items.Clear();
            foreach (Carro c in this.carros)
            {
                cbCarro.Items.Add($"{c.marca} {c.nome} {c.ano.ToString()}");
            }
        }
        private void AtualizarPecas(Carro c)
        {
            //Mostra acima da lista as informaçoes do carro
            lblPecas.Text = $"Peças do carro: {c.marca} {c.nome} {c.ano}";
            lvPecas.Items.Clear();

            //Associa a peça cadastrada com o carro informado
            foreach (Pecas p in c.pecas)
            {
                ListViewItem item = new ListViewItem(p.marca);
                item.SubItems.Add(p.nome);
                item.SubItems.Add(p.modelo);
                item.SubItems.Add(p.valor.ToString());
                lvPecas.Items.Add(item);
            }
        }

        private void btnAdicionarC_Click(object sender, EventArgs e)
        {
            //Verifica se os TextBox estão com alguma informação
            if (txtNomeC.Text.Length > 0 &&
                txtMarcaC.Text.Length > 0 &&
                ndAno.Value > 0)
            {
                //Registra na lista Carro as informaçoes do carro cadastrado
                string nome = txtNomeC.Text;
                string marca = txtMarcaC.Text;
                int ano = (int)ndAno.Value;
                Carro carro = new Carro(marca, nome, ano);
                this.carros.Add(carro);
                AtualizarCarros();
                txtMarcaC.Text = "";
                txtNomeC.Text = "";
                ndAno.Value = ndAno.Maximum;
                MessageBox.Show($"Carro {carro.marca} {carro.nome} {carro.ano} cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Preencha todos os campos para poder cadastrar");
            }
        }

        private void btnAdicionarP_Click(object sender, EventArgs e)
        {
            //Verifica se os TextBox estão com alguma informação
            if (txtMarcaP.Text.Length > 0 &&
                txtNomeP.Text.Length > 0 &&
                txtModelo.Text.Length > 0)
            {
                //Registra na lista Pecas as informaçoes da peça cadastrado, e associa a paça com o carro selecionado
                Carro c = this.carros[cbCarro.SelectedIndex];
                Pecas p = new Pecas(txtMarcaP.Text, txtNomeP.Text, txtModelo.Text, ndValor.Value);
                c.pecas.Add(p);
                txtMarcaP.Text = "";
                txtNomeP.Text = "";
                txtModelo.Text = "";
                ndValor.Value = 0;
                MessageBox.Show("Peça cadastrada com sucesso!");
                AtualizarPecas(c);
            }
            else
            {
                MessageBox.Show("Preencha todos os campos necessários para cadastrar a peça!");
            }
        }

        private void cbCarro_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Informa dentro do ComboBox os carros cadastrados 
            Carro c = this.carros[cbCarro.SelectedIndex];
            AtualizarPecas(c);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            //Verifica se existe alguma peça 
            if (lvPecas.Items.Count > 0)
            {
                //Remove a peça selecionada da lista
                Carro c = this.carros[cbCarro.SelectedIndex];
                int indice = lvPecas.SelectedIndices[0];
                c.pecas.RemoveAt(indice);
                AtualizarPecas(c);
            }
            else
            {
                MessageBox.Show("Não há peça para deletar.");
            }
        }

        private void lvPecas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Verifica se existe algum cadastro de peça, caso nao tenhao botao de deleta ficara desabilitado
            if (lvPecas.SelectedItems.Count > 0)
            {
                btnDeletar.Enabled = true;
            }
            else
            {
                btnDeletar.Enabled = false;
            }
        }       
    }
}




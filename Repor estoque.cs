using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Repor_estoque : Form
    {
        public Repor_estoque()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int cod, qtd;
            if (textBox1.Text != "" || textBox2.Text != "")
            {
                Controle.escritor = new StreamWriter(@"Estoque.txt");
                Controle.escritor2 = new StreamWriter(@"Saldo.txt");

                try
                {
                    cod = int.Parse(textBox1.Text);
                    qtd = int.Parse(textBox2.Text);
                    for (int i = 0; i <= Controle.contador; i++)
                    {
                        if (Controle.vetprod[i].cod == cod)
                        {
                            if (((Controle.vetprod[i].preco * 0.7) * qtd) <= Controle.Saldo)
                            {
                                Controle.vetprod[i].qtd += qtd;
                                Controle.Saldo = Controle.Saldo - (Controle.vetprod[i].preco * 0.7) * qtd;

                            }
                            else MessageBox.Show(" A quantidade Exede ao Saldo insuficiente Que e: R$" + Controle.Saldo);
                        }
                        Controle.escritor.WriteLine(Controle.vetprod[i].cod + ";" + Controle.vetprod[i].categoria + ";" + Controle.vetprod[i].nome + ";" + Controle.vetprod[i].qtd + ";" + Controle.vetprod[i].preco);
                    }
                    Controle.escritor.Close();

                    MessageBox.Show("PRDOUTO REPOSTO AO ESTOQUE COM SUCESSO !");                   
                    Controle.escritor2.WriteLine(Controle.Saldo);
                    Controle.escritor2.Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Formato incorreto!");
                }

            }
            else MessageBox.Show("Preencha todos os valores!");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Controle.carrega_dados();
            Pesquisa p = new Pesquisa();
            p.Show();
        }

        private void Repor_estoque_Load(object sender, EventArgs e)
        {
            Controle.carrega_dados();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int cod = 0, qtd = 0;
            Produto p;
            try { cod = int.Parse(textBox1.Text); }
            catch (System.FormatException)
            {
                MessageBox.Show("Erro Codigo invalido");
                label2.Text = ("Erro Codigo invalido");
            }
            try { qtd = int.Parse(textBox2.Text); }
            catch (System.FormatException)
            {
                MessageBox.Show("Insira uma Qauntidade valida");
                label4.Text = ("Insira uma Qauntidade valida");
            }
            for (int i = 0; i <= Controle.contador; i++)
            {
                if (Controle.vetprod[i].cod != cod)
                {
                    l.Items.Clear();
                    MessageBox.Show("Erro Codigo invalido");
                    l.Items.Add("Erro Codigo invalido");
                }
                else
                {
                    l.Items.Clear();
                    p = (Produto)Controle.vetprod[i];
                    l.Items.Add("Codigo: " + p.cod + "; Categoria: " + p.categoria + ";  Nome do Produto: " + p.nome + ";  Quantidade: " + p.qtd + "; Preço: R$" + p.preco + ";");
                    l.Items.Add("Sub total = R$" + p.preco * qtd);
                    if ((p.preco * qtd) > Controle.Saldo)
                    {
                        l.Items.Add(" A quantidade Exede ao Saldo  Que e: R$"+Controle.Saldo);
                    }
                }
            }
        }

        private void L_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

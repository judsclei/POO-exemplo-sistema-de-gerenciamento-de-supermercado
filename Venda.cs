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
    public partial class Venda : Form
    {
        public Venda()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Controle.carrega_dados();
            Pesquisa p = new Pesquisa();
            p.Show();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int cod=0,qtd=0;
            Produto p;
            try { cod = int.Parse(textBox1.Text); }
            catch (System.FormatException)
            {
                MessageBox.Show("Erro Codigo invalido");
                label2.Text=("Erro Codigo invalido");
            }
            try { qtd = int.Parse(textBox2.Text); }
            catch (System.FormatException)
            {
                MessageBox.Show("Insira uma Qauntidade valida");
                label4.Text = ("Insira uma Qauntidade valida");
            }
            for (int i = 0; i < Controle.contador; i++)
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
                    l.Items.Add("Codigo: " + p.cod + "; Categoria: " + p.categoria + ";  Nome do Produto: " + p.nome + ";  Quantidade: " + p.qtd + "; Preço: R$" + p.preco + ";") ;
                    l.Items.Add("Sub total = R$" + p.preco * qtd);                   
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Controle.hora = new DateTime();
            Controle.hora = DateTime.Now;
            int qtdvend, cod;
            if (textBox1.Text != "" || textBox2.Text != "")
            {
                try
                {
                    qtdvend = int.Parse(textBox2.Text);
                    cod = int.Parse(textBox1.Text);
                    for (int a = 0; a <= Controle.contador; a++)
                    {
                        if (Controle.vetprod[a].cod == cod)
                        {
                            Controle.escritor2 = new StreamWriter(@"Saldo.txt");
                            Controle.escritor3 = new StreamWriter(@"ControleDeCaixa.txt", true);

                            if (qtdvend <= Controle.vetprod[a].qtd)
                            {

                                Controle.vetprod[a].qtd = Controle.vetprod[a].qtd - qtdvend;
                                Controle.Saldo = Controle.Saldo + (Controle.vetprod[a].preco * qtdvend);
                                MessageBox.Show("Venda efetuada!" + "\n Saldo: " + Controle.Saldo);
                                //MessageBox.Show(Convert.ToString(Controle.hora));


                                Controle.escritor2.WriteLine(Controle.Saldo);
                                Controle.escritor3.WriteLine("Foram vendidas " + qtdvend + " unidades, do produto " + Controle.vetprod[a].cod + " - " + Controle.hora + " Saldo em caixa: " + Controle.Saldo);

                                Controle.escritor3.Close();
                            }
                            else
                            {
                                MessageBox.Show("Quantidade Excedida de"+ Controle.vetprod[a].nome+ ", so temos " + Controle.vetprod[a].qtd + " unidades do produto");
                                l.Items.Add("Quantidade Excedida de" + Controle.vetprod[a].nome + ", so temos " + Controle.vetprod[a].qtd + " unidades do produto");
                            }

                            if (Controle.vetprod[a].qtd <= 5)
                            {
                                MessageBox.Show("O produto " + Controle.vetprod[a].cod + " está acabando, por favor reponha o estoque");
                                l.Items.Add("O produto " + Controle.vetprod[a].cod + " está acabando, por favor reponha o estoque");
                            }

                            Controle.escritor2.Close();
                        }

                    }
                    Controle.escritor = new StreamWriter(@"Estoque.txt");
                    for (int a = 0; a <= Controle.contador; a++)
                    {

                        Controle.escritor.WriteLine(Controle.vetprod[a].cod + ";" + Controle.vetprod[a].categoria + ";" + Controle.vetprod[a].nome + ";" + Controle.vetprod[a].qtd + ";" + Controle.vetprod[a].preco);

                    }
                    Controle.escritor.Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Formato incorreto!");
                }


            }
            else MessageBox.Show("Preencha todos os valores!");
        }
    }
}

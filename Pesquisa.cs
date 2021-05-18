using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Pesquisa : Form
    {
        public Pesquisa()
        {
            InitializeComponent();
            
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // c.DataSource
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string nome = null,cat=null,c;
            int cod = 0;
            Produto p;
            if (comboBox1.SelectedIndex == 1)
            {
                try
                { 
                    cod = int.Parse(textBox1.Text);
                    for (int i = 0; i <= Controle.contador; i++)
                    {
                        p = (Produto)Controle.vetprod[i];
                        if (p.cod!=cod)
                        {
                            l.Items.Clear();
                            MessageBox.Show("Erro Codigo invalido");
                            l.Items.Add("Erro Codigo invalido");
                        }
                        else
                        {
                            l.Items.Clear();      
                            l.Items.Add("Codigo: " + p.cod + "; Categoria: " + p.categoria + ";  Nome do Produto: " + p.nome + ";  Quantidade: " + p.qtd + "; Preço: R$" + p.preco + ";");
                        }
                    }
                }               
                catch (System.FormatException)
                {
                    l.Items.Clear();
                    MessageBox.Show("Erro Codigo invalido");
                    l.Items.Add("Erro Codigo invalido");
                }
                }
            else if (comboBox1.SelectedIndex == 2)
            {
                try { nome = (textBox1.Text); }
                catch (System.FormatException)
                {
                    l.Items.Clear();
                    MessageBox.Show("Erro Nome invalido");
                    l.Items.Add("Erro Nome invalido");
                    
                }
                for (int i = 0; i < Controle.contador; i++)
                {
                    p = (Produto)Controle.vetprod[i];
                    if (nome == p.nome)
                    {
                        l.Items.Clear();
                        l.Items.Add("Codigo: " + p.cod + "; Categoria: " + p.categoria + ";  Nome do Produto: " + p.nome + ";  Quantidade: " + p.qtd + "; Preço: R$" + p.preco + ";");                        
                    }
                    else
                    {
                        l.Items.Clear();
                        MessageBox.Show("Erro Nome invalido");
                        l.Items.Add("Erro Nome invalido");
                        
                    }
                }
            }
            if (comboBox1.SelectedIndex == 3)
            {
                try { cat = (textBox1.Text); }
                catch (System.FormatException)
                {
                    l.Items.Clear();
                    MessageBox.Show("Erro Categoria invalida");
                    l.Items.Add("Erro Categoria invalida");
                    
                }
                c = cat.ToUpperInvariant();
                for (int i = 0; i < Controle.contador; i++)
                {
                    p = (Produto)Controle.vetprod[i];
                    if (c == p.categoria)
                    {
                        l.Items.Clear();
                        l.Items.Add("Codigo: " + p.cod + "; Categoria: " + p.categoria + ";  Nome do Produto: " + p.nome + ";  Quantidade: " + p.qtd + "; Preço: R$" + p.preco + ";");
                        
                    }
                    else
                    {
                        l.Items.Clear();
                        MessageBox.Show("Erro Categoria invalida");
                        l.Items.Add("Erro Categoria invalida");
                        
                    }
                }
            }           
        }

        private void Pesquisa_Load(object sender, EventArgs e)
        {
            Controle.carrega_dados();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void L_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

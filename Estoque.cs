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
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
        }

       // private void Tabelao_CellContentClick(object sender, DataGridViewCellEventArgs e)
      //  {
           // for (int i = 0; i < Controle.contador; i++)
           // {
               
               // tabelao.Rows.Add(Controle.vetprod[i].cod, Controle.vetprod[i].categoria, Controle.vetprod[i].nome, Controle.vetprod[i].qtd, Controle.vetprod[i].preco, Controle.vetprod[i].data);
          //  }
       // }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void L_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Controle.carrega_dados();
            Pesquisa p = new Pesquisa();
            p.ShowDialog();
        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            Produto p;
            l.Items.Clear();
            for (int i = 0; i <= Controle.contador; i++)
            {
                p = (Produto)Controle.vetprod[i];
                l.Items.Add("Codigo: " + p.cod + "; Categoria: " + p.categoria + ";  Nome do Produto: " + p.nome + ";  Quantidade: " + p.qtd + "; Preço: R$" + p.preco + ";");
            }


            //label7.Text = "código-cat-nome-quant-preço";
            // tabelao.DataSource = Controle.vetprod[Controle.contador];
        }
    }
}

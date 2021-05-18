using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp2
{
    class Produto
    {
        public string nome { get; set; }
        public double preco { get; set; }
        public int cod { get; set; }
        public int qtd { get; set; }
        public string categoria { get; set; }

        public Produto(double preco, int cod, int qtd, string categoria, string nome)
        {
            this.nome = nome;
            this.preco = preco;
            this.cod = cod;
            this.qtd = qtd;
            this.categoria = categoria;
        }
        public override string ToString()
        {
            return "\n" + Convert.ToString(cod) + ";" + categoria + ";" + nome
                + ";" + Convert.ToString(qtd) + ";" + Convert.ToString(preco);
        }
    }
}

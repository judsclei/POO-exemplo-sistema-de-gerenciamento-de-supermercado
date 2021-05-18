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
    public partial class Cadstropro : Form
    {
        public Cadstropro()
        {
            InitializeComponent();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int cod = 0;
            double preco = 0;

            string nome = null, cat = null;

            if (textBox1.Text != "" || textBox3.Text != "" || textBox2.Text != "" || textBox5.Text != "")
            {
                try
                { cod = int.Parse(textBox1.Text); }
                catch (FormatException)
                {
                    MessageBox.Show("Formato incorreto!");
                    label3.Text = ("Formato incorreto!");
                }
                try { cat = textBox3.Text; }
                catch (FormatException)
                {
                    MessageBox.Show("Formato incorreto!");
                    label7.Text = ("Formato incorreto!");
                }

                string tipo= cat.ToUpperInvariant();

                try { preco = double.Parse(textBox5.Text); }
                catch (FormatException)
                {
                    MessageBox.Show("Formato incorreto!");
                    label10.Text = ("Formato incorreto!");
                }
                try { nome = textBox2.Text; }
                catch (FormatException)
                {
                    MessageBox.Show("Formato incorreto!");
                    label5.Text = ("Formato incorreto!");
                }              
                for (int i = 0; i <= Controle.contador; i++)
                {

                    if (Controle.vetprod[i].cod == cod)
                    {
                        MessageBox.Show("Codigo ja cadastrado, tente novamente");
                        label12.Text = ("Codigo ja cadastrado, tente novamente");
                    }

                    else
                    {
                        int aux = 0;                     
                        Controle.escritor = new StreamWriter(@"Estoque.txt", true);
                        //Controle.vetprod[Controle.contador] = new Produto(preco, cod, 0, tipo, nome);
                        Controle.escritor.WriteLine(""+cod + ";" + tipo + ";" + nome  + ";" + aux + ";" + preco);
                        Controle.escritor.Close();
                        MessageBox.Show("PRODUTO CADASTRADO COM SUCESSO !");
                        label12.Text = ("PRODUTO CADASTRADO COM SUCESSO !");

                    }
                    i = Controle.contador;
                }
            }
            else
            {
                MessageBox.Show("Preenche todos os valores");
                label12.Text = ("Preenche todos os valores");
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
        }

        private void Cadstropro_Load(object sender, EventArgs e)
        {

        }
    }
}


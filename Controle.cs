using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Controle
    {
        public static DateTime hora;
        public static StreamWriter escritor;
        public static StreamWriter escritor2;
        public static StreamWriter escritor3;
        public static StreamReader leitor;
        public static int contador;
        public static Produto[] vetprod = new Produto[1000];
        public static double Saldo;


        public static void carrega_dados()
        {
            leitor = new StreamReader("Estoque.txt", true);

            string[] aux;//Vetor auxiliar do Split.
            string linha,nomarq="Estoque.txt";//Ler as linhas do arquivo. IMPORTANTE!
            int i = 0, codigo=0;
            double preco=0;
            int quant=0;
            string nome=null;
            string categoria=null;

            if (File.Exists(nomarq))
            {
                while (!leitor.EndOfStream)
                {//Lê e Grava no vetor de acordo com atributo da classe e a ordem dos argumentos
                    try
                    {
                        linha = leitor.ReadLine();
                        aux = linha.Split(';');
                        codigo = int.Parse(aux[0]);
                        categoria = aux[1];
                        nome = aux[2];
                        quant = int.Parse(aux[3]);
                        preco = double.Parse(aux[4]);
                    }
                    catch (System.FormatException)
                    {
                        MessageBox.Show("Erro na leitura do Arquivo");
                    }

                    vetprod[i] = new Produto(preco, codigo, quant, categoria, nome);

                    contador = i++;
                }
            }

            else { File.Create(nomarq); }
           
            leitor.Close();


            StreamReader arq2 = new StreamReader("Saldo.txt");

            string linha2;

            while (!arq2.EndOfStream)
            {
                linha2 = arq2.ReadLine();
                Saldo = double.Parse(linha2);

            }
            arq2.Close();
        }
  
    }
}

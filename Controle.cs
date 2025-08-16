using System;
using System.Collections.Generic;
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
        public static List<Produto> vetprod;
        public static double Saldo;


        public static void carrega_dados()
        {
            try 
            {
                leitor = new StreamReader("Estoque.txt", true);

                string[] aux;//Vetor auxiliar do Split.
                string linha, nomarq = "Estoque.txt";//Ler as linhas do arquivo. IMPORTANTE!
                int i = 0, codigo = 0;
                double preco = 0;
                int quant = 0;
                string nome = null;
                string categoria = null;

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

                        vetprod.Add ( new Produto(preco, codigo, quant, categoria, nome));

                        contador = i++;
                    }
                }

                else { File.Create(nomarq); }

                leitor.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Estamos criando uma nova base de estoque");
                new StreamWriter("Estoque.txt");

                leitor = new StreamReader("Estoque.txt", true);

            }

            

           

            StreamReader arq2;

            try
            {
                
                arq2 = new StreamReader("Saldo.txt");
            }
            catch (Exception)
            {
                MessageBox.Show("Estamos carregando o saldo atualizado");

                IDisposable disposable = new StreamWriter("Saldo.txt");
                disposable.Dispose();

                new StreamWriter("Saldo.txt");


                 arq2 = new StreamReader("Saldo.txt");

            }


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

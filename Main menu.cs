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
    public partial class Main_menu : Form
    {
        public Main_menu()
        {
            InitializeComponent();
            timer1.Start();
        }

      //  private void Button1_Click(object sender, EventArgs e)
      //  {
       //     this.Close();
        //    Form1 f1 = new Form1();
       //     f1.Close();
       // }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Controle.carrega_dados();
            Cadstropro c = new Cadstropro();

            nav(c,content);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Controle.carrega_dados();
            inicio i = new inicio();
            nav(i, content);
        }
        public void nav(Form form, Panel panel)
        {
            form.TopLevel = false;
            form.Size = panel.Size; 
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Controle.carrega_dados();
            Estoque es = new Estoque();
            nav(es, content);
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Controle.carrega_dados();
            Venda v = new Venda();
            nav(v, content);

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Controle.carrega_dados();
            Repor_estoque rp = new Repor_estoque();
            nav(rp, content);
        }

        private void Main_menu_Load(object sender, EventArgs e)
        {
            Controle.carrega_dados();
            label4.Text = ("R$" + Controle.Saldo);
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Info_system isy = new Info_system();
            isy.Show();
        }
    }
}

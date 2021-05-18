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
    public partial class Info_system : Form
    {
        public Info_system()
        {
            InitializeComponent();
        }

        private void Info_system_Load(object sender, EventArgs e)
        {
            l.Items.Add("Supermercado TFI");
            l.Items.Add("Versao 1.0.1 (Go Free)");
            l.Items.Add("Ano: 2019");
            l.Items.Add("Desenvolvedores:");
            l.Items.Add("Gustavo Henrique");
            l.Items.Add("Lucas Alves");
            l.Items.Add("Vinicius Bryan");
            l.Items.Add("Vinicius De Castro");
        }
    }
}

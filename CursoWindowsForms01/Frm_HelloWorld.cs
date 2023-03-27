using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms01
{
    public partial class Frm_HelloWorld : Form
    {
        public Frm_HelloWorld()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Vai fechar o app quando o Btn_Sair for clicado
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = Txt_ConteudoLabel.Text;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

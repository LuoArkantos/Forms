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
    public partial class Frm_MouseCaptura : Form
    {
        public Frm_MouseCaptura()
        {
            InitializeComponent();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            string PressedButton = e.Button.ToString(); //Vai pegar o botão de "e" que é a variável do tipo mouseEvents que contem dados sobre interação de mouse, e transformar o dado Button em String para exibir qual botao do mouse foi pressionado.

            MessageBox.Show(PressedButton);
        }
    }
}

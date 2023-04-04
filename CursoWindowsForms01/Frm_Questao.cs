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
    public partial class Frm_Questao : Form
    {
        public Frm_Questao()
        {
            InitializeComponent();
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes; //Define o botão como um botão de retorno YES
            this.Close(); //Fecha a DialogBox

        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

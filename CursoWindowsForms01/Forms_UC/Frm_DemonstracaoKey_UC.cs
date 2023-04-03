using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms01.Forms_UC
{
    public partial class Frm_DemonstracaoKey_UC : UserControl
    {
        public Frm_DemonstracaoKey_UC()
        {
            InitializeComponent();
        }
        private void Lbl_Minus_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Input_KeyDown(object sender, KeyEventArgs e)
        {
            Txt_Msg.AppendText($"\r\nTecla Pressionada: {e.KeyCode}\r\n");//vai printar a tecla
            Txt_Msg.AppendText($"\tCódigo da Tecla: {((int)e.KeyCode)}\r\n");//vai printar o codigo da tecla
            Txt_Msg.AppendText($"\tNome da Tecla: {e.KeyData}");//nome da tecla
            Lbl_Upper.Text = e.KeyCode.ToString().ToUpper();//Transforma em maiusculo
            Lbl_Lower.Text = e.KeyCode.ToString().ToLower();//transf em minusculo
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Txt_Input.Text = "";
            Txt_Msg.Text = "";
            Lbl_Upper.Text = "";
            Lbl_Lower.Text = "";
        }
    }
}
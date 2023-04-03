using CursoWindowsFormsDLL;
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
    public partial class Frm_ValidaSenha_UC : UserControl
    {
        bool MostrarSenha = false;

        public Frm_ValidaSenha_UC()
        {
            InitializeComponent();
        }
        private void Frm_ValidaSenha_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Txt_Senha.Text = "";
            Lbl_Resultado.Text = "";
        }

        private void Txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            // Cls_Uteis.ChecaForcaSenha esta pegando a classe ChecaForcaSenha que esta na classe Cls_Uteis, q por sua vez, esta na dll 
            Cls_Uteis.ChecaForcaSenha verifica = new Cls_Uteis.ChecaForcaSenha(); //cria var do tipo ChecaForcaSenha
            Cls_Uteis.ChecaForcaSenha.ForcaDaSenha forcaSenha;
            forcaSenha = verifica.GetForcaDaSenha(Txt_Senha.Text);
            Lbl_Resultado.Text = forcaSenha.ToString();

            //Cor do texto
            if (Lbl_Resultado.Text == "Inaceitavel" | Lbl_Resultado.Text == "Fraca")
            {
                Lbl_Resultado.ForeColor = Color.Red;
            }
            if (Lbl_Resultado.Text == "Aceitavel")
            {
                Lbl_Resultado.ForeColor = Color.Blue;
            }
            if (Lbl_Resultado.Text == "Forte" | Lbl_Resultado.Text == "Segura")
            {
                Lbl_Resultado.ForeColor = Color.Green;
            }
        }

        private void Btn_MostraSenha_Click(object sender, EventArgs e)
        {
            if (MostrarSenha == false)
            {
                Txt_Senha.PasswordChar = '\0';
                Btn_MostraSenha.Text = "Ocultar Senha";
                MostrarSenha = true;

            }
            else
            {
                Txt_Senha.PasswordChar = '*';
                MostrarSenha = false;
                Btn_MostraSenha.Text = "Mostrar Senha";
            }

        }
    }
}

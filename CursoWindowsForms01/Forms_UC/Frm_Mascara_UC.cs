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
    public partial class Frm_Mascara_UC : UserControl
    {
        public Frm_Mascara_UC()
        {
            InitializeComponent();
        }
        private void Frm_Mascara_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Hora_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;//Retira modo de exibição de senha(caso esteja ativo)
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "00:00"; //setta o formato do dado
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask; //printa o formato da mascara
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();//Poe o cursor na TxtBox quando clicado
        }

        private void Btn_CEP_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;//Retira modo de exibição de senha(caso esteja ativo)
            Lbl_Conteudo.Text = ""; //Limpa a lbl conteudo (rodapé)
            Msk_TextBox.Mask = "00000-000"; //setta o formato do dado
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask; //printa o formato da mascara
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();//Poe o cursor na TxtBox quando clicado
        }

        private void Btn_VerConteudo_Click(object sender, EventArgs e)
        {
            Lbl_Conteudo.Text = Msk_TextBox.Text;
        }

        private void Btn_Moeda_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;//Retira modo de exibição de senha(caso esteja ativo)
            Lbl_Conteudo.Text = ""; //Limpa a lbl conteudo (rodapé)
            Msk_TextBox.Mask = "$ 0,000,000.00"; //setta o formato do dado (o $ vai fazer com q o app mostre a moeda do seu sist operacional, não exatamente dollar)
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask; //printa o formato da mascara
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();//Poe o cursor na TxtBox quando clicado
        }

        private void Btn_Data_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;//Retira modo de exibição de senha(caso esteja ativo)
            Lbl_Conteudo.Text = ""; //Limpa a lbl conteudo (rodapé)
            Msk_TextBox.Mask = "00/00/0000"; //setta o formato do dado
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask; //printa o formato da mascara
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();//Poe o cursor na TxtBox quando clicado
        }

        private void Btn_Telefone_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;//Retira modo de exibição de senha(caso esteja ativo)
            Lbl_Conteudo.Text = ""; //Limpa a lbl conteudo (rodapé)
            Msk_TextBox.Mask = "(00) 00000-0000"; //setta o formato do dado
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask; //printa o formato da mascara
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();//Poe o cursor na TxtBox quando clicado
        }

        private void Btn_Senha_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = true;//Metodo UseSystemPassordChar vai mudar o tipo de exibição para password, mas deve ser destivado nos outros botões, senão todos os dados serão exibidos como senha.
            Lbl_Conteudo.Text = ""; //Limpa a lbl conteudo (rodapé)
            Msk_TextBox.Mask = "000000"; //setta o formato do dado
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask; //printa o formato da mascara
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();//Poe o cursor na TxtBox quando clicado
        }
    }
}

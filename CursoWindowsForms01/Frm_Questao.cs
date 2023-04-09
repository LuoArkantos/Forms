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
        public Frm_Questao(string nomeImagem, string mensagem)
        {
            InitializeComponent();

            Image MyImage = (Image)global::CursoWindowsForms01.Properties.Resources.ResourceManager.GetObject(nomeImagem); //Cria a variável MyImage do tipo IMAGE, pegando de Global, Os recursos das propriedades do projeto (Vai entrar em resources do projeto e verificar o conteudo) ResourceManager.GetObj(var) vai PEGAR o objeto q está no recurso e executar.

            Pic_Imagem.Image = MyImage; //O objeto imagem do form vai receber a variavel MyImage, q vai ter a imagem passada

            Lbl_Questao.Text = mensagem; // A label vai receber a mensagem para exibir.


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

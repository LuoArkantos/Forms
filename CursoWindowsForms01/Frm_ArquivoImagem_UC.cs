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
    public partial class Frm_ArquivoImagem_UC : UserControl
    {
        public Frm_ArquivoImagem_UC(string nomeArquivo)
        {
            InitializeComponent();

            Lbl_ArquivoImagem.Text = nomeArquivo; //Vai mudar o texto para o nome do arquivo selecionado
            Pic_ArquivoImagem.Image = Image.FromFile(nomeArquivo);//Vai pegar a imagem do arquivo (nomeArquivo) e exibir em Pic_ArquivoImagem.Image :)
        }

        private void Btn_Cor_Click(object sender, EventArgs e)
        {
            ColorDialog CDb = new ColorDialog(); //vai instanciar o tipo de DialogBox de seleção de cores
            if(CDb.ShowDialog() == DialogResult.OK)
            {
                Lbl_ArquivoImagem.ForeColor = CDb.Color; //Vai pegar a cor selecionada no CDb e colocar na Label
            }
        }

        private void Btn_Fonte_Click(object sender, EventArgs e)
        {
            FontDialog FDb = new FontDialog(); //Vai instanciar o tipo de DialogBox de seleção de fontes
            if (FDb.ShowDialog()== DialogResult.OK)
            {
                Lbl_ArquivoImagem.Font = FDb.Font; //Vai pegar a fonte selecionada no CDb e colocar na Label
            }
        }
    }
}

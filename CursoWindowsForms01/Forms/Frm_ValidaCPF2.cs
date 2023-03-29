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

namespace CursoWindowsForms01
{
    public partial class Frm_ValidaCPF2 : Form
    {
        public Frm_ValidaCPF2()
        {
            InitializeComponent();
        }

        private void Frm_ValidaCPF2_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Msk_CPF.Text = "";
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            string vConteudo = Msk_CPF.Text;
            vConteudo = vConteudo.Replace(".", "").Replace("-", "");
            vConteudo = vConteudo.Trim();
            
            if (vConteudo == "")
            {
                MessageBox.Show("CPF VAZIO", "Validação de CPF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (vConteudo.Length != 11)
                {
                    MessageBox.Show("CPF INCOMPLETO", "Validação de CPF", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Deseja realmente validar o CPF?", "Mensagem de Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) //Abre uma janela com opções SIM e NAO, quando clicado em SIM, executa o corpo da condicional
                    {
                        bool validaCpf = false;
                        validaCpf = Cls_Uteis.Valida(Msk_CPF.Text);
                        if (validaCpf == true)
                        {
                            MessageBox.Show("CPF VÁLIDO!", "Validação de CPF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("CPF INVÁLIDO!", "Validação de CPF", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }                
            }            
        }
    }
}

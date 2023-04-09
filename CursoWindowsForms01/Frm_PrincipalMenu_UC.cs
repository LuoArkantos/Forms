using CursoWindowsForms01.Forms_UC;
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
    public partial class Frm_PrincipalMenu_UC : Form
    {
        int ControleDemonstracaoKey = 0;
        int ControleHelloWorld = 0;
        int ControleMascara = 0;
        int ControleValidaCPF = 0;
        int ControleValidaCPF2 = 0;
        int ControleValidaSenha = 0;
        int ControleArquivoImagem = 0;
        public Frm_PrincipalMenu_UC()
        {
            InitializeComponent();

            novoToolStripMenuItem.Enabled = false; //.Enabled true e false dizem se o botão é habilitado ou não
            apagarTabToolStripMenuItem.Enabled = false;
            abrirImagemToolStripMenuItem.Enabled = false;
            desconectarToolStripMenuItem.Enabled = false;
        }
        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleDemonstracaoKey += 1;
            Frm_DemonstracaoKey_UC u = new Frm_DemonstracaoKey_UC();
            TabPage tab = new TabPage();
            u.Dock = DockStyle.Fill;
            tab.Name = "Demonstracao Key " + ControleDemonstracaoKey;
            tab.Text = "Demonstracao Key " + ControleDemonstracaoKey;
            tab.ImageIndex = 0;
            tab.Controls.Add(u);
            Tbc_Aplicacoes.TabPages.Add(tab);
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleHelloWorld += 1;
            Frm_HelloWorld_UC U = new Frm_HelloWorld_UC();//Chamo a janela
            TabPage tab = new TabPage();//Chamo a funcionalidade tabpage
            U.Dock = DockStyle.Fill; //function Dock recebendo DockStyle.Fill fará a tab responder ao tamanho da janela, ficando responsivo.
            tab.Name = "HelloWorld "+ ControleHelloWorld; //nomeio a tab (internamente)
            tab.Text = "HelloWorld "+ ControleHelloWorld;//Nomeio a tab (Visivel na aba)
            tab.ImageIndex = 1;
            tab.Controls.Add(U);//Adiciono a janela dentro da var tab
            Tbc_Aplicacoes.TabPages.Add(tab);//Exibo a tab //Metodo TabPages.Add(tab) no objeto Tbc
        }

        private void máscaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleMascara += 1;
            Frm_Mascara_UC u = new Frm_Mascara_UC();
            TabPage tab = new TabPage();
            u.Dock = DockStyle.Fill;
            tab.Name = "Mascara " + ControleMascara;
            tab.Text = "Mascara " + ControleMascara;
            tab.ImageIndex = 2;
            tab.Controls.Add(u);
            Tbc_Aplicacoes.TabPages.Add(tab);
        }

        private void valídaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF += 1;
            Frm_ValidaCPF_UC u = new Frm_ValidaCPF_UC();
            TabPage tab = new TabPage();
            u.Dock = DockStyle.Fill;
            tab.Name = "Valída CPF " + ControleValidaCPF;
            tab.Text = "Valída CPF " + ControleValidaCPF;
            tab.ImageIndex = 3;
            tab.Controls.Add(u);
            Tbc_Aplicacoes.TabPages.Add(tab);
        }

        private void valídaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF2 += 1;
            Frm_ValidaCPF2_UC u = new Frm_ValidaCPF2_UC();
            TabPage tab = new TabPage();
            u.Dock = DockStyle.Fill;
            tab.Name = "Valída CPF 2 " + ControleValidaCPF2;
            tab.Text = "Valída CPF 2 " + ControleValidaCPF2;
            tab.ImageIndex = 4;
            tab.Controls.Add(u);
            Tbc_Aplicacoes.TabPages.Add(tab);
        }

        private void valídaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaSenha += 1;
            Frm_ValidaSenha_UC u = new Frm_ValidaSenha_UC();
            TabPage tab = new TabPage();
            u.Dock = DockStyle.Fill;
            tab.Name = "Valída Senha " + ControleValidaSenha;
            tab.Text = "Valída Senha " + ControleValidaSenha;
            tab.ImageIndex = 5;
            tab.Controls.Add(u);
            Tbc_Aplicacoes.TabPages.Add(tab);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void apagarTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!(Tbc_Aplicacoes.SelectedTab == null)) //Se tab não for nulla
            {
                Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab); //Remove a Tab
            }
        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Db = new OpenFileDialog(); //Cria a DB do tipo Abertura de arquivos.

            Db.Title = "Abrir Arquivo";
            Db.InitialDirectory = "C:\\Users\\luizf\\Forms\\CursoWindowsForms01\\Images"; //Precisa ter barras duplas para o C# não entender como comando, sim como endereço
            Db.Filter = "PNG|*.PNG"; //filtra o tip de arquivo q vai aparecer
            
             
            if (Db.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivo = Db.FileName; //Vai pegar o nome da imagem para exibir na label do programa

                ControleArquivoImagem += 1;
                Frm_ArquivoImagem_UC u = new Frm_ArquivoImagem_UC(nomeArquivo); //parametro do construtor para modificar dados da tela
                TabPage tab = new TabPage();
                u.Dock = DockStyle.Fill;
                tab.Name = "Arquivo Imagem " + ControleArquivoImagem;
                tab.Text = "Arquivo Imagem " + ControleArquivoImagem;
                tab.ImageIndex = 6;
                tab.Controls.Add(u);
                Tbc_Aplicacoes.TabPages.Add(tab);
            }
            
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login l = new Frm_Login();
            l.ShowDialog();

            if (l.DialogResult == DialogResult.OK)
            {
                string usuario = l.usuario; //Pega os dados do usuario e senha inseridos
                string senha = l.senha;

                if (CursoWindowsFormsDLL.Cls_Uteis.validaSenhaLogin(senha) == true) //pega metodo de verificacao na classe dll
                {
                    novoToolStripMenuItem.Enabled = true;
                    apagarTabToolStripMenuItem.Enabled = true;
                    abrirImagemToolStripMenuItem.Enabled = true;
                    conectarToolStripMenuItem.Enabled = false;
                    desconectarToolStripMenuItem.Enabled = true;

                    MessageBox.Show($"Bem vindo {usuario}!", "Usuário Autenticado", MessageBoxButtons.OK, MessageBoxIcon.Information); //Mostra messagebox de autorizacao 
                }
                else
                {
                    MessageBox.Show($"Senha invalida!", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab); //Remove a Tab
            Frm_Questao ConfirmacaoBox = new Frm_Questao("perguntando", "Quer mesmo sair?");

            if (ConfirmacaoBox.ShowDialog() == DialogResult.Yes)
            {
                for (int i = Tbc_Aplicacoes.TabPages.Count; i > 0; i += -1)
                {
                    Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab); //Remove a Tab
                }

                novoToolStripMenuItem.Enabled = false;
                apagarTabToolStripMenuItem.Enabled = false;
                abrirImagemToolStripMenuItem.Enabled = false;
                conectarToolStripMenuItem.Enabled = true;
                desconectarToolStripMenuItem.Enabled = false;
            }
        }
    }
}
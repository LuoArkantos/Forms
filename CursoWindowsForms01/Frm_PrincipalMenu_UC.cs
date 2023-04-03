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
        int ContadorDeTabs = 0;
        public Frm_PrincipalMenu_UC()
        {
            InitializeComponent();
        }
        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContadorDeTabs += 1;
            Frm_DemonstracaoKey_UC u = new Frm_DemonstracaoKey_UC();
            TabPage tab = new TabPage();
            tab.Name = "Demonstracao Key " + ContadorDeTabs;
            tab.Text = "Demonstracao Key " + ContadorDeTabs;
            tab.ImageIndex = 0;
            tab.Controls.Add(u);
            Tbc_Aplicacoes.TabPages.Add(tab);
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContadorDeTabs += 1;
            Frm_HelloWorld_UC U = new Frm_HelloWorld_UC();//Chamo a janela
            TabPage tab = new TabPage();//Chamo a funcionalidade tabpage
            tab.Name = "HelloWorld "+ContadorDeTabs; //nomeio a tab (internamente)
            tab.Text = "HelloWorld "+ContadorDeTabs;//Nomeio a tab (Visivel na aba)
            tab.ImageIndex = 1;
            tab.Controls.Add(U);//Adiciono a janela dentro da var tab
            Tbc_Aplicacoes.TabPages.Add(tab);//Exibo a tab //Metodo TabPages.Add(tab) no objeto Tbc
        }

        private void máscaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContadorDeTabs += 1;
            Frm_Mascara_UC u = new Frm_Mascara_UC();
            TabPage tab = new TabPage();
            tab.Name = "Mascara " + ContadorDeTabs;
            tab.Text = "Mascara " + ContadorDeTabs;
            tab.ImageIndex = 2;
            tab.Controls.Add(u);
            Tbc_Aplicacoes.TabPages.Add(tab);
        }

        private void valídaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContadorDeTabs += 1;
            Frm_ValidaCPF_UC u = new Frm_ValidaCPF_UC();
            TabPage tab = new TabPage();
            tab.Name = "Valída CPF " + ContadorDeTabs;
            tab.Text = "Valída CPF " + ContadorDeTabs;
            tab.ImageIndex = 3;
            tab.Controls.Add(u);
            Tbc_Aplicacoes.TabPages.Add(tab);
        }

        private void valídaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContadorDeTabs += 1;
            Frm_ValidaCPF2_UC u = new Frm_ValidaCPF2_UC();
            TabPage tab = new TabPage();
            tab.Name = "Valída CPF 2 " + ContadorDeTabs;
            tab.Text = "Valída CPF 2 " + ContadorDeTabs;
            tab.ImageIndex = 4;
            tab.Controls.Add(u);
            Tbc_Aplicacoes.TabPages.Add(tab);
        }

        private void valídaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContadorDeTabs += 1;
            Frm_ValidaSenha_UC u = new Frm_ValidaSenha_UC();
            TabPage tab = new TabPage();
            tab.Name = "Valída Senha " + ContadorDeTabs;
            tab.Text = "Valída Senha " + ContadorDeTabs;
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
    }
}
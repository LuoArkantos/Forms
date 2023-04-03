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
            Frm_DemonstracaoKey f = new Frm_DemonstracaoKey();
            f.ShowDialog();
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
            Frm_Mascara f = new Frm_Mascara();
            f.ShowDialog();
        }

        private void valídaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF f = new Frm_ValidaCPF();
            f.ShowDialog();
        }

        private void valídaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF2 f = new Frm_ValidaCPF2();
            f.ShowDialog();
        }

        private void valídaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaSenha f = new Frm_ValidaSenha();
            f.ShowDialog();
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
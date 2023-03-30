﻿using System;
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
    public partial class Frm_PrincipalMenu_MDI : Form
    {
        public Frm_PrincipalMenu_MDI()
        {
            InitializeComponent();
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DemonstracaoKey f = new Frm_DemonstracaoKey();
            f.MdiParent = this; //Diz que ESTE (Frm_PrincipalMenu_MDI) é a janela PAI do formulario q vai ser aberto, assim abrindo o form dentro da janela principal
            f.Show(); 
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_HelloWorld f = new Frm_HelloWorld();
            f.MdiParent = this; //Diz que ESTE (Frm_PrincipalMenu_MDI) é a janela PAI do formulario q vai ser aberto, assim abrindo o form dentro da janela principal
            f.Show();
        }

        private void máscaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mascara f = new Frm_Mascara();
            f.MdiParent = this; //Diz que ESTE (Frm_PrincipalMenu_MDI) é a janela PAI do formulario q vai ser aberto, assim abrindo o form dentro da janela principal
            f.Show();
        }

        private void valídaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF f = new Frm_ValidaCPF();
            f.MdiParent = this; //Diz que ESTE (Frm_PrincipalMenu_MDI) é a janela PAI do formulario q vai ser aberto, assim abrindo o form dentro da janela principal
            f.Show();
        }

        private void valídaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF2 f = new Frm_ValidaCPF2();
            f.MdiParent = this; //Diz que ESTE (Frm_PrincipalMenu_MDI) é a janela PAI do formulario q vai ser aberto, assim abrindo o form dentro da janela principal
            f.Show();
        }

        private void valídaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaSenha f = new Frm_ValidaSenha();
            f.MdiParent = this; //Diz que ESTE (Frm_PrincipalMenu_MDI) é a janela PAI do formulario q vai ser aberto, assim abrindo o form dentro da janela principal
            f.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade); //O parametro é do namespace (System.Windows.Forms.MdiLayold.Cascade)
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal); //O parametro é do namespace (System.Windows.Forms.MdiLayold.TileHorizontal)
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical); //O parametro é do namespace (System.Windows.Forms.MdiLayold.TileVertical)
        }
    }
}
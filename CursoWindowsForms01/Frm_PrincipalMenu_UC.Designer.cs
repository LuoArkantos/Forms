﻿namespace CursoWindowsForms01
{
    partial class Frm_PrincipalMenu_UC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PrincipalMenu_UC));
            this.Mnu_Principal = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demonstraçãoKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helloWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.máscaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valídaCPFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valídaCPF2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valídaSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tbc_Aplicacoes = new System.Windows.Forms.TabControl();
            this.Iml_imagens = new System.Windows.Forms.ImageList(this.components);
            this.apagarTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mnu_Principal
            // 
            this.Mnu_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.Mnu_Principal.Location = new System.Drawing.Point(0, 0);
            this.Mnu_Principal.Name = "Mnu_Principal";
            this.Mnu_Principal.Size = new System.Drawing.Size(800, 24);
            this.Mnu_Principal.TabIndex = 0;
            this.Mnu_Principal.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.apagarTabToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.demonstraçãoKeyToolStripMenuItem,
            this.helloWorldToolStripMenuItem,
            this.máscaraToolStripMenuItem,
            this.valídaCPFToolStripMenuItem,
            this.valídaCPF2ToolStripMenuItem,
            this.valídaSenhaToolStripMenuItem});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // demonstraçãoKeyToolStripMenuItem
            // 
            this.demonstraçãoKeyToolStripMenuItem.Image = global::CursoWindowsForms01.Properties.Resources.Frm_DemonstracaoKey;
            this.demonstraçãoKeyToolStripMenuItem.Name = "demonstraçãoKeyToolStripMenuItem";
            this.demonstraçãoKeyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.demonstraçãoKeyToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.demonstraçãoKeyToolStripMenuItem.Text = "Demonstração &Key";
            this.demonstraçãoKeyToolStripMenuItem.Click += new System.EventHandler(this.demonstraçãoKeyToolStripMenuItem_Click);
            // 
            // helloWorldToolStripMenuItem
            // 
            this.helloWorldToolStripMenuItem.Image = global::CursoWindowsForms01.Properties.Resources.Frm_HelloWorld2;
            this.helloWorldToolStripMenuItem.Name = "helloWorldToolStripMenuItem";
            this.helloWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.helloWorldToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.helloWorldToolStripMenuItem.Text = "Hello &World";
            this.helloWorldToolStripMenuItem.Click += new System.EventHandler(this.helloWorldToolStripMenuItem_Click);
            // 
            // máscaraToolStripMenuItem
            // 
            this.máscaraToolStripMenuItem.Image = global::CursoWindowsForms01.Properties.Resources.Frm_Mascara2;
            this.máscaraToolStripMenuItem.Name = "máscaraToolStripMenuItem";
            this.máscaraToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.máscaraToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.máscaraToolStripMenuItem.Text = "&Máscara";
            this.máscaraToolStripMenuItem.Click += new System.EventHandler(this.máscaraToolStripMenuItem_Click);
            // 
            // valídaCPFToolStripMenuItem
            // 
            this.valídaCPFToolStripMenuItem.Image = global::CursoWindowsForms01.Properties.Resources.Frm_ValidaCPF3;
            this.valídaCPFToolStripMenuItem.Name = "valídaCPFToolStripMenuItem";
            this.valídaCPFToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.valídaCPFToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.valídaCPFToolStripMenuItem.Text = "Valída &CPF";
            this.valídaCPFToolStripMenuItem.Click += new System.EventHandler(this.valídaCPFToolStripMenuItem_Click);
            // 
            // valídaCPF2ToolStripMenuItem
            // 
            this.valídaCPF2ToolStripMenuItem.Image = global::CursoWindowsForms01.Properties.Resources.Frm_ValidaCPF22;
            this.valídaCPF2ToolStripMenuItem.Name = "valídaCPF2ToolStripMenuItem";
            this.valídaCPF2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.valídaCPF2ToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.valídaCPF2ToolStripMenuItem.Text = "Valída C&PF 2";
            this.valídaCPF2ToolStripMenuItem.Click += new System.EventHandler(this.valídaCPF2ToolStripMenuItem_Click);
            // 
            // valídaSenhaToolStripMenuItem
            // 
            this.valídaSenhaToolStripMenuItem.Image = global::CursoWindowsForms01.Properties.Resources.Frm_ValidaSenha2;
            this.valídaSenhaToolStripMenuItem.Name = "valídaSenhaToolStripMenuItem";
            this.valídaSenhaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.valídaSenhaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.valídaSenhaToolStripMenuItem.Text = "Valída &Senha";
            this.valídaSenhaToolStripMenuItem.Click += new System.EventHandler(this.valídaSenhaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // Tbc_Aplicacoes
            // 
            this.Tbc_Aplicacoes.ImageList = this.Iml_imagens;
            this.Tbc_Aplicacoes.Location = new System.Drawing.Point(0, 27);
            this.Tbc_Aplicacoes.Name = "Tbc_Aplicacoes";
            this.Tbc_Aplicacoes.SelectedIndex = 0;
            this.Tbc_Aplicacoes.Size = new System.Drawing.Size(800, 399);
            this.Tbc_Aplicacoes.TabIndex = 1;
            // 
            // Iml_imagens
            // 
            this.Iml_imagens.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Iml_imagens.ImageStream")));
            this.Iml_imagens.TransparentColor = System.Drawing.Color.Transparent;
            this.Iml_imagens.Images.SetKeyName(0, "Frm_DemonstracaoKey.png");
            this.Iml_imagens.Images.SetKeyName(1, "Frm_HelloWorld.png");
            this.Iml_imagens.Images.SetKeyName(2, "Frm_Mascara.png");
            this.Iml_imagens.Images.SetKeyName(3, "Frm_ValidaCPF.png");
            this.Iml_imagens.Images.SetKeyName(4, "Frm_ValidaCPF2.png");
            this.Iml_imagens.Images.SetKeyName(5, "Frm_ValidaSenha.png");
            // 
            // apagarTabToolStripMenuItem
            // 
            this.apagarTabToolStripMenuItem.Name = "apagarTabToolStripMenuItem";
            this.apagarTabToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.apagarTabToolStripMenuItem.Text = "Apagar Tab";
            this.apagarTabToolStripMenuItem.Click += new System.EventHandler(this.apagarTabToolStripMenuItem_Click);
            // 
            // Frm_PrincipalMenu_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tbc_Aplicacoes);
            this.Controls.Add(this.Mnu_Principal);
            this.MainMenuStrip = this.Mnu_Principal;
            this.Name = "Frm_PrincipalMenu_UC";
            this.Text = "Principal";
            this.Mnu_Principal.ResumeLayout(false);
            this.Mnu_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Mnu_Principal;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demonstraçãoKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helloWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem máscaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valídaCPFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valídaCPF2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valídaSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.TabControl Tbc_Aplicacoes;
        private System.Windows.Forms.ImageList Iml_imagens;
        private System.Windows.Forms.ToolStripMenuItem apagarTabToolStripMenuItem;
    }
}
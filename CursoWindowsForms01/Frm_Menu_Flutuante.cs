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
    public partial class Frm_Menu_Flutuante : Form
    {
        public Frm_Menu_Flutuante()
        {
            InitializeComponent();
        }

        private void Frm_Menu_Flutuante_MouseDown(object sender, MouseEventArgs e)
        {
            /*string str1 = e.Button.ToString(); //Testa se o botão do mouse pressionado é igual ao definido na condicional
            if (str1 == "Left")
            {
                MessageBox.Show($"Botão do mouse apertado: {str1}");
            }*/

            var PosicaoX = e.X; //Pega a posição X do mouse
            var PosicaoY = e.Y; //Pega a posição Y do mouse

            //if (e.Button == System.Windows.Forms.MouseButtons.Right) //Ve se o botão pressionado é o da direita e a posição tbm
            //{
            //    MessageBox.Show($"Botão do mouse apertado: {e.Button.ToString()} | Localização do click: {PosicaoX},{PosicaoY}");
            //}

            //Consatuindo o Menu Flutuante:

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var Menu = new ContextMenuStrip(); //Chama a classe de menus e bota na var Menu
                var xToolTip001 = new ToolStripMenuItem(); //Chama a classe de itens de menu para a var
                xToolTip001.Text = "Item 1"; //Cria um item tipo ToolStripMenu

                Menu.Items.Add(DesenhaMenu("Item 1")); //Adiciona o nome do item ao menu.
                Menu.Items.Add(DesenhaMenu("Item 2")); //Adiciona o nome do item ao menu.
                Menu.Items.Add(DesenhaMenu("Item 3")); //Adiciona o nome do item ao menu.
                Menu.Show(this, new Point(e.X,e.Y));
            }

            ToolStripMenuItem DesenhaMenu (string text)
            {
                var xToolTip = new ToolStripMenuItem();
                xToolTip.Text = text;
                return xToolTip;
            }
            
        }
    }
}

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
    public partial class Frm_MouseEventos : Form
    {
        public Frm_MouseEventos()
        {
            InitializeComponent();
        }

        private void Btn_Mouse_MouseEnter(object sender, EventArgs e) //Evento q executa quando o mouse entra na área do elemento
        {
            Btn_Mouse.Text = "Mouse Enter";
        }

        private void Btn_Mouse_MouseLeave(object sender, EventArgs e) //Evento q executa quando o mouse sai da área do elemento
        {
            Btn_Mouse.Text = "Mouse Leave";
        }

        private void Btn_Mouse_MouseHover(object sender, EventArgs e) //Evento que executa quando o mouse paira sobre o elemento
        {
            Btn_Mouse.Text = "Mouse Hover";
        }

        private void Btn_Mouse_MouseDown(object sender, MouseEventArgs e) //Evento que executa quando o botão do mouse é pressionado (HOLD) dentro da área do elemento
        {
            Btn_Mouse.Text = "Mouse Down";
        }

        private void Btn_Mouse_MouseUp(object sender, MouseEventArgs e) //Evento executando quando o botão segurado do mouse é solto (Release)
        {
            Btn_Mouse.Text = "Mouse Up";
        }
    }
}

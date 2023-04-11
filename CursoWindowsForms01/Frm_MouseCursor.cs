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
    public partial class Frm_MouseCursor : Form
    {
        public Frm_MouseCursor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            for (int i = 0; i < 10;  i++)
            {
                System.Threading.Thread.Sleep(1000); //Suspende o sistema por um tempo definido de milissegundos (1000 milisegundos = 1 seg)
            }
            this.Cursor = Cursors.Default;
        }
    }
}

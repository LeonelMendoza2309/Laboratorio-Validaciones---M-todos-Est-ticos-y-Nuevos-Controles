using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsbtnVentanas_Click(object sender, EventArgs e)
        { 

            frmVentanaTexto ventanaTexto = Application.OpenForms.OfType<frmVentanaTexto>().FirstOrDefault();
             if (ventanaTexto != null)
            {
                ventanaTexto.BringToFront();
                ventanaTexto.Focus();
            }
            else
            {
                ventanaTexto = new frmVentanaTexto();
                ventanaTexto.MdiParent = this;
                ventanaTexto.Show();
            }
        }

    }
}

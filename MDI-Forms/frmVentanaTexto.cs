using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace MDI_Forms
{
    public partial class frmVentanaTexto : Form
    {
        public frmVentanaTexto()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Name = "frmVentanaTexto";
            this.Text = "frmVentanaTexto";
            this.ResumeLayout(false);
        }
    }
}

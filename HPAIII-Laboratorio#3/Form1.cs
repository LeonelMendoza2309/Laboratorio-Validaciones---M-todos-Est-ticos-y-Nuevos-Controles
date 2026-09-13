using EjemploGrid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HPAIII_Laboratorio_3
{
    public partial class Form1 : Form
    {
        List<Persona> ListaPersona = new List<Persona>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Persona miColaborador1 = new Persona();

            miColaborador1.ID = 1;
            miColaborador1.Nombre = "Elena Carolina";
            miColaborador1.Apellidos = "Gonzalez Rodrigrez";
            miColaborador1.Correo = "elena.gonzalez@ejemplo.com";
            miColaborador1.FechaNacmiento = new DateTime(1997, 4, 18);
            ListaPersona.Add(miColaborador1);
            dgvdatos.DataSource = ListaPersona;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {

            if (txtIDemp.Text == "")
            {
                errorProvider1.SetError(txtIDemp, "Ingrese un Id");
                txtIDemp.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtIDemp, "");
            }


            if (txtNomb.Text == "")
            {
                errorProvider1.SetError(txtNomb, "Ingrese Los nombres del colaborador");
                txtNomb.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtNomb, "");
            }


            if (txtApe.Text == "")
            {
                errorProvider1.SetError(txtApe, "Ingrese los apellidos del colaborador");
                txtApe.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtApe, "");
            }


            if (Utilidades.EsCorreoValido(txtEmail.Text) == false)
            {
                errorProvider1.SetError(txtEmail, "Ingrese un correo Valido");
                txtEmail.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }


            decimal salario1;
            if (!decimal.TryParse(txtSal.Text, out salario1))
            {
                errorProvider1.SetError(txtSal, "Ingrese Salario Valido");
                txtSal.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtSal, "");
            }

            Persona colaborador1 = new Persona();
            colaborador1.ID = int.Parse(txtIDemp.Text);
            colaborador1.Nombre = txtNomb.Text;
            colaborador1.Apellidos = txtApe.Text;
            colaborador1.Correo = txtEmail.Text;
            colaborador1.Salario = salario1;
            colaborador1.FechaNacmiento = dtpFechn.Value;
            ListaPersona.Add(colaborador1);
            dgvdatos.DataSource = null; // Limpiar el DataSource antes de asignar la nueva lista
            dgvdatos.DataSource = ListaPersona;
        }
    }
}

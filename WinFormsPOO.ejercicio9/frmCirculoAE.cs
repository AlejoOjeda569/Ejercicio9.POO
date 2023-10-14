using ArrayCircunferencia.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPOO.ejercicio9
{
    public partial class frmCirculoAE : Form
    {
        public frmCirculoAE()
        {
            InitializeComponent();
        }
        private Circunferencia circulo;
        public Circunferencia GetCirculo()
        {
            return circulo;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (circulo==null)
                {
                    circulo = new Circunferencia();
                }
                circulo.SetRadio(double.Parse(txtRadio.Text));
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!double.TryParse(txtRadio.Text, out double radio))
            {
                valido = false;
                errorProvider1.SetError(txtRadio, "Numero mal Ingreado");
            }
            else if (radio <= 0)
            {
                valido = false;
                errorProvider1.SetError(txtRadio, "El numero no puede ser menor o igual 0");
            }

            return valido;
        }

    }
}

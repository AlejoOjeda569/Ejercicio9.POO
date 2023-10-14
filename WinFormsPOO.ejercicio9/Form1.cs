using ArrayCircunferencia.Utilidades;
using ClassCircunferenciaDatos;
using Microsoft.VisualBasic;


namespace WinFormsPOO.ejercicio9
{
    public partial class Form1 : Form
    {

        private ReprositorioCirculos repo;


        public Form1()
        {
            InitializeComponent();
            repo = new ReprositorioCirculos();
            txtCantidad.Text = repo.GetCantidad().ToString();
        }



        private void tbsSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmCirculoAE frm = new frmCirculoAE() { Text = "Agregar Circulo" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            Circunferencia circulo = frm.GetCirculo();
            repo.Agregar(circulo);
            txtCantidad.Text=repo.GetCantidad().ToString();
            DataGridViewRow r = contruirFilas();
            stearFila(r, circulo);
            AgregarFila(r);
            MessageBox.Show("Registro Agregado", "Mensaje", MessageBoxButtons.OK);
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void stearFila(DataGridViewRow r, Circunferencia circulo)
        {
            r.Cells[Colradio.Index].Value = circulo.GetRadio();
            r.Cells[ColArea.Index].Value = circulo.GetArea();
            r.Cells[ColPerimetro.Index].Value = circulo.GetPerimetro();

            r.Tag = circulo;

        }


        private DataGridViewRow contruirFilas()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("¿Desea dar de baja el Circulo?",
                "Confirmar Baja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }
            var filaseleccionada = dgvDatos.SelectedRows[0];
            Circunferencia circulo = filaseleccionada.Tag as Circunferencia;
            repo.Borrar(circulo);
            txtCantidad.Text = repo.GetCantidad().ToString();
            quitarFila(filaseleccionada);
            MessageBox.Show("Registro borrado", "Mensaje", MessageBoxButtons.OK,
    MessageBoxIcon.Information);


        }
        private void quitarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Remove(r);
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var filaseleccionada = dgvDatos.SelectedRows[0];
            Circunferencia circulo = (Circunferencia)filaseleccionada.Tag;
            frmCirculoAE frm = new frmCirculoAE() { Text = "Editar Circulo" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            circulo = frm.GetCirculo();
            stearFila(filaseleccionada, circulo);
            MessageBox.Show("Registro Editado", "Mensaje", MessageBoxButtons.OK,
            MessageBoxIcon.Information);

        }

        private void tsbFiltar_Click(object sender, EventArgs e)
        {

        }
    }
}
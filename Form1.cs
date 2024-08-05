namespace GestionTareasPendientes1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            var Tarea = txtTarea.Text;

            if (Tarea != "")
            {
                lstTareas.Items.Add(Tarea);
                limpiarCaja();
            }
            else
            {
                MessageBox.Show("Complete la casilla");
            }
        }
        private void limpiarCaja()
        {
            txtTarea.Text = "";

        }
        private void lstTareas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTarea_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            if (lstTareas.SelectedIndex != -1)
            {
                DialogResult dialogresult =
                    MessageBox.Show("Esta Seguro que desea eliminar?", "Tarea",
                    MessageBoxButtons.YesNo);
                if (dialogresult == DialogResult.Yes)
                {

                    lstTareas.Items.RemoveAt(lstTareas.SelectedIndex);
                    MessageBox.Show("Se elimino con exito!");
                }
                else
                {
                    MessageBox.Show("Se cancelo la operacion");
                }
            }
            else
            {
                MessageBox.Show("Selecciones un item de la lista");
            }
        }
    }
}

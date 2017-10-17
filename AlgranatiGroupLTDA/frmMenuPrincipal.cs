using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlgranatiGroupLTDA.Logica;

namespace AlgranatiGroupLTDA
{    
    public partial class frmMenuPrincipal : Form
    {
        //public static List<Plato> listaPlatos = Logica.Plato.CargarPlatos();
        //public static List<Mesa> listaMesas = Logica.Mesa.CargarMesas();        

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.ToShortDateString();
            Persistencia.CargarPersistencia();
            dgvMesas.DataSource = Persistencia.colMesas;
            foreach (Mesa me in Persistencia.colMesas)
            {
                if (me.estado=="Disponible")
                {
                    dgvMesas.Rows[me.numero - 1].DefaultCellStyle.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    dgvMesas.Rows[me.numero - 1].DefaultCellStyle.BackColor = System.Drawing.Color.DarkRed;
                }
            }
        } //Carga las mesas con su respectivos datos

        private void dgvMesas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {                
                if (e.RowIndex != -1)
                {
                    int numero = int.Parse(dgvMesas[0, e.RowIndex].Value.ToString());
                    foreach (Mesa me in Persistencia.colMesas)
                    {
                        if (me.numero == numero)
                        {
                            frmPedido frm = new frmPedido();
                            Persistencia.mesaSeleccionada = me;
                            frm.Show();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando las mesas", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } //Abre un nuevo form de pedido con los datos de la mesa

        private void frmMenuPrincipal_Activated(object sender, EventArgs e)
        {
            dgvMesas.DataSource = Persistencia.colMesas;
            foreach (Mesa me in Persistencia.colMesas)
            {
                if (me.estado == "Disponible")
                {
                    dgvMesas.Rows[me.numero - 1].DefaultCellStyle.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    dgvMesas.Rows[me.numero - 1].DefaultCellStyle.BackColor = System.Drawing.Color.DarkRed;
                }
            }
        } //Se activa cuando vuelve del menu de pedido y refresca la lista de mesas

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMPlatos frmABMP = new frmABMPlatos();
            frmABMP.ShowDialog();
        } //Abre el mantenimiento de Platos
    }
}

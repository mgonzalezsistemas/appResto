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
    public partial class frmSeleccionarPlato : Form
    {       
        public frmSeleccionarPlato()
        {
            InitializeComponent();
        }

        private void frmSeleccionarPlato_Load(object sender, EventArgs e)
        {
            dgvPlato.DataSource = Persistencia.listaPlatos;
        } //Carga la lista de los platos

        private void dgvPlato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int id = int.Parse(dgvPlato[0, e.RowIndex].Value.ToString());
                foreach (Plato p in Persistencia.listaPlatos)
                {
                    if (p.id == id)
                    {
                        Persistencia.mesaSeleccionada.pedidoMesa.listaPlatos.Add(p);
                        frmPedido frm = new frmPedido();
                        frm.Show();
                        this.Close();
                    }
                }
            }
        } //Selecciona el plato y lo agrega al pedido de la mesa
    }
}

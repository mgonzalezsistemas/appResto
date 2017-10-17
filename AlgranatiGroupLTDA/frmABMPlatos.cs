using AlgranatiGroupLTDA.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgranatiGroupLTDA
{
    public partial class frmABMPlatos : Form
    {
        public frmABMPlatos()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != "")
                {
                    if (txtPrecio.Text != "")
                    {
                        string nombre = txtNombre.Text;
                        double precio = double.Parse(txtPrecio.Text);
                        Plato p = new Plato(0, nombre, "", precio);
                        Persistencia.AgregarPlato(p);
                        MessageBox.Show("Se ingreso el Plato correctamente!", "Nuevo Plato", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Restauro boxs
                        txtNombre.Text = "";
                        txtPrecio.Text = "";
                        lblidResultado.Text = "?";
                        btnEliminar.Enabled = false;
                        btnModificar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar el precio para el Plato!", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar el nombre para el Plato!", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo ingresar el Plato!", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } //Ingresa un nuevo Plato 

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != "")
                {
                    if (txtPrecio.Text != "")
                    {
                        string nombre = txtNombre.Text;
                        double precio = double.Parse(txtPrecio.Text);
                        int id = int.Parse(lblidResultado.Text);
                        Plato p = new Plato(id, nombre, "", precio);
                        Persistencia.ModificarPlato(p);
                        MessageBox.Show("Se modifico el Plato correctamente!", "Modificar Plato", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Restauro boxs
                        txtNombre.Text = "";
                        txtPrecio.Text = "";
                        lblidResultado.Text = "?";
                        btnEliminar.Enabled = false;
                        btnModificar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar el precio para el Plato!", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar el nombre para el Plato!", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar el Plato!", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } //Modifica un plato existente

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Plato p= Persistencia.BuscarPlatos(txtNombre.Text);
                txtNombre.Text = p.nombre;
                txtPrecio.Text = p.precio.ToString();
                lblidResultado.Text = p.id.ToString();
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                btnIngresar.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se encontro el Plato!", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } //Buscar un palto existente

        private void frmABMPlatos_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;            
        } //Carga el form

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Persistencia.EliminarPlato(int.Parse(lblidResultado.Text));

                //Restauro boxs
                txtNombre.Text = "";
                txtPrecio.Text = "";
                lblidResultado.Text = "?";
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el Plato!", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } //Elimina un plato

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        } //Vuleve al menu Princial
    }
}

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
using ImprimirTicket;

namespace AlgranatiGroupLTDA
{
    public partial class frmPedido : Form
    {            
        public frmPedido()
        {
            InitializeComponent();
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.ToShortDateString();
            if (Persistencia.mesaSeleccionada.estado == "Disponible")
            {
                //Primera vez que se habre el plato Disponible
                btnCerrarMesa.Enabled = false;
                lblMesa.Text = "Mesa N°: " + Persistencia.mesaSeleccionada.numero.ToString();
                txtMesero.Enabled = true;
                txtCliente.Enabled = true;
                txtPaga.Enabled = false;
                txtRut.Enabled = false;
            }
            if(Persistencia.mesaSeleccionada.pedidoMesa.listaPlatos.Count>0)//Si existen platos en el pedido
            {
                if (Persistencia.mesaSeleccionada.estado == "Ocupada") // Cuando ya se ingreso el pedido
                {
                    btnIngresarPedido.Enabled = false;
                    txtPaga.Enabled = true;
                    txtRut.Enabled = true;
                    txtCliente.Enabled = false;
                    txtMesero.Enabled = false;
                }
                else //Cuando hay platos pero no se ingreso el pedido
                {
                    btnIngresarPedido.Enabled = true;
                    txtRut.Enabled = false;
                    btnCerrarMesa.Enabled = false;
                    txtMesero.Enabled = true;
                    txtCliente.Enabled = true;
                    txtPaga.Enabled = false;
                }
                
                //Controla btn, txt y lbl                                                
                txtCliente.Text = Persistencia.mesaSeleccionada.cliente;
                txtMesero.Text = Persistencia.mesaSeleccionada.mesero;
                lblMesa.Text = "Mesa N°: " + Persistencia.mesaSeleccionada.numero.ToString();
                dgvPlato.DataSource = Persistencia.mesaSeleccionada.pedidoMesa.listaPlatos;                

                //Controla dgv y totales
                double subtotal = 0;
                foreach (Plato p in Persistencia.mesaSeleccionada.pedidoMesa.listaPlatos)
                {
                    subtotal += p.precio;
                }
                lblSubTotal.Text = "Sub-Total: $" + subtotal.ToString();
                double iva = subtotal * 0.22;
                double total = subtotal + iva;
                lblIva.Text = "IVA: $" + iva.ToString();
                lblTotal.Text = total.ToString();

            }
            else //Cuando no hay platos en el pedido
            {
                btnIngresarPedido.Enabled = false;
                txtPaga.Enabled = false;
                txtMesero.Enabled = false;
                btnCerrarMesa.Enabled = false;
                txtCliente.Enabled = false;
                txtRut.Enabled = false;
            }
        } //Carga el pedido seleccionado y muestra los datos

        private void btnVolver_Click(object sender, EventArgs e)
        {
            for(int i = 0; i<Persistencia.colMesas.Count-1; i++)
            {
                if(Persistencia.colMesas[i].numero == Persistencia.mesaSeleccionada.numero)
                {
                    Persistencia.colMesas[i] = Persistencia.mesaSeleccionada;                    
                    this.Close();
                }
            }
        } //Vuelve al menu principal 

        private void btnSelPlato_Click(object sender, EventArgs e)
        {
            try
            {
                frmSeleccionarPlato frmSP = new frmSeleccionarPlato();
                frmSP.Show();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error cargando los platos", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } //Habre un nuevo form para selecionar un plato

        private void btnCerrarMesa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPaga.Text != "")
                {
                    if (double.Parse(lblTotal.Text) < double.Parse(txtPaga.Text))
                    {
                        imprimirTicket(Persistencia.mesaSeleccionada, double.Parse(txtPaga.Text));
                        Persistencia.mesaSeleccionada.cliente = "";
                        Persistencia.mesaSeleccionada.estado = "Disponible";
                        Persistencia.mesaSeleccionada.mesero = "";
                        Persistencia.mesaSeleccionada.pedidoMesa.listaPlatos.Clear();
                        Persistencia.mesaSeleccionada.pedidoMesa.numero = 0;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un abono mayor al total!", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar con cuanto abona el cliente!", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error imprimiendo el ticket de cierre!", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } //Cierra la mesa liberando el estado y llama a imprimirTicket 

        private void imprimirTicket(Mesa pMesaSeleccioanda,double pagaCon)
        {
            //Controla dgv y totales            
            double subtotal = 0;            
            foreach (Plato p in pMesaSeleccioanda.pedidoMesa.listaPlatos)
            {
                subtotal += p.precio;
            }            
            double iva = subtotal * 0.22;
            double total = subtotal + iva;
            double resto = pagaCon - total;
            MessageBox.Show("El cambio para el cliente es: $"+resto.ToString(), "Imprimiendo Ticket...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CrearTicket ticket = new CrearTicket();

            //Crear cuerpo del ticket
            CrearTicket nuvoTicket = new CrearTicket();

            nuvoTicket.AbrirCajon();

            //Datos de  la Empresa
            nuvoTicket.TextoCentro("ALGRANATI GROUP LTDA.");
            nuvoTicket.TextoCentro("Rut: 123456879012");
            nuvoTicket.TextoCentro("Direccion: Roque Graseras 694.");
            nuvoTicket.TextoCentro("Ubicacion: Montevideo, Uruguay.");
            nuvoTicket.TextoCentro("Telefono: 2710 2269.");
            nuvoTicket.LineasAsteriscos();

            //Datos del ticket
            nuvoTicket.TextoIzquierda("Fecha: " + lblFecha.Text);
            nuvoTicket.TextoIzquierda("Numero de ticket: " + Persistencia.numeroTicket.ToString());
            nuvoTicket.TextoIzquierda("Nombre cliente: " + pMesaSeleccioanda.cliente);
            if (txtRut.Text != "")
                nuvoTicket.TextoIzquierda("Rut cliente: " + txtRut.Text);

            nuvoTicket.TextoIzquierda("Atendido por: " + pMesaSeleccioanda.mesero);

            //Datos de los platos
            nuvoTicket.LineasGuion();
            nuvoTicket.EcabezadoPlatos();
            nuvoTicket.LineasGuion();
                        
            foreach (Plato p in pMesaSeleccioanda.pedidoMesa.listaPlatos)
            {                
                nuvoTicket.AgregarPlato(p.nombre, 1, p.precio, 0);                
            }
            nuvoTicket.LineasIgual();

            //Resumen de la venta 
            nuvoTicket.ColocarTotales("SUB-TOTAL: ", subtotal);
            nuvoTicket.ColocarTotales("IVA: ", subtotal * 22 / 100);            
            nuvoTicket.ColocarTotales("TOTAL: ", total);
            nuvoTicket.ColocarTotales("PAGA CON: ", double.Parse(txtPaga.Text));
            if (double.Parse(txtPaga.Text) < total)
            {
                MessageBox.Show("Se debe pagar con un monto mayor al total!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw new Exception("Se debe pagar con un monto mayor al total!");
            }
            nuvoTicket.ColocarTotales("CAMBIO: ", double.Parse(txtPaga.Text) - total);

            //Texto final de ticket
            nuvoTicket.LineasAsteriscos();
            nuvoTicket.TextoCentro("GRACIAS POR SU PREFERENCIA!");
            nuvoTicket.LineasAsteriscos();
            nuvoTicket.CortarTicket();
            nuvoTicket.ImprimirTicket("Microsoft XPS Document Writer");
            Persistencia.numeroTicket++;
        } //Genera el ticket y lo manda a la impresora

        private void btnIngresarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCliente.Text == "")
                {

                    MessageBox.Show("Debe ingresar un CLiente!", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtMesero.Text == "")
                    {
                        MessageBox.Show("Debe ingresar un mesero", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (Persistencia.mesaSeleccionada.pedidoMesa.listaPlatos.Count > 0)
                        {
                            Persistencia.mesaSeleccionada.estado = "Ocupada";
                            Persistencia.mesaSeleccionada.mesero = txtMesero.Text;
                            Persistencia.mesaSeleccionada.cliente = txtCliente.Text;

                            MessageBox.Show("Se ingreso el pedido correctamente", "NUEVO PEDIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error ingresando el pedido!", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } //Ingresa un nuevo pedido y regresa al menu principal

        private void dgvPlato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    int id = int.Parse(dgvPlato[0, e.RowIndex].Value.ToString());
                    Plato plato = new Plato();
                    foreach (Plato p in Persistencia.mesaSeleccionada.pedidoMesa.listaPlatos)
                    {
                        if (p.id == id)
                        {
                            plato = p;
                        }
                    }

                    Persistencia.mesaSeleccionada.pedidoMesa.listaPlatos.Remove(plato);
                    frmPedido frmP = new frmPedido();
                    this.Close();
                    frmP.Show();                                      
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error cargando los paltos", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        } //Elimina un plato de la lista        
    }
}

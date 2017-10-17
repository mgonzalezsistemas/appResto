namespace AlgranatiGroupLTDA
{
    partial class frmPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMesa = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.btnSelPlato = new System.Windows.Forms.Button();
            this.btnIngresarPedido = new System.Windows.Forms.Button();
            this.btnCerrarMesa = new System.Windows.Forms.Button();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dgvPlato = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMesero = new System.Windows.Forms.Label();
            this.txtMesero = new System.Windows.Forms.TextBox();
            this.txtPaga = new System.Windows.Forms.TextBox();
            this.lblPaga = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTituloTotal = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlato)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesa.Location = new System.Drawing.Point(191, 9);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(111, 27);
            this.lblMesa.TabIndex = 1;
            this.lblMesa.Text = "Mesa N°: ";
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.Location = new System.Drawing.Point(9, 62);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(113, 19);
            this.lblPedido.TabIndex = 2;
            this.lblPedido.Text = "Lista de Pedido:";
            // 
            // btnSelPlato
            // 
            this.btnSelPlato.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelPlato.Location = new System.Drawing.Point(404, 85);
            this.btnSelPlato.Name = "btnSelPlato";
            this.btnSelPlato.Size = new System.Drawing.Size(75, 49);
            this.btnSelPlato.TabIndex = 3;
            this.btnSelPlato.Text = "Agregar Plato";
            this.btnSelPlato.UseVisualStyleBackColor = true;
            this.btnSelPlato.Click += new System.EventHandler(this.btnSelPlato_Click);
            // 
            // btnIngresarPedido
            // 
            this.btnIngresarPedido.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarPedido.Location = new System.Drawing.Point(531, 85);
            this.btnIngresarPedido.Name = "btnIngresarPedido";
            this.btnIngresarPedido.Size = new System.Drawing.Size(75, 49);
            this.btnIngresarPedido.TabIndex = 4;
            this.btnIngresarPedido.Text = "Ingresar Pedido";
            this.btnIngresarPedido.UseVisualStyleBackColor = true;
            this.btnIngresarPedido.Click += new System.EventHandler(this.btnIngresarPedido_Click);
            // 
            // btnCerrarMesa
            // 
            this.btnCerrarMesa.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarMesa.Location = new System.Drawing.Point(653, 85);
            this.btnCerrarMesa.Name = "btnCerrarMesa";
            this.btnCerrarMesa.Size = new System.Drawing.Size(75, 49);
            this.btnCerrarMesa.TabIndex = 5;
            this.btnCerrarMesa.Text = "Cerrar Mesa";
            this.btnCerrarMesa.UseVisualStyleBackColor = true;
            this.btnCerrarMesa.Click += new System.EventHandler(this.btnCerrarMesa_Click);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(388, 339);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(106, 26);
            this.lblSubTotal.TabIndex = 6;
            this.lblSubTotal.Text = "Sub-Total:";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.Location = new System.Drawing.Point(441, 366);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(53, 26);
            this.lblIva.TabIndex = 7;
            this.lblIva.Text = "IVA:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(511, 394);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(20, 27);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = ".";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(701, 394);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 49);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dgvPlato
            // 
            this.dgvPlato.AllowUserToAddRows = false;
            this.dgvPlato.AllowUserToDeleteRows = false;
            this.dgvPlato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Observacion,
            this.Precio});
            this.dgvPlato.Location = new System.Drawing.Point(12, 85);
            this.dgvPlato.Name = "dgvPlato";
            this.dgvPlato.ReadOnly = true;
            this.dgvPlato.Size = new System.Drawing.Size(346, 358);
            this.dgvPlato.TabIndex = 10;
            this.dgvPlato.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlato_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 300;
            // 
            // Observacion
            // 
            this.Observacion.DataPropertyName = "descripcion";
            this.Observacion.HeaderText = "Observacion";
            this.Observacion.Name = "Observacion";
            this.Observacion.ReadOnly = true;
            this.Observacion.Visible = false;
            this.Observacion.Width = 300;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Visible = false;
            // 
            // lblMesero
            // 
            this.lblMesero.AutoSize = true;
            this.lblMesero.Location = new System.Drawing.Point(382, 154);
            this.lblMesero.Name = "lblMesero";
            this.lblMesero.Size = new System.Drawing.Size(42, 13);
            this.lblMesero.TabIndex = 11;
            this.lblMesero.Text = "Mesero";
            // 
            // txtMesero
            // 
            this.txtMesero.Location = new System.Drawing.Point(385, 171);
            this.txtMesero.MaxLength = 20;
            this.txtMesero.Name = "txtMesero";
            this.txtMesero.Size = new System.Drawing.Size(182, 20);
            this.txtMesero.TabIndex = 12;
            // 
            // txtPaga
            // 
            this.txtPaga.Location = new System.Drawing.Point(485, 298);
            this.txtPaga.Name = "txtPaga";
            this.txtPaga.Size = new System.Drawing.Size(72, 20);
            this.txtPaga.TabIndex = 14;
            // 
            // lblPaga
            // 
            this.lblPaga.AutoSize = true;
            this.lblPaga.Location = new System.Drawing.Point(423, 301);
            this.lblPaga.Name = "lblPaga";
            this.lblPaga.Size = new System.Drawing.Size(53, 13);
            this.lblPaga.TabIndex = 13;
            this.lblPaga.Text = "Paga con";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(385, 220);
            this.txtCliente.MaxLength = 20;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(182, 20);
            this.txtCliente.TabIndex = 16;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(382, 203);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 15;
            this.lblCliente.Text = "Cliente";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFecha.Location = new System.Drawing.Point(531, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(48, 13);
            this.lblFecha.TabIndex = 17;
            this.lblFecha.Text = "FECHA: ";
            // 
            // lblTituloTotal
            // 
            this.lblTituloTotal.AutoSize = true;
            this.lblTituloTotal.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTotal.Location = new System.Drawing.Point(427, 394);
            this.lblTituloTotal.Name = "lblTituloTotal";
            this.lblTituloTotal.Size = new System.Drawing.Size(89, 27);
            this.lblTituloTotal.TabIndex = 18;
            this.lblTituloTotal.Text = "Total: $";
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(593, 220);
            this.txtRut.MaxLength = 12;
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(199, 20);
            this.txtRut.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(592, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Rut";
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 477);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTituloTotal);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtPaga);
            this.Controls.Add(this.lblPaga);
            this.Controls.Add(this.txtMesero);
            this.Controls.Add(this.lblMesero);
            this.Controls.Add(this.dgvPlato);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblIva);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.btnCerrarMesa);
            this.Controls.Add(this.btnIngresarPedido);
            this.Controls.Add(this.btnSelPlato);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.lblMesa);
            this.Location = new System.Drawing.Point(300, 300);
            this.MaximizeBox = false;
            this.Name = "frmPedido";
            this.Text = " Pedido -- Algranati Group Ltda.";
            this.Load += new System.EventHandler(this.frmPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Button btnSelPlato;
        private System.Windows.Forms.Button btnIngresarPedido;
        private System.Windows.Forms.Button btnCerrarMesa;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dgvPlato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label lblMesero;
        private System.Windows.Forms.TextBox txtMesero;
        private System.Windows.Forms.TextBox txtPaga;
        private System.Windows.Forms.Label lblPaga;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTituloTotal;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Label label1;
    }
}
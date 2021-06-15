namespace SalonBellezaIU
{
	partial class CITASUI
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
			this.grdCita = new System.Windows.Forms.DataGridView();
			this.lblRegistrarCliente = new System.Windows.Forms.Label();
			this.txtBusqueda = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtClienteId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtCorreo = new System.Windows.Forms.TextBox();
			this.lblCita = new System.Windows.Forms.Label();
			this.labelServicio = new System.Windows.Forms.Label();
			this.lblFecha = new System.Windows.Forms.Label();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnEnviarCorreo = new System.Windows.Forms.Button();
			this.lblEstatus = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.cboBusqueda = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.cboServicios = new System.Windows.Forms.ComboBox();
			this.txtCitaId = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cboEstatu = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.grdCita)).BeginInit();
			this.SuspendLayout();
			// 
			// grdCita
			// 
			this.grdCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdCita.Location = new System.Drawing.Point(12, 311);
			this.grdCita.Name = "grdCita";
			this.grdCita.Size = new System.Drawing.Size(776, 139);
			this.grdCita.TabIndex = 12;
			this.grdCita.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCita_CellContentClick);
			// 
			// lblRegistrarCliente
			// 
			this.lblRegistrarCliente.AutoSize = true;
			this.lblRegistrarCliente.Location = new System.Drawing.Point(16, 9);
			this.lblRegistrarCliente.Name = "lblRegistrarCliente";
			this.lblRegistrarCliente.Size = new System.Drawing.Size(70, 13);
			this.lblRegistrarCliente.TabIndex = 38;
			this.lblRegistrarCliente.Text = "Registrar Cita";
			// 
			// txtBusqueda
			// 
			this.txtBusqueda.Location = new System.Drawing.Point(89, 40);
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Size = new System.Drawing.Size(203, 20);
			this.txtBusqueda.TabIndex = 39;
			this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(5, 40);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(78, 13);
			this.label12.TabIndex = 40;
			this.label12.Text = "Buscar  Cliente";
			// 
			// txtClienteId
			// 
			this.txtClienteId.Enabled = false;
			this.txtClienteId.Location = new System.Drawing.Point(79, 69);
			this.txtClienteId.Name = "txtClienteId";
			this.txtClienteId.Size = new System.Drawing.Size(100, 20);
			this.txtClienteId.TabIndex = 41;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 42;
			this.label1.Text = "ID Cliente";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(190, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 43;
			this.label2.Text = "Nombre";
			// 
			// txtNombre
			// 
			this.txtNombre.Enabled = false;
			this.txtNombre.Location = new System.Drawing.Point(240, 73);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(251, 20);
			this.txtNombre.TabIndex = 44;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(21, 99);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 45;
			this.label4.Text = "Direccion";
			// 
			// txtDireccion
			// 
			this.txtDireccion.Enabled = false;
			this.txtDireccion.Location = new System.Drawing.Point(79, 96);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(158, 20);
			this.txtDireccion.TabIndex = 46;
			this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(497, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 47;
			this.label3.Text = "Apellido";
			// 
			// txtApellido
			// 
			this.txtApellido.Enabled = false;
			this.txtApellido.Location = new System.Drawing.Point(547, 72);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(241, 20);
			this.txtApellido.TabIndex = 48;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(256, 103);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 13);
			this.label6.TabIndex = 49;
			this.label6.Text = "Telefono";
			// 
			// txtTelefono
			// 
			this.txtTelefono.Enabled = false;
			this.txtTelefono.Location = new System.Drawing.Point(311, 99);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(158, 20);
			this.txtTelefono.TabIndex = 50;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(24, 124);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(38, 13);
			this.label7.TabIndex = 51;
			this.label7.Text = "Correo";
			// 
			// txtCorreo
			// 
			this.txtCorreo.Enabled = false;
			this.txtCorreo.Location = new System.Drawing.Point(79, 121);
			this.txtCorreo.Name = "txtCorreo";
			this.txtCorreo.Size = new System.Drawing.Size(310, 20);
			this.txtCorreo.TabIndex = 52;
			// 
			// lblCita
			// 
			this.lblCita.AutoSize = true;
			this.lblCita.Location = new System.Drawing.Point(58, 9);
			this.lblCita.Name = "lblCita";
			this.lblCita.Size = new System.Drawing.Size(25, 13);
			this.lblCita.TabIndex = 53;
			this.lblCita.Text = "Cita";
			// 
			// labelServicio
			// 
			this.labelServicio.AutoSize = true;
			this.labelServicio.Location = new System.Drawing.Point(21, 148);
			this.labelServicio.Name = "labelServicio";
			this.labelServicio.Size = new System.Drawing.Size(45, 13);
			this.labelServicio.TabIndex = 55;
			this.labelServicio.Text = "Servicio";
			// 
			// lblFecha
			// 
			this.lblFecha.AutoSize = true;
			this.lblFecha.Location = new System.Drawing.Point(270, 148);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(71, 13);
			this.lblFecha.TabIndex = 56;
			this.lblFecha.Text = "Fecha y Hora";
			// 
			// dtpFecha
			// 
			this.dtpFecha.Location = new System.Drawing.Point(347, 145);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(200, 20);
			this.dtpFecha.TabIndex = 57;
			// 
			// btnNuevo
			// 
			this.btnNuevo.Location = new System.Drawing.Point(621, 9);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(75, 23);
			this.btnNuevo.TabIndex = 60;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(713, 9);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 61;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(121, 214);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 62;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnActualizar
			// 
			this.btnActualizar.Location = new System.Drawing.Point(17, 214);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(75, 23);
			this.btnActualizar.TabIndex = 63;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = true;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// btnEnviarCorreo
			// 
			this.btnEnviarCorreo.Location = new System.Drawing.Point(226, 214);
			this.btnEnviarCorreo.Name = "btnEnviarCorreo";
			this.btnEnviarCorreo.Size = new System.Drawing.Size(84, 23);
			this.btnEnviarCorreo.TabIndex = 64;
			this.btnEnviarCorreo.Text = "Enviar Correo";
			this.btnEnviarCorreo.UseVisualStyleBackColor = true;
			this.btnEnviarCorreo.Click += new System.EventHandler(this.btnEnviarCorreo_Click);
			// 
			// lblEstatus
			// 
			this.lblEstatus.AutoSize = true;
			this.lblEstatus.Location = new System.Drawing.Point(24, 180);
			this.lblEstatus.Name = "lblEstatus";
			this.lblEstatus.Size = new System.Drawing.Size(42, 13);
			this.lblEstatus.TabIndex = 65;
			this.lblEstatus.Text = "Estatus";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(609, 204);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(148, 13);
			this.label15.TabIndex = 68;
			this.label15.Text = "Seleccione tipo de busqueda:";
			// 
			// cboBusqueda
			// 
			this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboBusqueda.FormattingEnabled = true;
			this.cboBusqueda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboBusqueda.Location = new System.Drawing.Point(585, 230);
			this.cboBusqueda.Name = "cboBusqueda";
			this.cboBusqueda.Size = new System.Drawing.Size(203, 21);
			this.cboBusqueda.TabIndex = 69;
			this.cboBusqueda.SelectedIndexChanged += new System.EventHandler(this.cboBusqueda_SelectedIndexChanged);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(585, 257);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(203, 20);
			this.textBox1.TabIndex = 70;
			// 
			// btnConsultar
			// 
			this.btnConsultar.Location = new System.Drawing.Point(649, 283);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(75, 23);
			this.btnConsultar.TabIndex = 71;
			this.btnConsultar.Text = "Consultar";
			this.btnConsultar.UseVisualStyleBackColor = true;
			this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(528, 260);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(40, 13);
			this.label11.TabIndex = 72;
			this.label11.Text = "Buscar";
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(335, 214);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(75, 23);
			this.btnGuardar.TabIndex = 73;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// cboServicios
			// 
			this.cboServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboServicios.FormattingEnabled = true;
			this.cboServicios.Location = new System.Drawing.Point(79, 144);
			this.cboServicios.Name = "cboServicios";
			this.cboServicios.Size = new System.Drawing.Size(185, 21);
			this.cboServicios.TabIndex = 74;
			this.cboServicios.SelectedIndexChanged += new System.EventHandler(this.cboServicios_SelectedIndexChanged);
			// 
			// txtCitaId
			// 
			this.txtCitaId.Location = new System.Drawing.Point(113, 9);
			this.txtCitaId.Name = "txtCitaId";
			this.txtCitaId.Size = new System.Drawing.Size(100, 20);
			this.txtCitaId.TabIndex = 75;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(89, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(18, 13);
			this.label5.TabIndex = 76;
			this.label5.Text = "ID";
			// 
			// cboEstatu
			// 
			this.cboEstatu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboEstatu.FormattingEnabled = true;
			this.cboEstatu.Location = new System.Drawing.Point(79, 172);
			this.cboEstatu.Name = "cboEstatu";
			this.cboEstatu.Size = new System.Drawing.Size(185, 21);
			this.cboEstatu.TabIndex = 77;
			this.cboEstatu.SelectedIndexChanged += new System.EventHandler(this.cboEstatu_SelectedIndexChanged);
			// 
			// CITASUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cboEstatu);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtCitaId);
			this.Controls.Add(this.cboServicios);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.btnConsultar);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.cboBusqueda);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.lblEstatus);
			this.Controls.Add(this.btnEnviarCorreo);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.lblFecha);
			this.Controls.Add(this.labelServicio);
			this.Controls.Add(this.lblCita);
			this.Controls.Add(this.txtCorreo);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtClienteId);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtBusqueda);
			this.Controls.Add(this.lblRegistrarCliente);
			this.Controls.Add(this.grdCita);
			this.Name = "CITASUI";
			this.Text = "CITASUI";
			this.Load += new System.EventHandler(this.CITASUI_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdCita)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView grdCita;
		private System.Windows.Forms.Label lblRegistrarCliente;
		private System.Windows.Forms.TextBox txtBusqueda;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtClienteId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtCorreo;
		private System.Windows.Forms.Label lblCita;
		private System.Windows.Forms.Label labelServicio;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Button btnEnviarCorreo;
		private System.Windows.Forms.Label lblEstatus;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.ComboBox cboBusqueda;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.ComboBox cboServicios;
		private System.Windows.Forms.TextBox txtCitaId;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cboEstatu;
	}
}
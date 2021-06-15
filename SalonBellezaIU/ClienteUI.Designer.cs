namespace SalonBellezaIU
{
	partial class ClienteUI
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
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.txtEdad = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.txtCorreo = new System.Windows.Forms.TextBox();
			this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
			this.cboGenero = new System.Windows.Forms.ComboBox();
			this.grdClientes = new System.Windows.Forms.DataGridView();
			this.btnActualizarCliente = new System.Windows.Forms.Button();
			this.btnGuardarCliente = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.lblCliente = new System.Windows.Forms.Label();
			this.btnEliminarCliente = new System.Windows.Forms.Button();
			this.txtId = new System.Windows.Forms.TextBox();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.txtBusqueda = new System.Windows.Forms.TextBox();
			this.cboBusqueda = new System.Windows.Forms.ComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.lblRegistrarCliente = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNombre
			// 
			this.txtNombre.Enabled = false;
			this.txtNombre.Location = new System.Drawing.Point(78, 60);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(310, 20);
			this.txtNombre.TabIndex = 1;
			// 
			// txtApellido
			// 
			this.txtApellido.Enabled = false;
			this.txtApellido.Location = new System.Drawing.Point(78, 89);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(310, 20);
			this.txtApellido.TabIndex = 2;
			// 
			// txtDireccion
			// 
			this.txtDireccion.Enabled = false;
			this.txtDireccion.Location = new System.Drawing.Point(78, 118);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(158, 20);
			this.txtDireccion.TabIndex = 3;
			// 
			// txtEdad
			// 
			this.txtEdad.Enabled = false;
			this.txtEdad.Location = new System.Drawing.Point(78, 144);
			this.txtEdad.Name = "txtEdad";
			this.txtEdad.Size = new System.Drawing.Size(77, 20);
			this.txtEdad.TabIndex = 4;
			// 
			// txtTelefono
			// 
			this.txtTelefono.Enabled = false;
			this.txtTelefono.Location = new System.Drawing.Point(78, 172);
			this.txtTelefono.MaxLength = 10;
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(158, 20);
			this.txtTelefono.TabIndex = 5;
			// 
			// txtCorreo
			// 
			this.txtCorreo.Enabled = false;
			this.txtCorreo.Location = new System.Drawing.Point(78, 198);
			this.txtCorreo.Name = "txtCorreo";
			this.txtCorreo.Size = new System.Drawing.Size(310, 20);
			this.txtCorreo.TabIndex = 6;
			// 
			// dtpBirthday
			// 
			this.dtpBirthday.Enabled = false;
			this.dtpBirthday.Location = new System.Drawing.Point(138, 233);
			this.dtpBirthday.Name = "dtpBirthday";
			this.dtpBirthday.Size = new System.Drawing.Size(200, 20);
			this.dtpBirthday.TabIndex = 7;
			this.dtpBirthday.ValueChanged += new System.EventHandler(this.dtpBirthday_ValueChanged);
			// 
			// cboGenero
			// 
			this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboGenero.Enabled = false;
			this.cboGenero.FormattingEnabled = true;
			this.cboGenero.Location = new System.Drawing.Point(78, 260);
			this.cboGenero.Name = "cboGenero";
			this.cboGenero.Size = new System.Drawing.Size(144, 21);
			this.cboGenero.TabIndex = 9;
			// 
			// grdClientes
			// 
			this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdClientes.Location = new System.Drawing.Point(12, 362);
			this.grdClientes.Name = "grdClientes";
			this.grdClientes.Size = new System.Drawing.Size(776, 139);
			this.grdClientes.TabIndex = 11;
			this.grdClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdClientes_CellContentClick);
			this.grdClientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdClientes_CellContentClick);
			// 
			// btnActualizarCliente
			// 
			this.btnActualizarCliente.Location = new System.Drawing.Point(41, 304);
			this.btnActualizarCliente.Name = "btnActualizarCliente";
			this.btnActualizarCliente.Size = new System.Drawing.Size(107, 23);
			this.btnActualizarCliente.TabIndex = 12;
			this.btnActualizarCliente.Text = "Actualizar ";
			this.btnActualizarCliente.UseVisualStyleBackColor = true;
			this.btnActualizarCliente.Click += new System.EventHandler(this.btnActualizarCliente_Click);
			// 
			// btnGuardarCliente
			// 
			this.btnGuardarCliente.Location = new System.Drawing.Point(41, 304);
			this.btnGuardarCliente.Name = "btnGuardarCliente";
			this.btnGuardarCliente.Size = new System.Drawing.Size(75, 23);
			this.btnGuardarCliente.TabIndex = 14;
			this.btnGuardarCliente.Text = "Guardar";
			this.btnGuardarCliente.UseVisualStyleBackColor = true;
			this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 16;
			this.label2.Text = "Nombre";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 17;
			this.label3.Text = "Apellido";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(19, 118);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 18;
			this.label4.Text = "Direccion";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(19, 144);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 13);
			this.label5.TabIndex = 19;
			this.label5.Text = "Edad";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(21, 175);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 13);
			this.label6.TabIndex = 20;
			this.label6.Text = "Telefono";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(21, 205);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(38, 13);
			this.label7.TabIndex = 21;
			this.label7.Text = "Correo";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(21, 233);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(108, 13);
			this.label8.TabIndex = 22;
			this.label8.Text = "Fecha de Nacimiento";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(19, 260);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(42, 13);
			this.label9.TabIndex = 23;
			this.label9.Text = "Genero";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(16, 299);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(0, 13);
			this.label10.TabIndex = 24;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(12, 348);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(44, 13);
			this.label11.TabIndex = 25;
			this.label11.Text = "Clientes";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(545, 304);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(43, 13);
			this.label12.TabIndex = 26;
			this.label12.Text = "Buscar ";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(640, 233);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(85, 13);
			this.label14.TabIndex = 28;
			this.label14.Text = "Consultar cliente";
			// 
			// lblCliente
			// 
			this.lblCliente.AutoSize = true;
			this.lblCliente.Location = new System.Drawing.Point(20, 9);
			this.lblCliente.Name = "lblCliente";
			this.lblCliente.Size = new System.Drawing.Size(39, 13);
			this.lblCliente.TabIndex = 29;
			this.lblCliente.Text = "Cliente";
			// 
			// btnEliminarCliente
			// 
			this.btnEliminarCliente.Location = new System.Drawing.Point(682, 9);
			this.btnEliminarCliente.Name = "btnEliminarCliente";
			this.btnEliminarCliente.Size = new System.Drawing.Size(91, 23);
			this.btnEliminarCliente.TabIndex = 30;
			this.btnEliminarCliente.Text = "Eliminar ";
			this.btnEliminarCliente.UseVisualStyleBackColor = true;
			this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click_1);
			// 
			// txtId
			// 
			this.txtId.Enabled = false;
			this.txtId.Location = new System.Drawing.Point(78, 34);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(100, 20);
			this.txtId.TabIndex = 31;
			// 
			// btnConsultar
			// 
			this.btnConsultar.Location = new System.Drawing.Point(698, 328);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(75, 23);
			this.btnConsultar.TabIndex = 32;
			this.btnConsultar.Text = "Consultar";
			this.btnConsultar.UseVisualStyleBackColor = true;
			this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.Location = new System.Drawing.Point(585, 9);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(75, 23);
			this.btnNuevo.TabIndex = 33;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// txtBusqueda
			// 
			this.txtBusqueda.Location = new System.Drawing.Point(585, 301);
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Size = new System.Drawing.Size(203, 20);
			this.txtBusqueda.TabIndex = 34;
			this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
			// 
			// cboBusqueda
			// 
			this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboBusqueda.FormattingEnabled = true;
			this.cboBusqueda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboBusqueda.Location = new System.Drawing.Point(585, 275);
			this.cboBusqueda.Name = "cboBusqueda";
			this.cboBusqueda.Size = new System.Drawing.Size(203, 21);
			this.cboBusqueda.TabIndex = 35;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(608, 253);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(148, 13);
			this.label15.TabIndex = 36;
			this.label15.Text = "Seleccione tipo de busqueda:";
			// 
			// lblRegistrarCliente
			// 
			this.lblRegistrarCliente.AutoSize = true;
			this.lblRegistrarCliente.Location = new System.Drawing.Point(135, 9);
			this.lblRegistrarCliente.Name = "lblRegistrarCliente";
			this.lblRegistrarCliente.Size = new System.Drawing.Size(84, 13);
			this.lblRegistrarCliente.TabIndex = 37;
			this.lblRegistrarCliente.Text = "Registrar Cliente";
			// 
			// ClienteUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 503);
			this.Controls.Add(this.lblRegistrarCliente);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.cboBusqueda);
			this.Controls.Add(this.txtBusqueda);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.btnConsultar);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.btnEliminarCliente);
			this.Controls.Add(this.lblCliente);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnGuardarCliente);
			this.Controls.Add(this.btnActualizarCliente);
			this.Controls.Add(this.grdClientes);
			this.Controls.Add(this.cboGenero);
			this.Controls.Add(this.dtpBirthday);
			this.Controls.Add(this.txtCorreo);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.txtEdad);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.txtNombre);
			this.Name = "ClienteUI";
			this.Text = "ClienteUI";
			this.Load += new System.EventHandler(this.ClienteUI_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.TextBox txtEdad;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.TextBox txtCorreo;
		private System.Windows.Forms.DateTimePicker dtpBirthday;
		private System.Windows.Forms.ComboBox cboGenero;
		private System.Windows.Forms.DataGridView grdClientes;
		private System.Windows.Forms.Button btnActualizarCliente;
		private System.Windows.Forms.Button btnGuardarCliente;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label lblCliente;
		private System.Windows.Forms.Button btnEliminarCliente;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.TextBox txtBusqueda;
		private System.Windows.Forms.ComboBox cboBusqueda;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label lblRegistrarCliente;
	}
}
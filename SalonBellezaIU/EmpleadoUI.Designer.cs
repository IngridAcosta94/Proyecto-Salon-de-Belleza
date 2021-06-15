namespace SalonBellezaIU
{
	partial class EmpleadoUI
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
			this.lblRegistrarEmpleao = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.txtEdad = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.txtCorreo = new System.Windows.Forms.TextBox();
			this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
			this.cboGenero = new System.Windows.Forms.ComboBox();
			this.grdEmpleados = new System.Windows.Forms.DataGridView();
			this.btnActualizarEmplead = new System.Windows.Forms.Button();
			this.btnGuardarEmpleado = new System.Windows.Forms.Button();
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
			this.btnConsultar = new System.Windows.Forms.Button();
			this.btnEliminarEmpleado = new System.Windows.Forms.Button();
			this.label15 = new System.Windows.Forms.Label();
			this.cboBusqueda = new System.Windows.Forms.ComboBox();
			this.txtBusqueda = new System.Windows.Forms.TextBox();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.lblEmpleado = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.grdEmpleados)).BeginInit();
			this.SuspendLayout();
			// 
			// lblRegistrarEmpleao
			// 
			this.lblRegistrarEmpleao.AutoSize = true;
			this.lblRegistrarEmpleao.Location = new System.Drawing.Point(15, 9);
			this.lblRegistrarEmpleao.Name = "lblRegistrarEmpleao";
			this.lblRegistrarEmpleao.Size = new System.Drawing.Size(102, 13);
			this.lblRegistrarEmpleao.TabIndex = 0;
			this.lblRegistrarEmpleao.Text = "Registrar  Empleado";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(72, 41);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(89, 20);
			this.txtId.TabIndex = 1;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(72, 67);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(293, 20);
			this.txtNombre.TabIndex = 2;
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(72, 95);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(293, 20);
			this.txtApellido.TabIndex = 3;
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(72, 122);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(169, 20);
			this.txtDireccion.TabIndex = 4;
			// 
			// txtEdad
			// 
			this.txtEdad.Location = new System.Drawing.Point(72, 148);
			this.txtEdad.Name = "txtEdad";
			this.txtEdad.Size = new System.Drawing.Size(100, 20);
			this.txtEdad.TabIndex = 5;
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(72, 174);
			this.txtTelefono.MaxLength = 10;
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(169, 20);
			this.txtTelefono.TabIndex = 6;
			// 
			// txtCorreo
			// 
			this.txtCorreo.Location = new System.Drawing.Point(72, 202);
			this.txtCorreo.Name = "txtCorreo";
			this.txtCorreo.Size = new System.Drawing.Size(293, 20);
			this.txtCorreo.TabIndex = 7;
			// 
			// dtpBirthday
			// 
			this.dtpBirthday.Location = new System.Drawing.Point(114, 235);
			this.dtpBirthday.Name = "dtpBirthday";
			this.dtpBirthday.Size = new System.Drawing.Size(200, 20);
			this.dtpBirthday.TabIndex = 8;
			// 
			// cboGenero
			// 
			this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboGenero.FormattingEnabled = true;
			this.cboGenero.Location = new System.Drawing.Point(72, 265);
			this.cboGenero.Name = "cboGenero";
			this.cboGenero.Size = new System.Drawing.Size(121, 21);
			this.cboGenero.TabIndex = 9;
			// 
			// grdEmpleados
			// 
			this.grdEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdEmpleados.Location = new System.Drawing.Point(12, 367);
			this.grdEmpleados.Name = "grdEmpleados";
			this.grdEmpleados.Size = new System.Drawing.Size(776, 123);
			this.grdEmpleados.TabIndex = 11;
			this.grdEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEmpleados_CellContentClick_1);
			// 
			// btnActualizarEmplead
			// 
			this.btnActualizarEmplead.Location = new System.Drawing.Point(174, 315);
			this.btnActualizarEmplead.Name = "btnActualizarEmplead";
			this.btnActualizarEmplead.Size = new System.Drawing.Size(90, 23);
			this.btnActualizarEmplead.TabIndex = 12;
			this.btnActualizarEmplead.Text = "Actualizar Empleado";
			this.btnActualizarEmplead.UseVisualStyleBackColor = true;
			this.btnActualizarEmplead.Click += new System.EventHandler(this.btnActualizarEmplead_Click);
			// 
			// btnGuardarEmpleado
			// 
			this.btnGuardarEmpleado.Location = new System.Drawing.Point(72, 312);
			this.btnGuardarEmpleado.Name = "btnGuardarEmpleado";
			this.btnGuardarEmpleado.Size = new System.Drawing.Size(75, 23);
			this.btnGuardarEmpleado.TabIndex = 14;
			this.btnGuardarEmpleado.Text = "Guardar";
			this.btnGuardarEmpleado.UseVisualStyleBackColor = true;
			this.btnGuardarEmpleado.Click += new System.EventHandler(this.btnGuardarEmpleado_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(16, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "Id";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 16;
			this.label3.Text = "Nombre";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 101);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "Apellido";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(16, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 13);
			this.label5.TabIndex = 18;
			this.label5.Text = "Dirreccion";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(16, 154);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 13);
			this.label6.TabIndex = 19;
			this.label6.Text = "Edad";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(16, 177);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(49, 13);
			this.label7.TabIndex = 20;
			this.label7.Text = "Telefono";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(16, 205);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(32, 13);
			this.label8.TabIndex = 21;
			this.label8.Text = "Email";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(15, 235);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(93, 13);
			this.label9.TabIndex = 22;
			this.label9.Text = "Fecha Nacimiento";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(14, 265);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(42, 13);
			this.label10.TabIndex = 23;
			this.label10.Text = "Genero";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(498, 315);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(40, 13);
			this.label11.TabIndex = 24;
			this.label11.Text = "Buscar";
			// 
			// btnConsultar
			// 
			this.btnConsultar.Location = new System.Drawing.Point(627, 340);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(75, 23);
			this.btnConsultar.TabIndex = 26;
			this.btnConsultar.Text = "Consultar";
			this.btnConsultar.UseVisualStyleBackColor = true;
			this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click_1);
			// 
			// btnEliminarEmpleado
			// 
			this.btnEliminarEmpleado.Location = new System.Drawing.Point(690, 12);
			this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
			this.btnEliminarEmpleado.Size = new System.Drawing.Size(86, 23);
			this.btnEliminarEmpleado.TabIndex = 27;
			this.btnEliminarEmpleado.Text = "Eliminar ";
			this.btnEliminarEmpleado.UseVisualStyleBackColor = true;
			this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(580, 242);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(148, 13);
			this.label15.TabIndex = 37;
			this.label15.Text = "Seleccione tipo de busqueda:";
			// 
			// cboBusqueda
			// 
			this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboBusqueda.FormattingEnabled = true;
			this.cboBusqueda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboBusqueda.Location = new System.Drawing.Point(561, 275);
			this.cboBusqueda.Name = "cboBusqueda";
			this.cboBusqueda.Size = new System.Drawing.Size(203, 21);
			this.cboBusqueda.TabIndex = 38;
			this.cboBusqueda.SelectedIndexChanged += new System.EventHandler(this.cboBusqueda_SelectedIndexChanged);
			// 
			// txtBusqueda
			// 
			this.txtBusqueda.Location = new System.Drawing.Point(561, 312);
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Size = new System.Drawing.Size(203, 20);
			this.txtBusqueda.TabIndex = 39;
			// 
			// btnNuevo
			// 
			this.btnNuevo.Location = new System.Drawing.Point(595, 12);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(75, 23);
			this.btnNuevo.TabIndex = 40;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
			// 
			// lblEmpleado
			// 
			this.lblEmpleado.AutoSize = true;
			this.lblEmpleado.Location = new System.Drawing.Point(144, 9);
			this.lblEmpleado.Name = "lblEmpleado";
			this.lblEmpleado.Size = new System.Drawing.Size(54, 13);
			this.lblEmpleado.TabIndex = 41;
			this.lblEmpleado.Text = "Empleado";
			// 
			// EmpleadoUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 499);
			this.Controls.Add(this.lblEmpleado);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.txtBusqueda);
			this.Controls.Add(this.cboBusqueda);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.btnEliminarEmpleado);
			this.Controls.Add(this.btnConsultar);
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
			this.Controls.Add(this.btnGuardarEmpleado);
			this.Controls.Add(this.btnActualizarEmplead);
			this.Controls.Add(this.grdEmpleados);
			this.Controls.Add(this.cboGenero);
			this.Controls.Add(this.dtpBirthday);
			this.Controls.Add(this.txtCorreo);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.txtEdad);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.lblRegistrarEmpleao);
			this.Name = "EmpleadoUI";
			this.Text = "EmpleadoUI";
			this.Load += new System.EventHandler(this.EmpleadoUI_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdEmpleados)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblRegistrarEmpleao;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.TextBox txtEdad;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.TextBox txtCorreo;
		private System.Windows.Forms.DateTimePicker dtpBirthday;
		private System.Windows.Forms.ComboBox cboGenero;
		private System.Windows.Forms.DataGridView grdEmpleados;
		private System.Windows.Forms.Button btnActualizarEmplead;
		private System.Windows.Forms.Button btnGuardarEmpleado;
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
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.Button btnEliminarEmpleado;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.ComboBox cboBusqueda;
		private System.Windows.Forms.TextBox txtBusqueda;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Label lblEmpleado;
	}
}
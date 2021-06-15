namespace SalonBellezaIU
{
	partial class EquipoUI
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
			this.label2 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnEliminarCliente = new System.Windows.Forms.Button();
			this.btnGuardarCliente = new System.Windows.Forms.Button();
			this.btnActualizarCliente = new System.Windows.Forms.Button();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.cboBusqueda = new System.Windows.Forms.ComboBox();
			this.txtBusqueda = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.grdClientes = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNombre
			// 
			this.txtNombre.Enabled = false;
			this.txtNombre.Location = new System.Drawing.Point(74, 63);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(310, 20);
			this.txtNombre.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 17;
			this.label2.Text = "Nombre";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// txtId
			// 
			this.txtId.Enabled = false;
			this.txtId.Location = new System.Drawing.Point(74, 37);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(100, 20);
			this.txtId.TabIndex = 32;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 33;
			this.label1.Text = "ID";
			// 
			// btnNuevo
			// 
			this.btnNuevo.Location = new System.Drawing.Point(575, 3);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(75, 23);
			this.btnNuevo.TabIndex = 34;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.UseVisualStyleBackColor = true;
			// 
			// btnEliminarCliente
			// 
			this.btnEliminarCliente.Location = new System.Drawing.Point(668, 3);
			this.btnEliminarCliente.Name = "btnEliminarCliente";
			this.btnEliminarCliente.Size = new System.Drawing.Size(91, 23);
			this.btnEliminarCliente.TabIndex = 35;
			this.btnEliminarCliente.Text = "Eliminar";
			this.btnEliminarCliente.UseVisualStyleBackColor = true;
			// 
			// btnGuardarCliente
			// 
			this.btnGuardarCliente.Location = new System.Drawing.Point(155, 120);
			this.btnGuardarCliente.Name = "btnGuardarCliente";
			this.btnGuardarCliente.Size = new System.Drawing.Size(75, 23);
			this.btnGuardarCliente.TabIndex = 36;
			this.btnGuardarCliente.Text = "Guardar";
			this.btnGuardarCliente.UseVisualStyleBackColor = true;
			// 
			// btnActualizarCliente
			// 
			this.btnActualizarCliente.Location = new System.Drawing.Point(16, 120);
			this.btnActualizarCliente.Name = "btnActualizarCliente";
			this.btnActualizarCliente.Size = new System.Drawing.Size(107, 23);
			this.btnActualizarCliente.TabIndex = 37;
			this.btnActualizarCliente.Text = "Actualizar";
			this.btnActualizarCliente.UseVisualStyleBackColor = true;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(638, 120);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(87, 13);
			this.label14.TabIndex = 38;
			this.label14.Text = "Consultar Equipo";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(611, 133);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(148, 13);
			this.label15.TabIndex = 39;
			this.label15.Text = "Seleccione tipo de busqueda:";
			// 
			// cboBusqueda
			// 
			this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboBusqueda.FormattingEnabled = true;
			this.cboBusqueda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboBusqueda.Location = new System.Drawing.Point(589, 166);
			this.cboBusqueda.Name = "cboBusqueda";
			this.cboBusqueda.Size = new System.Drawing.Size(203, 21);
			this.cboBusqueda.TabIndex = 40;
			// 
			// txtBusqueda
			// 
			this.txtBusqueda.Location = new System.Drawing.Point(589, 193);
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Size = new System.Drawing.Size(203, 20);
			this.txtBusqueda.TabIndex = 41;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(540, 196);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(43, 13);
			this.label12.TabIndex = 42;
			this.label12.Text = "Buscar ";
			// 
			// btnConsultar
			// 
			this.btnConsultar.Location = new System.Drawing.Point(648, 219);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(75, 23);
			this.btnConsultar.TabIndex = 43;
			this.btnConsultar.Text = "Consultar";
			this.btnConsultar.UseVisualStyleBackColor = true;
			// 
			// grdClientes
			// 
			this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdClientes.Location = new System.Drawing.Point(16, 248);
			this.grdClientes.Name = "grdClientes";
			this.grdClientes.Size = new System.Drawing.Size(776, 190);
			this.grdClientes.TabIndex = 44;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(74, 3);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 13);
			this.label3.TabIndex = 45;
			this.label3.Text = "Equipo";
			// 
			// EquipoUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.grdClientes);
			this.Controls.Add(this.btnConsultar);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtBusqueda);
			this.Controls.Add(this.cboBusqueda);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.btnActualizarCliente);
			this.Controls.Add(this.btnGuardarCliente);
			this.Controls.Add(this.btnEliminarCliente);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNombre);
			this.Name = "EquipoUI";
			this.Text = "EquipoUI";
			this.Load += new System.EventHandler(this.EquipoUI_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Button btnEliminarCliente;
		private System.Windows.Forms.Button btnGuardarCliente;
		private System.Windows.Forms.Button btnActualizarCliente;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.ComboBox cboBusqueda;
		private System.Windows.Forms.TextBox txtBusqueda;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.DataGridView grdClientes;
		private System.Windows.Forms.Label label3;
	}
}
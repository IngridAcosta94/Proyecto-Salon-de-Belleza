namespace SalonBellezaIU
{
	partial class MaterialUI
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
			this.label3 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnActualizarCliente = new System.Windows.Forms.Button();
			this.btnGuardarCliente = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnEliminarCliente = new System.Windows.Forms.Button();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.cboBusqueda = new System.Windows.Forms.ComboBox();
			this.txtBusqueda = new System.Windows.Forms.TextBox();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.grdClientes = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(64, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 46;
			this.label3.Text = "Material";
			// 
			// txtId
			// 
			this.txtId.Enabled = false;
			this.txtId.Location = new System.Drawing.Point(53, 45);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(100, 20);
			this.txtId.TabIndex = 47;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 48;
			this.label1.Text = "ID";
			// 
			// txtNombre
			// 
			this.txtNombre.Enabled = false;
			this.txtNombre.Location = new System.Drawing.Point(53, 71);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(310, 20);
			this.txtNombre.TabIndex = 49;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 50;
			this.label2.Text = "Nombre";
			// 
			// btnActualizarCliente
			// 
			this.btnActualizarCliente.Location = new System.Drawing.Point(12, 113);
			this.btnActualizarCliente.Name = "btnActualizarCliente";
			this.btnActualizarCliente.Size = new System.Drawing.Size(107, 23);
			this.btnActualizarCliente.TabIndex = 51;
			this.btnActualizarCliente.Text = "Actualizar";
			this.btnActualizarCliente.UseVisualStyleBackColor = true;
			// 
			// btnGuardarCliente
			// 
			this.btnGuardarCliente.Location = new System.Drawing.Point(141, 113);
			this.btnGuardarCliente.Name = "btnGuardarCliente";
			this.btnGuardarCliente.Size = new System.Drawing.Size(75, 23);
			this.btnGuardarCliente.TabIndex = 52;
			this.btnGuardarCliente.Text = "Guardar";
			this.btnGuardarCliente.UseVisualStyleBackColor = true;
			// 
			// btnNuevo
			// 
			this.btnNuevo.Location = new System.Drawing.Point(576, 9);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(75, 23);
			this.btnNuevo.TabIndex = 53;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.UseVisualStyleBackColor = true;
			// 
			// btnEliminarCliente
			// 
			this.btnEliminarCliente.Location = new System.Drawing.Point(684, 9);
			this.btnEliminarCliente.Name = "btnEliminarCliente";
			this.btnEliminarCliente.Size = new System.Drawing.Size(91, 23);
			this.btnEliminarCliente.TabIndex = 54;
			this.btnEliminarCliente.Text = "Eliminar";
			this.btnEliminarCliente.UseVisualStyleBackColor = true;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(643, 113);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(91, 13);
			this.label14.TabIndex = 55;
			this.label14.Text = "Consultar Material";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(611, 136);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(148, 13);
			this.label15.TabIndex = 56;
			this.label15.Text = "Seleccione tipo de busqueda:";
			// 
			// cboBusqueda
			// 
			this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboBusqueda.FormattingEnabled = true;
			this.cboBusqueda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboBusqueda.Location = new System.Drawing.Point(576, 152);
			this.cboBusqueda.Name = "cboBusqueda";
			this.cboBusqueda.Size = new System.Drawing.Size(203, 21);
			this.cboBusqueda.TabIndex = 57;
			// 
			// txtBusqueda
			// 
			this.txtBusqueda.Location = new System.Drawing.Point(576, 179);
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Size = new System.Drawing.Size(203, 20);
			this.txtBusqueda.TabIndex = 58;
			// 
			// btnConsultar
			// 
			this.btnConsultar.Location = new System.Drawing.Point(646, 205);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(75, 23);
			this.btnConsultar.TabIndex = 59;
			this.btnConsultar.Text = "Consultar";
			this.btnConsultar.UseVisualStyleBackColor = true;
			// 
			// grdClientes
			// 
			this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdClientes.Location = new System.Drawing.Point(12, 248);
			this.grdClientes.Name = "grdClientes";
			this.grdClientes.Size = new System.Drawing.Size(776, 190);
			this.grdClientes.TabIndex = 60;
			// 
			// MaterialUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.grdClientes);
			this.Controls.Add(this.btnConsultar);
			this.Controls.Add(this.txtBusqueda);
			this.Controls.Add(this.cboBusqueda);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.btnEliminarCliente);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.btnGuardarCliente);
			this.Controls.Add(this.btnActualizarCliente);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label3);
			this.Name = "MaterialUI";
			this.Text = "MaterialUI";
			this.Load += new System.EventHandler(this.MaterialUI_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnActualizarCliente;
		private System.Windows.Forms.Button btnGuardarCliente;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Button btnEliminarCliente;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.ComboBox cboBusqueda;
		private System.Windows.Forms.TextBox txtBusqueda;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.DataGridView grdClientes;
	}
}
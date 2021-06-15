using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalonBellezaSRV;
using SalonBellezaBO;

namespace SalonBellezaIU
{
	public partial class EmpleadoUI : Form
	{
		public EmpleadoUI()
		{
			InitializeComponent();
			RetrieveEmpleado();
		}

		
		private void EmpleadoUI_Load(object sender, EventArgs e)
		{

			try
			{

				LoadGender();//metodo para indicar el genero en el cbo
				LoadBusqueda();//metodo para indicar tipo de busqueda

				dtpBirthday.Format = DateTimePickerFormat.Custom;
				dtpBirthday.CustomFormat = " ";

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
        }

		public void LoadGender()
		{
			var lstGender = new List<object>
			{
				new {GenderId = 0, Name = "Seleciona un Genero"},
				new {GenderId = 1,Name = "Masculino"},
				new {GenderId = 2,Name = "Femenino"} };
			cboGenero.DataSource = lstGender;
			cboGenero.DisplayMember = "Name";
			cboGenero.ValueMember = "GenderId";
			cboGenero.SelectedValue = 0;
		}

		public void LoadBusqueda()
		{
			var lstBusqueda = new List<object>
			{
				new {ClientId = 0, Name = "Seleciona un opcion"},
				new {ClientId = 1,Name = "Nombre"},
				new {ClientId = 2,Name = "Apellido"} };
			cboBusqueda.DataSource = lstBusqueda;
			cboBusqueda.DisplayMember = "Name";
			cboBusqueda.ValueMember = "ClientId";
			cboBusqueda.SelectedValue = 0;
		}
       
		public void Buscar()//ste metodo sirve para llnar el grd de acurdo a la busqueda
		{
			var srvEmpleados = new EmpleadoSRV();
			var Empleado = Busqueda();//aqui indico que 


			List<empleado> lstEmpleados = new List<empleado>();
			if (Empleado.EmpleadoId > 0)
				lstEmpleados = new List<empleado> { srvEmpleados.GetEmpleado(Empleado.EmpleadoId) };
			else
				lstEmpleados = srvEmpleados.GetEmpleados(Empleado);

			grdEmpleados.DataSource = lstEmpleados;
		}

		public empleado Busqueda() //busqueda por nombre o apellido
		{
			var empleado2 = new empleado();

			if (cboBusqueda.Text == "Nombre")
			{
				empleado2.Nombre = txtBusqueda.Text.Trim();
			}
			else if (cboBusqueda.Text == "Apellido")
			{

				empleado2.Apellido = txtBusqueda.Text.Trim();
			}

			return empleado2;


		}





		public void RetrieveEmpleado()
		{
			var srvEmpleados = new EmpleadoSRV();
			var Empleado = UserInterfaceToData();

			List<empleado> lstEmpleados = new List<empleado>();
			if (Empleado.EmpleadoId > 0)
				lstEmpleados = new List<empleado> { srvEmpleados.GetEmpleado(Empleado.EmpleadoId) };
			else
				lstEmpleados = srvEmpleados.GetEmpleados(Empleado);

			grdEmpleados.DataSource = lstEmpleados;
		}

	
		public void PrepareInsertToUpdate()
		{
			//LoadGroups();

			var Empleado = new empleado();
			DataToUserInterface(Empleado);

			dtpBirthday.Format = DateTimePickerFormat.Custom;
			dtpBirthday.CustomFormat = " ";
		}

		public void DataToUserInterface(empleado bo)
		{
			txtEdad.Text = bo.edad > 0 ? bo.edad.ToString() : String.Empty;
			txtDireccion.Text = bo.Direccion;
			txtCorreo.Text = bo.correo;
			txtNombre.Text = bo.Nombre;
			txtId.Text = bo.EmpleadoId > 0 ? bo.EmpleadoId.ToString() : string.Empty;
			txtApellido.Text = bo.Apellido;
			txtTelefono.Text = bo.Telefono;
			if (bo.Genero.HasValue)
				if (bo.Genero.Value)
					cboGenero.SelectedItem = "Masculino";
				else
					cboGenero.SelectedItem = "Femenino";
			dtpBirthday.Value = bo.Birthday ?? DateTime.Now;
		}
		
		
		public void CreateEmpleado()
		{
			var Empleado = UserInterfaceToData();
			string mng = ValidateInsert(Empleado);

			if (!string.IsNullOrEmpty(mng))
				throw new Exception(mng);

			var srvEmpleado = new EmpleadoSRV();
			Empleado.EmpleadoId = srvEmpleado.CreateEmpleado(Empleado);
			DataToUserInterface(Empleado);
		}

		public empleado UserInterfaceToData()
		{
			var Empleado = new empleado();

			if (!string.IsNullOrEmpty(txtId.Text.Trim()))
				Empleado.EmpleadoId = Int32.Parse(txtId.Text.Trim());

			if (!string.IsNullOrEmpty(txtDireccion.Text.Trim()))
				Empleado.Direccion = txtDireccion.Text.Trim();

			if (!string.IsNullOrEmpty(txtCorreo.Text.Trim()))
				Empleado.correo = txtCorreo.Text.Trim();

			if (!string.IsNullOrEmpty(txtNombre.Text.Trim()))
				Empleado.Nombre = txtNombre.Text.Trim();

			switch (cboGenero.SelectedValue)
			{
				case 1:
					Empleado.Genero = true;
					break;
				case 2:
					Empleado.Genero = false;
					break;
			}


			if (!string.IsNullOrEmpty(txtApellido.Text.Trim()))
				Empleado.Apellido = txtApellido.Text.Trim();

			if (!string.IsNullOrEmpty(txtTelefono.Text.Trim()))
				Empleado.Telefono = txtTelefono.Text.Trim();

			if (!string.IsNullOrEmpty(dtpBirthday.Text.Trim()))
				Empleado.Birthday = dtpBirthday.Value;

			return Empleado;
		}

		public string ValidateInsert(empleado Empleado)
		{
			return string.Empty;
		}

		private void dtpBirthday_ValueChanged(object sender, EventArgs e)//para seleccionar la fecha de nac.
		{
			dtpBirthday.Format = DateTimePickerFormat.Custom;
			dtpBirthday.CustomFormat = "dd/MM/yyyy";

		}

		private void cboBusqueda_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnConsultar_Click_1(object sender, EventArgs e)
		{
			btnConsultar.Visible = true;
			btnActualizarEmplead.Visible = true;
			btnEliminarEmpleado.Visible = true;

			btnGuardarEmpleado.Visible = false;
			txtApellido.Enabled = false;
			txtNombre.Enabled = false;
			txtDireccion.Enabled = false;
			txtCorreo.Enabled = false;
			txtEdad.Enabled = false;
			txtTelefono.Enabled = false;
			dtpBirthday.Enabled = false;
			cboGenero.Enabled = false;
			lblRegistrarEmpleao.Visible = false;
			lblEmpleado.Visible = true;
			// sirve para limpiar los textbox 
			txtApellido.Text = "";
			txtNombre.Text = "";
			txtDireccion.Text = "";
			txtCorreo.Text = "";
			txtEdad.Text = "";
			txtTelefono.Text = "";
			dtpBirthday.Text = "";
			cboGenero.Text = "";
			//lblRegistrarCliente.Text = "";
			//lblCliente.Text = "";

			try
			{
				Buscar();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			btnConsultar.Visible = true;
			btnGuardarEmpleado.Visible = false;

		}

		private void btnNuevo_Click_1(object sender, EventArgs e)
		{
			txtApellido.Enabled = true;
			txtNombre.Enabled = true;
			txtDireccion.Enabled = true;
			txtCorreo.Enabled = true;
			txtEdad.Enabled = true;
			txtTelefono.Enabled = true;
			dtpBirthday.Enabled = true;
			cboGenero.Enabled = true;
			//lblRegistrarEmpleado.Visible = true;
			//lblCliente.Visible = false;

			btnGuardarEmpleado.Visible = true;
			try
			{
				PrepareInsertToUpdate();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnEliminarEmpleado_Click(object sender, EventArgs e)
		{
			try
			{
				if (!string.IsNullOrEmpty(txtId.Text.Trim()))
				{
					int EmpleadoId = Int32.Parse(txtId.Text);
					var query = new EmpleadoSRV().DeleteEmpleado(EmpleadoId);
				}
				MessageBox.Show("Información Eliminada correctamente.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnGuardarEmpleado_Click(object sender, EventArgs e)
		{

			try
			{
				if (string.IsNullOrEmpty(txtId.Text.Trim()))
					CreateEmpleado();
				else
					UpdateEmpleado();
				MessageBox.Show("Información guardada correctamente.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

		}

		private void grdEmpleados_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
			var bo = new EmpleadoSRV().GetEmpleado((int)grdEmpleados.Rows[e.RowIndex].Cells[0].Value);
			txtId.Text = bo.EmpleadoId.ToString();
			txtNombre.Text = bo.Nombre;
			txtApellido.Text = bo.Apellido;
			txtDireccion.Text = bo.Direccion;
			txtEdad.Text = bo.edad.ToString();
			txtTelefono.Text = bo.Telefono;
			txtCorreo.Text = bo.correo;
			dtpBirthday.Text = bo.Birthday.ToString();
			cboGenero.Text = bo.Genero.ToString();
		}

		private void btnActualizarEmplead_Click(object sender, EventArgs e)
		{

			try
			{

				UpdateEmpleado();

				MessageBox.Show("Información Actualizada correctamente.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			RetrieveEmpleado();//este srive para que despues de que guarde lo actualice

		}

		public void UpdateEmpleado()
		{
			var Empleado = UserInterfaceToData();
			string mng = ValidateUpdate(Empleado);

			if (!string.IsNullOrEmpty(mng))
				throw new Exception(mng);

			var srvEmpleado = new EmpleadoSRV();
			Empleado.EmpleadoId = srvEmpleado.UpdateEmpleado(Empleado.EmpleadoId, Empleado);
			DataToUserInterface(Empleado);
		}


		private string ValidateUpdate(empleado bo)
		{
			var mng = ValidateInsert(bo);
			if (bo.EmpleadoId <= 0)
				mng += ",identificador";
			return mng;
		}

		
	}
}

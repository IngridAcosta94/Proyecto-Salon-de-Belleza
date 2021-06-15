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
	public partial class ClienteUI : Form
	{
		public ClienteUI()//todo lo que quieras que suceda cuando inicie el programa 
			//se incluye aqui adentro
		{
			InitializeComponent();
			RetrieveCliente();
			btnGuardarCliente.Visible = false;
			lblRegistrarCliente.Visible = false;
		}

		private void ClienteUI_Load(object sender, EventArgs e) //esto te llena los datos por defecto todo lo que sea cbo u dtb
		{// todas las cargas primero se declaran en Load
			try
			{

				LoadGender();//metodo para indicar el genero en el cbo
				LoadBusqueda();

				dtpBirthday.Format = DateTimePickerFormat.Custom;
				dtpBirthday.CustomFormat = " ";

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		public void LoadGender()//cargar datos a combobox de genero
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
		public void LoadBusqueda()//cargar datos a tu combobox de mi boton busqueda
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

       private void grdClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)//aqui se creo el evento para los 
			//esto se crea el evento de los registros																				 //registros
		{
			if (e.RowIndex > -1 && e.ColumnIndex > -1)// esta accion sirve para que no de error al dar clic al titulo

			{
				var bo = new ClienteSRV().GetCliente((int)grdClientes.Rows[e.RowIndex].Cells[0].Value);
				txtId.Text = bo.ClienteId.ToString();
				txtNombre.Text = bo.Nombre;
				txtApellido.Text = bo.Apellido;
				txtDireccion.Text = bo.Direccion;
				txtEdad.Text = bo.Edad.ToString();
				txtTelefono.Text = bo.Telefono;
				txtCorreo.Text = bo.correo;
				dtpBirthday.Text = bo.Birthday.ToString();
				cboGenero.Text = bo.Genero.ToString();

				txtDireccion.Enabled = true;
				txtCorreo.Enabled = true;
				txtTelefono.Enabled = true;
				btnActualizarCliente.Visible = true;
			}
		}

		private void btnConsultar_Click(object sender, EventArgs e)//se creo el evento para el boton de la consulta
		{
			btnConsultar.Visible = true;
			btnActualizarCliente.Visible = true;
			btnEliminarCliente.Visible = true;

			btnGuardarCliente.Visible = false;
			txtApellido.Enabled = false;
			txtNombre.Enabled = false;
			txtDireccion.Enabled = false;
			txtCorreo.Enabled = false;
			txtEdad.Enabled = false;
			txtTelefono.Enabled = false;
			dtpBirthday.Enabled = false;
			cboGenero.Enabled = false;
			lblRegistrarCliente.Visible = false;
			lblCliente.Visible = true;
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
			btnGuardarCliente.Visible = false;
		}

		public void Buscar()//ste metodo sirve para llnar el grd de acurdo a la busqueda
		{
			var srvCliente = new ClienteSRV();
			var Cliente = Busqueda();//aqui indico que 


			List<cliente> lstClientes = new List<cliente>();
			if (Cliente.ClienteId > 0)
				lstClientes = new List<cliente> { srvCliente.GetCliente(Cliente.ClienteId) };
			else
				lstClientes = srvCliente.GetClientes(Cliente);

			grdClientes.DataSource = lstClientes;
		}

		public cliente Busqueda() //busqueda por nombre o apellido
		{
			var cliente2 = new cliente();

			if (cboBusqueda.Text == "Nombre")
			{
				cliente2.Nombre = txtBusqueda.Text.Trim();
			}
			else if (cboBusqueda.Text == "Apellido")
			{

				cliente2.Apellido = txtBusqueda.Text.Trim();
			}

			return cliente2;


		}

		public void RetrieveCliente()
		{
			var srvCliente = new ClienteSRV();
			var Cliente = UserInterfaceToData();//aqui indico que 
			


			List<cliente> lstClientes = new List<cliente>();
			if (Cliente.ClienteId > 0)
				lstClientes = new List<cliente> { srvCliente.GetCliente(Cliente.ClienteId) };
			else
				lstClientes = srvCliente.GetClientes(Cliente);

			grdClientes.DataSource = lstClientes;
		}

		

		

		private void btnNuevo_Click(object sender, EventArgs e)// sirve para limpiar los campos despues de haber 
		{
			txtApellido.Enabled = true;
			txtNombre.Enabled = true;
			txtDireccion.Enabled = true;
			txtCorreo.Enabled = true;
			txtEdad.Enabled = true;
			txtTelefono.Enabled = true;
			dtpBirthday.Enabled = true;
			cboGenero.Enabled = true;
			lblRegistrarCliente.Visible = true;
			lblCliente.Visible = false;
			btnEliminarCliente.Visible = false;
			btnGuardarCliente.Visible = true;
			btnActualizarCliente.Visible = false;
			try
			{
				PrepareInsertToUpdate();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			lblRegistrarCliente.Visible = true;
			lblCliente.Visible = false;

		}
		public void PrepareInsertToUpdate()//
		{
			//LoadGroups();

			var Cliente = new cliente();
			DataToUserInterface(Cliente);

			dtpBirthday.Format = DateTimePickerFormat.Custom;
			dtpBirthday.CustomFormat = " ";
		}

		 public void DataToUserInterface(cliente bo) {            
            txtEdad.Text = bo.Edad > 0 ? bo.Edad.ToString() : String.Empty;
            txtDireccion.Text = bo.Direccion;
            txtCorreo.Text = bo.correo;
            txtNombre.Text = bo.Nombre;
            txtId.Text = bo.ClienteId > 0 ? bo.ClienteId.ToString() : string.Empty;
            txtApellido.Text = bo.Apellido;
            txtTelefono.Text = bo.Telefono;
            if(bo.Genero.HasValue)
                if (bo.Genero.Value)
                    cboGenero.SelectedValue = "Masculino";
                else
                    cboGenero.SelectedValue = "Femenino";

			/*if (cboGenero.Text=="Masculino")
			{
				cboGenero.Text=bo.Genero;
			}
			else if (cboGenero.Text == "Femenino")
			{
				cboGenero.Text = bo.Genero;
			}*/




            dtpBirthday.Value = bo.Birthday ?? DateTime.Now;
        }

		private void btnGuardarCliente_Click(object sender, EventArgs e)//sentencia para guardar la informacion despues
			//de haber llenado los campos
		{
			
           try
			{
				if (string.IsNullOrEmpty(txtId.Text.Trim()))
					CreateCliente();
				else
					UpdateCliente();
				MessageBox.Show("Información guardada correctamente.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			RetrieveCliente();//este srive para que despues de que guarde lo actualice


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

			txtApellido.Enabled = false;
			txtNombre.Enabled = false;
			txtDireccion.Enabled = false;
			txtCorreo.Enabled = false;
			txtEdad.Enabled = false;
			txtTelefono.Enabled = false;
			dtpBirthday.Enabled = false;
			cboGenero.Enabled = false;
			lblRegistrarCliente.Visible = true;
			lblCliente.Visible = false;

		}

		public void CreateCliente()
		{
			var Cliente = UserInterfaceToData();
			string mng = ValidateInsert(Cliente);

			if (!string.IsNullOrEmpty(mng))
				throw new Exception(mng);

			var srvcliente = new ClienteSRV();
			Cliente.ClienteId = srvcliente.CreateCliente(Cliente);
			DataToUserInterface(Cliente);
		}

		public cliente UserInterfaceToData()// esto sirve pra llenar cada campo y guardar
		{
			var Cliente = new cliente();

			if (!string.IsNullOrEmpty(txtId.Text.Trim()))
				Cliente.ClienteId = Int32.Parse(txtId.Text.Trim());

			if (!string.IsNullOrEmpty(txtDireccion.Text.Trim()))
				Cliente.Direccion = txtDireccion.Text.Trim();

			if (!string.IsNullOrEmpty(txtCorreo.Text.Trim()))
				Cliente.correo = txtCorreo.Text.Trim();

			if (!string.IsNullOrEmpty(txtNombre.Text.Trim()))
				Cliente.Nombre = txtNombre.Text.Trim();

			//if (!string.IsNullOrEmpty(cboGenero.Text.Trim()))
				//Cliente.Genero = cboGenero.Text.Trim();



			switch (cboGenero.SelectedValue)
			{
				case "Masculino":
					Cliente.Genero = true;
					break;
				case "Femenino":
					Cliente.Genero = false;
					break;
			}


			if (!string.IsNullOrEmpty(txtApellido.Text.Trim()))
				Cliente.Apellido = txtApellido.Text.Trim();

			if (!string.IsNullOrEmpty(txtTelefono.Text.Trim()))
				Cliente.Telefono = txtTelefono.Text.Trim();

			if (!string.IsNullOrEmpty(dtpBirthday.Text.Trim()))
				Cliente.Birthday = dtpBirthday.Value;

			return Cliente;
		}
		public string ValidateInsert(cliente Cliente)
		{
			return string.Empty;
		}

		private void dtpBirthday_ValueChanged(object sender, EventArgs e)//para seleccionar la fecha de nac.
		{
			dtpBirthday.Format = DateTimePickerFormat.Custom;
			dtpBirthday.CustomFormat = "dd/MM/yyyy";

		}

		
		/*private void grdClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			// este evento me sirve para darle doble clic a la inf. del griew y
			//te muestre al cliente en pantalla
			if (e.RowIndex > -1 && e.ColumnIndex > -1)// esta accion sirve para que no de error al dar clic al titulo
			{
                txtId.Text = grdClientes.CurrentRow.Cells["ClienteId"].Value.ToString();
				txtNombre.Text = grdClientes.CurrentRow.Cells["Nombre"].Value.ToString();
				txtApellido.Text = grdClientes.CurrentRow.Cells["Apellido"].Value.ToString();
				txtDireccion.Text = grdClientes.CurrentRow.Cells["Direccion"].Value.ToString();
				txtEdad.Text = grdClientes.CurrentRow.Cells["Edad"].Value.ToString();
				txtTelefono.Text = grdClientes.CurrentRow.Cells["Telefono"].Value.ToString();
				txtCorreo.Text = grdClientes.CurrentRow.Cells["correo"].Value.ToString();
				dtpBirthday.Text = grdClientes.CurrentRow.Cells["Birthday"].Value.ToString();
				cboGenero.Text = grdClientes.CurrentRow.Cells["Genero"].Value.ToString();
				txtDireccion.Enabled = true;
				txtCorreo.Enabled = true;
				txtTelefono.Enabled = true;
            }
				
		}*/

		
		public void DeleteCliente()
		{
			var Cliente = UserInterfaceToData();
			string mng = ValidateUpdate(Cliente);

			if (!string.IsNullOrEmpty(mng))
				throw new Exception(mng);

			var srvcliente = new ClienteSRV();
			Cliente.ClienteId = srvcliente.UpdateCliente(Cliente.ClienteId, Cliente);
			DataToUserInterface(Cliente);
		}



		private void btnActualizarCliente_Click(object sender, EventArgs e)
		{

			try
			{
			
				UpdateCliente();

				MessageBox.Show("Información Actualizada correctamente.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			RetrieveCliente();//este srive para que despues de que guarde lo actualice


		}

		public void UpdateCliente()
		{
			var Cliente = UserInterfaceToData();
			string mng = ValidateUpdate(Cliente);

			if (!string.IsNullOrEmpty(mng))
				throw new Exception(mng);

			var srvcliente = new ClienteSRV();
			Cliente.ClienteId = srvcliente.UpdateCliente(Cliente.ClienteId, Cliente);
			DataToUserInterface(Cliente);
		}

		private string ValidateUpdate(cliente bo)
		{
			var mng = ValidateInsert(bo);
			if (bo.ClienteId <= 0)
				mng += ",identificador";
			return mng;
		}

		private void btnEliminarCliente_Click_1(object sender, EventArgs e)
		{
			try
			{
				if (!string.IsNullOrEmpty(txtId.Text.Trim()))
				{
					int ClienteId = Int32.Parse(txtId.Text);
					var query = new ClienteSRV().DeleteCliente(ClienteId);
				}
				MessageBox.Show("Información Eliminada correctamente.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

		}

		private void txtBusqueda_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}



		/*public cliente UserInterfaceToData1()// esto sirve pra llenar cada campo y guardar
		{
			var Cliente = new cliente();

			if (!string.IsNullOrEmpty(txtId.Text.Trim()))
				Cliente.ClienteId = Int32.Parse(txtId.Text.Trim());

			if (!string.IsNullOrEmpty(txtDireccion.Text.Trim()))
				Cliente.Direccion = txtDireccion.Text.Trim();

			if (!string.IsNullOrEmpty(txtCorreo.Text.Trim()))
				Cliente.correo = txtCorreo.Text.Trim();

			//if (!string.IsNullOrEmpty(txtNombre.Text.Trim()))
				//Cliente.Nombre = txtNombre.Text.Trim();



			/*switch (cboGenero.SelectedValue)
			{
				case 1:
					Cliente.Genero = true;
					break;
				case 2:
					Cliente.Genero = false;
					break;
			}


			//if (!string.IsNullOrEmpty(txtApellido.Text.Trim()))
				Cliente.Apellido = txtApellido.Text.Trim();

			if (!string.IsNullOrEmpty(txtTelefono.Text.Trim()))
				Cliente.Telefono = txtTelefono.Text.Trim();

			//if (!string.IsNullOrEmpty(dtpBirthday.Text.Trim()))
			//	Cliente.Birthday = dtpBirthday.Value;

			return Cliente;
		}

		private void lblRegistrarCliente_Click(object sender, EventArgs e)
		{

		} */













	}










}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalonBellezaBO;
using SalonBellezaSRV;
using System.Data.Entity;


namespace SalonBellezaIU
{
	public partial class CITASUI : Form
	{
		public CITASUI()
		{
			InitializeComponent();
		}

		private void CITASUI_Load(object sender, EventArgs e)
		{
			try
			{

				LoadServicio();//metodo para indicar el genero en el cbo
				LoadBusqueda();
				LoadEstatus();
				
				dtpFecha.Format = DateTimePickerFormat.Custom;
				dtpFecha.CustomFormat = " ";

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		

		public void LoadServicio()
		{
			var srvServicios = new ServicioSRV();
			var lstServicios = srvServicios.GetServicios(new Servicio());
			var ServicioDummy = new Servicio { ServicioId = 0, Nombre = "Selecciona un servicio" };
			lstServicios.Add(ServicioDummy);
			cboServicios.DataSource = lstServicios;
			cboServicios.DisplayMember = "Nombre";
			cboServicios.ValueMember = "ServicioId";
			cboServicios.SelectedValue = ServicioDummy.ServicioId;
		}

		

		public void LoadBusqueda()//cargar datos a tu combobox de mi boton busqueda
		{
			var lstBusqueda = new List<object>
			{
				new {CitaId = 0,Name = "Seleciona un opcion"},
				new {CitaId = 1,Name = "Fecha"},
				new {CitaId = 2,Name = "Hora"},
			};
			cboBusqueda.DataSource = lstBusqueda;
			cboBusqueda.DisplayMember = "Name";
			cboBusqueda.ValueMember = "CitaId";
			cboBusqueda.SelectedValue = 0;

		}

		public void LoadEstatus()//cargar datos a tu combobox de mi boton busqueda
		{
			var lstEstatus = new List<object>
			{
				new {EstatusID = 0,Name = "Seleciona un opcion"},
				new {EstatusID = 1,Name = "Activo"},
				new {EstatusID = 2,Name = "Completado"},
				new {EstatusID = 3,Name = "Cancelado"},
			};
			cboEstatu.DataSource = lstEstatus;
			cboEstatu.DisplayMember = "Name";
			cboEstatu.ValueMember = "EstatusID";
			cboEstatu.SelectedValue = 0;
		}
		

		

		private void btnConsultar_Click(object sender, EventArgs e)
		{
			try
			{
				RetrieveCita();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
        }

		public void RetrieveCita()
		{
			var srvCita = new CitaSRV();
			var Cita = UserInterfaceToData();// para que el usuario tenga acceso


			List<cita> lstCita = new List<cita>();
			if (Cita.CitaId > 0)
				lstCita = new List<cita> { srvCita.GetCita(Cita.CitaId) };
			else
				lstCita = srvCita.GetCita(Cita);

			grdCita.DataSource = lstCita;
		}

		public cita UserInterfaceToData()
		{
			var Cita = new cita();

			if (!string.IsNullOrEmpty(txtCitaId.Text.Trim()))
				Cita.CitaId = Int32.Parse(txtCitaId.Text.Trim());

			if (!string.IsNullOrEmpty(txtClienteId.Text.Trim()))
				Cita.ClienteId = Int32.Parse(txtClienteId.Text.Trim());


			if (cboServicios.SelectedItem != null)// para que traiga el texto utilizare text.value y creo otro if// para selecionar servicio
											  //pero usando group
			if (((Servicio)cboServicios.SelectedItem).ServicioId > 0)
					Cita.ServicioId = ((Servicio)cboServicios.SelectedItem).ServicioId;

			if (!string.IsNullOrEmpty(dtpFecha.Text.Trim()))// para indicar fecha de la cita
				Cita.FechaHora = dtpFecha.Value;

			if (!string.IsNullOrEmpty(cboEstatu.Text.Trim()))
			   Cita.Estatus = cboEstatu.Text.Trim();


			return Cita;
		}
        private void btnNuevo_Click(object sender, EventArgs e)
		{
			try
			{
				PrepareInsertToUpdate();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		public void PrepareInsertToUpdate()
		{
			LoadServicio();
			

			var Cita = new cita();
			DataToUserInterface(Cita);

			dtpFecha.Format = DateTimePickerFormat.Custom;
			dtpFecha.CustomFormat = " ";
		}

		public void DataToUserInterface(cita bo)
		{

			int clieid = Int32.Parse(txtClienteId.Text);

           clieid = bo.ClienteId;


			cboServicios.SelectedItem = bo.ServicioId;

			dtpFecha.Value = bo.FechaHora ?? DateTime.Now;

			if (cboEstatu.Text=="Activo")
			{
				cboEstatu.Text=bo.Estatus;
			}
			else if (cboEstatu.Text == "Completado")
			{
				cboEstatu.Text = bo.Estatus;
			}
			else if (cboEstatu.Text == "Cancelado")
				cboEstatu.Text = bo.Estatus;


		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(txtCitaId.Text.Trim()))
					CreateCita();
				else
					UpdateCita();
				MessageBox.Show("Información guardada correctamente.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		public void CreateCita()
		{
			var Cita = UserInterfaceToData();
			string mng = ValidateInsert(Cita);

			if (!string.IsNullOrEmpty(mng))
				throw new Exception(mng);

			var srvCita = new CitaSRV();
			Cita.CitaId = srvCita.CreateCita(Cita);
			DataToUserInterface(Cita);
		}

		public string ValidateInsert(cita Cita)
		{
			return string.Empty;
		}


		public void UpdateCita()
		{
			var Cita = UserInterfaceToData();
			string mng = ValidateUpdate(Cita);

			if (!string.IsNullOrEmpty(mng))
				throw new Exception(mng);

			var srvCita = new CitaSRV();
			Cita.CitaId = srvCita.UpdateCita(Cita.CitaId, Cita);
			DataToUserInterface(Cita);
		}

		private string ValidateUpdate(cita bo)
		{
			var mng = ValidateInsert(bo);
			if (bo.CitaId <= 0)
				mng += ",identificador";
			return mng;
		}







		private void btnActualizar_Click(object sender, EventArgs e)
		{
			try
			{

				UpdateCita();

				MessageBox.Show("Información Actualizada correctamente.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			RetrieveCita();//este srive para que despues de que guarde lo actualice

		}

		private void grdCita_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1 && e.ColumnIndex > -1)// esta accion sirve para que no de error al dar clic al titulo

			{    
				var bo = new CitaSRV().GetCita((int)grdCita.Rows[e.RowIndex].Cells[0].Value);

				txtCitaId.Text = bo.CitaId.ToString();
				txtClienteId.Text = bo.ClienteId.ToString();
				dtpFecha.Text = bo.FechaHora.ToString();
                cboServicios.Text = bo.Servicio.ToString();
				cboEstatu.Text = bo.Estatus.ToString();

			}

		}

		private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
				if ((int)e.KeyChar == (int)Keys.Enter)
				{
					var bo = new ClienteSRV().GetCliente2(txtBusqueda.Text);

					txtNombre.Text = bo.Nombre.ToString();
					txtClienteId.Text = bo.ClienteId.ToString();
					txtApellido.Text = bo.Apellido.ToString();
					txtCorreo.Text = bo.correo.ToString();
					txtDireccion.Text = bo.Direccion.ToString();
					txtTelefono.Text = bo.Telefono.ToString();
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "El Usuario no existe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}


		}

		private void cboEstatu_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void cboBusqueda_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void cboServicios_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnEnviarCorreo_Click(object sender, EventArgs e)
		{

		}

		private void txtDireccion_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{

			try
			{
				if (!string.IsNullOrEmpty(txtCitaId.Text.Trim()))
				{
					int CitaId = Int32.Parse(txtCitaId.Text);
					var query = new CitaSRV().DeleteCita(CitaId);
				}
				MessageBox.Show("Información Eliminada correctamente.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			try
			{
				

			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}

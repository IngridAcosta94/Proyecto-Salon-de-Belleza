using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonBellezaIU
{
	public partial class PaginaPrincipalUI : Form
	{
		
		public PaginaPrincipalUI()
		{
			InitializeComponent();
		}

		private void pnlTitulo_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pcbCerrar_Click_1(object sender, EventArgs e)
		{
			Application.Exit();//para que se cierre la aplicacion ose detenga
		}


		private void pcbMinimizar_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void pcbMaximizar_Click(object sender, EventArgs e)// para que maximize y oculte el boton minimi
		{
			this.WindowState = FormWindowState.Maximized;
			pcbMaximizar.Visible = false;
			pcbRestaurar1.Visible = true;
		}

		private void pcbRestaurar1_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Normal;
			pcbMaximizar.Visible = true;
			pcbRestaurar1.Visible = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pnlOpciones_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}

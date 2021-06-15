namespace SalonBellezaIU
{
	partial class PaginaPrincipalUI
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaPrincipalUI));
			this.pnlTitulo = new System.Windows.Forms.Panel();
			this.pcbMaximizar = new System.Windows.Forms.PictureBox();
			this.pcbMinimizar = new System.Windows.Forms.PictureBox();
			this.pcbRestaurar1 = new System.Windows.Forms.PictureBox();
			this.pcbCerrar = new System.Windows.Forms.PictureBox();
			this.pnlOpciones = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.pnlContenido = new System.Windows.Forms.Panel();
			this.pnlTitulo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbMaximizar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbMinimizar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbRestaurar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbCerrar)).BeginInit();
			this.pnlOpciones.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTitulo
			// 
			this.pnlTitulo.BackColor = System.Drawing.Color.DarkMagenta;
			this.pnlTitulo.Controls.Add(this.pcbMaximizar);
			this.pnlTitulo.Controls.Add(this.pcbMinimizar);
			this.pnlTitulo.Controls.Add(this.pcbRestaurar1);
			this.pnlTitulo.Controls.Add(this.pcbCerrar);
			this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
			this.pnlTitulo.Name = "pnlTitulo";
			this.pnlTitulo.Size = new System.Drawing.Size(1080, 35);
			this.pnlTitulo.TabIndex = 0;
			this.pnlTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitulo_Paint);
			// 
			// pcbMaximizar
			// 
			this.pcbMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pcbMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pcbMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("pcbMaximizar.Image")));
			this.pcbMaximizar.Location = new System.Drawing.Point(1014, 4);
			this.pcbMaximizar.Name = "pcbMaximizar";
			this.pcbMaximizar.Size = new System.Drawing.Size(25, 25);
			this.pcbMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcbMaximizar.TabIndex = 2;
			this.pcbMaximizar.TabStop = false;
			this.pcbMaximizar.Click += new System.EventHandler(this.pcbMaximizar_Click);
			// 
			// pcbMinimizar
			// 
			this.pcbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pcbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pcbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pcbMinimizar.Image")));
			this.pcbMinimizar.Location = new System.Drawing.Point(983, 3);
			this.pcbMinimizar.Name = "pcbMinimizar";
			this.pcbMinimizar.Size = new System.Drawing.Size(25, 25);
			this.pcbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcbMinimizar.TabIndex = 1;
			this.pcbMinimizar.TabStop = false;
			this.pcbMinimizar.Click += new System.EventHandler(this.pcbMinimizar_Click);
			// 
			// pcbRestaurar1
			// 
			this.pcbRestaurar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pcbRestaurar1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pcbRestaurar1.Image = ((System.Drawing.Image)(resources.GetObject("pcbRestaurar1.Image")));
			this.pcbRestaurar1.Location = new System.Drawing.Point(1014, 3);
			this.pcbRestaurar1.Name = "pcbRestaurar1";
			this.pcbRestaurar1.Size = new System.Drawing.Size(25, 25);
			this.pcbRestaurar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcbRestaurar1.TabIndex = 3;
			this.pcbRestaurar1.TabStop = false;
			this.pcbRestaurar1.Visible = false;
			this.pcbRestaurar1.Click += new System.EventHandler(this.pcbRestaurar1_Click);
			// 
			// pcbCerrar
			// 
			this.pcbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pcbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pcbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pcbCerrar.Image")));
			this.pcbCerrar.Location = new System.Drawing.Point(1045, 4);
			this.pcbCerrar.Name = "pcbCerrar";
			this.pcbCerrar.Size = new System.Drawing.Size(25, 25);
			this.pcbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcbCerrar.TabIndex = 0;
			this.pcbCerrar.TabStop = false;
			this.pcbCerrar.Click += new System.EventHandler(this.pcbCerrar_Click_1);
			// 
			// pnlOpciones
			// 
			this.pnlOpciones.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pnlOpciones.Controls.Add(this.panel4);
			this.pnlOpciones.Controls.Add(this.panel3);
			this.pnlOpciones.Controls.Add(this.panel2);
			this.pnlOpciones.Controls.Add(this.button4);
			this.pnlOpciones.Controls.Add(this.button3);
			this.pnlOpciones.Controls.Add(this.button2);
			this.pnlOpciones.Controls.Add(this.panel1);
			this.pnlOpciones.Controls.Add(this.button1);
			this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlOpciones.Location = new System.Drawing.Point(0, 35);
			this.pnlOpciones.Name = "pnlOpciones";
			this.pnlOpciones.Size = new System.Drawing.Size(206, 580);
			this.pnlOpciones.TabIndex = 1;
			this.pnlOpciones.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOpciones_Paint);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.DarkMagenta;
			this.panel4.Location = new System.Drawing.Point(0, 284);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(10, 45);
			this.panel4.TabIndex = 8;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.DarkMagenta;
			this.panel3.Location = new System.Drawing.Point(0, 230);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(10, 48);
			this.panel3.TabIndex = 7;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DarkMagenta;
			this.panel2.Location = new System.Drawing.Point(0, 176);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(10, 48);
			this.panel2.TabIndex = 6;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Black;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkMagenta;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.Violet;
			this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
			this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.Location = new System.Drawing.Point(14, 176);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(176, 48);
			this.button4.TabIndex = 5;
			this.button4.Text = "CLIENTES";
			this.button4.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Black;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkMagenta;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Violet;
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.Location = new System.Drawing.Point(12, 230);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(176, 48);
			this.button3.TabIndex = 4;
			this.button3.Text = "SERVICIOS";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Black;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkMagenta;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Violet;
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(9, 284);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(197, 45);
			this.button2.TabIndex = 3;
			this.button2.Text = "EMPLEADOS";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkMagenta;
			this.panel1.Location = new System.Drawing.Point(0, 122);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(10, 48);
			this.panel1.TabIndex = 2;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Black;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkMagenta;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Violet;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(12, 122);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(176, 48);
			this.button1.TabIndex = 1;
			this.button1.Text = "CITAS";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pnlContenido
			// 
			this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlContenido.Location = new System.Drawing.Point(206, 35);
			this.pnlContenido.Name = "pnlContenido";
			this.pnlContenido.Size = new System.Drawing.Size(874, 580);
			this.pnlContenido.TabIndex = 2;
			// 
			// PaginaPrincipalUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1080, 615);
			this.Controls.Add(this.pnlContenido);
			this.Controls.Add(this.pnlOpciones);
			this.Controls.Add(this.pnlTitulo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "PaginaPrincipalUI";
			this.Text = "PaginaPrincipalUI";
			this.pnlTitulo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pcbMaximizar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbMinimizar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbRestaurar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbCerrar)).EndInit();
			this.pnlOpciones.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlTitulo;
		private System.Windows.Forms.PictureBox pcbCerrar;
		private System.Windows.Forms.Panel pnlOpciones;
		private System.Windows.Forms.Panel pnlContenido;
		private System.Windows.Forms.PictureBox pcbMinimizar;
		private System.Windows.Forms.PictureBox pcbMaximizar;
		private System.Windows.Forms.PictureBox pcbRestaurar1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel4;
	}
}
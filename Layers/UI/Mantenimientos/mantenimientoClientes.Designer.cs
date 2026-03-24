namespace JarasTech.Layers.UI
{
    partial class mantenimientoClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpDatosCliente = new System.Windows.Forms.GroupBox();
            this.lblTipoIdentificacion = new System.Windows.Forms.Label();
            this.rdoNacional = new System.Windows.Forms.RadioButton();
            this.rdoExtranjero = new System.Windows.Forms.RadioButton();
            this.lblNumeroIdentificacion = new System.Windows.Forms.Label();
            this.txtNumeroIdentificacion = new System.Windows.Forms.TextBox();
            this.btnConsultarAPI = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.rdoMasculino = new System.Windows.Forms.RadioButton();
            this.rdoFemenino = new System.Windows.Forms.RadioButton();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.lblDireccionExacta = new System.Windows.Forms.Label();
            this.txtDireccionExacta = new System.Windows.Forms.TextBox();
            this.lblFotografia = new System.Windows.Forms.Label();
            this.picFotografia = new System.Windows.Forms.PictureBox();
            this.btnCargarFoto = new System.Windows.Forms.Button();
            this.grpListaClientes = new System.Windows.Forms.GroupBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grpDatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotografia)).BeginInit();
            this.grpListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatosCliente
            // 
            this.grpDatosCliente.BackColor = System.Drawing.Color.White;
            this.grpDatosCliente.Controls.Add(this.lblTipoIdentificacion);
            this.grpDatosCliente.Controls.Add(this.rdoNacional);
            this.grpDatosCliente.Controls.Add(this.rdoExtranjero);
            this.grpDatosCliente.Controls.Add(this.lblNumeroIdentificacion);
            this.grpDatosCliente.Controls.Add(this.txtNumeroIdentificacion);
            this.grpDatosCliente.Controls.Add(this.btnConsultarAPI);
            this.grpDatosCliente.Controls.Add(this.lblNombre);
            this.grpDatosCliente.Controls.Add(this.txtNombre);
            this.grpDatosCliente.Controls.Add(this.lblApellidos);
            this.grpDatosCliente.Controls.Add(this.txtApellidos);
            this.grpDatosCliente.Controls.Add(this.lblSexo);
            this.grpDatosCliente.Controls.Add(this.rdoMasculino);
            this.grpDatosCliente.Controls.Add(this.rdoFemenino);
            this.grpDatosCliente.Controls.Add(this.lblTelefono);
            this.grpDatosCliente.Controls.Add(this.txtTelefono);
            this.grpDatosCliente.Controls.Add(this.lblCorreoElectronico);
            this.grpDatosCliente.Controls.Add(this.txtCorreoElectronico);
            this.grpDatosCliente.Controls.Add(this.lblProvincia);
            this.grpDatosCliente.Controls.Add(this.cboProvincia);
            this.grpDatosCliente.Controls.Add(this.lblDireccionExacta);
            this.grpDatosCliente.Controls.Add(this.txtDireccionExacta);
            this.grpDatosCliente.Controls.Add(this.lblFotografia);
            this.grpDatosCliente.Controls.Add(this.picFotografia);
            this.grpDatosCliente.Controls.Add(this.btnCargarFoto);
            this.grpDatosCliente.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpDatosCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(110)))));
            this.grpDatosCliente.Location = new System.Drawing.Point(12, 12);
            this.grpDatosCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDatosCliente.Name = "grpDatosCliente";
            this.grpDatosCliente.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDatosCliente.Size = new System.Drawing.Size(531, 645);
            this.grpDatosCliente.TabIndex = 0;
            this.grpDatosCliente.TabStop = false;
            this.grpDatosCliente.Text = "Datos del Cliente";
            // 
            // lblTipoIdentificacion
            // 
            this.lblTipoIdentificacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTipoIdentificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTipoIdentificacion.Location = new System.Drawing.Point(13, 30);
            this.lblTipoIdentificacion.Name = "lblTipoIdentificacion";
            this.lblTipoIdentificacion.Size = new System.Drawing.Size(181, 18);
            this.lblTipoIdentificacion.TabIndex = 0;
            this.lblTipoIdentificacion.Text = "Tipo de Identificación:";
            // 
            // rdoNacional
            // 
            this.rdoNacional.Checked = true;
            this.rdoNacional.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdoNacional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.rdoNacional.Location = new System.Drawing.Point(205, 27);
            this.rdoNacional.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoNacional.Name = "rdoNacional";
            this.rdoNacional.Size = new System.Drawing.Size(108, 22);
            this.rdoNacional.TabIndex = 0;
            this.rdoNacional.TabStop = true;
            this.rdoNacional.Text = "Nacional";
            this.rdoNacional.CheckedChanged += new System.EventHandler(this.rdoNacional_CheckedChanged);
            // 
            // rdoExtranjero
            // 
            this.rdoExtranjero.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdoExtranjero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.rdoExtranjero.Location = new System.Drawing.Point(340, 28);
            this.rdoExtranjero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoExtranjero.Name = "rdoExtranjero";
            this.rdoExtranjero.Size = new System.Drawing.Size(116, 22);
            this.rdoExtranjero.TabIndex = 1;
            this.rdoExtranjero.Text = "Extranjero";
            // 
            // lblNumeroIdentificacion
            // 
            this.lblNumeroIdentificacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNumeroIdentificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblNumeroIdentificacion.Location = new System.Drawing.Point(13, 62);
            this.lblNumeroIdentificacion.Name = "lblNumeroIdentificacion";
            this.lblNumeroIdentificacion.Size = new System.Drawing.Size(165, 18);
            this.lblNumeroIdentificacion.TabIndex = 2;
            this.lblNumeroIdentificacion.Text = "N° Identificación:";
            // 
            // txtNumeroIdentificacion
            // 
            this.txtNumeroIdentificacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNumeroIdentificacion.Location = new System.Drawing.Point(13, 82);
            this.txtNumeroIdentificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeroIdentificacion.MaxLength = 20;
            this.txtNumeroIdentificacion.Name = "txtNumeroIdentificacion";
            this.txtNumeroIdentificacion.Size = new System.Drawing.Size(255, 30);
            this.txtNumeroIdentificacion.TabIndex = 2;
            // 
            // btnConsultarAPI
            // 
            this.btnConsultarAPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(110)))));
            this.btnConsultarAPI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarAPI.FlatAppearance.BorderSize = 0;
            this.btnConsultarAPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarAPI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultarAPI.ForeColor = System.Drawing.Color.White;
            this.btnConsultarAPI.Location = new System.Drawing.Point(277, 80);
            this.btnConsultarAPI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultarAPI.Name = "btnConsultarAPI";
            this.btnConsultarAPI.Size = new System.Drawing.Size(248, 30);
            this.btnConsultarAPI.TabIndex = 3;
            this.btnConsultarAPI.Text = "Consultar ";
            this.btnConsultarAPI.UseVisualStyleBackColor = false;
            this.btnConsultarAPI.Click += new System.EventHandler(this.btnConsultarAPI_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblNombre.Location = new System.Drawing.Point(13, 124);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(75, 18);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.Location = new System.Drawing.Point(13, 144);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(243, 30);
            this.txtNombre.TabIndex = 4;
            // 
            // lblApellidos
            // 
            this.lblApellidos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblApellidos.Location = new System.Drawing.Point(265, 124);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(69, 18);
            this.lblApellidos.TabIndex = 5;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtApellidos.Location = new System.Drawing.Point(265, 144);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidos.MaxLength = 100;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(249, 30);
            this.txtApellidos.TabIndex = 5;
            // 
            // lblSexo
            // 
            this.lblSexo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblSexo.Location = new System.Drawing.Point(13, 185);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(51, 18);
            this.lblSexo.TabIndex = 6;
            this.lblSexo.Text = "Sexo:";
            // 
            // rdoMasculino
            // 
            this.rdoMasculino.Checked = true;
            this.rdoMasculino.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdoMasculino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.rdoMasculino.Location = new System.Drawing.Point(72, 183);
            this.rdoMasculino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoMasculino.Name = "rdoMasculino";
            this.rdoMasculino.Size = new System.Drawing.Size(123, 22);
            this.rdoMasculino.TabIndex = 6;
            this.rdoMasculino.TabStop = true;
            this.rdoMasculino.Text = "Masculino";
            // 
            // rdoFemenino
            // 
            this.rdoFemenino.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdoFemenino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.rdoFemenino.Location = new System.Drawing.Point(205, 185);
            this.rdoFemenino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoFemenino.Name = "rdoFemenino";
            this.rdoFemenino.Size = new System.Drawing.Size(108, 22);
            this.rdoFemenino.TabIndex = 7;
            this.rdoFemenino.Text = "Femenino";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTelefono.Location = new System.Drawing.Point(13, 218);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(87, 18);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTelefono.Location = new System.Drawing.Point(13, 238);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.MaxLength = 20;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(155, 30);
            this.txtTelefono.TabIndex = 8;
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCorreoElectronico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblCorreoElectronico.Location = new System.Drawing.Point(179, 218);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(135, 18);
            this.lblCorreoElectronico.TabIndex = 9;
            this.lblCorreoElectronico.Text = "Correo Electrónico:";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCorreoElectronico.Location = new System.Drawing.Point(179, 238);
            this.txtCorreoElectronico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreoElectronico.MaxLength = 100;
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(336, 30);
            this.txtCorreoElectronico.TabIndex = 9;
            // 
            // lblProvincia
            // 
            this.lblProvincia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblProvincia.Location = new System.Drawing.Point(13, 278);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(87, 18);
            this.lblProvincia.TabIndex = 10;
            this.lblProvincia.Text = "Provincia:";
            // 
            // cboProvincia
            // 
            this.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboProvincia.Location = new System.Drawing.Point(13, 298);
            this.cboProvincia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(500, 31);
            this.cboProvincia.TabIndex = 10;
            // 
            // lblDireccionExacta
            // 
            this.lblDireccionExacta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDireccionExacta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblDireccionExacta.Location = new System.Drawing.Point(13, 338);
            this.lblDireccionExacta.Name = "lblDireccionExacta";
            this.lblDireccionExacta.Size = new System.Drawing.Size(156, 18);
            this.lblDireccionExacta.TabIndex = 11;
            this.lblDireccionExacta.Text = "Dirección Exacta:";
            // 
            // txtDireccionExacta
            // 
            this.txtDireccionExacta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDireccionExacta.Location = new System.Drawing.Point(13, 358);
            this.txtDireccionExacta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccionExacta.MaxLength = 255;
            this.txtDireccionExacta.Multiline = true;
            this.txtDireccionExacta.Name = "txtDireccionExacta";
            this.txtDireccionExacta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDireccionExacta.Size = new System.Drawing.Size(500, 66);
            this.txtDireccionExacta.TabIndex = 11;
            // 
            // lblFotografia
            // 
            this.lblFotografia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFotografia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblFotografia.Location = new System.Drawing.Point(13, 436);
            this.lblFotografia.Name = "lblFotografia";
            this.lblFotografia.Size = new System.Drawing.Size(200, 18);
            this.lblFotografia.TabIndex = 12;
            this.lblFotografia.Text = "Fotografía del Cliente:";
            // 
            // picFotografia
            // 
            this.picFotografia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.picFotografia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFotografia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFotografia.Location = new System.Drawing.Point(13, 455);
            this.picFotografia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picFotografia.Name = "picFotografia";
            this.picFotografia.Size = new System.Drawing.Size(150, 150);
            this.picFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFotografia.TabIndex = 13;
            this.picFotografia.TabStop = false;
            this.picFotografia.Click += new System.EventHandler(this.picFotografia_Click);
            // 
            // btnCargarFoto
            // 
            this.btnCargarFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.btnCargarFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarFoto.FlatAppearance.BorderSize = 0;
            this.btnCargarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarFoto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCargarFoto.ForeColor = System.Drawing.Color.White;
            this.btnCargarFoto.Location = new System.Drawing.Point(13, 612);
            this.btnCargarFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargarFoto.Name = "btnCargarFoto";
            this.btnCargarFoto.Size = new System.Drawing.Size(149, 28);
            this.btnCargarFoto.TabIndex = 12;
            this.btnCargarFoto.Text = "Cargar Foto";
            this.btnCargarFoto.UseVisualStyleBackColor = false;
            this.btnCargarFoto.Click += new System.EventHandler(this.btnCargarFoto_Click);
            // 
            // grpListaClientes
            // 
            this.grpListaClientes.BackColor = System.Drawing.Color.White;
            this.grpListaClientes.Controls.Add(this.lblFiltro);
            this.grpListaClientes.Controls.Add(this.txtFiltro);
            this.grpListaClientes.Controls.Add(this.btnBuscar);
            this.grpListaClientes.Controls.Add(this.dgvClientes);
            this.grpListaClientes.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpListaClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(110)))));
            this.grpListaClientes.Location = new System.Drawing.Point(555, 12);
            this.grpListaClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpListaClientes.Name = "grpListaClientes";
            this.grpListaClientes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpListaClientes.Size = new System.Drawing.Size(1077, 702);
            this.grpListaClientes.TabIndex = 2;
            this.grpListaClientes.TabStop = false;
            this.grpListaClientes.Text = "Lista de Clientes";
            // 
            // lblFiltro
            // 
            this.lblFiltro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblFiltro.Location = new System.Drawing.Point(12, 28);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(105, 18);
            this.lblFiltro.TabIndex = 0;
            this.lblFiltro.Text = "Buscar cliente:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFiltro.Location = new System.Drawing.Point(12, 48);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(468, 30);
            this.txtFiltro.TabIndex = 30;
            this.txtFiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFiltro_KeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(110)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(491, 46);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(125, 31);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.ColumnHeadersHeight = 36;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.Location = new System.Drawing.Point(12, 89);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 30;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(1039, 601);
            this.dgvClientes.TabIndex = 32;
            this.dgvClientes.SelectionChanged += new System.EventHandler(this.dgvClientes_SelectionChanged);
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.White;
            this.pnlBotones.Controls.Add(this.btnNuevo);
            this.pnlBotones.Controls.Add(this.btnGuardar);
            this.pnlBotones.Controls.Add(this.btnEliminar);
            this.pnlBotones.Controls.Add(this.btnLimpiar);
            this.pnlBotones.Location = new System.Drawing.Point(12, 665);
            this.pnlBotones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(531, 48);
            this.pnlBotones.TabIndex = 1;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(0, 6);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(120, 36);
            this.btnNuevo.TabIndex = 20;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(110)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(131, 6);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 36);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(260, 6);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 36);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(389, 6);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 36);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.Text = "Cancelar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // mantenimientoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1717, 726);
            this.Controls.Add(this.grpDatosCliente);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.grpListaClientes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1210, 763);
            this.Name = "mantenimientoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JarasTech  —  Mantenimiento de Clientes";
            this.Load += new System.EventHandler(this.mantenimientoClientes_Load);
            this.grpDatosCliente.ResumeLayout(false);
            this.grpDatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotografia)).EndInit();
            this.grpListaClientes.ResumeLayout(false);
            this.grpListaClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        // ── Declaraciones de campos ───────────────────────────────────────
        private System.Windows.Forms.GroupBox grpDatosCliente;
        private System.Windows.Forms.Label lblTipoIdentificacion;
        private System.Windows.Forms.RadioButton rdoNacional;
        private System.Windows.Forms.RadioButton rdoExtranjero;
        private System.Windows.Forms.Label lblNumeroIdentificacion;
        private System.Windows.Forms.TextBox txtNumeroIdentificacion;
        private System.Windows.Forms.Button btnConsultarAPI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.RadioButton rdoMasculino;
        private System.Windows.Forms.RadioButton rdoFemenino;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.ComboBox cboProvincia;
        private System.Windows.Forms.Label lblDireccionExacta;
        private System.Windows.Forms.TextBox txtDireccionExacta;
        private System.Windows.Forms.Label lblFotografia;
        private System.Windows.Forms.PictureBox picFotografia;
        private System.Windows.Forms.Button btnCargarFoto;

        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;

        private System.Windows.Forms.GroupBox grpListaClientes;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvClientes;
    }
}
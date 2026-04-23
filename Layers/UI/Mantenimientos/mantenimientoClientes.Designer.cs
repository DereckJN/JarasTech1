namespace JarasTech.Layers.UI
{
    partial class mantenimientoClientes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlIzquierdo = new System.Windows.Forms.Panel();
            this.grpIdentificacion = new System.Windows.Forms.GroupBox();
            this.lblTipoIdentificacion = new System.Windows.Forms.Label();
            this.rdoNacional = new System.Windows.Forms.RadioButton();
            this.rdoExtranjero = new System.Windows.Forms.RadioButton();
            this.lblNumeroIdentificacion = new System.Windows.Forms.Label();
            this.txtNumeroIdentificacion = new System.Windows.Forms.TextBox();
            this.btnConsultarAPI = new System.Windows.Forms.Button();
            this.lblEstadoAPI = new System.Windows.Forms.Label();
            this.grpDatos = new System.Windows.Forms.GroupBox();
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
            this.grpFoto = new System.Windows.Forms.GroupBox();
            this.picFotografia = new System.Windows.Forms.PictureBox();
            this.btnCargarFoto = new System.Windows.Forms.Button();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlDerecho = new System.Windows.Forms.Panel();
            this.grpListaClientes = new System.Windows.Forms.GroupBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblConteo = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            this.pnlIzquierdo.SuspendLayout();
            this.grpIdentificacion.SuspendLayout();
            this.grpDatos.SuspendLayout();
            this.grpFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotografia)).BeginInit();
            this.pnlBotones.SuspendLayout();
            this.pnlDerecho.SuspendLayout();
            this.grpListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(55)))));
            this.pnlTop.Controls.Add(this.lblTitulo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1380, 52);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(14, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(370, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "👥  Mantenimiento de Clientes";
            // 
            // pnlIzquierdo
            // 
            this.pnlIzquierdo.AutoScroll = true;
            this.pnlIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.pnlIzquierdo.Controls.Add(this.grpIdentificacion);
            this.pnlIzquierdo.Controls.Add(this.grpDatos);
            this.pnlIzquierdo.Controls.Add(this.grpFoto);
            this.pnlIzquierdo.Controls.Add(this.pnlBotones);
            this.pnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIzquierdo.Location = new System.Drawing.Point(0, 52);
            this.pnlIzquierdo.Name = "pnlIzquierdo";
            this.pnlIzquierdo.Size = new System.Drawing.Size(500, 698);
            this.pnlIzquierdo.TabIndex = 1;
            // 
            // grpIdentificacion
            // 
            this.grpIdentificacion.Controls.Add(this.lblTipoIdentificacion);
            this.grpIdentificacion.Controls.Add(this.rdoNacional);
            this.grpIdentificacion.Controls.Add(this.rdoExtranjero);
            this.grpIdentificacion.Controls.Add(this.lblNumeroIdentificacion);
            this.grpIdentificacion.Controls.Add(this.txtNumeroIdentificacion);
            this.grpIdentificacion.Controls.Add(this.btnConsultarAPI);
            this.grpIdentificacion.Controls.Add(this.lblEstadoAPI);
            this.grpIdentificacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpIdentificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(110)))));
            this.grpIdentificacion.Location = new System.Drawing.Point(10, 10);
            this.grpIdentificacion.Name = "grpIdentificacion";
            this.grpIdentificacion.Size = new System.Drawing.Size(478, 140);
            this.grpIdentificacion.TabIndex = 0;
            this.grpIdentificacion.TabStop = false;
            this.grpIdentificacion.Text = "Identificación";
            // 
            // lblTipoIdentificacion
            // 
            this.lblTipoIdentificacion.AutoSize = true;
            this.lblTipoIdentificacion.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTipoIdentificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTipoIdentificacion.Location = new System.Drawing.Point(10, 28);
            this.lblTipoIdentificacion.Name = "lblTipoIdentificacion";
            this.lblTipoIdentificacion.Size = new System.Drawing.Size(42, 20);
            this.lblTipoIdentificacion.TabIndex = 0;
            this.lblTipoIdentificacion.Text = "Tipo:";
            // 
            // rdoNacional
            // 
            this.rdoNacional.Checked = true;
            this.rdoNacional.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdoNacional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(110)))));
            this.rdoNacional.Location = new System.Drawing.Point(60, 25);
            this.rdoNacional.Name = "rdoNacional";
            this.rdoNacional.Size = new System.Drawing.Size(95, 22);
            this.rdoNacional.TabIndex = 0;
            this.rdoNacional.TabStop = true;
            this.rdoNacional.Text = "Nacional";
            this.rdoNacional.CheckedChanged += new System.EventHandler(this.rdoNacional_CheckedChanged);
            // 
            // rdoExtranjero
            // 
            this.rdoExtranjero.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdoExtranjero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(110)))));
            this.rdoExtranjero.Location = new System.Drawing.Point(164, 25);
            this.rdoExtranjero.Name = "rdoExtranjero";
            this.rdoExtranjero.Size = new System.Drawing.Size(105, 22);
            this.rdoExtranjero.TabIndex = 1;
            this.rdoExtranjero.Text = "Extranjero";
            // 
            // lblNumeroIdentificacion
            // 
            this.lblNumeroIdentificacion.AutoSize = true;
            this.lblNumeroIdentificacion.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblNumeroIdentificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblNumeroIdentificacion.Location = new System.Drawing.Point(10, 56);
            this.lblNumeroIdentificacion.Name = "lblNumeroIdentificacion";
            this.lblNumeroIdentificacion.Size = new System.Drawing.Size(123, 20);
            this.lblNumeroIdentificacion.TabIndex = 2;
            this.lblNumeroIdentificacion.Text = "N° Identificación:";
            // 
            // txtNumeroIdentificacion
            // 
            this.txtNumeroIdentificacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNumeroIdentificacion.Location = new System.Drawing.Point(10, 76);
            this.txtNumeroIdentificacion.MaxLength = 20;
            this.txtNumeroIdentificacion.Name = "txtNumeroIdentificacion";
            this.txtNumeroIdentificacion.Size = new System.Drawing.Size(195, 30);
            this.txtNumeroIdentificacion.TabIndex = 2;
            this.txtNumeroIdentificacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeroIdentificacion_KeyDown);
            // 
            // btnConsultarAPI
            // 
            this.btnConsultarAPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(110)))));
            this.btnConsultarAPI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarAPI.FlatAppearance.BorderSize = 0;
            this.btnConsultarAPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarAPI.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnConsultarAPI.ForeColor = System.Drawing.Color.White;
            this.btnConsultarAPI.Location = new System.Drawing.Point(214, 74);
            this.btnConsultarAPI.Name = "btnConsultarAPI";
            this.btnConsultarAPI.Size = new System.Drawing.Size(255, 32);
            this.btnConsultarAPI.TabIndex = 3;
            this.btnConsultarAPI.Text = "Consultar API Hacienda";
            this.btnConsultarAPI.UseVisualStyleBackColor = false;
            this.btnConsultarAPI.Click += new System.EventHandler(this.btnConsultarAPI_Click);
            // 
            // lblEstadoAPI
            // 
            this.lblEstadoAPI.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblEstadoAPI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.lblEstadoAPI.Location = new System.Drawing.Point(10, 116);
            this.lblEstadoAPI.Name = "lblEstadoAPI";
            this.lblEstadoAPI.Size = new System.Drawing.Size(458, 18);
            this.lblEstadoAPI.TabIndex = 99;
            this.lblEstadoAPI.Text = "Ingrese la cédula y presione Consultar";
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.lblApellidos);
            this.grpDatos.Controls.Add(this.txtApellidos);
            this.grpDatos.Controls.Add(this.lblSexo);
            this.grpDatos.Controls.Add(this.rdoMasculino);
            this.grpDatos.Controls.Add(this.rdoFemenino);
            this.grpDatos.Controls.Add(this.lblTelefono);
            this.grpDatos.Controls.Add(this.txtTelefono);
            this.grpDatos.Controls.Add(this.lblCorreoElectronico);
            this.grpDatos.Controls.Add(this.txtCorreoElectronico);
            this.grpDatos.Controls.Add(this.lblProvincia);
            this.grpDatos.Controls.Add(this.cboProvincia);
            this.grpDatos.Controls.Add(this.lblDireccionExacta);
            this.grpDatos.Controls.Add(this.txtDireccionExacta);
            this.grpDatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(110)))));
            this.grpDatos.Location = new System.Drawing.Point(10, 158);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(478, 356);
            this.grpDatos.TabIndex = 1;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos Personales";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblNombre.Location = new System.Drawing.Point(10, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.Location = new System.Drawing.Point(10, 46);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(225, 30);
            this.txtNombre.TabIndex = 4;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblApellidos.Location = new System.Drawing.Point(244, 26);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(75, 20);
            this.lblApellidos.TabIndex = 1;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtApellidos.Location = new System.Drawing.Point(244, 46);
            this.txtApellidos.MaxLength = 100;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(224, 30);
            this.txtApellidos.TabIndex = 5;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblSexo.Location = new System.Drawing.Point(10, 92);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(44, 20);
            this.lblSexo.TabIndex = 2;
            this.lblSexo.Text = "Sexo:";
            // 
            // rdoMasculino
            // 
            this.rdoMasculino.Checked = true;
            this.rdoMasculino.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdoMasculino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(110)))));
            this.rdoMasculino.Location = new System.Drawing.Point(55, 90);
            this.rdoMasculino.Name = "rdoMasculino";
            this.rdoMasculino.Size = new System.Drawing.Size(100, 22);
            this.rdoMasculino.TabIndex = 6;
            this.rdoMasculino.TabStop = true;
            this.rdoMasculino.Text = "Masculino";
            // 
            // rdoFemenino
            // 
            this.rdoFemenino.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdoFemenino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(110)))));
            this.rdoFemenino.Location = new System.Drawing.Point(165, 90);
            this.rdoFemenino.Name = "rdoFemenino";
            this.rdoFemenino.Size = new System.Drawing.Size(100, 22);
            this.rdoFemenino.TabIndex = 7;
            this.rdoFemenino.Text = "Femenino";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTelefono.Location = new System.Drawing.Point(10, 126);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(70, 20);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTelefono.Location = new System.Drawing.Point(10, 146);
            this.txtTelefono.MaxLength = 20;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(150, 30);
            this.txtTelefono.TabIndex = 8;
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCorreoElectronico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblCorreoElectronico.Location = new System.Drawing.Point(170, 126);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(135, 20);
            this.lblCorreoElectronico.TabIndex = 4;
            this.lblCorreoElectronico.Text = "Correo Electrónico:";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCorreoElectronico.Location = new System.Drawing.Point(170, 146);
            this.txtCorreoElectronico.MaxLength = 100;
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(298, 30);
            this.txtCorreoElectronico.TabIndex = 9;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblProvincia.Location = new System.Drawing.Point(10, 192);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(72, 20);
            this.lblProvincia.TabIndex = 5;
            this.lblProvincia.Text = "Provincia:";
            // 
            // cboProvincia
            // 
            this.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboProvincia.Location = new System.Drawing.Point(10, 212);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(458, 31);
            this.cboProvincia.TabIndex = 10;
            // 
            // lblDireccionExacta
            // 
            this.lblDireccionExacta.AutoSize = true;
            this.lblDireccionExacta.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDireccionExacta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblDireccionExacta.Location = new System.Drawing.Point(10, 258);
            this.lblDireccionExacta.Name = "lblDireccionExacta";
            this.lblDireccionExacta.Size = new System.Drawing.Size(122, 20);
            this.lblDireccionExacta.TabIndex = 6;
            this.lblDireccionExacta.Text = "Dirección Exacta:";
            // 
            // txtDireccionExacta
            // 
            this.txtDireccionExacta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDireccionExacta.Location = new System.Drawing.Point(10, 278);
            this.txtDireccionExacta.MaxLength = 255;
            this.txtDireccionExacta.Multiline = true;
            this.txtDireccionExacta.Name = "txtDireccionExacta";
            this.txtDireccionExacta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDireccionExacta.Size = new System.Drawing.Size(458, 60);
            this.txtDireccionExacta.TabIndex = 11;
            // 
            // grpFoto
            // 
            this.grpFoto.Controls.Add(this.picFotografia);
            this.grpFoto.Controls.Add(this.btnCargarFoto);
            this.grpFoto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(110)))));
            this.grpFoto.Location = new System.Drawing.Point(10, 522);
            this.grpFoto.Name = "grpFoto";
            this.grpFoto.Size = new System.Drawing.Size(478, 118);
            this.grpFoto.TabIndex = 2;
            this.grpFoto.TabStop = false;
            this.grpFoto.Text = "Fotografía";
            // 
            // picFotografia
            // 
            this.picFotografia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.picFotografia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFotografia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFotografia.Location = new System.Drawing.Point(10, 20);
            this.picFotografia.Name = "picFotografia";
            this.picFotografia.Size = new System.Drawing.Size(90, 90);
            this.picFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFotografia.TabIndex = 0;
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
            this.btnCargarFoto.Location = new System.Drawing.Point(112, 22);
            this.btnCargarFoto.Name = "btnCargarFoto";
            this.btnCargarFoto.Size = new System.Drawing.Size(150, 34);
            this.btnCargarFoto.TabIndex = 1;
            this.btnCargarFoto.Text = "Cargar Foto";
            this.btnCargarFoto.UseVisualStyleBackColor = false;
            this.btnCargarFoto.Click += new System.EventHandler(this.btnCargarFoto_Click);
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.pnlBotones.Controls.Add(this.btnNuevo);
            this.pnlBotones.Controls.Add(this.btnGuardar);
            this.pnlBotones.Controls.Add(this.btnEliminar);
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 648);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(500, 50);
            this.pnlBotones.TabIndex = 3;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(6, 7);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(112, 36);
            this.btnNuevo.TabIndex = 20;
            this.btnNuevo.Text = "➕ Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(133, 7);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 36);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "💾 Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(264, 7);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 36);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "🗑 Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(382, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 36);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "❌ Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnlDerecho
            // 
            this.pnlDerecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.pnlDerecho.Controls.Add(this.grpListaClientes);
            this.pnlDerecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDerecho.Location = new System.Drawing.Point(500, 52);
            this.pnlDerecho.Name = "pnlDerecho";
            this.pnlDerecho.Padding = new System.Windows.Forms.Padding(10);
            this.pnlDerecho.Size = new System.Drawing.Size(880, 698);
            this.pnlDerecho.TabIndex = 2;
            // 
            // grpListaClientes
            // 
            this.grpListaClientes.BackColor = System.Drawing.Color.White;
            this.grpListaClientes.Controls.Add(this.lblFiltro);
            this.grpListaClientes.Controls.Add(this.txtFiltro);
            this.grpListaClientes.Controls.Add(this.btnBuscar);
            this.grpListaClientes.Controls.Add(this.lblConteo);
            this.grpListaClientes.Controls.Add(this.dgvClientes);
            this.grpListaClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpListaClientes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpListaClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(110)))));
            this.grpListaClientes.Location = new System.Drawing.Point(10, 10);
            this.grpListaClientes.Name = "grpListaClientes";
            this.grpListaClientes.Size = new System.Drawing.Size(860, 678);
            this.grpListaClientes.TabIndex = 0;
            this.grpListaClientes.TabStop = false;
            this.grpListaClientes.Text = "Lista de Clientes";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblFiltro.Location = new System.Drawing.Point(12, 26);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(199, 20);
            this.lblFiltro.TabIndex = 0;
            this.lblFiltro.Text = "Buscar por nombre o cédula:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFiltro.Location = new System.Drawing.Point(12, 46);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(490, 30);
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
            this.btnBuscar.Location = new System.Drawing.Point(512, 44);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 32);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "🔍 Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblConteo
            // 
            this.lblConteo.AutoSize = true;
            this.lblConteo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblConteo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(140)))));
            this.lblConteo.Location = new System.Drawing.Point(636, 52);
            this.lblConteo.Name = "lblConteo";
            this.lblConteo.Size = new System.Drawing.Size(107, 19);
            this.lblConteo.TabIndex = 32;
            this.lblConteo.Text = "Total: 0 clientes";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvClientes.ColumnHeadersHeight = 36;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle30.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle30;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.Location = new System.Drawing.Point(12, 84);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 30;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(836, 582);
            this.dgvClientes.TabIndex = 32;
            this.dgvClientes.SelectionChanged += new System.EventHandler(this.dgvClientes_SelectionChanged);
            // 
            // mantenimientoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1380, 750);
            this.Controls.Add(this.pnlDerecho);
            this.Controls.Add(this.pnlIzquierdo);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "mantenimientoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JarasTech — Mantenimiento de Clientes";
            this.Load += new System.EventHandler(this.mantenimientoClientes_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlIzquierdo.ResumeLayout(false);
            this.grpIdentificacion.ResumeLayout(false);
            this.grpIdentificacion.PerformLayout();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.grpFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFotografia)).EndInit();
            this.pnlBotones.ResumeLayout(false);
            this.pnlDerecho.ResumeLayout(false);
            this.grpListaClientes.ResumeLayout(false);
            this.grpListaClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlIzquierdo;
        private System.Windows.Forms.GroupBox grpIdentificacion;
        private System.Windows.Forms.Label lblTipoIdentificacion;
        private System.Windows.Forms.RadioButton rdoNacional;
        private System.Windows.Forms.RadioButton rdoExtranjero;
        private System.Windows.Forms.Label lblNumeroIdentificacion;
        private System.Windows.Forms.TextBox txtNumeroIdentificacion;
        private System.Windows.Forms.Button btnConsultarAPI;
        private System.Windows.Forms.Label lblEstadoAPI;
        private System.Windows.Forms.GroupBox grpDatos;
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
        private System.Windows.Forms.GroupBox grpFoto;
        private System.Windows.Forms.PictureBox picFotografia;
        private System.Windows.Forms.Button btnCargarFoto;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnlDerecho;
        private System.Windows.Forms.GroupBox grpListaClientes;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblConteo;
        private System.Windows.Forms.DataGridView dgvClientes;
    }
}
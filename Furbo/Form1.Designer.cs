namespace Furbo
{
    partial class Furbo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Furbo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcPrincipal = new System.Windows.Forms.TabControl();
            this.tpJornadas = new System.Windows.Forms.TabPage();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblJornada = new System.Windows.Forms.Label();
            this.pcbMax = new System.Windows.Forms.PictureBox();
            this.PcbGoles = new System.Windows.Forms.PictureBox();
            this.PcbBotaOro = new System.Windows.Forms.PictureBox();
            this.pcbPuskas = new System.Windows.Forms.PictureBox();
            this.lblPichichiData = new System.Windows.Forms.Label();
            this.lblMaxData = new System.Windows.Forms.Label();
            this.lvPerdedor = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pcbVS = new System.Windows.Forms.PictureBox();
            this.lvGanador = new System.Windows.Forms.ListView();
            this.clmNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmGoles = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtGanador = new System.Windows.Forms.TextBox();
            this.lblPerdedor = new System.Windows.Forms.Label();
            this.lblGanador = new System.Windows.Forms.Label();
            this.txtPerdedor = new System.Windows.Forms.TextBox();
            this.lblPuskasData = new System.Windows.Forms.Label();
            this.lbltotalData = new System.Windows.Forms.Label();
            this.prbBarra = new System.Windows.Forms.ProgressBar();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvJornadas = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.participacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcEstadisticas = new System.Windows.Forms.TabPage();
            this.lblResul = new System.Windows.Forms.Label();
            this.dgvResul = new System.Windows.Forms.DataGridView();
            this.dgvStats = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pichichi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puskas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcJugadores = new System.Windows.Forms.TabPage();
            this.lwJugadores = new System.Windows.Forms.ListView();
            this.imgLista = new System.Windows.Forms.ImageList(this.components);
            this.tcPrincipal.SuspendLayout();
            this.tpJornadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbGoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBotaOro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPuskas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJornadas)).BeginInit();
            this.tcEstadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).BeginInit();
            this.tcJugadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Controls.Add(this.tpJornadas);
            this.tcPrincipal.Controls.Add(this.tcEstadisticas);
            this.tcPrincipal.Controls.Add(this.tcJugadores);
            this.tcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPrincipal.Enabled = false;
            this.tcPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(1061, 506);
            this.tcPrincipal.TabIndex = 1;
            // 
            // tpJornadas
            // 
            this.tpJornadas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpJornadas.BackgroundImage")));
            this.tpJornadas.Controls.Add(this.lblInfo);
            this.tpJornadas.Controls.Add(this.lblJornada);
            this.tpJornadas.Controls.Add(this.pcbMax);
            this.tpJornadas.Controls.Add(this.PcbGoles);
            this.tpJornadas.Controls.Add(this.PcbBotaOro);
            this.tpJornadas.Controls.Add(this.pcbPuskas);
            this.tpJornadas.Controls.Add(this.lblPichichiData);
            this.tpJornadas.Controls.Add(this.lblMaxData);
            this.tpJornadas.Controls.Add(this.lvPerdedor);
            this.tpJornadas.Controls.Add(this.pcbVS);
            this.tpJornadas.Controls.Add(this.lvGanador);
            this.tpJornadas.Controls.Add(this.txtGanador);
            this.tpJornadas.Controls.Add(this.lblPerdedor);
            this.tpJornadas.Controls.Add(this.lblGanador);
            this.tpJornadas.Controls.Add(this.txtPerdedor);
            this.tpJornadas.Controls.Add(this.lblPuskasData);
            this.tpJornadas.Controls.Add(this.lbltotalData);
            this.tpJornadas.Controls.Add(this.prbBarra);
            this.tpJornadas.Controls.Add(this.lblTitulo);
            this.tpJornadas.Controls.Add(this.dgvJornadas);
            this.tpJornadas.Location = new System.Drawing.Point(4, 22);
            this.tpJornadas.Name = "tpJornadas";
            this.tpJornadas.Padding = new System.Windows.Forms.Padding(3);
            this.tpJornadas.Size = new System.Drawing.Size(1053, 480);
            this.tpJornadas.TabIndex = 2;
            this.tpJornadas.Text = "Jornadas";
            this.tpJornadas.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblInfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(3, 462);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 15);
            this.lblInfo.TabIndex = 79;
            // 
            // lblJornada
            // 
            this.lblJornada.AutoSize = true;
            this.lblJornada.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJornada.Location = new System.Drawing.Point(698, 101);
            this.lblJornada.Name = "lblJornada";
            this.lblJornada.Size = new System.Drawing.Size(0, 26);
            this.lblJornada.TabIndex = 78;
            // 
            // pcbMax
            // 
            this.pcbMax.Image = ((System.Drawing.Image)(resources.GetObject("pcbMax.Image")));
            this.pcbMax.Location = new System.Drawing.Point(696, 213);
            this.pcbMax.Name = "pcbMax";
            this.pcbMax.Size = new System.Drawing.Size(73, 49);
            this.pcbMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbMax.TabIndex = 77;
            this.pcbMax.TabStop = false;
            // 
            // PcbGoles
            // 
            this.PcbGoles.Image = ((System.Drawing.Image)(resources.GetObject("PcbGoles.Image")));
            this.PcbGoles.Location = new System.Drawing.Point(696, 268);
            this.PcbGoles.Name = "PcbGoles";
            this.PcbGoles.Size = new System.Drawing.Size(73, 49);
            this.PcbGoles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbGoles.TabIndex = 76;
            this.PcbGoles.TabStop = false;
            // 
            // PcbBotaOro
            // 
            this.PcbBotaOro.Image = ((System.Drawing.Image)(resources.GetObject("PcbBotaOro.Image")));
            this.PcbBotaOro.Location = new System.Drawing.Point(696, 323);
            this.PcbBotaOro.Name = "PcbBotaOro";
            this.PcbBotaOro.Size = new System.Drawing.Size(73, 49);
            this.PcbBotaOro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbBotaOro.TabIndex = 75;
            this.PcbBotaOro.TabStop = false;
            // 
            // pcbPuskas
            // 
            this.pcbPuskas.Image = ((System.Drawing.Image)(resources.GetObject("pcbPuskas.Image")));
            this.pcbPuskas.Location = new System.Drawing.Point(696, 378);
            this.pcbPuskas.Name = "pcbPuskas";
            this.pcbPuskas.Size = new System.Drawing.Size(73, 49);
            this.pcbPuskas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPuskas.TabIndex = 74;
            this.pcbPuskas.TabStop = false;
            // 
            // lblPichichiData
            // 
            this.lblPichichiData.AutoSize = true;
            this.lblPichichiData.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPichichiData.Location = new System.Drawing.Point(775, 337);
            this.lblPichichiData.Name = "lblPichichiData";
            this.lblPichichiData.Size = new System.Drawing.Size(0, 26);
            this.lblPichichiData.TabIndex = 73;
            // 
            // lblMaxData
            // 
            this.lblMaxData.AutoSize = true;
            this.lblMaxData.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxData.Location = new System.Drawing.Point(775, 224);
            this.lblMaxData.Name = "lblMaxData";
            this.lblMaxData.Size = new System.Drawing.Size(0, 26);
            this.lblMaxData.TabIndex = 72;
            // 
            // lvPerdedor
            // 
            this.lvPerdedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lvPerdedor.BackgroundImage")));
            this.lvPerdedor.BackgroundImageTiled = true;
            this.lvPerdedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvPerdedor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvPerdedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPerdedor.FullRowSelect = true;
            this.lvPerdedor.HideSelection = false;
            this.lvPerdedor.Location = new System.Drawing.Point(882, 182);
            this.lvPerdedor.Name = "lvPerdedor";
            this.lvPerdedor.Size = new System.Drawing.Size(163, 245);
            this.lvPerdedor.TabIndex = 71;
            this.lvPerdedor.UseCompatibleStateImageBehavior = false;
            this.lvPerdedor.View = System.Windows.Forms.View.Details;
            this.lvPerdedor.DoubleClick += new System.EventHandler(this.jugadorSeleccionado);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 109;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Goles";
            this.columnHeader2.Width = 53;
            // 
            // pcbVS
            // 
            this.pcbVS.Image = ((System.Drawing.Image)(resources.GetObject("pcbVS.Image")));
            this.pcbVS.Location = new System.Drawing.Point(696, 130);
            this.pcbVS.Name = "pcbVS";
            this.pcbVS.Size = new System.Drawing.Size(110, 46);
            this.pcbVS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbVS.TabIndex = 0;
            this.pcbVS.TabStop = false;
            // 
            // lvGanador
            // 
            this.lvGanador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lvGanador.BackgroundImage")));
            this.lvGanador.BackgroundImageTiled = true;
            this.lvGanador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvGanador.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNombre,
            this.clmGoles});
            this.lvGanador.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvGanador.FullRowSelect = true;
            this.lvGanador.HideSelection = false;
            this.lvGanador.Location = new System.Drawing.Point(493, 182);
            this.lvGanador.Name = "lvGanador";
            this.lvGanador.Size = new System.Drawing.Size(163, 245);
            this.lvGanador.TabIndex = 70;
            this.lvGanador.UseCompatibleStateImageBehavior = false;
            this.lvGanador.View = System.Windows.Forms.View.Details;
            this.lvGanador.DoubleClick += new System.EventHandler(this.jugadorSeleccionado);
            // 
            // clmNombre
            // 
            this.clmNombre.Text = "Nombre";
            this.clmNombre.Width = 109;
            // 
            // clmGoles
            // 
            this.clmGoles.Text = "Goles";
            this.clmGoles.Width = 53;
            // 
            // txtGanador
            // 
            this.txtGanador.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGanador.Location = new System.Drawing.Point(534, 130);
            this.txtGanador.Multiline = true;
            this.txtGanador.Name = "txtGanador";
            this.txtGanador.ReadOnly = true;
            this.txtGanador.Size = new System.Drawing.Size(79, 46);
            this.txtGanador.TabIndex = 69;
            // 
            // lblPerdedor
            // 
            this.lblPerdedor.AutoSize = true;
            this.lblPerdedor.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerdedor.Location = new System.Drawing.Point(888, 101);
            this.lblPerdedor.Name = "lblPerdedor";
            this.lblPerdedor.Size = new System.Drawing.Size(156, 26);
            this.lblPerdedor.TabIndex = 68;
            this.lblPerdedor.Text = "Equipo Perdedor";
            // 
            // lblGanador
            // 
            this.lblGanador.AutoSize = true;
            this.lblGanador.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanador.Location = new System.Drawing.Point(497, 101);
            this.lblGanador.Name = "lblGanador";
            this.lblGanador.Size = new System.Drawing.Size(149, 26);
            this.lblGanador.TabIndex = 67;
            this.lblGanador.Text = "Equipo Ganador";
            // 
            // txtPerdedor
            // 
            this.txtPerdedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerdedor.Location = new System.Drawing.Point(926, 130);
            this.txtPerdedor.Multiline = true;
            this.txtPerdedor.Name = "txtPerdedor";
            this.txtPerdedor.ReadOnly = true;
            this.txtPerdedor.Size = new System.Drawing.Size(79, 46);
            this.txtPerdedor.TabIndex = 66;
            // 
            // lblPuskasData
            // 
            this.lblPuskasData.AutoSize = true;
            this.lblPuskasData.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuskasData.Location = new System.Drawing.Point(775, 392);
            this.lblPuskasData.Name = "lblPuskasData";
            this.lblPuskasData.Size = new System.Drawing.Size(0, 26);
            this.lblPuskasData.TabIndex = 64;
            // 
            // lbltotalData
            // 
            this.lbltotalData.AutoSize = true;
            this.lbltotalData.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalData.Location = new System.Drawing.Point(775, 279);
            this.lbltotalData.Name = "lbltotalData";
            this.lbltotalData.Size = new System.Drawing.Size(0, 26);
            this.lbltotalData.TabIndex = 62;
            // 
            // prbBarra
            // 
            this.prbBarra.Location = new System.Drawing.Point(8, 436);
            this.prbBarra.Name = "prbBarra";
            this.prbBarra.Size = new System.Drawing.Size(1037, 23);
            this.prbBarra.Step = 1;
            this.prbBarra.TabIndex = 60;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(299, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(427, 42);
            this.lblTitulo.TabIndex = 59;
            this.lblTitulo.Text = "Listado de Jornadas Jugadas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvJornadas
            // 
            this.dgvJornadas.AllowUserToAddRows = false;
            this.dgvJornadas.AllowUserToDeleteRows = false;
            this.dgvJornadas.AllowUserToResizeColumns = false;
            this.dgvJornadas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvJornadas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJornadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvJornadas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvJornadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJornadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJornadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJornadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.fecha,
            this.participacion});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJornadas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvJornadas.EnableHeadersVisualStyles = false;
            this.dgvJornadas.Location = new System.Drawing.Point(8, 101);
            this.dgvJornadas.Name = "dgvJornadas";
            this.dgvJornadas.ReadOnly = true;
            this.dgvJornadas.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvJornadas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvJornadas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvJornadas.Size = new System.Drawing.Size(468, 326);
            this.dgvJornadas.TabIndex = 38;
            this.dgvJornadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgJorndadas_CellClick);
            // 
            // numero
            // 
            this.numero.HeaderText = "Numero de Jornada";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 200;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // participacion
            // 
            this.participacion.HeaderText = "Nº de participantes";
            this.participacion.Name = "participacion";
            this.participacion.ReadOnly = true;
            this.participacion.Width = 150;
            // 
            // tcEstadisticas
            // 
            this.tcEstadisticas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tcEstadisticas.BackgroundImage")));
            this.tcEstadisticas.Controls.Add(this.lblResul);
            this.tcEstadisticas.Controls.Add(this.dgvResul);
            this.tcEstadisticas.Controls.Add(this.dgvStats);
            this.tcEstadisticas.Location = new System.Drawing.Point(4, 22);
            this.tcEstadisticas.Name = "tcEstadisticas";
            this.tcEstadisticas.Padding = new System.Windows.Forms.Padding(3);
            this.tcEstadisticas.Size = new System.Drawing.Size(1053, 480);
            this.tcEstadisticas.TabIndex = 3;
            this.tcEstadisticas.Text = "Estadisticas";
            this.tcEstadisticas.UseVisualStyleBackColor = true;
            // 
            // lblResul
            // 
            this.lblResul.AutoSize = true;
            this.lblResul.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResul.Location = new System.Drawing.Point(52, 390);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(0, 26);
            this.lblResul.TabIndex = 68;
            // 
            // dgvResul
            // 
            this.dgvResul.AllowUserToAddRows = false;
            this.dgvResul.AllowUserToDeleteRows = false;
            this.dgvResul.AllowUserToResizeColumns = false;
            this.dgvResul.AllowUserToResizeRows = false;
            this.dgvResul.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResul.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResul.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvResul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResul.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvResul.Location = new System.Drawing.Point(57, 419);
            this.dgvResul.Name = "dgvResul";
            this.dgvResul.ReadOnly = true;
            this.dgvResul.RowHeadersVisible = false;
            this.dgvResul.Size = new System.Drawing.Size(951, 58);
            this.dgvResul.TabIndex = 40;
            // 
            // dgvStats
            // 
            this.dgvStats.AllowUserToAddRows = false;
            this.dgvStats.AllowUserToDeleteRows = false;
            this.dgvStats.AllowUserToResizeColumns = false;
            this.dgvStats.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvStats.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvStats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStats.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvStats.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.pichichi,
            this.winrate,
            this.totales,
            this.puskas});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStats.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvStats.EnableHeadersVisualStyles = false;
            this.dgvStats.Location = new System.Drawing.Point(57, 6);
            this.dgvStats.Name = "dgvStats";
            this.dgvStats.ReadOnly = true;
            this.dgvStats.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStats.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvStats.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvStats.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvStats.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvStats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStats.Size = new System.Drawing.Size(951, 371);
            this.dgvStats.TabIndex = 39;
            this.dgvStats.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStats_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn1.HeaderText = "JUGADOR";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "PARTIDOS JUGADOS";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "GOLES/PARTIDO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // pichichi
            // 
            this.pichichi.HeaderText = "PICHICHIS";
            this.pichichi.Name = "pichichi";
            this.pichichi.ReadOnly = true;
            // 
            // winrate
            // 
            this.winrate.HeaderText = "WIN RATE";
            this.winrate.Name = "winrate";
            this.winrate.ReadOnly = true;
            // 
            // totales
            // 
            this.totales.HeaderText = "GOLES TOTALES";
            this.totales.Name = "totales";
            this.totales.ReadOnly = true;
            this.totales.Width = 200;
            // 
            // puskas
            // 
            this.puskas.HeaderText = "PUSKÁS";
            this.puskas.Name = "puskas";
            this.puskas.ReadOnly = true;
            this.puskas.Width = 80;
            // 
            // tcJugadores
            // 
            this.tcJugadores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tcJugadores.BackgroundImage")));
            this.tcJugadores.Controls.Add(this.lwJugadores);
            this.tcJugadores.Location = new System.Drawing.Point(4, 22);
            this.tcJugadores.Name = "tcJugadores";
            this.tcJugadores.Padding = new System.Windows.Forms.Padding(3);
            this.tcJugadores.Size = new System.Drawing.Size(1053, 480);
            this.tcJugadores.TabIndex = 4;
            this.tcJugadores.Text = "Jugadores";
            this.tcJugadores.UseVisualStyleBackColor = true;
            // 
            // lwJugadores
            // 
            this.lwJugadores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lwJugadores.BackgroundImage")));
            this.lwJugadores.BackgroundImageTiled = true;
            this.lwJugadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lwJugadores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwJugadores.HideSelection = false;
            this.lwJugadores.LargeImageList = this.imgLista;
            this.lwJugadores.Location = new System.Drawing.Point(3, 3);
            this.lwJugadores.Name = "lwJugadores";
            this.lwJugadores.Size = new System.Drawing.Size(1047, 474);
            this.lwJugadores.TabIndex = 0;
            this.lwJugadores.UseCompatibleStateImageBehavior = false;
            this.lwJugadores.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lwJugadores_MouseDoubleClick);
            // 
            // imgLista
            // 
            this.imgLista.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgLista.ImageSize = new System.Drawing.Size(169, 238);
            this.imgLista.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Furbo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 506);
            this.Controls.Add(this.tcPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Furbo";
            this.Text = "Furbo";
            this.Load += new System.EventHandler(this.Furbo_Load);
            this.tcPrincipal.ResumeLayout(false);
            this.tpJornadas.ResumeLayout(false);
            this.tpJornadas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbGoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBotaOro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPuskas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJornadas)).EndInit();
            this.tcEstadisticas.ResumeLayout(false);
            this.tcEstadisticas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).EndInit();
            this.tcJugadores.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcPrincipal;
        private System.Windows.Forms.TabPage tpJornadas;
        private System.Windows.Forms.PictureBox pcbVS;
        private System.Windows.Forms.ListView lvGanador;
        private System.Windows.Forms.ColumnHeader clmNombre;
        private System.Windows.Forms.ColumnHeader clmGoles;
        private System.Windows.Forms.TextBox txtGanador;
        private System.Windows.Forms.Label lblPerdedor;
        private System.Windows.Forms.Label lblGanador;
        private System.Windows.Forms.TextBox txtPerdedor;
        private System.Windows.Forms.Label lblPuskasData;
        private System.Windows.Forms.Label lbltotalData;
        private System.Windows.Forms.ProgressBar prbBarra;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvJornadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn participacion;
        private System.Windows.Forms.TabPage tcEstadisticas;
        private System.Windows.Forms.ListView lvPerdedor;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblPichichiData;
        private System.Windows.Forms.Label lblMaxData;
        private System.Windows.Forms.PictureBox pcbPuskas;
        private System.Windows.Forms.PictureBox PcbGoles;
        private System.Windows.Forms.PictureBox PcbBotaOro;
        private System.Windows.Forms.PictureBox pcbMax;
        private System.Windows.Forms.DataGridView dgvStats;
        private System.Windows.Forms.Label lblJornada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn pichichi;
        private System.Windows.Forms.DataGridViewTextBoxColumn winrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn totales;
        private System.Windows.Forms.DataGridViewTextBoxColumn puskas;
        private System.Windows.Forms.DataGridView dgvResul;
        private System.Windows.Forms.Label lblResul;
        private System.Windows.Forms.TabPage tcJugadores;
        private System.Windows.Forms.ListView lwJugadores;
        private System.Windows.Forms.ImageList imgLista;
        private System.Windows.Forms.Label lblInfo;
    }
}


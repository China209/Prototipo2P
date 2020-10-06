namespace CapaVista
{
    partial class frmTelefonos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelefonos));
            this.pnlCuerpo = new System.Windows.Forms.Panel();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.gbxIngresoDatos = new System.Windows.Forms.GroupBox();
            this.cmbMaestro = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvVistaDatos = new System.Windows.Forms.DataGridView();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.cmsEM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrHoraFecha = new System.Windows.Forms.Timer(this.components);
            this.pnlCuerpo.SuspendLayout();
            this.gbxIngresoDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaDatos)).BeginInit();
            this.pnlInferior.SuspendLayout();
            this.cmsEM.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.BackColor = System.Drawing.Color.White;
            this.pnlCuerpo.Controls.Add(this.btnRefrescar);
            this.pnlCuerpo.Controls.Add(this.lblBuscar);
            this.pnlCuerpo.Controls.Add(this.cmbBuscar);
            this.pnlCuerpo.Controls.Add(this.gbxIngresoDatos);
            this.pnlCuerpo.Controls.Add(this.dgvVistaDatos);
            this.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCuerpo.Location = new System.Drawing.Point(0, 72);
            this.pnlCuerpo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCuerpo.Name = "pnlCuerpo";
            this.pnlCuerpo.Size = new System.Drawing.Size(1274, 591);
            this.pnlCuerpo.TabIndex = 5;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefrescar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefrescar.FlatAppearance.BorderSize = 0;
            this.btnRefrescar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnRefrescar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefrescar.Location = new System.Drawing.Point(391, 215);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(220, 34);
            this.btnRefrescar.TabIndex = 13;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(730, 222);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(62, 20);
            this.lblBuscar.TabIndex = 12;
            this.lblBuscar.Text = "Buscar";
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Location = new System.Drawing.Point(819, 219);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(401, 28);
            this.cmbBuscar.TabIndex = 11;
            this.cmbBuscar.SelectedIndexChanged += new System.EventHandler(this.cmbBuscar_SelectedIndexChanged);
            // 
            // gbxIngresoDatos
            // 
            this.gbxIngresoDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxIngresoDatos.BackColor = System.Drawing.Color.White;
            this.gbxIngresoDatos.Controls.Add(this.cmbMaestro);
            this.gbxIngresoDatos.Controls.Add(this.txtTelefono);
            this.gbxIngresoDatos.Controls.Add(this.lblTelefono);
            this.gbxIngresoDatos.Controls.Add(this.lblNombre);
            this.gbxIngresoDatos.Controls.Add(this.btnModificar);
            this.gbxIngresoDatos.Controls.Add(this.btnGuardar);
            this.gbxIngresoDatos.Location = new System.Drawing.Point(54, 7);
            this.gbxIngresoDatos.Margin = new System.Windows.Forms.Padding(4);
            this.gbxIngresoDatos.Name = "gbxIngresoDatos";
            this.gbxIngresoDatos.Padding = new System.Windows.Forms.Padding(4);
            this.gbxIngresoDatos.Size = new System.Drawing.Size(1166, 189);
            this.gbxIngresoDatos.TabIndex = 3;
            this.gbxIngresoDatos.TabStop = false;
            this.gbxIngresoDatos.Text = "Datos de Maestro de Teléfono";
            // 
            // cmbMaestro
            // 
            this.cmbMaestro.FormattingEnabled = true;
            this.cmbMaestro.Location = new System.Drawing.Point(135, 33);
            this.cmbMaestro.Name = "cmbMaestro";
            this.cmbMaestro.Size = new System.Drawing.Size(339, 28);
            this.cmbMaestro.TabIndex = 10;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(765, 36);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(292, 27);
            this.txtTelefono.TabIndex = 9;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(644, 39);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(79, 20);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(32, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Maestro";
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificar.Location = new System.Drawing.Point(896, 123);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(220, 34);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Actualizar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(557, 123);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(220, 34);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvVistaDatos
            // 
            this.dgvVistaDatos.AllowUserToAddRows = false;
            this.dgvVistaDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVistaDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVistaDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvVistaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVistaDatos.GridColor = System.Drawing.Color.DarkGray;
            this.dgvVistaDatos.Location = new System.Drawing.Point(54, 273);
            this.dgvVistaDatos.Margin = new System.Windows.Forms.Padding(0);
            this.dgvVistaDatos.Name = "dgvVistaDatos";
            this.dgvVistaDatos.RowHeadersWidth = 51;
            this.dgvVistaDatos.RowTemplate.Height = 24;
            this.dgvVistaDatos.Size = new System.Drawing.Size(1166, 298);
            this.dgvVistaDatos.TabIndex = 2;
            this.dgvVistaDatos.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVistaDatos_CellMouseUp);
            // 
            // pnlInferior
            // 
            this.pnlInferior.BackColor = System.Drawing.Color.Silver;
            this.pnlInferior.Controls.Add(this.lblFecha);
            this.pnlInferior.Controls.Add(this.lblHora);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.ForeColor = System.Drawing.Color.Black;
            this.pnlInferior.Location = new System.Drawing.Point(0, 663);
            this.pnlInferior.Margin = new System.Windows.Forms.Padding(4);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(1274, 54);
            this.pnlInferior.TabIndex = 4;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(498, 15);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(56, 20);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(684, 15);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(47, 20);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "Hora";
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Margin = new System.Windows.Forms.Padding(5);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1274, 72);
            this.pnlSuperior.TabIndex = 3;
            // 
            // cmsEM
            // 
            this.cmsEM.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsEM.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsEM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEliminar,
            this.cmsModificar});
            this.cmsEM.Name = "cmsEM";
            this.cmsEM.Size = new System.Drawing.Size(158, 52);
            // 
            // cmsEliminar
            // 
            this.cmsEliminar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsEliminar.Name = "cmsEliminar";
            this.cmsEliminar.Size = new System.Drawing.Size(157, 24);
            this.cmsEliminar.Text = "Eliminar";
            this.cmsEliminar.Click += new System.EventHandler(this.cmsEliminar_Click);
            // 
            // cmsModificar
            // 
            this.cmsModificar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsModificar.Name = "cmsModificar";
            this.cmsModificar.Size = new System.Drawing.Size(157, 24);
            this.cmsModificar.Text = "Actualizar";
            this.cmsModificar.Click += new System.EventHandler(this.cmsModificar_Click);
            // 
            // tmrHoraFecha
            // 
            this.tmrHoraFecha.Enabled = true;
            this.tmrHoraFecha.Tick += new System.EventHandler(this.tmrHoraFecha_Tick);
            // 
            // frmTelefonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 717);
            this.Controls.Add(this.pnlCuerpo);
            this.Controls.Add(this.pnlInferior);
            this.Controls.Add(this.pnlSuperior);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTelefonos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maestro Telefonos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmModulo_FormClosing);
            this.pnlCuerpo.ResumeLayout(false);
            this.pnlCuerpo.PerformLayout();
            this.gbxIngresoDatos.ResumeLayout(false);
            this.gbxIngresoDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaDatos)).EndInit();
            this.pnlInferior.ResumeLayout(false);
            this.pnlInferior.PerformLayout();
            this.cmsEM.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCuerpo;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.DataGridView dgvVistaDatos;
        private System.Windows.Forms.GroupBox gbxIngresoDatos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ContextMenuStrip cmsEM;
        private System.Windows.Forms.ToolStripMenuItem cmsEliminar;
        private System.Windows.Forms.ToolStripMenuItem cmsModificar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer tmrHoraFecha;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.ComboBox cmbMaestro;
    }
}
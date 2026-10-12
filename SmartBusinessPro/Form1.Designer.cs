namespace SmartBusinessPro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTitulo = new Label();
            lblNombre = new Label();
            lblPrecio = new Label();
            lblStock = new Label();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            lblCategoria = new Label();
            lblProveedor = new Label();
            cmbProveedor = new ComboBox();
            cmbCategoria = new ComboBox();
            chkActivo = new CheckBox();
            btnGuardar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            lblEstado = new Label();
            btnProbarConexion = new Button();
            dgvProductos = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colProducto = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colCategoria = new DataGridViewTextBoxColumn();
            colProveedor = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(110, 215, 235);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(975, 55);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "SMARTBUSINESSPRO | GESTIÓN DE PRODUCTOS";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.FromArgb(110, 215, 235);
            lblNombre.Location = new Point(30, 78);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(75, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre :";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.ForeColor = Color.FromArgb(110, 215, 235);
            lblPrecio.Location = new Point(450, 78);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(60, 20);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio :";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStock.ForeColor = Color.FromArgb(110, 215, 235);
            lblStock.Location = new Point(690, 78);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(55, 20);
            lblStock.TabIndex = 3;
            lblStock.Text = "Stock :";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(40, 65, 100);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(120, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(305, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.FromArgb(40, 65, 100);
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.ForeColor = Color.White;
            txtPrecio.Location = new Point(520, 75);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(150, 23);
            txtPrecio.TabIndex = 5;
            // 
            // txtStock
            // 
            txtStock.BackColor = Color.FromArgb(40, 65, 100);
            txtStock.BorderStyle = BorderStyle.FixedSingle;
            txtStock.ForeColor = Color.White;
            txtStock.Location = new Point(755, 75);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(190, 23);
            txtStock.TabIndex = 6;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.ForeColor = Color.FromArgb(110, 215, 235);
            lblCategoria.Location = new Point(30, 123);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(84, 20);
            lblCategoria.TabIndex = 7;
            lblCategoria.Text = "Categoría :";
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProveedor.ForeColor = Color.FromArgb(110, 215, 235);
            lblProveedor.Location = new Point(555, 123);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(89, 20);
            lblProveedor.TabIndex = 20;
            lblProveedor.Text = "Proveedor :";
            // 
            // cmbProveedor
            // 
            cmbProveedor.BackColor = Color.FromArgb(40, 65, 100);
            cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProveedor.FlatStyle = FlatStyle.Flat;
            cmbProveedor.ForeColor = Color.White;
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Items.AddRange(new object[] { "Tech Solutions", "Digital Corp", "Global Supply" });
            cmbProveedor.Location = new Point(645, 120);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(300, 23);
            cmbProveedor.TabIndex = 21;
            // 
            // cmbCategoria
            // 
            cmbCategoria.BackColor = Color.FromArgb(40, 65, 100);
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FlatStyle = FlatStyle.Flat;
            cmbCategoria.ForeColor = Color.White;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(120, 120);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(305, 23);
            cmbCategoria.TabIndex = 9;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Checked = true;
            chkActivo.CheckState = CheckState.Checked;
            chkActivo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkActivo.ForeColor = Color.FromArgb(110, 215, 235);
            chkActivo.Location = new Point(450, 121);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(73, 24);
            chkActivo.TabIndex = 13;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(30, 120, 200);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(525, 165);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 40);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(60, 85, 120);
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(670, 165);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(130, 40);
            btnActualizar.TabIndex = 15;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(192, 57, 43);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(815, 165);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(130, 40);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblEstado
            // 
            lblEstado.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblEstado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.ForeColor = Color.FromArgb(170, 190, 215);
            lblEstado.Location = new Point(30, 517);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(740, 28);
            lblEstado.TabIndex = 18;
            lblEstado.Text = "Sin conectar";
            lblEstado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnProbarConexion
            // 
            btnProbarConexion.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnProbarConexion.BackColor = Color.FromArgb(60, 85, 120);
            btnProbarConexion.FlatAppearance.BorderSize = 0;
            btnProbarConexion.FlatStyle = FlatStyle.Flat;
            btnProbarConexion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProbarConexion.ForeColor = Color.White;
            btnProbarConexion.Location = new Point(785, 513);
            btnProbarConexion.Name = "btnProbarConexion";
            btnProbarConexion.Size = new Size(160, 34);
            btnProbarConexion.TabIndex = 19;
            btnProbarConexion.Text = "Probar conexión";
            btnProbarConexion.UseVisualStyleBackColor = false;
            btnProbarConexion.Click += btnProbarConexion_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.FromArgb(35, 60, 95);
            dgvProductos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 65, 110);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(110, 215, 235);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(40, 65, 110);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(110, 215, 235);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { colId, colProducto, colPrecio, colStock, colCategoria, colProveedor });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(35, 60, 95);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 120, 200);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.GridColor = Color.FromArgb(60, 85, 120);
            dgvProductos.Location = new Point(30, 230);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(915, 275);
            dgvProductos.TabIndex = 17;
            // 
            // colId
            // 
            colId.DataPropertyName = "ProductoId";
            colId.FillWeight = 40F;
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colProducto
            // 
            colProducto.DataPropertyName = "Nombre";
            colProducto.FillWeight = 130F;
            colProducto.HeaderText = "Producto";
            colProducto.Name = "colProducto";
            colProducto.ReadOnly = true;
            // 
            // colPrecio
            // 
            colPrecio.DataPropertyName = "Precio";
            colPrecio.HeaderText = "Precio";
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            // 
            // colStock
            // 
            colStock.DataPropertyName = "Stock";
            colStock.FillWeight = 60F;
            colStock.HeaderText = "Stock";
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            // 
            // colCategoria
            // 
            colCategoria.DataPropertyName = "CategoriaNombre";
            colCategoria.HeaderText = "Categoría";
            colCategoria.Name = "colCategoria";
            colCategoria.ReadOnly = true;
            // 
            // colProveedor
            // 
            colProveedor.DataPropertyName = "Proveedor";
            colProveedor.FillWeight = 120F;
            colProveedor.HeaderText = "Proveedor";
            colProveedor.Name = "colProveedor";
            colProveedor.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 50, 80);
            ClientSize = new Size(975, 561);
            Controls.Add(dgvProductos);
            Controls.Add(btnProbarConexion);
            Controls.Add(lblEstado);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(chkActivo);
            Controls.Add(cmbProveedor);
            Controls.Add(lblProveedor);
            Controls.Add(cmbCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(lblStock);
            Controls.Add(lblPrecio);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SmartBusinessPro - Gestión de Productos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private Label lblPrecio;
        private Label lblStock;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private Label lblCategoria;
        private ComboBox cmbCategoria;
        private Label lblProveedor;
        private ComboBox cmbProveedor;
        private CheckBox chkActivo;
        private Button btnGuardar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Label lblEstado;
        private Button btnProbarConexion;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colCategoria;
        private DataGridViewTextBoxColumn colProveedor;
    }
}
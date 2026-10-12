using System.ComponentModel;
using System.Globalization;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace SmartBusinessPro
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class Form1 : Form
    {
        private BindingList<Producto> _productos = new BindingList<Producto>();
        private Producto _seleccionado;

        public Form1()
        {
            InitializeComponent();

            // El -= evita que los eventos se dupliquen si el diseñador ya los enlazó
            Load -= Form1_Load;
            Load += Form1_Load;
            btnGuardar.Click -= btnGuardar_Click;
            btnGuardar.Click += btnGuardar_Click;
            btnActualizar.Click -= btnActualizar_Click;
            btnActualizar.Click += btnActualizar_Click;
            btnEliminar.Click -= btnEliminar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnProbarConexion.Click -= btnProbarConexion_Click;
            btnProbarConexion.Click += btnProbarConexion_Click;
            dgvProductos.SelectionChanged -= dgvProductos_SelectionChanged;
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
        }

        // ---------------------------------------------------------------
        //  Carga inicial
        // ---------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvProductos.AutoGenerateColumns = false;

            if (cmbProveedor.Items.Count == 0)
                cmbProveedor.Items.AddRange(new object[] { "Tech Solutions", "Digital Corp", "Global Supply" });
            cmbProveedor.SelectedIndex = 0;

            CargarDatos();
        }

        /// <summary>
        /// Consulta categorías y productos en SQL Server mediante el contexto
        /// y los muestra en el formulario. Devuelve false si hubo un error.
        /// </summary>
        private bool CargarDatos()
        {
            try
            {
                using var db = new SmartBusinessContext();

                var categorias = db.Categorias
                    .AsNoTracking()
                    .Where(c => c.Activa)
                    .OrderBy(c => c.Nombre)
                    .ToList();

                var productos = db.Productos
                    .Include(p => p.Categoria)
                    .AsNoTracking()
                    .OrderBy(p => p.ProductoId)
                    .ToList();

                cmbCategoria.DataSource = null;
                cmbCategoria.DisplayMember = "Nombre";
                cmbCategoria.ValueMember = "CategoriaId";
                cmbCategoria.DataSource = categorias;

                _productos = new BindingList<Producto>(productos);
                dgvProductos.DataSource = _productos;
                dgvProductos.ClearSelection();
                _seleccionado = null;

                var conexion = db.Database.GetDbConnection();
                MostrarEstado($"Conectado a {conexion.DataSource} / {conexion.Database}  |  " +
                              $"{productos.Count} producto(s) cargado(s)", true);
                return true;
            }
            catch (Exception ex)
            {
                MostrarEstado("Sin conexión con la base de datos", false);
                ManejarError(ex);
                return false;
            }
        }

        // ---------------------------------------------------------------
        //  Botones
        // ---------------------------------------------------------------
        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            try
            {
                using var db = new SmartBusinessContext();
                db.Database.OpenConnection();   // lanza la excepción real si falla
                db.Database.CloseConnection();
            }
            catch (Exception ex)
            {
                MostrarEstado("Sin conexión con la base de datos", false);
                ManejarError(ex);
                return;
            }

            if (CargarDatos())
                MessageBox.Show("Conexión establecida correctamente.", "SmartBusinessPro",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(out decimal precio, out int stock)) return;

            try
            {
                using var db = new SmartBusinessContext();
                db.Productos.Add(new Producto
                {
                    Nombre = txtNombre.Text.Trim(),
                    Precio = precio,
                    Stock = stock,
                    CategoriaId = (int)cmbCategoria.SelectedValue,
                    Proveedor = cmbProveedor.Text,
                    Activo = chkActivo.Checked
                });
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                ManejarError(ex);
                return;
            }

            CargarDatos();
            LimpiarFormulario();
            MessageBox.Show("Producto guardado correctamente.", "SmartBusinessPro",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (_seleccionado == null)
            {
                MessageBox.Show("Seleccione un producto de la lista para actualizar.", "SmartBusinessPro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidarCampos(out decimal precio, out int stock)) return;

            try
            {
                using var db = new SmartBusinessContext();
                var producto = db.Productos.Find(_seleccionado.ProductoId);
                if (producto == null)
                {
                    MessageBox.Show("El producto ya no existe en la base de datos.", "SmartBusinessPro",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarDatos();
                    return;
                }

                producto.Nombre = txtNombre.Text.Trim();
                producto.Precio = precio;
                producto.Stock = stock;
                producto.CategoriaId = (int)cmbCategoria.SelectedValue;
                producto.Proveedor = cmbProveedor.Text;
                producto.Activo = chkActivo.Checked;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                ManejarError(ex);
                return;
            }

            CargarDatos();
            LimpiarFormulario();
            MessageBox.Show("Producto actualizado correctamente.", "SmartBusinessPro",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_seleccionado == null)
            {
                MessageBox.Show("Seleccione un producto de la lista para eliminar.", "SmartBusinessPro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                $"¿Desea eliminar el producto \"{_seleccionado.Nombre}\"?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes) return;

            try
            {
                using var db = new SmartBusinessContext();
                var producto = db.Productos.Find(_seleccionado.ProductoId);
                if (producto != null)
                {
                    db.Productos.Remove(producto);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                ManejarError(ex);
                return;
            }

            CargarDatos();
            LimpiarFormulario();
            MessageBox.Show("Producto eliminado correctamente.", "SmartBusinessPro",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ---------------------------------------------------------------
        //  Tabla
        // ---------------------------------------------------------------
        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null || !dgvProductos.CurrentRow.Selected) return;
            if (!(dgvProductos.CurrentRow.DataBoundItem is Producto p)) return;

            _seleccionado = p;
            txtNombre.Text = p.Nombre;
            txtPrecio.Text = p.Precio.ToString("N2", CultureInfo.InvariantCulture);
            txtStock.Text = p.Stock.ToString();
            cmbCategoria.SelectedValue = p.CategoriaId;
            cmbProveedor.SelectedIndex = cmbProveedor.FindStringExact(p.Proveedor ?? "");
            chkActivo.Checked = p.Activo;
        }

        // ---------------------------------------------------------------
        //  Validación y utilidades
        // ---------------------------------------------------------------
        private bool ValidarCampos(out decimal precio, out int stock)
        {
            precio = 0;
            stock = 0;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                Aviso("Ingrese el nombre del producto.", txtNombre);
                return false;
            }
            if (!decimal.TryParse(txtPrecio.Text.Replace(",", ""), NumberStyles.Number,
                    CultureInfo.InvariantCulture, out precio) || precio < 0)
            {
                Aviso("Ingrese un precio válido (ej. 1250.00).", txtPrecio);
                return false;
            }
            if (!int.TryParse(txtStock.Text, out stock) || stock < 0)
            {
                Aviso("Ingrese un stock válido (número entero).", txtStock);
                return false;
            }
            if (cmbCategoria.SelectedValue == null)
            {
                Aviso("No hay categorías cargadas. Pruebe la conexión con la base de datos.", btnProbarConexion);
                return false;
            }
            if (cmbProveedor.SelectedIndex < 0)
            {
                Aviso("Seleccione el proveedor.", cmbProveedor);
                return false;
            }
            return true;
        }

        private void Aviso(string mensaje, Control control)
        {
            MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            if (cmbCategoria.Items.Count > 0) cmbCategoria.SelectedIndex = 0;
            if (cmbProveedor.Items.Count > 0) cmbProveedor.SelectedIndex = 0;
            chkActivo.Checked = true;
            _seleccionado = null;
            dgvProductos.ClearSelection();
            txtNombre.Focus();
        }

        private void MostrarEstado(string texto, bool correcto)
        {
            lblEstado.Text = texto;
            lblEstado.ForeColor = correcto
                ? Color.FromArgb(120, 220, 140)
                : Color.FromArgb(255, 120, 110);
        }

        // ---------------------------------------------------------------
        //  Manejo de errores de conexión / base de datos
        // ---------------------------------------------------------------
        private void ManejarError(Exception ex)
        {
            MessageBox.Show(TraducirError(ex), "SmartBusinessPro - Error de base de datos",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static string TraducirError(Exception ex)
        {
            for (Exception inner = ex; inner != null; inner = inner.InnerException)
            {
                if (inner is SqlException sql)
                {
                    switch (sql.Number)
                    {
                        case 2:
                        case 53:
                        case -1:
                        case 40:
                        case 10060:
                        case 10061:
                            return "No se pudo conectar con el servidor SQL Server.\n\n" +
                                   "Verifique el valor de 'Server=' en App.config y que el servicio de SQL Server esté iniciado.";
                        case 4060:
                            return "La base de datos indicada no existe o el usuario no tiene acceso a ella.\n\n" +
                                   "Verifique el valor de 'Database=' en App.config.";
                        case 18456:
                            return "SQL Server rechazó el inicio de sesión.\n\n" +
                                   "Verifique las credenciales o la autenticación de Windows.";
                        case 208:
                            return "No se encontró una tabla en la base de datos.\n\n" +
                                   "Verifique que ejecutó el script que crea las tablas Categorias y Productos.";
                        case 547:
                            return "No se puede completar la operación porque el producto tiene ventas registradas u otros datos relacionados.\n\n" +
                                   "En su lugar, desmarque la casilla 'Activo' y pulse Actualizar.";
                        default:
                            return $"Error de SQL Server ({sql.Number}):\n{sql.Message}";
                    }
                }

                if (inner is InvalidOperationException && inner.Message.Contains("SmartBusinessConnection"))
                    return inner.Message;
            }

            return "Ocurrió un error inesperado:\n" + ex.Message;
        }
    }
}
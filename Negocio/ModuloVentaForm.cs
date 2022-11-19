using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioHOYSI.Vista
{
    public partial class ModuloVentaForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-52DJJ63;Initial Catalog=dbInventario;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        int Cantidad = 1;
        public ModuloVentaForm()
        {
            InitializeComponent();
            LoadCostumer();
            LoadProduct();
        }

        private void pictureBoxCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
           
        }

        private void LoadCostumer()
        {
            int i = 0;
            dgvCustomer.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbCliente WHERE CONCAT(IdCliente, NombreCliente) LIKE '%"+txtSearchCust.Text+"%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCustomer.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            con.Close();
        }

        public void LoadProduct()
        {
            int i = 0;
            dgvProduct.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbProducto WHERE CONCAT(IdProducto, NombreProducto, PrecioProducto, DescripcionProducto, CategoriaProducto) LIKE '%" + txtSearchProd.Text + "%' ", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadCostumer();
        }

        private void txtSearchProd_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }




        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            GetCantidad();
            if (Convert.ToInt16(nuCantidad.Value)>Cantidad)
            {
                
                MessageBox.Show("No hay suficiente stock de este producto", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nuCantidad.Value = nuCantidad.Value - 1;
                return;
            }
            if (Convert.ToInt16(nuCantidad.Value) > 0) 
            {
                int total = Convert.ToInt16(txtPrecio.Text) * Convert.ToInt16(nuCantidad.Value);
                txtTotal.Text = total.ToString();
            }
            
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtClid.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtClNombre.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPid.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPnombre.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPrecio.Text = dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if ( txtClid.Text == "" )
                {
                    MessageBox.Show("Por favor seleccione el cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtPid.Text == "")
                {
                    MessageBox.Show("Por favor seleccione el producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Esta seguro de guardar esta venta?", "Guardando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbVentas(FechaVenta, IdProducto, IdCliente, CantidadVenta, PrecioVenta, TotalVenta)VALUES(@FechaVenta, @IdProducto, @IdProducto, @CantidadVenta, @PrecioVenta, @TotalVenta)", con);
                    cm.Parameters.AddWithValue("@FechaVenta", dtFecha.Value);
                    cm.Parameters.AddWithValue("@IdProducto", Convert.ToInt16(txtPid.Text));
                    cm.Parameters.AddWithValue("@IdCliente", Convert.ToInt16(txtClid.Text));
                    cm.Parameters.AddWithValue("@CantidadVenta", Convert.ToInt16(nuCantidad.Value));
                    cm.Parameters.AddWithValue("@PrecioVenta", Convert.ToInt16(txtPrecio.Text));
                    cm.Parameters.AddWithValue("@TotalVenta", Convert.ToInt16(txtTotal.Text));
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("La venta ha sido agregada correctamente");
                    



                    cm = new SqlCommand("UPDATE tbProducto SET CantidadProducto=(CantidadProducto-@CantidadProducto) WHERE IdProducto LIKE '" + txtPid.Text + "'", con);
                    cm.Parameters.AddWithValue("@CantidadProducto", Convert.ToInt16(nuCantidad.Value));

                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    LoadProduct();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Limpiar()
        {
            txtClid.Clear();
            txtClNombre.Clear();

            txtPid.Clear();
            txtPnombre.Clear();

            txtSearchCust.Clear();
            txtSearchProd.Clear();

            txtPrecio.Clear();
            nuCantidad.Value = 0;
            txtTotal.Clear();
            dtFecha.Value = DateTime.Now;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
           
        }

        public void GetCantidad()
        {
            cm = new SqlCommand("SELECT CantidadProducto FROM tbProducto WHERE IdProducto='"+ txtPid.Text + "'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Cantidad = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }
    }
}

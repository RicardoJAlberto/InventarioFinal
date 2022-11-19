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
    public partial class FormProducto : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-52DJJ63;Initial Catalog=dbInventario;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public FormProducto()
        {
            InitializeComponent();
            LoadProduct();
        }
        public void LoadProduct()
        {
            int i = 0;
            dgvProducto.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbProducto WHERE CONCAT(IdProducto, NombreProducto, PrecioProducto, DescripcionProducto, CategoriaProducto) LIKE '%"+txtBuscar.Text+"%' ", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProducto.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ModuloProductoForm formModule = new ModuloProductoForm();
            formModule.btnGuardar.Enabled = true;
            formModule.btnActualizar.Enabled = false;
            formModule.ShowDialog();
            LoadProduct();
            
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProducto.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                ModuloProductoForm productModule = new ModuloProductoForm();
                productModule.lblpid.Text = dgvProducto.Rows[e.RowIndex].Cells[1].Value.ToString();
                productModule.txtpNombre.Text = dgvProducto.Rows[e.RowIndex].Cells[2].Value.ToString();
                productModule.txtpCantidad.Text = dgvProducto.Rows[e.RowIndex].Cells[3].Value.ToString();
                productModule.txtpPrecio.Text = dgvProducto.Rows[e.RowIndex].Cells[4].Value.ToString();
                productModule.txtpDescripcion.Text = dgvProducto.Rows[e.RowIndex].Cells[5].Value.ToString();
                productModule.comboCat.Text = dgvProducto.Rows[e.RowIndex].Cells[6].Value.ToString();

                productModule.btnGuardar.Enabled = false;
                productModule.btnActualizar.Enabled = true;
                productModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Eliminar producto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tbProducto WHERE IdProducto LIKE '" + dgvProducto.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Se ha eliminado correctamente");
                }
            }
            LoadProduct();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

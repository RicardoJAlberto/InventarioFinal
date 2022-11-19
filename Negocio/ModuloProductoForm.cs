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
    public partial class ModuloProductoForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-52DJJ63;Initial Catalog=dbInventario;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public ModuloProductoForm()
        {
            InitializeComponent();
            LoadCategory();
        }

        public void LoadCategory()
        {
            comboCat.Items.Clear();
            cm = new SqlCommand("SELECT NombreCategoria FROM tbCategoria", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                comboCat.Items.Add(dr[0].ToString());

            }
            dr.Close();
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ProductModuleForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (MessageBox.Show("Estas seguro de guardar este producto?", "Guardando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbProducto(NombreProducto,CantidadProducto,PrecioProducto,DescripcionProducto,CategoriaProducto)VALUES(@NombreProducto,@CantidadProducto,@PrecioProducto,@DescripcionProducto,@CategoriaProducto)", con);
                    cm.Parameters.AddWithValue("@NombreProducto", txtpNombre.Text);
                    cm.Parameters.AddWithValue("@CantidadProducto",Convert.ToInt16(txtpCantidad.Text));
                    cm.Parameters.AddWithValue("@PrecioProducto", Convert.ToInt16(txtpPrecio.Text));
                    cm.Parameters.AddWithValue("@DescripcionProducto", txtpDescripcion.Text);
                    cm.Parameters.AddWithValue("@CategoriaProducto", comboCat.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("El producto ha sido agregado correctamente");
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
            txtpNombre.Clear();
            txtpCantidad.Clear();
            txtpDescripcion.Clear();
            txtpPrecio.Clear();
            comboCat.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            btnGuardar.Enabled = true;
            btnActualizar.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (MessageBox.Show("Estas seguro de actualizar este usuario?", "Actualizando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tbProducto SET NombreProducto=@NombreProducto,CantidadProducto=@CantidadProducto,PrecioProducto=@PrecioProducto,DescripcionProducto=@DescripcionProducto,CategoriaProducto=@CategoriaProducto WHERE IdProducto LIKE '" + lblpid.Text + "'", con);
                    cm.Parameters.AddWithValue("@NombreProducto", txtpNombre.Text);
                    cm.Parameters.AddWithValue("@CantidadProducto", txtpCantidad.Text);
                    cm.Parameters.AddWithValue("@PrecioProducto", txtpPrecio.Text);
                    cm.Parameters.AddWithValue("@DescripcionProducto", txtpDescripcion.Text);
                    cm.Parameters.AddWithValue("@CategoriaProducto", comboCat.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("El producto ha sido actualizado correctamente");
                    this.Dispose();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}

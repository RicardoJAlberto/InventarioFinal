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

namespace InventarioHOYSI
{
    public partial class FormCategoria : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-52DJJ63;Initial Catalog=dbInventario;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public FormCategoria()
        {
            InitializeComponent();
            LoadCategory();
        }
        public void LoadCategory()
        {
            int i = 0;
            dgvCategoria.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbCategoria WHERE CONCAT(IdCategoria, NombreCategoria) LIKE '%"+txtBuscar.Text+"%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCategoria.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            con.Close();
        }


        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCategoria.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                ModuloCategoriaForm formModule = new ModuloCategoriaForm();
                formModule.lblCategoryID.Text = dgvCategoria.Rows[e.RowIndex].Cells[1].Value.ToString();
                formModule.txtCategory.Text = dgvCategoria.Rows[e.RowIndex].Cells[2].Value.ToString();

                formModule.btnGuardar.Enabled = false;
                formModule.btnActualizar.Enabled = true;
                formModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Eliminar categoria?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tbCategoria WHERE IdCategoria LIKE '" + dgvCategoria.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Se ha eliminado correctamente");
                }
            }
            LoadCategory();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ModuloCategoriaForm formModule = new ModuloCategoriaForm();
            formModule.btnGuardar.Enabled = true;
            formModule.btnActualizar.Enabled = false;
            formModule.ShowDialog();
            LoadCategory();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            LoadCategory();
        }
    }
}

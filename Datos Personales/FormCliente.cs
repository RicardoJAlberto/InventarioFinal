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
    public partial class FormCliente : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-52DJJ63;Initial Catalog=dbInventario;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public FormCliente()
        {
            InitializeComponent();
            LoadCustomer();
        }
        public void LoadCustomer()
        {
            int i = 0;
            dgvCliente.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbCliente WHERE CONCAT (IdCliente, NombreCliente) LIKE '%"+txtBuscar.Text+"%' ", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCliente.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCliente.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                ModuloClienteForm customerModule = new ModuloClienteForm();
                customerModule.lblCID.Text = dgvCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
                customerModule.txtName.Text = dgvCliente.Rows[e.RowIndex].Cells[2].Value.ToString();
                customerModule.txtCell.Text = dgvCliente.Rows[e.RowIndex].Cells[3].Value.ToString();

                customerModule.btnGuardar.Enabled = false;
                customerModule.btnActualizar.Enabled = true;
                customerModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Eliminar usuario?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tbCliente WHERE IdCliente LIKE '" + dgvCliente.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Se ha eliminado correctamente");
                }
            }
            LoadCustomer();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ModuloClienteForm moduleForm = new ModuloClienteForm();
            moduleForm.btnGuardar.Enabled = true;
            moduleForm.btnActualizar.Enabled = false;
            moduleForm.ShowDialog();
            LoadCustomer();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            LoadCustomer();
        }
    }
}

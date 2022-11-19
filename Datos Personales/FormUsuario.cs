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
    public partial class FormUsuario : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-52DJJ63;Initial Catalog=dbInventario;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public FormUsuario()
        {
            InitializeComponent();
            LoadUser();
        }

        public void LoadUser()
        {
            int i = 0;
            dgvUsuario.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbUsuarios WHERE CONCAT (Usuario, NombreUsuario) LIKE '%"+txtBuscar.Text+"%' ", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvUsuario.Rows.Add(i,dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ModuloUsuarioForm userModule = new ModuloUsuarioForm();
            userModule.btnGuardar.Enabled = true;
            userModule.btnActualizar.Enabled = false;
            userModule.ShowDialog();
            LoadUser();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvUsuario.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                ModuloUsuarioForm userModule = new ModuloUsuarioForm();
                userModule.txtUsuario.Text = dgvUsuario.Rows[e.RowIndex].Cells[1].Value.ToString();
                userModule.txtNombre.Text = dgvUsuario.Rows[e.RowIndex].Cells[2].Value.ToString();
                userModule.txtPassword.Text = dgvUsuario.Rows[e.RowIndex].Cells[3].Value.ToString();
                userModule.txtTelefono.Text = dgvUsuario.Rows[e.RowIndex].Cells[4].Value.ToString();

                userModule.btnGuardar.Enabled = false;
                userModule.btnActualizar.Enabled = true;
                userModule.txtUsuario.Enabled = false;
                userModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Eliminar usuario?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tbUsuarios WHERE Usuario LIKE '" + dgvUsuario.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Se ha eliminado correctamente");
                }
            }
            LoadUser();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            LoadUser();
        }
    }
}

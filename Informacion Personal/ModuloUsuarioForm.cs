using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventarioHOYSI
{
    public partial class ModuloUsuarioForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-52DJJ63;Initial Catalog=dbInventario;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        public ModuloUsuarioForm()
        {
            InitializeComponent();
        }

        private void UserModuleForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text != txtRePassword.Text)
                {
                    MessageBox.Show("La Password no coincide", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(MessageBox.Show("Estas seguro de guardar este usuario?", "Guardando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbUsuarios(Usuario,NombreUsuario,PasswordUsuario,TelefonoUsuario)VALUES(@Usuario,@NombreUsuario,@PasswordUsuario,@TelefonoUsuario)", con);
                    cm.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                    cm.Parameters.AddWithValue("@NombreUsuario", txtNombre.Text);
                    cm.Parameters.AddWithValue("@PasswordUsuario", txtPassword.Text);
                    cm.Parameters.AddWithValue("@TelefonoUsuario", txtTelefono.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("El Usuario ha sido agregado correctamente");
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            btnGuardar.Enabled = true;
            btnActualizar.Enabled = false;
        }

        public void Limpiar()
        {
            txtUsuario.Clear();
            txtNombre.Clear();
            txtPassword.Clear();
            txtRePassword.Clear();
            txtTelefono.Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text != txtRePassword.Text)
                {
                    MessageBox.Show("La Password no coincide", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Estas seguro de actualizar este usuario?", "Actualizando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tbUsuarios SET NombreUsuario=@NombreUsuario, PasswordUsuario=@PasswordUsuario, TelefonoUsuario=@TelefonoUsuario WHERE Usuario LIKE '"+txtUsuario.Text +"'", con);
                    cm.Parameters.AddWithValue("@NombreUsuario", txtNombre.Text);
                    cm.Parameters.AddWithValue("@PasswordUsuario", txtPassword.Text);
                    cm.Parameters.AddWithValue("@TelefonoUsuario", txtTelefono.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("El Usuario ha sido actualizado correctamente");
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

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
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-52DJJ63;Initial Catalog=dbInventario;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void checkBoxMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMostrar.Checked == false)
                txtPassword.UseSystemPasswordChar = true;
            else
                txtPassword.UseSystemPasswordChar = false;
        }

        private void lblLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtPassword.Clear();
        }

        private void pictureBoxCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Salir", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("SELECT * FROM tbUsuarios WHERE Usuario=@Usuario AND PasswordUsuario=@PasswordUsuario", con);
                cm.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                cm.Parameters.AddWithValue("@PasswordUsuario", txtPassword.Text);
                con.Open();
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("Bienvenido " + dr["NombreUsuario"].ToString() + "  ", "Haz ingresado correctamente",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormPrincipal main = new FormPrincipal();
                    this.Hide();
                    main.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Usuario o Password invalido", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

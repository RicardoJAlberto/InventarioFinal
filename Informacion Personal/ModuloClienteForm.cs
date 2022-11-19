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
using System.Data.Common;

namespace InventarioHOYSI
{
    
    public partial class ModuloClienteForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-52DJJ63;Initial Catalog=dbInventario;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        public ModuloClienteForm()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try 
            { 
           
                if (MessageBox.Show("Estas seguro de guardar este cliente?", "Guardando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbCliente(NombreCliente,TelefonoCliente)VALUES(@NombreCliente,@TelefonoCliente)", con);
                    cm.Parameters.AddWithValue("@NombreCliente", txtName.Text);
                    cm.Parameters.AddWithValue("@TelefonoCliente", txtCell.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("El cliente ha sido agregado correctamente");
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
            txtName.Clear();
            txtCell.Clear();
          
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            btnGuardar.Enabled = true;
            btnActualizar.Enabled = false;
        }

        private void pictureBoxCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try 
             { 
                 if (MessageBox.Show("Estas seguro de actualizar este cliente?", "Actualizando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                 {
                cm = new SqlCommand("UPDATE tbCliente SET NombreCliente = @NombreCliente, TelefonoCliente = @TelefonoCliente WHERE IdCliente LIKE '" + lblCID.Text + "'", con);
                cm.Parameters.AddWithValue("@NombreCliente", txtName.Text);
                cm.Parameters.AddWithValue("@TelefonoCliente", txtCell.Text);
                con.Open();
                cm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("El cliente ha sido actualizado correctamente");
                this.Dispose();

                 }
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CustomerModuleForm_Load(object sender, EventArgs e)
        {

        }
    }
}

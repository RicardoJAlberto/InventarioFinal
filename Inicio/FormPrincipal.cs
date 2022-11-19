using InventarioHOYSI.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioHOYSI
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void customerButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new FormProducto());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new FormUsuario());
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCliente());
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCategoria());
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            openChildForm(new FormVenta());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

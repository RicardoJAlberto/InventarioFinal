namespace InventarioHOYSI
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPedidos = new InventarioHOYSI.CustomerButton();
            this.btnUsuarios = new InventarioHOYSI.CustomerButton();
            this.btnCategoria = new InventarioHOYSI.CustomerButton();
            this.btnCliente = new InventarioHOYSI.CustomerButton();
            this.btnProducto = new InventarioHOYSI.CustomerButton();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProducto)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnPedidos);
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.btnCategoria);
            this.panel1.Controls.Add(this.btnCliente);
            this.panel1.Controls.Add(this.btnProducto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 100);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(733, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Pedidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(625, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Usuarios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(511, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Categorias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(418, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(303, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Producto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Image = ((System.Drawing.Image)(resources.GetObject("btnPedidos.Image")));
            this.btnPedidos.ImageHover = global::InventarioHOYSI.Properties.Resources.icons8_purchase_orderb_641;
            this.btnPedidos.ImageNormal = global::InventarioHOYSI.Properties.Resources.icons8_purchase_order_64;
            this.btnPedidos.Location = new System.Drawing.Point(714, 3);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(100, 50);
            this.btnPedidos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPedidos.TabIndex = 14;
            this.btnPedidos.TabStop = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageHover = global::InventarioHOYSI.Properties.Resources.Users_120px2;
            this.btnUsuarios.ImageNormal = global::InventarioHOYSI.Properties.Resources.icons8_Users_64;
            this.btnUsuarios.Location = new System.Drawing.Point(608, 3);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(100, 50);
            this.btnUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUsuarios.TabIndex = 13;
            this.btnUsuarios.TabStop = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoria.Image")));
            this.btnCategoria.ImageHover = global::InventarioHOYSI.Properties.Resources.opened_folder_120px1;
            this.btnCategoria.ImageNormal = global::InventarioHOYSI.Properties.Resources.icons8_opened_folder_64;
            this.btnCategoria.Location = new System.Drawing.Point(502, 3);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(100, 50);
            this.btnCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCategoria.TabIndex = 12;
            this.btnCategoria.TabStop = false;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.ImageHover = global::InventarioHOYSI.Properties.Resources.customer_120px2;
            this.btnCliente.ImageNormal = global::InventarioHOYSI.Properties.Resources.icons8_customer_64;
            this.btnCliente.Location = new System.Drawing.Point(396, 3);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(100, 50);
            this.btnCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCliente.TabIndex = 11;
            this.btnCliente.TabStop = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnProducto.Image")));
            this.btnProducto.ImageHover = global::InventarioHOYSI.Properties.Resources.product3_120px;
            this.btnProducto.ImageNormal = global::InventarioHOYSI.Properties.Resources.icons8_product_64;
            this.btnProducto.Location = new System.Drawing.Point(290, 3);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(100, 50);
            this.btnProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnProducto.TabIndex = 10;
            this.btnProducto.TabStop = false;
            this.btnProducto.Click += new System.EventHandler(this.customerButton1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 147);
            this.label3.TabIndex = 9;
            this.label3.Text = "JO FASHION: SISTEMA DE MANEJO DE INVENTARIO";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 463);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(874, 15);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelMain.Controls.Add(this.pictureBox1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 100);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(874, 363);
            this.panelMain.TabIndex = 2;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventarioHOYSI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(52, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(789, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 478);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProducto)).EndInit();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label3;
        private CustomerButton btnProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomerButton btnPedidos;
        private CustomerButton btnUsuarios;
        private CustomerButton btnCategoria;
        private CustomerButton btnCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace AppCine_Grupo10
{
    public partial class Menu : Form
    {
        //Definir ventanas de forms
        FrmPanelMenu frmMenu = new FrmPanelMenu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        FrmPanelCartelera frmCartelera = new FrmPanelCartelera() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        FrmPanelReservas frmReservas = new FrmPanelReservas() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        FrmPanelReporte1 frmReportes1 = new FrmPanelReporte1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        FrmPanelReporte2 frmReportes2 = new FrmPanelReporte2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        FrmPanelReporte3 frmReportes3 = new FrmPanelReporte3() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        FrmPanelReporte4 frmReportes4 = new FrmPanelReporte4() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };






        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            CargarPanel(frmMenu);
            MostrarReportes(false);
            ActivarBoton(BtnMenu);

        }



        // Metodos propios
        private void CargarPanel(System.Windows.Forms.Form iForm)
        {
            this.PanelPrincipal.Controls.Clear();
            this.PanelPrincipal.Controls.Add(iForm);
            iForm.Show();
        }

        private void MostrarReportes(bool estado)
        {
            BtnReporte1.Enabled = estado;
            BtnReporte1.Visible = estado;
            BtnReporte2.Enabled = estado;
            BtnReporte2.Visible = estado;
            BtnReporte3.Enabled = estado;
            BtnReporte3.Visible = estado;
            BtnReporte4.Enabled = estado;
            BtnReporte4.Visible = estado;
        }

        private void ActivarBoton(System.Windows.Forms.Button boton)
        {
            BtnMenu.ForeColor = Color.FromArgb(156, 161, 178);
            BtnCartelera.ForeColor = Color.FromArgb(156, 161, 178);
            BtnReservas.ForeColor = Color.FromArgb(156, 161, 178);
            BtnReportes.ForeColor = Color.FromArgb(156, 161, 178);
            BtnReporte1.ForeColor = Color.FromArgb(156, 161, 178);
            BtnReporte2.ForeColor = Color.FromArgb(156, 161, 178);
            BtnReporte3.ForeColor = Color.FromArgb(156, 161, 178);
            BtnReporte4.ForeColor = Color.FromArgb(156, 161, 178);

            boton.ForeColor = Color.FromArgb(50, 142, 226);
        }















        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            CargarPanel(frmMenu);
            ActivarBoton(BtnMenu);
        }

        private void PanelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCartelera_Click(object sender, EventArgs e)
        {
            CargarPanel(frmCartelera);
            ActivarBoton(BtnCartelera);
        }

        private void BtnReservas_Click(object sender, EventArgs e)
        {
            CargarPanel(frmReservas);
            ActivarBoton(BtnReservas);
        }

        private void BtnReporte1_Click(object sender, EventArgs e)
        {
            CargarPanel(frmReportes1);
            ActivarBoton(BtnReporte1);
            BtnReportes.ForeColor = Color.FromArgb(50, 142, 226);
        }

        private void BtnReporte2_Click(object sender, EventArgs e)
        {
            CargarPanel(frmReportes2);
            ActivarBoton(BtnReporte2);
            BtnReportes.ForeColor = Color.FromArgb(50, 142, 226);
        }

        private void BtnReporte3_Click(object sender, EventArgs e)
        {
            CargarPanel(frmReportes3);
            ActivarBoton(BtnReporte3);
            BtnReportes.ForeColor = Color.FromArgb(50, 142, 226);
        }

        private void BtnReporte4_Click(object sender, EventArgs e)
        {
            CargarPanel(frmReportes4);
            ActivarBoton(BtnReporte4);
            BtnReportes.ForeColor = Color.FromArgb(50, 142, 226);
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            ActivarBoton(BtnReportes);
            if (BtnReporte1.Enabled == true)
            {
                MostrarReportes(false);
            }
            else
            {
                MostrarReportes(true);
            }
        }
    }
}

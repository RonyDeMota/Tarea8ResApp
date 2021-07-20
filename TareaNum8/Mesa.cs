using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BuisnessLayer;

namespace TareaNum8
{
    public partial class Mesa : Form
    {
        Servicio Servic;
        public static Mesa instancia { get; } = new Mesa();
        public Mesa()
        {
            Servic = new Servicio();
            InitializeComponent();
        }
        Princi Principal = Princi.Instancia;
        private void Mesa_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Mesa_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Principal.Show();
        }
        private void Mesa_Load(object sender, EventArgs e)
        {
            CantPers();
        }
  private void cbxCantidadPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Disable();
        }
 private void btnAddOrden_Click(object sender, EventArgs e)
        {
            GuardarOrdenes();
        }
        private void BtnMesaAnadirOrd_Click(object sender, EventArgs e)
        {
            HacerOrdene();
        }
        private void btnCancelOrder_Click(object sender, EventArgs e)
        {

            this.Hide();

            Principal.Show();

        }
private void Mesa_VisibleChanged(object sender, EventArgs e)
        {
            CargarOrden();
        }





        #region Methods


        private void CargarOrden()
        {
            TableViewOrden.Rows.Clear();

            foreach (Orden Item in Repositorio.Instancia.OrdenesPorMesas)
            {

                TableViewOrden.Rows.Add(Item.Nombre, Item.Entradas, Item.PlatosFuertes, Item.Bebidas, Item.Postres);

            }
        }

        private void CantPers()
        {
            cbxCantidadPersonas.Items.Add("Seleccione una Opción");

            cbxCantidadPersonas.Items.Add("1");
            cbxCantidadPersonas.Items.Add("2");
            cbxCantidadPersonas.Items.Add("3");
            cbxCantidadPersonas.Items.Add("4");

            cbxCantidadPersonas.SelectedItem = "Seleccione una Opción";
        }

        private void HacerOrdene()
        {
            if (cbxCantidadPersonas.Text != "Seleccione una Opción")
            {
                if (cbxCantidadPersonas.Text != "Seleccione una Opción")
                {
                    HacerOrdenes FormOrdenes = new HacerOrdenes();
                    FormOrdenes.Show();
                    this.Hide();
                }
                else
                { MessageBox.Show("No puede realizar mas ordenes"); }
            }
            else
            { MessageBox.Show("Seleccione una Opción"); }
        }

        private void GuardarOrdenes()
        {
            foreach (Orden Item in Repositorio.Instancia.OrdenesPorMesas)
            {
                Servic.AgregarOrdenGeneral(Item);
            }

            this.Hide();

            Princi newForm = Princi.Instancia;

            newForm.Show();
        }

        public void Limpiar()
        {
            Repositorio.Instancia.OrdenesPorMesas.Clear();

            cbxCantidadPersonas.SelectedItem = "Seleccione una Opción";

            cbxCantidadPersonas.Enabled = true;
        }

        private void Disable()
        {
            if (cbxCantidadPersonas.Text != "Seleccione una Opción")
            {
                cbxCantidadPersonas.Enabled = false;
            }
        }








        #endregion

       
    }
}

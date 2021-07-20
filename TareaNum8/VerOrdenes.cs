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
    public partial class VerOrdenes : Form
    {
        public VerOrdenes()
        {
            InitializeComponent();
        }

        private void VerOrdenes_Load(object sender, EventArgs e)
        {
            ViewOrdenes();
        }
        private void BtnAtra_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VerOrdenes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Princi Principal = Princi.Instancia;
            Principal.Show();
        }





        private void ViewOrdenes()
        {
            foreach (Orden Item in Repositorio.Instancia.OrdenesGeneral)
            {

                dvgVerOrdenes.Rows.Add(Item.Nombre, Item.Entradas, Item.PlatosFuertes, Item.Bebidas, Item.Postres);

            }
        }

      
    }
}

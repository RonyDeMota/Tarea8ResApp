using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaNum8
{
    public partial class Princi : Form
    {
        public Princi()
        {
            InitializeComponent();
        }
        public static Princi Instancia { get; } = new Princi();
        private void btnMesa1_Click(object sender, EventArgs e)
        {
            Mesas();
        }
        private void btnMesa2_Click(object sender, EventArgs e)
        {
            Mesas();
        }
        private void btnMesa3_Click(object sender, EventArgs e)
        {
            Mesas();
        }

        private void btnMesa4_Click(object sender, EventArgs e)
        {
            Mesas();
        }

        private void btnMesa5_Click(object sender, EventArgs e)
        {
            Mesas();
        }
        private void Princi_VisibleChanged(object sender, EventArgs e)
        {
            TareaNum8.Mesa.instancia.Limpiar();
        }
        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            VerOrdenes VerOrdenes = new VerOrdenes();
            this.Hide();
            VerOrdenes.Show();
        }







        private void Mesas()
        {
            Mesa Mesas = Mesa.instancia;

            Mesas.Show();
            this.Hide();
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLayer
{
   public sealed class Repositorio
    {
        public List<Orden> OrdenesGeneral { get; set; } = new List<Orden>();
        public List<Orden> OrdenesPorMesas { get; set; } = new List<Orden>();

        public static Repositorio Instancia { get; } = new Repositorio();

        private Repositorio()
        {

        }
    }
}

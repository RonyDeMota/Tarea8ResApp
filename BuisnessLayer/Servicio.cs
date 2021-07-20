using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLayer
{
   public class Servicio
    {
        public void AgregarOrdenGeneral(Orden Item)
        {
            Repositorio.Instancia.OrdenesGeneral.Add(Item);
        }
        public void AgregarOrdenPorMesas(Orden Item)
        {
            Repositorio.Instancia.OrdenesPorMesas.Add(Item);
        }
    }
}

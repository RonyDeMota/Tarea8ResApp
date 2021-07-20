using System;

namespace BuisnessLayer
{
    public class Orden
    {
            public string Nombre { get; set; }
            public string Entradas { get; set; }
            public string PlatosFuertes { get; set; }
            public string Bebidas { get; set; }
            public string Postres { get; set; }
            public Orden(string Nombre, string Entradas, string PlatosFuertes, string Bebidas, string Postres)
            {
                this.Nombre = Nombre;
                this.Entradas = Entradas;
                this.PlatosFuertes = PlatosFuertes;
                this.Bebidas = Bebidas;
                this.Postres = Postres;
            }
        
    }
}

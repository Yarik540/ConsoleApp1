using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bodega
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<Sucursal> Sucursales { get; set; }
        public Bodega(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
            Sucursales = new List<Sucursal>();
        }
        public void AgregarSucursal(Sucursal sucursal)
        {
            if (sucursal != null && !Sucursales.Contains(sucursal))
            {
                Sucursales.Add(sucursal);
            }
        }

    }
}

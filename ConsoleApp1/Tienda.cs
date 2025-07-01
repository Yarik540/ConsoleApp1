using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Tienda
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<Producto> Productos { get; set; }
        public Tienda(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
            Productos = new List<Producto>();
        }
        public void AgregarProducto(Producto producto)
        {
            if (producto != null && !Productos.Contains(producto))
            {
                Productos.Add(producto);
            }
        }
        public override string ToString()
        {
            return $"Tienda: {Nombre}, Dirección: {Direccion}";
        }
    }
}

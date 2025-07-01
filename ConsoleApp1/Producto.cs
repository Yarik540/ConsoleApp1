using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public Producto(int id, string nombre, decimal precio)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Nombre: {Nombre}, Precio: {Precio:C}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Producto other)
            {
                return Id == other.Id && Nombre == other.Nombre && Precio == other.Precio;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Nombre, Precio);
        }
        public static bool operator ==(Producto left, Producto right)
        {
            if (left is null && right is null) return true;
            if (left is null || right is null) return false;
            return left.Equals(right);
        }
        public static bool operator !=(Producto left, Producto right)
        {
            return !(left == right);

        }
    }
}

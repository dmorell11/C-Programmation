using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    public class Producto
    {
        private string name;
        private double price;
        private int stock;

        public Producto (string name, double price, int stock)
        {
            this.name = name;
            this.price = price;
            this.stock = stock;
        }

        public string Name
        { get {
                return name;
            } set
            {
                this.name = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 0)
                {
                    this.price = value;
                }
            }
        }
        public int Stock
        {
            get
            {
                return stock;
            }
            set
            {
                if (value >= 0)
                {
                    this.stock = value;
                }
            }
        }

    public double CalcularValorTotal()
        {
            return stock * price;
        }

    }
    /*
    Ejercicio: Creación de una clase de Productos

    Crea una clase llamada Producto que represente un producto en una tienda. 
    La clase Producto deberá tener los siguientes atributos privados:

    nombre (string): el nombre del producto.
    precio (double): el precio del producto.
    cantidadEnStock (int): la cantidad de unidades del producto en stock.

    Debes proporcionar métodos públicos para establecer y obtener estos atributos. 
    Utiliza propiedades para encapsular el acceso a los atributos y asegúrate de que 
    el precio sea un valor positivo y que la cantidad en stock sea mayor o igual a cero.

    Además, la clase Producto debe tener un método llamado CalcularValorTotal que calcule 
    el valor total en stock del producto multiplicando el precio por la cantidad en stock.

    Crea una instancia de la clase Producto, establece sus atributos y luego llama al 
    método CalcularValorTotal para calcular el valor total en stock del producto y 
    mostrarlo en la consola.

    Asegúrate de que tu código esté bien estructurado y que se utilicen propiedades 
    y métodos de manera apropiada para acceder y modificar los atributos de la clase Producto.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto camiseta = new Producto("camiseta", 15, 5);
            Console.WriteLine(camiseta.CalcularValorTotal());
            camiseta.Price = 20;
            Console.WriteLine(camiseta.CalcularValorTotal());

        }

    }
}

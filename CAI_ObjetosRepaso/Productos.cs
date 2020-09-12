using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen
{
    class Productos
    {
        //ATRIBUTOS
        private string _nombre;
        private string _tipoProducto;
        private int _stock;
        private float _precio;
        private bool _disponible;

        //PROPIEDADES

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
        public string TipoProducto
        {
            get { return this._tipoProducto; }
            set { this._tipoProducto = value; }
        }
        public int Stock
        {
            get { return this._stock; }
            set { this._stock = value; }
        }

        public float Precio
        {
            get { return this._precio; }
            set { this._precio = value; }
        }

        //CONSTRUCTORES

        public Productos()
        { 

        }
        public Productos(string nombre, string tipoproducto)
        {
            this._nombre = nombre;
            this._tipoProducto = tipoproducto;
        }

        public Productos(string nombre, string tipoproducto, int stock, float precio):this(nombre, tipoproducto) //FORMA DE REUTILIZAR EL CONSTRUCTOR
        {
            if (stock < 0)
                throw new Exception();
            else
            {
                this._stock = stock;
                this._precio = precio;
                this._disponible = true;
            }
        }

        public void Comprar(int cantidad)
        {
            this._stock += cantidad;
        }

        public void Comprar()
        {
            this._stock++;
        }

        public string Vender(int cantidad)
        {
            if (cantidad > this._stock)
            {
                return "No hay stock para la venta";
            }
            else
            {
                this._stock -= cantidad;
                return "Venta realizada con exito";
            }        
        }

        public string Vender()
        {
            if(_stock == 0)
            {
                return "No hay stock para la venta";
            }
            else
            {
                this._stock --;
                return "Venta realizada con exito";
            }
        }

        public void Disponible()
        {
            if(_stock > 0)
            {
                this._disponible = true;
            }
            else
            {
                this._disponible = false;
            }
        }

        public override string ToString()
        {
            return string.Format("Producto: {0} --Tipo: {1} --Precio: {2} --Stock: {3} --Disponible: {4}",
                this._nombre, this._tipoProducto, this._precio, this._stock, this._disponible);
        }

    }
}

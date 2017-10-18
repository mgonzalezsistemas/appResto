using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgranatiGroupLTDA.Logica
{
    
    public class Plato
    {
        //Atributos
        public int id { set; get; }
        public string nombre { set; get; }
        public string descripcion { set; get; }
        public double precio { set; get; }

        //Constructor 
        public Plato() { }
        public Plato(int id, string nombre, string descripcion,double precio)
        {            
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
        }

        //Operaciones
        //public static List<Plato> CargarPlatos()
        //{
        //    List<Plato> lista = new List<Plato>();

        //    Plato e1 = new Plato();
        //    e1.id = 1;
        //    e1.nombre = "Capuchino";
        //    e1.precio = 120;
        //    lista.Add(e1);

        //    Plato e2 = new Plato();
        //    e2.id = 2;
        //    e2.nombre = "Cortado";
        //    e2.precio = 100;
        //    lista.Add(e2);

        //    Plato e3 = new Plato();
        //    e3.id = 3;
        //    e3.nombre = "Sandwich Caliente";
        //    e3.precio = 140;
        //    lista.Add(e3);

        //    Plato e4 = new Plato();
        //    e4.id = 4;
        //    e4.nombre = "Sandwich Caliente con Muzarella";
        //    e4.precio = 160;
        //    lista.Add(e4);

        //    Plato e5 = new Plato();
        //    e5.id = 5;
        //    e5.nombre = "Jugo Natural";
        //    e5.precio = 60;
        //    lista.Add(e5);

        //    Plato e6 = new Plato();
        //    e6.id = 6;
        //    e6.nombre = "Pizzeta con Muzarella";
        //    e6.precio = 100;
        //    lista.Add(e6);

        //    Plato e7 = new Plato();
        //    e7.id = 7;
        //    e7.nombre = "Pizzeta comun";
        //    e7.precio = 80;
        //    lista.Add(e7);

        //    Plato e8 = new Plato();
        //    e8.id = 8;
        //    e8.nombre = "Pizza Familiar";
        //    e8.precio = 170;
        //    lista.Add(e8);

        //    Plato e9 = new Plato();
        //    e9.id = 9;
        //    e9.nombre = "Pizza Familiar con Muzarella";
        //    e9.precio = 200;
        //    lista.Add(e9);

        //    Plato e10 = new Plato();
        //    e10.id = 10;
        //    e10.nombre = "Copa Helada";
        //    e10.precio = 80;
        //    lista.Add(e10);

        //    Plato e11 = new Plato();
        //    e11.id = 11;
        //    e11.nombre = "Flan con dulce de leche";
        //    e11.precio = 90;
        //    lista.Add(e11);

        //    Plato e12 = new Plato();
        //    e12.id = 12;
        //    e12.nombre = "Refresco 1 Ltro";
        //    e12.precio = 100;
        //    lista.Add(e12);

        //    Plato e13 = new Plato();
        //    e13.id = 13;
        //    e13.nombre = "Cerveza 1 Ltro";
        //    e13.precio = 150;
        //    lista.Add(e13);

        //    Plato e14 = new Plato();
        //    e14.id = 14;
        //    e14.nombre = "Refresco 600 Mlt";
        //    e14.precio = 60;
        //    lista.Add(e14);

        //    return lista;
        //}
        
    }
}
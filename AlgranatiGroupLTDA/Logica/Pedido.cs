using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgranatiGroupLTDA.Logica
{
    public class Pedido
    {
        //Atributos
        public int numero { set; get; }
        public DateTime fecha { set; get; }
        public List<Plato> listaPlatos { set; get; }

        //Constructor
        public Pedido()
        {
            listaPlatos = new List<Plato>();
        }
        public Pedido(int numero, DateTime fecha, List<Plato> listaPlatos)
        {
            this.numero = numero;
            this.fecha = fecha;
            this.listaPlatos = listaPlatos;
        }               
    }
}
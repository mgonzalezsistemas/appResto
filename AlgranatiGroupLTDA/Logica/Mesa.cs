using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgranatiGroupLTDA.Logica
{
    public class Mesa
    {        
        //Atributos
        public int numero { set; get; }
        public string estado { set; get; }
        public string mesero { set; get; }
        public string cliente { set; get; }
        public Pedido pedidoMesa { set; get; }

        //Constructor
        public Mesa()
        {
            this.pedidoMesa = new Pedido();
        }
        public Mesa(int numero, string estado, string mesero, string cliente, Pedido pedidoMesa)
        {
            this.numero = numero;
            this.estado = estado;
            this.mesero = mesero;
            this.cliente = cliente;
            this.pedidoMesa = pedidoMesa;
        }

        //Operaciones
        public static List<Mesa> CargarMesas()
        {          
            List<Mesa> lista = new List<Mesa>();

            Mesa m1 = new Mesa();
            m1.numero = 1;
            m1.estado = "Disponible";
            lista.Add(m1);

            Mesa m2 = new Mesa();
            m2.numero = 2;
            m2.estado = "Disponible";
            lista.Add(m2);

            Mesa m3 = new Mesa();
            m3.numero = 3;
            m3.estado = "Disponible";
            lista.Add(m3);

            Mesa m4 = new Mesa();
            m4.numero = 4;
            m4.estado = "Disponible";
            lista.Add(m4);

            Mesa m5 = new Mesa();
            m5.numero = 5;
            m5.estado = "Disponible";
            lista.Add(m5);

            Mesa m6 = new Mesa();
            m6.numero = 6;
            m6.estado = "Disponible";
            lista.Add(m6);

            Mesa m7 = new Mesa();
            m7.numero = 7;
            m7.estado = "Disponible";
            lista.Add(m7);

            Mesa m8 = new Mesa();
            m8.numero =8;
            m8.estado = "Disponible";
            lista.Add(m8);

            Mesa m9 = new Mesa();
            m9.numero = 9;
            m9.estado = "Disponible";
            lista.Add(m9);

            Mesa m10 = new Mesa();
            m10.numero = 10;
            m10.estado = "Disponible";
            lista.Add(m10);

            return lista;
        }
    }
}

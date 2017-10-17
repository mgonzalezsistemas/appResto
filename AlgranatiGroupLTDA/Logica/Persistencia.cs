using AlgranatiGroupLTDA.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace AlgranatiGroupLTDA.Logica
{
    public static class Persistencia
    {
        public static List<Mesa> colMesas { set; get; }
        public static Mesa mesaSeleccionada { set; get; }
        public static Plato platoSeleccioando { set; get; }
        public static long numeroTicket { set; get; }
        public static List<Plato> listaPlatos { set; get; }
        
        public static void CargarPersistencia()
        {
            listaPlatos = CargarPlatos();
            mesaSeleccionada = new Mesa();
            platoSeleccioando = new Plato();
            colMesas = Mesa.CargarMesas();
            numeroTicket = SiguienteTicket(); 
        } 

        public static long SiguienteTicket()
        {
            ConexionBD con = new ConexionBD();
            con.AbrirConexion();

            if (con == null)
            {
                throw new Exception("No se pudo conectar a la Base de Datos!");
            }
            
            string consulta = "SELECT numero FROM Ticket ORDER BY numero DESC LIMIT 1;";
            MySqlCommand cmd = new MySqlCommand(consulta, con.conexion);
            MySqlDataReader rd = cmd.ExecuteReader();
            long ultimoTicket = 0;

            while (rd.Read())
            {
                ultimoTicket= rd.GetInt64(0);
            }

            con.CerrarConexion();
            return ultimoTicket++;
        } //Carga el siguiente numero de ticket a utilizar

        public static List<Plato> CargarPlatos()
        {
            ConexionBD con = new ConexionBD();
            con.AbrirConexion();

            if (con == null)
            {
                throw new Exception("No se pudo conectar a la Base de Datos!");
            }

            string consulta = "SELECT * FROM Platos;";
            MySqlCommand cmd = new MySqlCommand(consulta, con.conexion);
            MySqlDataReader rd = cmd.ExecuteReader();
            List<Plato> lista = new List<Plato>();

            while (rd.Read())
            {
                Plato p = new Plato();
                p.id = rd.GetInt32(0);
                p.nombre = rd.GetString(1);
                p.precio = rd.GetDouble(2);
                lista.Add(p);
            }

            con.CerrarConexion();
            return lista;
        } //Carga los platos que hay en la BD

        public static void AgregarPlato(Plato p)
        {
            ConexionBD con = new ConexionBD();
            con.AbrirConexion();

            if (con == null)
            {
                throw new Exception("No se pudo conectar a la Base de Datos!");
            }

            string consulta = "INSERT INTO Platos (nombrePlato, precio) VALUES ('"+p.nombre+"',"+p.precio.ToString()+");";

            MySqlCommand cmd = new MySqlCommand(consulta, con.conexion);

            int Resultado = cmd.ExecuteNonQuery();

            con.CerrarConexion();

            if (Resultado == 0)
            {
                throw new Exception("No se pudo ingresar el Plato!");
            }
        } //Ingresar un nuevo plato a la BD

        public static void ModificarPlato(Plato p)
        {
            ConexionBD con = new ConexionBD();
            con.AbrirConexion();

            if (con == null)
            {
                throw new Exception("No se pudo conectar a la Base de Datos!");
            }

            string consulta = "UPDATE Platos SET nombrePlato='"+p.nombre+"', precio="+p.precio.ToString()+" WHERE id="+p.id+";";

            MySqlCommand cmd = new MySqlCommand(consulta, con.conexion);

            int Resultado = cmd.ExecuteNonQuery();

            con.CerrarConexion();

            if (Resultado == 0)
            {
                throw new Exception("No se pudo modificar el Plato");
            }
        } //Modifica un plato existente en la BD

        public static Plato BuscarPlatos(string pNombre)
        {
            ConexionBD con = new ConexionBD();
            con.AbrirConexion();

            if (con == null)
            {
                throw new Exception("No se pudo conectar a la Base de Datos!");
            }

            string consulta = "SELECT * FROM Platos WHERE nombrePlato='"+pNombre+"';";
            MySqlCommand cmd = new MySqlCommand(consulta, con.conexion);
            MySqlDataReader rd = cmd.ExecuteReader();
            Plato p = new Plato();

            while (rd.Read())
            {                
                p.id = rd.GetInt32(0);
                p.nombre = rd.GetString(1);
                p.precio = rd.GetDouble(2);                
            }

            con.CerrarConexion();
            return p;
        } //Carga los platos que hay en la BD

        public static void EliminarPlato(int pid)
        {
            ConexionBD con = new ConexionBD();
            con.AbrirConexion();

            if (con == null)
            {
                throw new Exception("No se pudo conectar a la Base de Datos!");
            }

            string consulta = "DELETE FROM Platos Where id="+pid+";";

            MySqlCommand cmd = new MySqlCommand(consulta, con.conexion);

            int Resultado = cmd.ExecuteNonQuery();

            con.CerrarConexion();

            if (Resultado == 0)
            {
                throw new Exception("No se pudo eliminar el Plato!");
            }
        } //Modifica un plato existente en la BD
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AlgranatiGroupLTDA.Entidades
{
    public class ConexionBD
    {
        //Atributos
        public MySqlConnection conexion;

        //Constructores
        public ConexionBD()
        {
            conexion = new MySqlConnection("server=127.0.0.1; port=3306; database= AlgranatiGroup; Uid=root; pwd='';");
        }

        //Operaciones
        public bool AbrirConexion() {
            try
            {
                conexion.Open();
                return true;
            }
            catch (Exception ex) {
                return false;
                throw ex;
            }            
        }

        public bool CerrarConexion()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch (Exception ex) {
                return false;
                throw ex;
            }

        }
    }
}

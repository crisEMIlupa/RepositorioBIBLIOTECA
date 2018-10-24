using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace biblioteca
{
    class estudianteBD
    {
        public static int Agregar(estudiante Estu)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into estudiantes (codEst, nombreEst, semestreEst, carreraEst, domicilio, telefonoEst) values ('{0}','{1}','{2}', '{3}', '{4}', '{5}')",
               Estu.codEstu, Estu.nombreEstu, Estu.semestreEstu, Estu.carreraEstu, Estu.domicilioEstu,Estu.telefonoEstu), conexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static List<estudiante> Buscar()
        {
            List<estudiante> _lista = new List<estudiante>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT codEst, nombreEst, semestreEst, carreraEst, domicilioEst,telefonoEst FROM estudiantes"), estudiante.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                estudiante pEstu = new estudiante();
                pEstu.codEstu = _reader.GetString(0);
                pEstu.nombreEstu = _reader.GetString(1);
                pEstu.semestreEstu = _reader.GetString(2);
                pEstu.carreraEstu = _reader.GetString(3);
                pEstu.domicilioEstu = _reader.GetString(4);
                pEstu.telefonoEstu = _reader.GetString(5);
                
                
            }

            return _lista;
        }
    }
}

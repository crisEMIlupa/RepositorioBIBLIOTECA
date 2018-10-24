using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace biblioteca
{
    class tesisBD
    {
        public static int Agregar(tesis Tes)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into tesis (codTes, tituloTes, carreraTes, nombreEsTes, ciEst, nombreTutor, especialidad, codTutor) values ('{0}','{1}','{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
               Tes.codtes, Tes.titulites, Tes.carretes, Tes.nombretes, Tes.cites, Tes.nombtes, Tes.especialidadtes, Tes.codites), conexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static List<tesis> Buscar()
        {
            List<tesis> _lista = new List<tesis>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT codTes, tituloTes, carreraTes, nombreEsTes,ciEst,nombreTutor,especialidad,codTutor FROM tesis"), tesis.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                tesis pCliente = new tesis();
                pCliente.codtes = _reader.GetString(0);
                pCliente.titulites = _reader.GetString(1);
                pCliente.carretes = _reader.GetString(2);
                pCliente.nombretes = _reader.GetString(3);
                pCliente.cites = _reader.GetString(4);
                pCliente.nombtes = _reader.GetString(5);
                pCliente.especialidadtes = _reader.GetString(6);
                pCliente.codites = _reader.GetString(7);
                _lista.Add(pCliente);
            }

            return _lista;
        }
        /*public static List<tesis> Buscar()
        {
            List<tesis> _lista = new List<tesis>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT ciCliente, nomCliente, teleCliente, domiCliente FROM cliente"), conexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                tesis pCliente = new tesis();
                pCliente.ciCliente = _reader.GetString(0);
                pCliente.nomCliente = _reader.GetString(1);
                pCliente.teleCliente = _reader.GetString(2);
                pCliente.domiCliente = _reader.GetString(3);

                _lista.Add(pCliente);
            }

            return _lista;
        }

        public static int Actualizar(tesis pCliente)
        {
            int retorno = 0;
            MySqlConnection conexion = Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update cliente set teleCliente ='{0}', domiCliente ='{1}' where ciCliente ='{2}'",
               pCliente.teleCliente, pCliente.domiCliente, pCliente.ciCliente), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }

        public static int Eliminar(string pId)
        {
            int retorno = 0;
            MySqlConnection conexion = Conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From cliente where ciCliente ='{0}'", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }*/
    }
}

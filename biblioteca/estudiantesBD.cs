using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace biblioteca
{
    class estudiantesBD
    {
       // public static int Agregar(estudiantes estu)
        //{

            /* int retorno = 0;

             MySqlCommand comando = new MySqlCommand(string.Format("Insert into mueble (tipoMueble, modelo, dimenAlto, dimenAncho, dimenLargo) values ('{0}','{1}', {2}, {3} , {4} )",
                 estu.tipoMuebl, Mueb.modelo, Mueb.dimAlto, Mueb.dimAncho, Mueb.dimLargo), conexion.ObtenerConexion());
             retorno = comando.ExecuteNonQuery();
             return retorno;
         }

         public static List<Mueble> Buscar()
         {
             List<Mueble> _lista = new List<Mueble>();

             MySqlCommand _comando = new MySqlCommand(String.Format(
            "SELECT codMueble, tipoMueble, modelo, dimenAlto, dimenAncho, dimenLargo FROM mueble"), conexion.ObtenerConexion());
             MySqlDataReader _reader = _comando.ExecuteReader();
             while (_reader.Read())
             {
                 Mueble pMueble = new Mueble();
                 pMueble.codMueble = _reader.GetInt32(0);
                 pMueble.tipoMuebl = _reader.GetString(1);
                 pMueble.modelo = _reader.GetString(2);
                 pMueble.dimAlto = _reader.GetInt32(3);
                 pMueble.dimAncho = _reader.GetInt32(4);
                 pMueble.dimLargo = _reader.GetInt32(5);
                 _lista.Add(pMueble);
             }

             return _lista;
         }

         public static int Actualizar(Mueble pMueble)
         {
             int retorno = 0;
             MySqlConnection conexion = Conexion.ObtenerConexion();

             MySqlCommand comando = new MySqlCommand(string.Format("Update mueble set dimenAlto  ={0}, dimenAncho ={1}, dimenLargo ={2} where codMueble ='{3}'",
                pMueble.dimAlto, pMueble.dimAncho, pMueble.dimLargo, pMueble.codMueble), conexion);

             retorno = comando.ExecuteNonQuery();
             conexion.Close();

             return retorno;

         }

         public static int Eliminar(int pId)
         {
             int retorno = 0;
             MySqlConnection conexion = Conexion.ObtenerConexion();

             MySqlCommand comando = new MySqlCommand(string.Format("Delete From mueble where codMueble ={0}", pId), conexion);

             retorno = comando.ExecuteNonQuery();
             conexion.Close();

             return retorno;

         }*/
        
    }
}

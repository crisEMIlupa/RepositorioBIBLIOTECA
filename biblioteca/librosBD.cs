using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace biblioteca
{
    class librosBD
    {
        public static int Agregar(libros lib)
        {

            
            int retorno = 0;

        MySqlCommand comando = new MySqlCommand(string.Format("Insert into libros (codLib, tituloLib, autorLib, edicionLib, editorialLib, carreraLib) values ('{0}','{1}','{2}', '{3}', '{4}', '{5}')",
           lib.codlib, lib.titulolib, lib.autorlib, lib.edicionlib, lib.editoriallib, lib.carreralib), conexion.ObtenerConexion());
        retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    public static List<libros> Buscar()
    {
        List<libros> _lista = new List<libros>();

        MySqlCommand _comando = new MySqlCommand(String.Format(
       "SELECT codLib, tituloLib, autorLib, edicionLib, editorialLib, carreraLib FROM libros"), tesis.ObtenerConexion());
        MySqlDataReader _reader = _comando.ExecuteReader();
        while (_reader.Read())
        {
            libros pLibro = new libros();
                pLibro.codlib = _reader.GetString(0);
                pLibro.titulolib = _reader.GetString(1);
                pLibro.autorlib = _reader.GetString(2);
                pLibro.edicionlib = _reader.GetString(3);
                pLibro.editoriallib = _reader.GetString(4);
                pLibro.carreralib = _reader.GetString(5);
                
            _lista.Add(pLibro);
        }

        return _lista;
    }
}
}

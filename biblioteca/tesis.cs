using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace biblioteca
{
    class tesis
    {
        public string codtes { get; set; }
        public string titulites { get; set; }
        public string carretes { get; set; }
        public string nombretes { get; set; }
        public string cites { get; set; }
        public string nombtes { get; set; }
        public string especialidadtes { get; set; }
        public string codites { get; set; }


        public tesis() { }

        public tesis(string codTes, string tituloTes, string carreraTes, string nombreEsTes, string ciEst, string nombreTutor, string especialidad, string codTutor)

        {
            this.codites = codTes;
            this.titulites = tituloTes;
            this.carretes = carreraTes;
            this.nombretes = nombreEsTes;
            this.cites = ciEst;
            this.nombtes = nombreTutor;
            this.especialidadtes = especialidad;
            this.codites = codTutor;
        }
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=biblioteca; Uid=root; pwd=;");
            conectar.Open();
            return conectar;
        }
        /* internal static MySqlConnection ObtenerConexion()
          {
              throw new NotImplementedException();
          }*/
    }
}

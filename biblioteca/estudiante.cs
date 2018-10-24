using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace biblioteca
{
    class estudiante
    {
        
            public string codEstu { get; set; }
            public string nombreEstu { get; set; }
            public string semestreEstu { get; set; }
            public string carreraEstu { get; set; }
            public string domicilioEstu { get; set; }
            public string telefonoEstu { get; set; }
            


            public estudiante() { }

            public estudiante(string codEs, string nombreEs, string semestreEs, string carreraEs, string domicilioEs, string telefonoEs)

            {
                this.codEstu = codEs;
                this.nombreEstu = nombreEs;
                this.semestreEstu = semestreEs;
                this.carreraEstu = carreraEs;
                this.domicilioEstu = domicilioEs;
                this.telefonoEstu = telefonoEs;
                
            }

        internal static MySqlConnection ObtenerConexion()
        {
            throw new NotImplementedException();
        }
    }
    }

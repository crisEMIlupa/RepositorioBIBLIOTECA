using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    class tesis
    {
        public string codtes { get; set; }
        public string titulites { get; set; }
        public string carretes { get; set; }
        public string nomtes { get; set; }
        public int cites { get; set; }
        public string nombtes { get; set; }
        public string especialidadtes { get; set; }
        public string codites { get; set; }


        public tesis() { }

        public tesis(string codTes, string tituloTes, string carreraTes, string nombreEsTes, int ciEst, string nombreTutor, string especialidad, string codTutor)

        {
            this.codites = codTes;
            this.titulites = tituloTes;
            this.carretes = carreraTes;
            this.nomtes = nombreEsTes;
            this.cites = ciEst;
            this.nombtes = nombreTutor;
            this.especialidadtes = especialidad;
            this.codites = codTutor;
        }
    }
}

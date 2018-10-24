using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    class estudiantes
    {
        public int codMueble { get; set; }
        public string tipoMuebl { get; set; }
        public string modelo { get; set; }
        public int dimAlto { get; set; }
        public int dimAncho { get; set; }
        public int dimLargo { get; set; }

        public estudiantes() { }

        public estudiantes(int codmue, string tipomue, string mode, int dimal, int diman, int dimlar)

        {
            this.codMueble = codmue;
            this.tipoMuebl = tipomue;
            this.modelo = mode;
            this.dimAlto = dimal;
            this.dimAncho = diman;
            this.dimLargo = dimlar;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    class libros
    {
        public string codlib { get; set; }
        public string titulolib { get; set; }
        public string autorlib { get; set; }
        public string edicionlib { get; set; }
        public string editoriallib { get; set; }
        public string carreralib { get; set; }
        
        


        public libros() { }

        public libros(string codLIB, string tituloLIB, string autorLIB, string edicionLIB, string editorialLIB, string carreraLIB)

        {
            this.autorlib = codLIB;
            this.titulolib = tituloLIB;
            this.autorlib = autorLIB;
            this.edicionlib = editorialLIB;
            this.editoriallib = editorialLIB;
            this.carreralib = carreraLIB;
           
        }
    }
}

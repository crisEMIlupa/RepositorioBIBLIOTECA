using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    class nodoEstudiante
    {
        private nodoEstudiante sig;
        private string nombre;
        private string codigo;
        private string semestre;
        private string carrera;
        private int telefono;
        private string domicilio;
        

        public nodoEstudiante()//CONSTRUCTOR
        {
            nombre = "";
            codigo = "";
            semestre = "";
            carrera = "";
            telefono = 0;
            domicilio = "";
            
            
            sig = null;
        }
        //SET
        public void set_nombre(string nom)
        {
            nombre = nom;
        }
        public void set_codigo(string cod)
        {
            codigo = cod;
        }
        public void set_semestre(string semes)
        {
            semestre = semes;
        }
        public void set_carrera(string carre)
        {
            carrera = carre;
        }

        public void set_telefono(int fono)
        {
            telefono = fono;
        }
        public void set_domicilio(string domi)
        {
            domicilio = domi;
        }
       
        public void set_sig(nodoEstudiante s)
        {
            sig = s;
        }
        //GET
        public string get_nombre()
        {
            return nombre;
        }
        public string get_codigo()
        {
            return codigo;
        }
        public string get_semestre()
        {
            return semestre;
        }
        public string get_carrera()
        {
            return carrera;
        }
        public int get_telefono()
        {
            return telefono;
        }
        public string get_domicilio()
        {
            return domicilio;
        }
       
        public nodoEstudiante get_sig()
        {
            return sig;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    class listaEstudiante
    {
        private nodoEstudiante cabeza;
        private nodoEstudiante nuevo;

        public listaEstudiante()
        {
            cabeza = null;
            nuevo = null;
        }
        public void crear_nodo_estudiante()
        {
            nuevo = new nodoEstudiante();
        }

        public nodoEstudiante vacio()
        {
            return cabeza;
        }//FIN DEL METODO VACIO

        public void crear_lista(string nom, string cod, string seme, string carre, int fono, string domi)
        {
            crear_nodo_estudiante();
            nuevo.set_nombre(nom);
            nuevo.set_codigo(cod);
            nuevo.set_semestre(seme);
            nuevo.set_carrera(carre);
            nuevo.set_telefono(fono);
            nuevo.set_domicilio(domi);
         
            nodoEstudiante aux;
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                aux = cabeza;
                while (aux.get_sig() != null)
                {
                    aux = aux.get_sig();
                }
                aux.set_sig(nuevo);
            }
        }//FIN DEL METODO CREAR LISTA
    }
}

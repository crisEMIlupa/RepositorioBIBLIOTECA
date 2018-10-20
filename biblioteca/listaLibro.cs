using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    class listaLibro
    {
        private nodoLibro cabeza;
        private nodoLibro nuevo;

        public listaLibro()
        {
            cabeza = null;
            nuevo = null;
        }
        public void crear_nodo_libro()
        {
            nuevo = new nodoLibro();
        }

        public nodoLibro vacio()
        {
            return cabeza;
        }//FIN DEL METODO VACIO

        public void crear_lista(string tit,string cod, string edi, string edit, string aut, string carre, string mate)
        {
            crear_nodo_libro();
            nuevo.set_titulo(tit);
            nuevo.set_codigo(cod);
            nuevo.set_edicion(edi);
            nuevo.set_editorial(edit);
            nuevo.set_autor(aut);
            nuevo.set_carrera(carre);
            nuevo.set_materia(mate);
            nodoLibro aux;
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

        public nodoLibro buscar(string mar, string mod)
        {
            nodoLibro aux = cabeza;
            while (aux != null)
            {
                if (aux.get_titulo() == mar && aux.get_autor() == mod)
                {
                    return aux;
                }
                aux = aux.get_sig();
            }
            return null;
        }

    }
}

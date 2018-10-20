using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    class lista
    {
        nodo cabeza, nuevo;
        public lista()
        {
            cabeza = null;
            nuevo = null;
        }
        public void crear_nodo(int lot, int canti)
        {
            nuevo = new nodo();
            nuevo.set_lote(lot);
            nuevo.set_cant(canti);
            nuevo.set_sgte(null);
        }
        public void crear_lista(int lot, int canti)
        {
            nodo aux;
            crear_nodo(lot, canti);
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                aux = cabeza;
                while (aux.get_sgte() != null)
                {
                    aux = aux.get_sgte();
                }
                aux.set_sgte(nuevo);
            }
        }
        public nodo dev_cabeza()
        {
            return cabeza;
        }
        public void retu_cabeza(nodo cab)
        {
            cabeza = cab;
        }
    }
}

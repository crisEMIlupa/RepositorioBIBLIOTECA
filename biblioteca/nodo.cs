using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    class nodo
    {
        int lote;
        int cantidad;
        nodo sgte;
        public nodo()
        {
            cantidad = 0;
            lote = 0;
            sgte = null;
        }
        public void set_cant(int can)
        {
            cantidad = can;
        }
        public void set_lote(int lot)
        {
            lote = lot;
        }
        public void set_sgte(nodo punt)
        {
            sgte = punt;
        }
        public int get_cant()
        {
            return cantidad;
        }
        public int get_lote()
        {
            return lote;
        }
        public nodo get_sgte()
        {
            return sgte;
        }
    }
}

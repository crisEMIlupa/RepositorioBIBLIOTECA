using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    class nodoLibro
    {
        private nodoLibro sig;
        private string titulo;
        private string codigo;
        private string edicion;
        private string editorial;
        private string autor;
        private string carrera;
        private string materia;

        public nodoLibro()//CONSTRUCTOR
        {
            titulo = "";
            codigo = "";
            edicion = "";
            editorial = "";
            autor = "";
            carrera = "";
            materia = "";
            sig = null;
        }
        //SET
        public void set_titulo(string tit)
        {
            titulo = tit;
        }
        public void set_codigo(string cod)
        {
            codigo = cod;
        }
        public void set_edicion(string col)
        {
            edicion = col;
        }
        public void set_editorial(string mar)
        {
            editorial = mar;
        }
       
        public void set_autor(string p)
        {
          autor = p;
        }
        public void set_carrera(string cant)
        {
            carrera = cant;
        }
        public void set_materia(string mat)
        {
            materia = mat;
        }
        public void set_sig(nodoLibro s)
        {
            sig = s;
        }
        //GET
        public string get_titulo()
        {
            return titulo;
        }
        public string get_codigo()
        {
            return codigo;
        }
        public string get_edicion()
        {
            return edicion;
        }
        public string get_editorial()
        {
            return editorial;
        }
        public string get_autor()
        {
            return autor;
        }
        public string get_carrera()
        {
            return carrera;
        }
        public string get_materia()
        {
            return materia;
        }
        public nodoLibro get_sig()
        {
            return sig;
        }
    }
}

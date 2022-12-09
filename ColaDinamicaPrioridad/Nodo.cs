using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColaDinamicaPrioridad
{
    internal class Nodo
    {
        private string dato;
        private Nodo siguiente;
        private int prioridad;
        public string Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public int Prioridad
        {
            get { return prioridad; }
            set { prioridad = value; }
        }
        public Nodo()
        {
            dato = "";
            prioridad = 0;
            siguiente = null;
        }
        public override string ToString()
        {
            return dato;
        }
    }
}

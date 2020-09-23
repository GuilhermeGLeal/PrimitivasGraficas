using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitivasGráficas
{
    class NoRedo
    {
        private Ponto info;
        private Poligono poligon;
        private string metodo;
        private NoRedo prox;

        public NoRedo(Ponto info, NoRedo prox, string metodo, Poligono poligon)
        {
            this.info = info;
            this.prox = prox;
            this.metodo = metodo;
            this.Poligon = poligon;
        }

        public NoRedo()
        {
            this.info = new Ponto();
        }

        public Ponto Info { get => info; set => info = value; }
        public NoRedo Prox { get => prox; set => prox = value; }
        public string Metodo { get => metodo; set => metodo = value; }
        public Poligono Poligon { get => poligon; set => poligon = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitivasGráficas
{
    class NoPilha
    {
        private Ponto2 p;
        private NoPilha prox;

      
        public NoPilha(Ponto2 p, NoPilha prox)
        {
            this.p = p;
            this.prox = prox;
        }

        public NoPilha()
        {

        }

        public Ponto2 P { get => p; set => p = value; }
        public NoPilha Prox { get => prox; set => prox = value; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitivasGráficas
{
    class PilhaCor
    {
        private NoPilha inicio;

        public PilhaCor()
        {
            this.inicio = null;
        }

        public Ponto2 retirar()
        {
            Ponto2 aux = inicio.P;
            inicio = inicio.Prox;

            return aux;
        }
        
        public bool isEmpty()
        {
            return inicio == null;   
        }

        public void inserir(Ponto2 pont)
        {
            NoPilha novo = new NoPilha(pont, inicio);
            inicio = novo;
        }

    }
}

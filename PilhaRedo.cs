using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitivasGráficas
{
    class PilhaRedo
    {
        private NoRedo inicio;

        public PilhaRedo()
        {
            this.inicio = null;
        }

        public void inicializar()
        {
            this.inicio = null; 
        }
        public NoRedo Inicio { get => inicio; set => inicio = value; }
        
        public void inserir(Ponto info, string metodo)
        {
            NoRedo novo = new NoRedo(info, inicio, metodo, null);
            inicio = novo;
        }

        public void inserir(Poligono info, string metodo)
        {
            NoRedo novo = new NoRedo(null, inicio, metodo, info);
            inicio = novo;
        }

        public void retirar()
        {
            if(inicio != null) 
             inicio = inicio.Prox;
        }

        public bool isEmpty()
        {
            return Inicio == null;
        }

        public int qtdPilha()
        {
            NoRedo aux = inicio;
            int size = 0;

            while (aux != null)
            {
                size++;
                aux = aux.Prox;
            }

            return size;
                
        }
    }
}

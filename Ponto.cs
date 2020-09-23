using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitivasGráficas
{
    class Ponto
    {
        private double xInicio, yInicio;
        private double xFinal, yFinal;

        public Ponto(double xInicio, double yInicio, double xFinal, double yFinal)
        {
            this.XInicio = xInicio;
            this.YInicio = yInicio;
            this.XFinal = xFinal;
            this.YFinal = yFinal;
        }

        public double XInicio { get => xInicio; set => xInicio = value; }
        public double YInicio { get => yInicio; set => yInicio = value; }
        public double XFinal { get => xFinal; set => xFinal = value; }
        public double YFinal { get => yFinal; set => yFinal = value; }

        public Ponto()
        {

        }

        public void resetaPontos()
        {
            this.XInicio = -99999.0;
            this.XFinal = -1.0;
            this.YInicio = -1.0;
            this.YFinal = -1.0;
        }

        public void transefePontos(Ponto aux)
        {
            this.XFinal = aux.XFinal;
            this.YFinal = aux.YFinal;
            this.yInicio = aux.yInicio;
            this.xInicio = aux.xInicio;
        }

        public void transferePonto2(Ponto2 inicio, Ponto2 fim)
        {
            this.xInicio = inicio.X;
            this.yInicio = inicio.Y;
            this.xFinal = fim.X;
            this.YFinal = fim.Y;
        }
    }

}

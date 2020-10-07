using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitivasGráficas
{
    class Ponto
    {
        private double xInicio, yInicio;
        private double xFinal, yFinal;

        private double xInicioWP, yInicioWP;
        private double xFinalWP, yFinalWP;

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
        public double XInicioWP { get => xInicioWP; set => xInicioWP = value; }
        public double YInicioWP { get => yInicioWP; set => yInicioWP = value; }
        public double XFinalWP { get => xFinalWP; set => xFinalWP = value; }
        public double YFinalWP { get => yFinalWP; set => yFinalWP = value; }

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

        public void viewPort(int width, int height, Bitmap bitdest)
        {
            
            double sx, sy;
            sx = (double)(bitdest.Width) / (double)(width);
            sy = (double)(bitdest.Height) / (double)(height);
            
            xInicioWP = Math.Round(xInicio * sx);
            XFinalWP = Math.Round(xFinal * sx);
            YInicioWP = Math.Round(yInicio * sy);
            yFinalWP = Math.Round(yFinal* sy);


        }
    }

}

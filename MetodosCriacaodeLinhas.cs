using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PrimitivasGráficas
{
    class MetodosCriacaodeLinhas
    {
        public static void EquacaoRealdaReta(Bitmap imgOrigem, Ponto pontos)
        {
            double dy = pontos.YFinal - pontos.YInicio;
            double dx = pontos.XFinal - pontos.XInicio;
            double m = 0.0, inc, x, y;

            y = pontos.YInicio;
            x = pontos.XInicio;

            if (dx != 0)
                m = dy / dx;

            try
            {
                if (Math.Abs(dx) > Math.Abs(dy))
                {
                    inc = dx < 0 ? -1 : 1;

                    for (; x != pontos.XFinal; x += inc)
                    {

                        imgOrigem.SetPixel((int)x, (int)y, Color.FromArgb(0, 0, 255));
                        y = pontos.YInicio + m * (x - pontos.XInicio);

                    }
                }
                else
                {
                    inc = dy < 0 ? -1 : 1;

                    for (; y != pontos.YFinal; y += inc)
                    {

                        imgOrigem.SetPixel((int)x, (int)y, Color.FromArgb(0, 0, 255));
                        x = pontos.XInicio + (y - pontos.YInicio) / m;
                    }
                }
            }
            catch (Exception e) { }
           
        }

        public static void DDA(Bitmap imgOrigem, Ponto pontos)
        {

            double X, Y, Xinc, Yinc, Length;
            double dX, dY;

            dX = (pontos.XFinal - pontos.XInicio);
            dY = (pontos.YFinal - pontos.YInicio);
            Length = Math.Abs(dX);

            if (Math.Abs(dY) > Length)
                Length = Math.Abs((pontos.YFinal - pontos.YInicio));

            Xinc = dX / Length;
            Yinc = dY / Length;

            X = pontos.XInicio; Y = pontos.YInicio;

            try
            {
                if (Math.Abs(dX) > Math.Abs(dY))
                {

                    while (X != pontos.XFinal)
                    {
                        imgOrigem.SetPixel((int)X, (int)Y, Color.FromArgb(0, 255, 0));
                        X = X + Xinc;
                        Y = Y + Yinc;
                    }

                }
                else
                {

                    while (Y != pontos.YFinal)
                    {
                        imgOrigem.SetPixel((int)X, (int)Y, Color.FromArgb(0, 255, 0));
                        X = X + Xinc;
                        Y = Y + Yinc;
                    }

                }
            }
            catch (Exception e) { }
           
        }

        public static void bresenham2(Bitmap imgOrigem, int xi, int xf, int yi, int yf)
        {
            int declive;
            int dx, dy, incE, incNE, d, x, y;

            dx = xf - xi;
            dy = yf - yi;


            try
            {
                if (Math.Abs(dx) > Math.Abs(dy))
                {
                    if (xf < xi)
                    {
                        bresenham2(imgOrigem, xf, xi, yf, yi);
                        return;
                    }

                    declive = dy < 0 ? -1 : 1;
                    dy = dy < 0 ? -dy : dy;
                    incE = 2 * dy;
                    incNE = 2 * dy - 2 * dx;
                    d = 2 * dy - dx;
                    y = yi;

                    for (x = xi; x <= xf; x++)
                    {
                        imgOrigem.SetPixel(x, y, Color.FromArgb(255, 0, 0));

                        if (d <= 0)
                        {
                            d += incE;
                        }
                        else
                        {
                            d += incNE;
                            y += declive;
                        }
                    }
                }
                else
                {
                    if (yf < yi)
                    {
                        bresenham2(imgOrigem, xf, xi, yf, yi);
                        return;
                    }

                    declive = dx < 0 ? -1 : 1;
                    dx = dx < 0 ? -dx : dx;
                    incE = 2 * dx;
                    incNE = 2 * dx - 2 * dy;
                    d = 2 * dx - dy;
                    x = xi;

                    for (y = yi; y <= yf; y++)
                    {
                        imgOrigem.SetPixel(x, y, Color.FromArgb(255, 0, 0));

                        if (d <= 0)
                        {
                            d += incE;
                        }
                        else
                        {
                            d += incNE;
                            x += declive;
                        }
                    }
                }
            }
            catch (Exception e) { } 
            

           
        }
    }
}

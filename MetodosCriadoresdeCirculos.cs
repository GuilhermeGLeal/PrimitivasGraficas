using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PrimitivasGráficas
{
    class MetodosCriadoresdeCirculos
    {

        private static void ElipsePoints(int cx, int cy, int x, int y, Bitmap origem)
        {
            origem.SetPixel(cx + x, cy +y, Color.FromArgb(0,0,0));
            origem.SetPixel(cx + x, cy  - y, Color.FromArgb(0, 0, 0));
            origem.SetPixel(cx - x, cy  - y, Color.FromArgb(0, 0, 0));
            origem.SetPixel(cx - x, cy + y, Color.FromArgb(0, 0, 0));
        }

        public static void MidpointElipse(Ponto pont, Bitmap origem)
        {
            int x, y;
            double d1, d2;


            int a, b;

            a = (int)(Math.Abs(pont.XFinal - pont.XInicio));
            b = (int)(Math.Abs(pont.YFinal - pont.YInicio));

            x = 0;
            y = b;
            d1 = b * b - a * a * b + a * a / 4.0;

            try
            {
                ElipsePoints((int)pont.XInicio, (int)pont.YInicio, x, y, origem);


                while (a * a * (y - 0.5) > b * b * (x + 1))
                {

                    if (d1 < 0)
                    {
                        d1 = d1 + b * b * (2 * x + 3);
                        x++;
                    }
                    else
                    {
                        d1 = d1 + b * b * (2 * x + 3) + a * a * (-2 * y + 2);
                        x++;
                        y--;
                    }

                    ElipsePoints((int)pont.XInicio, (int)pont.YInicio, x, y, origem);
                }

                d2 = b * b * (x + 0.5) * (x + 0.5) + a * a * (y - 1) * (y - 1) - a * a * b * b;

                while (y > 0)
                {

                    if (d2 < 0)
                    {

                        d2 = d2 + b * b * (2 * x + 2) + a * a * (-2 * y + 3);
                        x++;
                        y--;
                    }
                    else
                    {
                        d2 = d2 + a * a * (-2 * y + 3);
                        y--;
                    }

                    ElipsePoints((int)pont.XInicio, (int)pont.YInicio, x, y, origem);
                }
            }
            catch (Exception e) { }
          
        }

        public static void equacaoGeral(Bitmap origem, Ponto pontos, double Raio)
        {
            double x = 0, y;           
            double fim = Raio / Math.Sqrt(2.0);

            try
            {
                for (; x < fim; x++)
                {
                    y = Math.Sqrt(Math.Pow(Raio, 2.0) - Math.Pow(x, 2.0));

                    simetriaDE8(origem, (int)pontos.XInicio, (int)pontos.YInicio, (int)x, (int)y, "EQUACAO");
                }
            }
            catch (Exception e) { }          

        }

        public static void pontoMedio(Bitmap origem, Ponto pontos, double Raio)
        {
            
            double x = 0;
            double y = Raio;
            double d = 1 - Raio;

            try
            {
                simetriaDE8(origem, (int)pontos.XInicio, (int)pontos.YInicio, (int)x, (int)y, "PONTO");
                while (y > x)
                {
                    if (d < 0)
                        d += 2 * x + 3;
                    else
                    {
                        d += 2.0 * (x - y) + 5.0;
                        y--;
                    }

                    x++;
                    simetriaDE8(origem, (int)pontos.XInicio, (int)pontos.YInicio, (int)x, (int)y, "PONTO");

                }
            }
            catch(Exception e) { }
            
        }
    

        public static void trignometria(Bitmap origem, Ponto pontos, double Raio)
        {
            double x , y;
            double AnguloAtual = 45.0;
            double Perimetro = 2 * Math.PI * Raio;
            double AnguloAux;
            double inc = 360.0 / Perimetro;

            try
            {
                for (; AnguloAtual <= 90; AnguloAtual += inc)
                {

                    AnguloAux = AnguloAtual * Math.PI / 180;

                    x = Raio * Math.Cos(AnguloAux);
                    y = Raio * Math.Sin(AnguloAux);
                    

                    simetriaDE8(origem, (int)pontos.XInicio, (int)pontos.YInicio, (int)x, (int)y, "TRIGO");
                }
            }
            catch (Exception e) { };
           
        }

        public static void simetriaDE8(Bitmap origem, int cx, int cy, int x, int y, string metodo)
        {
            Color novaCor = Color.FromArgb(0,0,0);

            switch (metodo)
            {
                case "EQUACAO":
                    novaCor = Color.FromArgb(255, 0, 0);
                    break;
                case "TRIGO":
                    novaCor = Color.FromArgb(0, 255, 0);
                    break;
                case "PONTO":
                    novaCor = Color.FromArgb(0, 0, 255);
                    break;
            }


            /*1*/origem.SetPixel(cx + x, cy + y, novaCor);
            /*2*/origem.SetPixel(cx + y, cy + x, novaCor);
            /*3*/origem.SetPixel(cx + y, cy - x, novaCor);
            /*4*/origem.SetPixel(cx + x, cy - y, novaCor);
            /*5*/origem.SetPixel(cx - x, cy - y, novaCor);
            /*6*/origem.SetPixel(cx - y, cy - x, novaCor);
            /*7*/origem.SetPixel(cx - y, cy + x, novaCor);
            /*8*/origem.SetPixel(cx - x, cy + y, novaCor);
          
        }

    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PrimitivasGráficas
{
    class Poligono
    {
        private List<Ponto2> pontosOriginais;
        private List<Ponto2> pontosAtuais;
        private List<Ponto2> pontosViewPort;
        private double[][] matrizAcumulada;
        private bool inicializado;

        public List<Ponto2> PontosOriginais { get => pontosOriginais; set => pontosOriginais = value; }
        public List<Ponto2> PontosAtuais { get => pontosAtuais; set => pontosAtuais = value; }
        public List<Ponto2> PontosViewPort { get => pontosViewPort; set => pontosViewPort = value; }

        public Poligono()
        {
            this.pontosAtuais = new List<Ponto2>();
            this.pontosOriginais = new List<Ponto2>();
            

            this.matrizAcumulada = new double[3][];

            inicializado = false;
        }

        public void inicializarMatriz()
        {
            if (!inicializado)
            {
                for (int i = 0; i < matrizAcumulada.Length; i++)
                {
                    matrizAcumulada[i] = new double[3];
                }

                this.matrizAcumulada[0][0] = 1.0;
                this.matrizAcumulada[1][1] = 1.0;
                this.matrizAcumulada[2][2] = 1.0;

                inicializado = !inicializado;
            }
           
        }

        public void addPonto(Ponto2 aux)
        {
            pontosOriginais.Add(aux);
        }

        public double getPontoOriginalX(int pos)
        {
            return this.pontosOriginais[pos].X;
        }

        public double getPontoOriginalY(int pos)
        {
            return this.pontosOriginais[pos].Y;
        }

        public void addPontoAtual(Ponto2 aux)
        {
            pontosAtuais.Add(aux);
        }

        public Ponto2 getPontoAtual(int pos)
        {
            return this.pontosAtuais[pos];
        }

        public void translacao(double X, double Y)
        {
            if(X!= 0 && Y != 0)
            {
                double[,] matrizTrans = new double[3, 3];
                double[,] matrizAux = new double[3, 3];
                double soma;
                matrizTrans[0, 0] = 1.0;
                matrizTrans[1, 1] = 1.0;
                matrizTrans[2, 2] = 1.0;
                matrizTrans[0, 2] = X;
                matrizTrans[1, 2] = Y;
                matrizAux = retMatAux(matrizAcumulada);
                for (int linha = 0; linha < 3; linha++)
                {
                    for (int coluna = 0; coluna < 3; coluna++)
                    {
                        soma = 0;

                        for (int k  = 0; k < 3; k++)
                        {
                            soma += matrizTrans[linha, k] * matrizAux[k,coluna];
                        }

                        this.matrizAcumulada[linha][coluna] = soma;
                    }
                }
            }

        }
        public double[,] retMatAux(double[][] matrizAcumulada)
        {
            double[,] matrizAux = new double[3, 3];
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    matrizAux[i, j] = matrizAcumulada[i][j];
                }
            }
            return matrizAux;
        }
        
        public double retornaCX()
        {
            double somaX = 0;

            for (int i = 0; i < pontosAtuais.Count; i++)
            {
                somaX += pontosAtuais[i].X;
            }

            return somaX / pontosAtuais.Count;
        }

        public double retornaCY()
        {
            double somaY = 0;

            for (int i = 0; i < pontosAtuais.Count; i++)
            {
                somaY += pontosAtuais[i].Y;
            }

            return somaY / pontosAtuais.Count;
        }
    
        public void escala(double fatorX, double fatorY)
        {
            double[,] matrizEscala = new double[3, 3];

            matrizEscala[0, 0] = fatorX;
            matrizEscala[1, 1] = fatorY;
            matrizEscala[2, 2] = 1.0;
            double soma;
            double[,] matrizAux = retMatAux(this.matrizAcumulada);
            
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    soma = 0;

                    for (int k = 0; k < 3; k++)
                    {
                        soma += matrizEscala[linha, k] * matrizAux[k,coluna];
                    }

                    this.matrizAcumulada[linha][coluna] = soma;
                }
            }
        }

        public void rotacao(double angulo)
        {
            double rad = angulo * Math.PI / 180.0;
            double[,] matrizAngulo = new double[3, 3];
            double soma;

            matrizAngulo[0, 0] = Math.Cos(rad);
            matrizAngulo[0, 1] = -Math.Sin(rad);
            matrizAngulo[1, 0] = Math.Sin(rad);
            matrizAngulo[1, 1] = Math.Cos(rad);
            matrizAngulo[2, 2] = 1.0;
            double[,] matrizAux = retMatAux(this.matrizAcumulada);
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    soma = 0;

                    for (int k = 0; k < 3; k++)
                    {
                        soma += matrizAngulo[linha, k] * matrizAux[k, coluna];
                    }

                    this.matrizAcumulada[linha][coluna] = soma;
                }
            }

        }

        public void rotacao(double angulo, double X, double Y)
        {
            this.translacao(-X, -Y);
            this.rotacao(angulo);
            this.translacao(X, Y);
        }

        public void escala(double fatorX, double fatorY, double X, double Y)
        {
            this.translacao(-X, -Y);
            this.escala(fatorX, fatorY);
            this.translacao(X, Y);
        }

        public void shearXY(double fatorX, double fatorY)
        {
            double X = retornaCX();
            double Y = retornaCY();
            this.translacao(-X, -Y);
            this.shear(fatorX, fatorY);
            this.translacao(X, Y);
        }
      
        public void shear(double fatorX, double fatorY)
        {
            double[,] matrizShear = new double[3, 3];

            matrizShear[0, 0] = 1.0;
            matrizShear[1, 1] = 1.0;
            matrizShear[2, 2] = 1.0;
            matrizShear[1, 0] = fatorX;
            matrizShear[0, 1] = fatorY;
            double soma;
            double[,] matrizAux = retMatAux(this.matrizAcumulada);

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    soma = 0;

                    for (int k = 0; k < 3; k++)
                    {
                        soma += matrizShear[linha, k] * matrizAux[k, coluna];
                    }

                    this.matrizAcumulada[linha][coluna] = soma;
                }
            }
        }
       

        public void reflexaoX(double fatorX)
        {
            double[,] matrizReflexao = new double[3, 3];

            matrizReflexao[0, 0] = 1.0;
            matrizReflexao[1, 1] = fatorX;
            matrizReflexao[2, 2] = 1.0;
           
            double soma;
            double[,] matrizAux = retMatAux(this.matrizAcumulada);

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    soma = 0;

                    for (int k = 0; k < 3; k++)
                    {
                        soma += matrizReflexao[linha, k] * matrizAux[k, coluna];
                    }

                    this.matrizAcumulada[linha][coluna] = soma;
                }
            }
        }

        public void reflexaoY(double fatorY)
        {
            double[,] matrizReflexao = new double[3, 3];

            matrizReflexao[0, 0] = fatorY;
            matrizReflexao[1, 1] = 1.0;
            matrizReflexao[2, 2] = 1.0;

            double soma;
            double[,] matrizAux = retMatAux(this.matrizAcumulada);

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    soma = 0;

                    for (int k = 0; k < 3; k++)
                    {
                        soma += matrizReflexao[linha, k] * matrizAux[k, coluna];
                    }

                    this.matrizAcumulada[linha][coluna] = soma;
                }
            }
        }

        public void aplicarMA()
        {
            double[,] pontosOrig = new double[3,1];
            double[,] novoPonto = new double[3, 1];
            double soma = 0;


            for (int i = 0; i < pontosOriginais.Count; i++)
            {
                pontosOrig[0, 0] = pontosOriginais[i].X;
                pontosOrig[1, 0] = pontosOriginais[i].Y;
                pontosOrig[2, 0] = 1.0;
                                
                for (int linha = 0; linha < 3; linha++)
                {                    

                    for (int coluna = 0; coluna < 1; coluna++)
                    {
                        soma = 0;

                        for (int k = 0; k < 3; k++)
                        {
                            soma += matrizAcumulada[linha][k] * pontosOrig[k, coluna];
                        }

                        novoPonto[linha, coluna] = Math.Round(soma);
                    }

                  
                }

                this.PontosAtuais[i].X = novoPonto[0, 0];
                this.PontosAtuais[i].Y = novoPonto[1, 0];
            }
        }

        public void floodFill(int x, int y, Bitmap imageBitSrc)
        {
            try
            {
                PilhaCor stack = new PilhaCor();
                Ponto2 aux;
                Color color;
                int[] vetX = { 1, 0, -1, 0 };
                int[] vetY = { 0, 1, 0, -1 };

                stack.inserir(new Ponto2(x, y));

                while (!stack.isEmpty())
                {
                    aux = stack.retirar();
                    imageBitSrc.SetPixel((int)(aux.X), (int)(aux.Y), Color.FromArgb(150, 150, 150));

                    for (int i = 0; i < vetX.Length; i++)
                    {
                        color = imageBitSrc.GetPixel((int)(aux.X + vetX[i]), (int)(aux.Y + vetY[i]));

                        if (color.G != 255)
                        {
                            if (color.G != 150 && color.B != 150 && color.R != 150)
                                stack.inserir(new Ponto2(aux.X + vetX[i], aux.Y + vetY[i]));
                        }
                    }

                }
            }
            catch (Exception e) { 
                
            };
           
        }

        public int retornaYMax()
        {
            double x = 0;

            for (int i = 0; i < pontosAtuais.Count; i++)
            {
                if (pontosAtuais[i].Y > x)
                    x = pontosAtuais[i].Y;
            }

            return (int)x;
        }

        public void carregaListaET(Bitmap imageBitSrc)
        {
            int tamLista = retornaYMax();
            ListaET[] listas = new ListaET[tamLista+1];
            double Ymax = 0, Xmim = 0, incrX = 0, dy, dx, Ymin;

            for (int i = 0; i < pontosAtuais.Count-1; i++)
            {
                if (pontosAtuais[i].Y < pontosAtuais[i + 1].Y)
                {
                    Ymax = pontosAtuais[i + 1].Y;
                    Xmim = pontosAtuais[i].X;
                    Ymin = pontosAtuais[i].Y;

                    dy = Ymax - Ymin;
                    dx = pontosAtuais[i + 1].X - Xmim;
                }
                else
                {
                    Ymax = pontosAtuais[i].Y;
                    Xmim = pontosAtuais[i+1].X;
                    Ymin = pontosAtuais[i + 1].Y;

                    dy = Ymax - Ymin;
                    dx = pontosAtuais[i].X - Xmim;
                }               

                incrX = dx / dy;
                if (listas[(int)Ymin] == null)
                    listas[(int)Ymin] = new ListaET();

                listas[(int)Ymin].inserir(Ymax, Xmim, incrX); 
            }

            if (pontosAtuais[0].Y < pontosAtuais[pontosAtuais.Count-1].Y)
            {
                Ymax = pontosAtuais[pontosAtuais.Count - 1].Y;
                Xmim = pontosAtuais[0].X;
                Ymin = pontosAtuais[0].Y;

                dy = Ymax - Ymin;
                dx = pontosAtuais[pontosAtuais.Count - 1].X - Xmim;
            }
            else
            {
                Ymax = pontosAtuais[0].Y;
                Xmim = pontosAtuais[pontosAtuais.Count - 1].X;
                Ymin = pontosAtuais[pontosAtuais.Count - 1].Y;

                dy = Ymax - Ymin;
                dx = pontosAtuais[0].X - Xmim;
            }           

            incrX = dx / dy;
            if (listas[(int)Ymin] == null)
                listas[(int)Ymin] = new ListaET();
            listas[(int)Ymin].inserir(Ymax, Xmim, incrX);

            criaAET(imageBitSrc, listas);
        }
        
        public void retornaET(ListaET[] listas, ListaET AET, ref int y)
        {
            NoListaET aux;

            if(y == -1)
            {
                for (int i = 0; i < listas.Length; i++)
                {
                    if(listas[i] != null)
                    {
                        y = i;

                        aux = listas[i].Inicio;
                        while (aux != null)
                        {
                            AET.inserir(aux.Ymax1, aux.Xmin1, aux.IncrX1);
                            aux = aux.Prox;
                        }
                         

                        break;
                    }
                }
            }
            else
            {
                if (listas[y] != null)
                {                   
                    aux = listas[y].Inicio;

                    while (aux != null)
                    {
                        AET.inserir(aux.Ymax1, aux.Xmin1, aux.IncrX1);
                        aux = aux.Prox;
                    }                    
                }
            }
        }

        public void incrementaXMIN(ListaET AET)
        {
            NoListaET aux = AET.Inicio;

            while(aux != null)
            {
                aux.Xmin1 += aux.IncrX1;
                aux = aux.Prox;
            }
        }

        public void pintarValores(ListaET AET, Bitmap imageBitSrc, int y)
        {
            NoListaET cx1, cx2;
            cx1 = AET.Inicio;
            cx2 = AET.Inicio.Prox;

            while(cx2 != null)
            {
                for (int i = (int)cx1.Xmin1; i < cx2.Xmin1; i++)
                {
                    imageBitSrc.SetPixel(i, y, Color.FromArgb(150, 150, 150));
                }

                cx1 = cx1.Prox.Prox;
                cx2 = cx1 == null? null : cx2.Prox.Prox;
            }
            
        }

        public void criaAET(Bitmap imageBitSrc, ListaET[] listas)
        {
            try
            {
                ListaET AET = new ListaET();
                int Y = -1;

                retornaET(listas, AET, ref Y);

                while (AET.Inicio != null)
                {
                    AET.retirarIgual(Y); // retirar y == ymax

                    if (AET.Inicio != null)
                    {
                        AET.ordenaXmin(); // ordernar a AET pelo xmin de forma crescente
                        pintarValores(AET, imageBitSrc, Y); // desenhar aos pares na lista AET, de xmin até xmin
                        incrementaXMIN(AET); // incrementar o xmin de cada caixa com seu incrx respectivo
                        Y++; // Y++
                        retornaET(listas, AET, ref Y);// chamar o retornaET passado o Y
                    }

                }
            }catch(Exception e) { }
          
        }

        public void viewPort(Bitmap bit,Bitmap bitdest)
        {
            this.pontosViewPort = new List<Ponto2>();
            double sx,sy;
            sx = (double)(bitdest.Width)/(double)(bit.Width);
            sy = (double)(bitdest.Height)/(double)(bit.Height);
            Ponto2 p;
            for(int i=0;i<pontosAtuais.Count();i++)
            {                
                p = new Ponto2(pontosAtuais[i].X, pontosAtuais[i].Y);
                p.X = Math.Round(p.X * sx);
                p.Y = Math.Round(p.Y * sy);
                pontosViewPort.Add(p);
            }
        }
    }
}

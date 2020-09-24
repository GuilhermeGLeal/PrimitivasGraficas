﻿using System;
using System.Collections.Generic;
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
        private double[][] matrizAcumulada;
        private bool inicializado;

        public List<Ponto2> PontosOriginais { get => pontosOriginais; set => pontosOriginais = value; }
        public List<Ponto2> PontosAtuais { get => pontosAtuais; set => pontosAtuais = value; }

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
            // chamar a função de atribuir a matriz aux;
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


        public void shearX(double fatorX)
        {
            double[,] matrizShear = new double[3, 3];

            matrizShear[0, 0] = 1.0;
            matrizShear[1, 1] = 1.0;
            matrizShear[2, 2] = 1.0;
            matrizShear[1, 0] = fatorX;
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

        public void shearY(double fatorY)
        {
            double[,] matrizShear = new double[3, 3];

            matrizShear[0, 0] = 1.0;
            matrizShear[1, 1] = 1.0;
            matrizShear[2, 2] = 1.0;
            matrizShear[0, 2] = fatorY;
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

    }
}

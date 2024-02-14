﻿using System;
using System.Diagnostics.SymbolStore;
using Tabuleiro;
namespace Tabuleiro
{
    class tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        private Peca[,] pecas;
        //  private Posicao pos;
        public tabuleiro(int Linhas, int Colunas)
        {
            this.Linhas = Linhas;
            this.Colunas = Colunas;
            pecas = new Peca[Linhas, Colunas];
        }
        public Peca peca(int linha, int coluna)
        {
            {
                return pecas[linha, coluna];
            }
        }
        public Peca peca(Posicao pos)
        {
            return pecas[pos.Linha, pos.Coluna];
        }

        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return peca(pos) != null;
        }

        public void ColocarPeca(Peca P, Posicao pos)

        {
            if (ExistePeca(pos))
            {
                throw new TabuleiroException("Já existtem uma peça!");
            }
            pecas[pos.Linha,pos.Coluna] = P;    
            P.posicao = pos;
        }
        public Peca RetirarPeca(Posicao pos)
        {
            if (peca(pos) == null)
            {
                  return null;
            }
            Peca aux = peca(pos);
            aux.posicao = null;
            pecas[pos.Linha, pos.Coluna] = null;
            return aux;
        }

        public bool PosicaoValida(Posicao pos)
        {
            if (pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas)
            {
                return false;
            }
            return true;
        }
        public void ValidarPosicao(Posicao pos)
        {
            if (!PosicaoValida(pos))
            {
                throw new TabuleiroException("Posiçao invlálida");
            }
        }


    }

}

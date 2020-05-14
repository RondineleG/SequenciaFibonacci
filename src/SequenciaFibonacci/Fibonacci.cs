using System;
using System.Collections.Generic;

namespace SequenciaFibonacci
{
    public class Fibonacci
    {
        public List<int> NumerosFibonacci()
        {
            var listaNumerosFibonacci = new List<int>();
            int numeroAtual = 1, numeroAnterior = 0, numeroProximo;

            for (var i = 0; i < 14; ++i)
            {
                numeroProximo = numeroAtual + numeroAnterior;
                numeroAtual = numeroAnterior;
                numeroAnterior = numeroProximo;
                listaNumerosFibonacci.Add(numeroAtual);
            }
            return listaNumerosFibonacci;
        }
        public bool IsFibonacci(int numeroTestado) => NumerosFibonacci().Contains(numeroTestado);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    internal class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        private double saldo = 100;

        public void DefinirSaldo(double saldo)
        {
            if (saldo < 0)
            {
                return;
            }
            
            this.saldo = saldo;
        }

        public double ObterSaldo()
        {
            return saldo;
        }

        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (saldo < valor)
            {
                return false;
            }
            
            saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
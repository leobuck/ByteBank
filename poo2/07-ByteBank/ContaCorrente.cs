using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    internal class ContaCorrente
    {
        //private Cliente _titular;

        //public Cliente Titular
        //{
        //    get { return _titular; }
        //    set { _titular = value; }
        //}

        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }
        //public static int ObterTotalDeContasCriadas()
        //{
        //    return TotalDeContasCriadas;
        //}

        private int _agencia { get; set; }
        public int Agencia
        {
            get { return _agencia; }
            set
            {
                if (value <= 0)
                {
                    return;
                }

                _agencia = value;
            }
        }

        public int Numero { get; set; }

        private double _saldo = 100;
        public double Saldo
        {
            get { return _saldo; }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }

        //public void SetSaldo(double saldo)
        //{
        //    if (saldo < 0)
        //    {
        //        return;
        //    }
            
        //    this.saldo = saldo;
        //}

        //public double GetSaldo()
        //{
        //    return saldo;
        //}

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            
            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}

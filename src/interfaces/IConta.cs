using ATM.src.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.interfaces.IConta.cs
{
    interface IConta
    {
        void sacar(double valor);

        void depositar(double valor);

        void transferir(double valor, Conta contaDestino);

        void imprimirExtrato();
    }
}

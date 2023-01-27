using src.interfaces.IConta.cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.src.entities
{
    public abstract class Conta : IConta
    {

        private static readonly Random random = new Random();

        private static int AGENCIA_PADRAO = random.Next(0, 8900);
        private static int SEQUENCIAL = random.Next(0, 8900);


        protected int agencia { get; private set; }
        protected int numero { get; private set; }
        protected double saldo { get; private set; }
        protected Cliente cliente { get; private set; }

        public Conta (Cliente cliente)
        {
            agencia = AGENCIA_PADRAO + random.Next(1, 100);
            numero = SEQUENCIAL++;
            this.cliente = cliente;
        }

        public void sacar(double valor)
        {
            saldo -= valor;
        }

        public void depositar(double valor)
        {
            saldo += valor;
        }

        public void transferir(double valor, Conta contaDestino)
        {
            this.sacar(valor);
            contaDestino.depositar(valor);


        }

        public virtual void imprimirExtrato()
        {
            Console.WriteLine($"Titular: {this.cliente.Nome}");
            Console.WriteLine($"Agencia: {this.agencia}");
            Console.WriteLine($"Numero:  {this.numero}");
            Console.WriteLine($"Saldo:   {this.saldo}");
        }
    }
}

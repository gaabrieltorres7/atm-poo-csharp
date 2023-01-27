using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.src.entities
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(Cliente cliente) : base(cliente)
        {
        }

        public override void imprimirExtrato()
        {
            Console.WriteLine("= Extrato Conta Poupança =");
            base.imprimirExtrato();
        }
    }
}

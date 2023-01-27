using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.src.entities
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(Cliente cliente) : base(cliente)
        {
        }

        public override void imprimirExtrato()
        {
            Console.WriteLine("= Extrato Conta Corrente =");
            base.imprimirExtrato();
        }
    }
}

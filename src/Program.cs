using ATM.src.entities;
using System;

Cliente gabriel = new Cliente();
gabriel.Nome = "Gabriel";


Conta cc = new ContaCorrente(gabriel);
Conta poupanca = new ContaPoupanca(gabriel);


cc.depositar(100);
cc.transferir(20, poupanca);

cc.imprimirExtrato();
poupanca.imprimirExtrato();

Console.WriteLine("\n-----------------------------------------------------\n");


Cliente naldo = new Cliente();
naldo.Nome = "Naldo";


Conta cc2 = new ContaCorrente(naldo);
Conta poupanca2 = new ContaPoupanca(naldo);


cc2.depositar(200);
cc2.transferir(20, poupanca2);

cc2.imprimirExtrato();
poupanca2.imprimirExtrato();

Console.WriteLine("\n-----------------------------------------------------\n");

cc2.transferir(80, poupanca);
poupanca.imprimirExtrato();
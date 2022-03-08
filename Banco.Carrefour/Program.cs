using System;
using System.Collections.Generic;

namespace Banco.Carrefour
{
    class Program
    {
        static List<Conta> listContas = new List<Conta>();
        static void Main(string[] args)
        {
            System.Console.WriteLine("O Banco Carrefour possui diversas operações para facilitar o seu dia-a-dia!\nEstamos a sua disposição.");
            
            string opcaoUsuario = ObterOpcaoUsusario();
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        TransferirConta();
                        break;
                    case "4":
                        SacarConta();
                        break;
                    case "5":
                        DepositarConta();
                        break;
                    default:
                        throw new ThreadInterruptedException("Opção inválida.");
                        break;
                }
                System.Console.WriteLine();
                
                opcaoUsuario = ObterOpcaoUsusario();
                Console.Clear();
            }
            System.Console.WriteLine("O Banco Carrefour agradece a sua preferência!");
            System.Console.WriteLine();
            
        }

        private static void DepositarConta()
        {
            System.Console.WriteLine("---------------Operação de Depósito---------------");
            System.Console.WriteLine("Digite o número da conta que recebera o depósito: ");
            var numConta = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Quanto deseja Depositar: ");
            var depositoConta = int.Parse(Console.ReadLine());
            listContas[numConta].Depositar(depositoConta);
        }

        private static void TransferirConta()
        {
            System.Console.WriteLine("---------------Operação de Transferência---------------");
            System.Console.WriteLine("Digite o número da conta a ser debitada: ");
            var sacaConta = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o número da conta a ser creditada: ");
            var recebeConta = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Quanto deseja transferir da conta {0} para a conta {1}: ", sacaConta, recebeConta);
            var valorTranferencia = int.Parse(Console.ReadLine());
            listContas[sacaConta].Transferir(valorTranferencia, listContas[recebeConta]);
            
        }

        private static void SacarConta()
        {
            System.Console.WriteLine("---------------Operação de Saque---------------");
            System.Console.WriteLine("Digite o número da conta: ");
            var numConta = int.Parse(Console.ReadLine());
            Console.Clear();
            listContas[numConta].Recepcionar();
            System.Console.WriteLine("Quanto você quer sacar da conta: ");
            var quantiaSaque = double.Parse(Console.ReadLine());
            listContas[numConta].Sacar(quantiaSaque);
        }

        private static void ListarContas()
        {
            if(listContas.Count() == 0){
                System.Console.WriteLine("Não há nenhuma conta cadastrada no Banco!");
                return;
            }
            for (int i = 0; i < listContas.Count(); i++)
            {
                System.Console.Write("#{0}", i);
                System.Console.WriteLine(listContas[i]);                
            }
        }

        private static string ObterOpcaoUsusario()
        {
            System.Console.WriteLine();        
            System.Console.WriteLine("Informe qual o procedimento a ser realizado:");            
            System.Console.WriteLine("1 - Listas contas armazenadas");
            System.Console.WriteLine("2 - Inserir uma nova conta ");
            System.Console.WriteLine("3 - Tranferir");
            System.Console.WriteLine("4 - Sacar");
            System.Console.WriteLine("5 - Depositar");
            System.Console.WriteLine("X - Sair do sistema");

            System.Console.WriteLine();
            
            string opcaoUsuario = Console.ReadLine().ToUpper();
            return opcaoUsuario;
        }

        private static void InserirConta()
        {
            System.Console.WriteLine("---------------Operação de Inserção de Conta---------------");
            System.Console.WriteLine("Digite 1 para Conta Física ou 2 para Conta Juídica");
            var entradaConta = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o nome:");
            var entradaNome = Console.ReadLine();
            System.Console.WriteLine("Digite o saldo da conta:");
            var entradaSaldo = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o crédito para emprestimo:");
            var entradaCredito = double.Parse(Console.ReadLine());

            var novaConta = new Conta((TipoConta)entradaConta, 
                                        entradaSaldo, 
                                        entradaCredito, 
                                        entradaNome, listContas.Count());
            listContas.Add(novaConta);
            Console.Clear();
        }
    }
}
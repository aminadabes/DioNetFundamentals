using System;
using System.Collections.Generic;
using AppBancaria.Classes;
using AppBancaria.Enum;

namespace AppBancaria
{
    class Program
    {
        static List<Conta> listContas = new List<Conta>();
        static PainelDeControle painelDeControle = new PainelDeControle();

        static void Main(string[] args)
        {
            string opcaoDesejada = painelDeControle.OperacaoDesejada();

            while(opcaoDesejada.ToUpper() !=  "X")            
            {
                switch (opcaoDesejada)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;   
                    case "3":
                        Transferir();
                        break;                            
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
                        break;
                    case "6":
                        Emprestimo();
                        break;          
                    case "C":
                        Console.Clear();
                        break;            
                    default:
                    throw new ArgumentOutOfRangeException();
                }

                opcaoDesejada = painelDeControle.OperacaoDesejada();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
            
        }

        private static void Transferir()
        {
            Console.Write("Digite o número da conta de origem:");
             int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.Write("Digite o número da conta de destino:");
             int indiceContaDestino = int.Parse(Console.ReadLine());

             Console.Write("Digite o valor a ser transferido:");
             double valorTransferencia = double.Parse(Console.ReadLine());

             listContas[indiceContaOrigem].Transferir(valorTransferencia, listContas[indiceContaDestino]);
        }

        private static void Depositar()
        {
            Console.Write("Digite o número da conta:");
             int indiceConta = int.Parse(Console.ReadLine());

             Console.Write("Digite o valor a ser depositado:");
             double valorDeposito = double.Parse(Console.ReadLine());
             
             listContas[indiceConta].Depositar(valorDeposito);
        }

        private static void Sacar()
        {
             Console.Write("Digite o número da conta:");
             int indiceConta = int.Parse(Console.ReadLine());

             Console.Write("Digite o valor a ser sacado:");
             double valorSaque = double.Parse(Console.ReadLine());

             listContas[indiceConta].Sacar(valorSaque);

        }

        private static void ListarContas()
        {
            Console.WriteLine("Listar contas");

            if(listContas.Count == 0)
            {
                Console.WriteLine("Nenhuma conta cadastrada");
                return;
            }

            for (int i = 0; i < listContas.Count; i++)
            {
                Conta conta = listContas[i];
                Console.Write("#{0} - ", i);
                Console.WriteLine(conta);
            }

        }

        private static void Emprestimo()
        {
            Console.WriteLine("INFORMAÇÕES DO EMPRESTIMO");

            Console.Write("Digite o número da conta:");
            int indiceConta = int.Parse(Console.ReadLine());
            
            Console.Write("Qual o valor desejado? ");
            double valorDesejado = double.Parse(Console.ReadLine());   

            Console.Write("Quantidade de prestações:");
            int qtdPrestacoes = int.Parse(Console.ReadLine());    

            listContas[indiceConta].Emprestimo(valorDesejado , qtdPrestacoes);

        }
        private static void InserirConta()
        {
            Console.WriteLine("Inserir nova conta");

            Console.Write("Digite 1 para Conta Física ou 2 para Jurídica:");
            int entradaTipoConta = int.Parse(Console.ReadLine());            

            Console.Write("Digite o nome do Cliente:");
            string entradaNome = Console.ReadLine();
            
            Console.Write("Digite o saldo inicial:");
            double entradaSaldo = double.Parse(Console.ReadLine());
            
            Console.Write("Digite o crédito:");
            double entradaCredito = double.Parse(Console.ReadLine());
                 
            Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta, 
                                        saldo: entradaSaldo, 
                                        limite: entradaCredito, 
                                        nome: entradaNome);

            listContas.Add(novaConta);
          
        }      
    }
}

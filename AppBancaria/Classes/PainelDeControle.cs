using System;

namespace AppBancaria.Classes
{
    public class PainelDeControle
    {
        private string operacaoDesejada { get; set; }
         public string OperacaoDesejada()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Bank a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1. Listar Contas");
            Console.WriteLine("2. Inserir nova conta");
            Console.WriteLine("3. Transferir");
            Console.WriteLine("4. Sacar");
            Console.WriteLine("5. Depositar");
            Console.WriteLine("6. Emprestimos");
            Console.WriteLine("C. Limpar Tela");
            Console.WriteLine("X. Sair");
            Console.WriteLine();

            operacaoDesejada = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return operacaoDesejada;

        }
    }
}
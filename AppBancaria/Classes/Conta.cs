using System;
using AppBancaria.Enum;

namespace AppBancaria.Classes
{
    public class Conta
    {
      private TipoConta TipoConta { get; set; }

        private double Saldo { get; set; }

        private double Limite { get; set; }

        private string Nome { get; set; }

        public Conta(TipoConta tipoConta, double saldo, double limite, string nome)
        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Limite = limite;
            this.Nome = nome;
        }

        public bool Sacar(double valorSaque)
        {   
            // Validação de saldo suficiente
            if(this.Saldo - valorSaque < (this.Limite * -1))   
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
            
            this.Saldo -= valorSaque;
            
            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
            
            return true;
        }

        public void Depositar(double valorDeposito) 
        {
            //valida se há valor para deposito
            if(valorDeposito<=0){
                Console.WriteLine("Envelope vazio ou valores negativos"); 
                return;
            }
            this.Saldo += valorDeposito;

            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
        }

        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if(this.Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
            }
        }


        public void Emprestimo(double valorDesejado, int qtdParcelas)
        {
            double valorFinal;
            double valorDaPrestacao;
            if(qtdParcelas <= 12)
            {                
               valorFinal = valorDesejado + (valorDesejado * 0.15);
               valorDaPrestacao = valorFinal / qtdParcelas;
            } else if (qtdParcelas > 12 && qtdParcelas <= 24)
            {             
                valorFinal = valorDesejado + (valorDesejado * 0.30);
                valorDaPrestacao = valorFinal / qtdParcelas;
            }
            else{             
               valorFinal = valorDesejado + (valorDesejado * 0.50);
               valorDaPrestacao = valorFinal / qtdParcelas;
            }
            Console.WriteLine("Informações do Emprestimo:");
            Console.WriteLine("O valor solicitado é R$ {0} em {1} parcelas de R$ {2} sendo o valor final R$ {3}", valorDesejado.ToString("N2"), qtdParcelas, valorDaPrestacao.ToString("N2"), valorFinal.ToString("N2"));
        }
       
        public override string ToString()
        {
            string retorno = "";
            retorno += "TipoConta " + this.TipoConta + "  - ";
            retorno += "Nome " + this.Nome + "  - ";
            retorno += "Saldo " + this.Saldo+ "  - ";
            retorno += "Limite " + this.Limite;
            return retorno;
        }
    }
}
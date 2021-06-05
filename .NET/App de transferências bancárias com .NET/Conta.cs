using System;

namespace App.Bank
{
    public class Conta
    {
        private TipoConta TipoConta { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private string Nome { get; set; }

        public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
        }
         public bool Sacar(double valorSaque)
        {
            //validação de saldo suficiente
            if (this.Saldo - valorSaque < (this.Credito *-1))
            {
                Console.WriteLine("Saldo Insuficiente!");
                return false;
            }

            this.Saldo -= valorSaque;

            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
            // https: //docs.microsoft.com/pt-br/dotnet/standard/base-types/composite-formatting

            return true;
        }
        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;
            
            Console.WriteLine("Saldo atual da conta de {0} e {1}", this.Nome, this.Saldo);
        }
        public void Tranferir(double valorTranferencia, Conta contaDestino)
        {
           if (this.Sacar(valorTranferencia)){
                contaDestino.Depositar(valorTranferencia);
           }
        }
        public override string ToString()
        {
           string retorno ="";
           retorno += "TipoConta "  + this.TipoConta + " | ";
           retorno += "Nome "  + this.Nome + " | ";
           retorno += "Crédito "  + this.Credito;
            return retorno;
        }

        internal void Tranferir(object p)
        {
            throw new NotImplementedException();
        }
    }

}

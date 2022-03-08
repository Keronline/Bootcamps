namespace Banco.Carrefour
{
    public class Conta
    {
        private string Nome { get; set; }

        private double Saldo;

        private TipoConta TipoConta;
        private double Credito;

        private int NumConta;

        public Conta(TipoConta tipoConta, double saldo, double credito, string nome, int numeroConta)
        {
            this.Nome = nome;
            this.Saldo = saldo;
            this.TipoConta = tipoConta;
            this.Credito = credito;
            this.NumConta = numeroConta;
        }

        public void Recepcionar()
        {
            System.Console.WriteLine("Olá, {0}! É muito bom te ver novamente!\n", this.Nome.ToUpper());
        }

        public bool Sacar(double valorSaque)
        {
            if (valorSaque > this.Saldo + this.Credito)
            {
                System.Console.WriteLine("Saldo insuficiente.");
                return false;
            }
            this.Saldo = this.Saldo - valorSaque;
            System.Console.WriteLine("Processo realizado com sucesso!\n O saldo atual da conta {0} é de R${1},00", this.NumConta, this.Saldo);
            return true;
        }

        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;
            System.Console.WriteLine("O saldo atual da conta {0} é de R${1},00.", this.NumConta, this.Saldo);
        }

        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if (this.Sacar(valorTransferencia)) contaDestino.Depositar(valorTransferencia);
        }

        public override string ToString()
        {
            string retorno = " ";
            retorno += "Tipo de conta: " + this.TipoConta + " | ";
            retorno += "Nome: " + this.Nome + " | ";
            retorno += "Saldo: R$" + this.Saldo + ",00 | ";
            retorno += "Crédito: R$" + this.Credito + ",00 | ";

            return retorno;
        }

    }
}
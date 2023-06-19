namespace CSharpBasic
{
    class ContaCorrente2
    {
        public int NumConta { get; set; }
        public int Agencia { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public void Sacar(double valor)
        {
            if (valor <= 0)
                throw new ContaCorrenteException("Valor inválido");

            this.Saldo -= valor;
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente2 contaDestino)
        {
            Sacar(valor);
            contaDestino.Depositar(valor);
        }

    }
}

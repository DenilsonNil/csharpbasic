namespace CSharpBasic
{
    //Precisa ser uma classe estática
    static class ContaCorrenteExtension
    {
        //O primeiro parâmetro precisa ser com a sintaxe this + espaço + parametro do tipo da classe que estou extendendo.
        public static void Transferir(this ContaCorrente3 conta, double valor, ContaCorrente3 contaDestino )
        {
            conta.Sacar(valor);
            contaDestino.Depositar(valor);
        }

        public static void MostrarSaldo(this ContaCorrente3 conta)
        {
            Console.WriteLine(conta.Saldo);
        }


    }
}

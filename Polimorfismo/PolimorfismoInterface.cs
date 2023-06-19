namespace CSharpBasic
{
    class PolimorfismoInterface
    {
        public void TestPolimorfismoInterface()
        {
            /** Aqui está polimorfismo, posso trocar a implementação do ImprimirColecao apenas trocando o tipo de objeto que implementa IColecionavel
             * Já que este método recebe este tipo de objeto, se daqui a algum tempo preciso expandir a aplicação bastaria criar a classe nova e posso usala
             * no metodo ImprimirColecao, ou seja, pode-se adicionar uma classe tardiamente e encaixar ela em uma estrutura que já existia sem precisa mexer no codigo
             * do metodo ImprimirColecao, ou seja o sistema está preparado para o futuro.
             * O metodo ImprimirColecao não lida com Selo, boné ou chaveiro ele lida com algo que é Icolecionavel.
             * **/
            IColecionavel i = new Selo();
            ImprimirColecao(i);
        }

        static void ImprimirColecao(IColecionavel colecionavel)
        {
            Console.WriteLine(colecionavel.getNomeColecao());
        }
    }

    public interface IColecionavel
    {
        string getNomeColecao();
    }

    public class Selo : IColecionavel
    {
        public string getNomeColecao()
        {
            throw new NotImplementedException();
        }
    }



}

namespace CSharpBasic
{
    internal class ParametrosSaida
    {
        public void TestParametrosSaida()

            /** a e b são variaveis de entrada e result é uma variável de saida, isso significa que 
             * que qualquer modificação nesta variável feita pelo metodo chamado vai ser refletida fora do método
             * A variável de saída não precisa ser inicializada, já que quem vai atribuir o valor a ela é o metodo de destino,
             * O compilador garante que esta variável vai ser inicializada dentro do método chamado, caso c não recebesse algum valor no método de destino
             * haverá um erro de compilação.
             * **/
        {
            Matematica matematica = new Matematica();
            int result;
            matematica.Multiplicar(10, 2, out result);
            Console.WriteLine(result);

             /**
              * A vantagem de trabalhar com out (parametros de saída) é usar em casos em que eu quero retornar mais de um valor no método
              * Por exemplo retornar o resultado da soma e também da multiplicação de dois numeros.**/
            int multiplicacao;
            int soma;
            matematica.MultiplicarESomar(3, 6, out multiplicacao, out soma);
        }
    }

    class Matematica
    {
        public void Multiplicar(int a, int b, out int c)
        {
            c = a * b;
        }

        public void MultiplicarESomar(int a, int b, out int resultadoMultiplicacao, out int resultadoSoma)
        {
            resultadoMultiplicacao = a * b;
            resultadoSoma = a + b;
        }

    }
}

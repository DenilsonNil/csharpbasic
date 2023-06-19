namespace CSharpBasic
{
    public class StringFormat
{
        public void TestStringFormat()
        {
            string cidade = "Manaus";
            string estado = "Amazonas";

            /** Concatenação de strings criam novos objetos na memória, se for feito muitas vezes pode gerar um problema de performace
             * Muitos objetos de vida curta serão criados e pode sobrecarregar o garbagecollector**/
            Console.WriteLine("Cidade " + cidade + "Estado " + estado);

            //Usando placeholders no fim teremos uma string só
            Console.WriteLine("Cidade {0}, Estado {1}", cidade, estado);

            //Os placeholders também podem ter informações de tamanho e alinhamento
            /** Mostrando em uma primeira linha Cidade e estado como títulos e em uma segunda linha os valores como uma tabela com alinhamento.
             *O titulo cidade tem tamanho 10 e Cidade tamanho 15, ou seja, serão adicionados espaços a direita até completar o tamanho**/

            Console.WriteLine("{0, 10}{1, 15}", "Cidade", "Estado");
            Console.WriteLine("{0, 10}{1, 15}", cidade, estado);

            //Para alinhar a esquerda adicionar um sinal de menos antes do tamanho
            Console.WriteLine("{0, -10}{1, -15}", "Cidade", "Estado");
            Console.WriteLine("{0, -10}{1, -15}", cidade, estado);

            //Mostrar um número em formato de moeda (C) Currency
            Console.WriteLine("Valor {0:C} ", 120.40);

            //Preenchendo com zeros e informando o tamanho máximo
            Console.WriteLine("Quantidade {0:D5}", 35);

            //Mostrando apenas 2 casas decimais
            Console.WriteLine("Peso: {0:N2}", 55.342);

            //Formatos customizados, exemplo o número tem que ter tamanho 10 e se não tiver deve ser preenchido com zeros a esquerda
            Console.WriteLine("{0:0000000000}", 345);

            //Máscara de telefone, Como o parenteses é um caracatere especial em regex ele é tratado de forma diferente na String adicionamos \\
            Console.WriteLine("{0:\\(##\\) ####-####}", 1165437899);

            //Formatar o dado e ao invés de mostrar na tela, guardar em uma string
            string telefone = String.Format("{0:\\(##\\) ####-####}", 1165437899);
        }
}
}

namespace CSharpBasic
{
    class StaticConstructor
    {
        public void TestStaticConstructor()
        {
            Console.WriteLine(Cambio.cotacaoDolar);
        }
    }

    class Cambio
    {
        public static double cotacaoDolar;

        /** Um construtor estático serve para inicializar fields staticos da classe. 
         * Não pode ter parametros.
         * É executado todas as vezes que a classe é referenciada, por exemplo neste caso na linha 13
         * quando a classe é referenciada o C# vai identificar que existe um construtor estático na classe
         * e se ele ainda não foi executado ele será executado e apenas 1 vez. Quem  invoca é o CLR e não a aplicação.
         * O construtor estático é o primeiro que é executado, antes de qualquer inicialização de field da classe e  antes de qualquer outro construtor.
         *
         * **/
        static Cambio()
        {
            cotacaoDolar = 12.1;
        }
    }
}

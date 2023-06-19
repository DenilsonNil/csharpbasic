namespace CSharpBasic
{
    class Constants
    {
        class Matematica
        {
            /** Usar a palavra chave const para definir uma constante. Essa palavra chave faz com que o field seja um static, portanto, 
             * o acesso se dá por meio da classe e não por instância. 
             * Uma constante deve ter o seu valor atribuído em tempo de compilação**/
            public const double PI = 3.14;

            /** Ao declarar um field como readonly não significa que o field é estático, portanto, 
             * seria necessário criar uma instancia da classe para ter acesso ao field, a não ser que use static e readyonly juntos.
             * 
            **/
            public readonly double E = 2.71828;

            /**Outra característica é que o valor atribuido não precisa ser conhecido em tempo de compilação, ou seja, nem precisa ter um valor atribuído na linha
             * onde o field é declarado.
             * A partir do momento que dermos um valor para o field esse valor vai ser fixo, ou seja, não pode mais ser alterado.
             * Esse valor deve ser atribuído nos construtores, se for um field statico no construtor estático..
             * **/
            public static readonly string name;

            static Matematica()
            {
                name = "Denilson";
            }

            public readonly int age;
            public Matematica()
            {
                this.age = 36;
            }

            public void TestConstants()
            {
                //Console.WriteLine(Matematica.age); // Não compila já que readonly não significa estático

                Matematica m = new Matematica();
                //m.age = 22; Não compila pois o field é readonly e já teve o seu valor atribuído no construtor da classe Matematica.
            }

        }
    }
}

namespace CSharpBasic
{
    class Polimorfismo
    {
        public void TestPolimorfismo()
        {
            //Polimorfismo
            Animal2 a = new Cachorro2();
            a.Falar(); // O método chamado será de Cachorro pois o objeto que está no objeto é um cachorro.

            //Como a referencia é de um animal não é possível chamar o método Morder
            // a.Morder() Não compila

            /**Para transformar a variável a que é animal em um cachorro usamos o casting explícito, lembrando que a referencia um cachorro.
             * Usado quando tenho um tipo mais genérico e preciso converte-lo para um tipo mais específico, faço isso quando preciso ter acesso 
             * a métodos de tipos específicos
             **/
            Cachorro2 c = (Cachorro2) a;
            c.Morder();

            //Operadores as e is usado para garantir que o casting pode ser feito

            Animal2 a2 = new Cachorro2();
            if(a2 is Cachorro2) // Se a2 é uma referencia a um cachorro retorna true
            {
                //Lembrando que para acessar o método eu ainda preciso fazer o casting
                Cachorro2 c2 = (Cachorro2) a2;
                c2.Morder();

            }

            //Converta para mim a2 para o tipo Cachorro2 e armarzene em c3 se a2 não for do tipo Cachorro2 o retorno é null faz o casting e já armarzena na mesma linha
            Cachorro2 c3 = a2 as Cachorro2;
            if(c3 != null) { 
                c3.Morder();
            }

        }
    }


    //SuperClasse       
    class Animal2
    {
        //Modificador virtual para informar que o método pode ser alterado pelas subclasses (sobrescrito)
        public virtual void EmitirSom()
        {
            Console.WriteLine("-----");
        }
    }

    //Subclasse
    class Cachorro2 : Animal2
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Something");
        }
        public void Morder()
        {
            Console.WriteLine("Something");
        }
    }

    //Subclasse
    class Gato2 : Animal2
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Something");
        }
    }

}

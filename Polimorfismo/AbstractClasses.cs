namespace CSharpBasic
{
    class AbstractClasses
    {
        public void TestAbstractClasses()
        {
            Animal3 a = new Cachorro3();
        }
    }

    abstract class Animal3
    {
        public abstract void Falar(); //Por default já fica com o modificador virtual
    }

    //Subclasse
    class Cachorro3 : Animal3
    {
        public override void Falar()
        {
            Console.WriteLine("Something");
        }

        public void Morder()
        {
            Console.WriteLine("Something");

        }
    }

    //Subclasse
    class Gato3 : Animal3
    {
        public override void Falar()
        {
            Console.WriteLine("Something");
        }
    }

}


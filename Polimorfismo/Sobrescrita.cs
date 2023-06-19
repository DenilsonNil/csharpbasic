namespace CSharpBasic
{
    class Program
    {
        public void TestPolimorfismo()
        {
            Cachorro c = new Cachorro();
            c.EmitirSom();

            Gato g = new Gato();
            g.EmitirSom();
        }
    }


    //SuperClasse
    class Animal4
    {
        //Modificador virtual para informar que o método pode ser alterado pelas subclasses (sobrescrito)
        public virtual void Falar()
        {
            Console.WriteLine("-----");
        }
    }

    //Subclasse
    class Cachorro : Animal2
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Something");
        }

        public static implicit operator Cachorro(Animal4 v)
        {
            throw new NotImplementedException();
        }
    }

    //Subclasse
    class Gato : Animal2
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Something");
        }
    }

}

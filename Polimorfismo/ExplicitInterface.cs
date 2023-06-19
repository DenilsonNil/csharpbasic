namespace CSharpBasic
{
    //Usamos este tipo de implementação quando precisamos implementar mais de uma interface que possuem um ou mais métodos com o mesmo nome
    //Neste caso por exemplo não tem como o compilador saber qual dos metodos EmitirSom deve ser chamado
    class ExplicitInterfaceExample : IAnimal, IBrinquedo
    {
       void IAnimal.EmitirSom()
        {
            Console.WriteLine("Animal");
        }

       void IBrinquedo.EmitirSom() 
        {
            Console.WriteLine("Brinquedo");
        }
    }

    interface IAnimal
    {
        void EmitirSom();
    }

    interface IBrinquedo
    {
        void EmitirSom();
    }
}


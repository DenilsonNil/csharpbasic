namespace CSharpBasic
{
    class ObjectInitializers
    {
        public void TestObjectInitializers()
        {
            //Criando uma instancia de um objeto através de object initializers
            Contato c = new Contato
            {
                Nome = "José",
                Telefone = "9999",
                Email = "algo@algo.com",
                Endereco = "abcd"
            };
            c.MostrarNome();

            //Criando uma instancia de um objeto usando tanto o construtor com parametro quanto o object initializer.
            Contato c2 = new Contato("Maria")
            { 
                Telefone = "9999",
                Email = "algo@algo.com",
                Endereco = "abcd"
            };
            c2.MostrarNome();

        }
    }

    class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }

        public Contato()
        {
            Console.WriteLine("Contato()");
        }

        public Contato(string nome)
        {
            Console.WriteLine("Contato(string)");
            this.Nome = nome;
        }

        public void MostrarNome()
        {
            Console.WriteLine(Nome);
        }

    }
}

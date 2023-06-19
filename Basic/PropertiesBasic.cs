namespace CSharpBasic
{
    class PropertiesBasic
    {
       public void TestPropertiesBasic()
        {
            Address address = new Address();
            address.Logradouro = "";
            address.Apartamento = true;
            Console.WriteLine(address.numero);
        }
    }

    class Address
    {
        private string logradouro;
      

        //Property sem validação, a sintaxe é simplificada. Precisa ser de escrita e leitura e não é necessário um field.
        public bool Apartamento { get; set; }

        //Também é possível restringir
        public int numero { get; private set; }


        //Property com regras de validação, precisa ter um field associado.
        public string Logradouro
        {
            get
            {
                return logradouro;
            }

            set
            {   if(value != null)
                    logradouro = value;
            }
        }
    }
}

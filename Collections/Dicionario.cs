namespace CSharpBasic
{
    class Dicionario
    {
        public void TestDicionario()
        {
            Estado e1 = new Estado("Rio Grande do Sul");
            Estado e2 = new Estado("Santa Catarina");
            Estado e3 = new Estado("Paraná");

            Dictionary<string, Estado> dic = new Dictionary<string, Estado>();
            //Adicionar dados em um dicionário
            //String já implementa equals e hashcode porém se a sua chave for uma chave criada por você mesmo é necessário implementar equals e hashcode para que 
            //O compilador saiba identificar uma chave igual e uma chave diferente
            dic.Add("RS", e1);
            dic.Add("SC", e2);
            dic.Add("PR", e3);

            dic["RS"] = e1;
            dic["SC"] = e2;
            dic["PR"] = e3;

            //Acessar elementos de um dicionário
            try
            {
                Estado e = dic["PR"];
                Console.WriteLine(e.Nome);
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine("A chave não existe");
            }

            //Verificar se um elemento existe baseado em uma chave
            Estado ePR;
            bool exist = dic.TryGetValue("PR", out ePR);
            Console.WriteLine(exist);

            //Iterar sobre as chaves
            Dictionary<string, Estado>.KeyCollection keys = dic.Keys;
            foreach (string key in keys)
            {
                Console.WriteLine(key);
            }

            //Iterar sobre os valores
            Dictionary<string, Estado>.ValueCollection values = dic.Values;
            foreach (Estado estado in values)
            {
                Console.WriteLine(estado.Nome);
            }

            //Iterar sobre os pares de chave e valor
            foreach (KeyValuePair<string, Estado> entry in dic)
            {
                string key = entry.Key;
                Estado value = entry.Value;

                Console.WriteLine(key + " => " + value.Nome);
            }
        }
    }

    public class Estado
    {
        public string Nome { get; set; }

        public Estado(string nome)
        {
            this.Nome = nome;
        }
    }
}

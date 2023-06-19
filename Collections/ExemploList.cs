namespace CSharpBasic
{
    class ExemploList
    {
        /**Lista é uma estrutura de dados que armarzena os dados de maneira sequencial e que usa por trás um array, 
         * portanto os ítems são indexados.
         * Quando se trabalha com lista diferentemente de um array não é necessário definir o tamanho da lista no momento da criação.
         * Outra vantagem é que quando se remove um ítem de um array fica um buraco, com List isso não ocorre já que o método 
         * remove realoca os ítems
         * 
         * **/
        public void TestList()
        {
            List<string> nomes = new List<string>();
            //Inserir no final da lista
            nomes.Add("José");
            nomes.Add("Maria");
            nomes.Add("Pedro");

            //Inserir elemento no meio da lista
            nomes.Insert(1, "Paula");

            //Percorrendo elementos
            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }

            //Verificar se um ítem existe na lista
            bool contem = nomes.Contains("José");

            //A property Count guarda o tamanho da lista    
            int listSize = nomes.Count;

            //O acesso a um elemento pode ser feito como em um array, ou seja pelo índice
            string primeiroNome  = nomes[0];

            //Outra forma de iteração usando o laço for e acessando o item da lista pelo índice

            for (int i = 0; i < nomes.Count; i++)
            {
                Console.Write(nomes[i]);
            }

            //Buscar a posição de um elemento na lista, se o elemento não existe retorna -1
            nomes.IndexOf("Paula");
        }
    }
}

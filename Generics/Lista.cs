namespace CSharpBasic
{
    /** Quando não se usa generics e queremos usar uma estrutura que seja genérica usamos objects para armarzenar os dados porém
     * isso pode causar problemas:
     * 1 - Ter ficar fazendo cast explícito ao tentar ler o dado de object desse object.
     * 2 - Ter que fazer boxing e unboxing, ou seja, Object é um reference type criado no managed heap, se eu passo um int por exemplo
     * para guardar nesse object, sendo que um int é um reference type ou seja, fica na stack tenho que fazer
     * um processamento a mais para fazer atribuição de int pra object. Internamente um objeto a mais é criado
     * no managed heap e o int fica dentro deste objeto e a partir daí o inteiro passa a existir no heap. No momento de ler o dado acontece o contrário, 
     * o object está no managed heap e se eu preciso ler esse dado internamente ocorre o unboxing, ou seja, esse dado é tirado do managed heap e é colocado
     * na stack como um int e o objeto do heap fica disponível pra o garbage collector com Boxing e unboxing a aplicação precisa criar no managed heap
     * um objeto a mais podendo dar problemas de performace.
     * 
     * Na prática basta substituir object por T que é recebido pela classe**/
    public class Lista<T>
    {
        //O tipo de dado T da lista vai ser repassado para o T do nó
        private No<T> primeiro;

        public void Adicionar(T elemento)
        {
            No<T> novoNo = new No<T>();
            novoNo.Elemento = elemento;

            if (primeiro == null)
            {
                primeiro = novoNo;
            }
            else
            {
                No<T> no = primeiro;
                while (no.Proximo != null)
                {
                    no = no.Proximo;
                }
                no.Proximo = novoNo;
            }
        }

        public T Ler(int pos)
        {
            if (pos < 0)
            {
                //A chamada default retorna null se T for um reference value e retorna o valor padrão caso seja primitivo
                return default(T);
            }

            if (primeiro == null)
            {
                return default(T);
            }

            int count = 0;
            No<T> no = primeiro;

            while (count < pos)
            {
                no = no.Proximo;
                count++;
            }

            return no.Elemento;
        }

        private class No<T>
        {
            public T Elemento { get; set; }
            public No<T> Proximo { get; set; }
        }
    }
}

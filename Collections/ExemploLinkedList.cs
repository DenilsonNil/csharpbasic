namespace CSharpBasic
{
    class ExemploLinkedList
    {
        /**LinkedList é uma estrutura de dados onde os dados são armarzenados de forma sequencial
         * porém a diferença pra uma lista é que é uma estrutura de dados composta por nós, onde cada nó
         * contém o elemento da lista e um ponteiro para o próximo ítem da lista e ao elemento anterior.
         * Quando se trabalha com list temos por trás um array e portanto é fácil chegar a qualquer elemento
         * da estrutura porém com linked list não temos indice e portanto é necessário ter ponteiros para o próximo
         * elemento assim como para o elemento anterior. Quando é necessário chegar em algum elemento da linkedlist temos que ir percorrendo um por um.
         * Como não temos conceitos de índice não tem como inserir em uma determinada posição, excluir de uma determinada posição. 
         * A vantagem é com relação de manipulação de elementos no meio da lista. Quando se trabalha com List e é necessário remover ou inserir um elemento
         * no meio da lista a implementação de List move cada elemento para a esquerda ou pra direita do Array. Com LinkedList basta acertar os ponteiros o que é muito mais rápido. **/
        public void criarListas()
        {
            LinkedList<string> meses = new LinkedList<string>();
            meses.AddLast("Janeiro");
            meses.AddLast("Fevereiro");
            meses.AddLast("Março");

            foreach (string mes in meses) 
            {
                Console.WriteLine(mes);          
            }

            //Percorrendo um linked list para encontrar um ítem.

            //Obter o primeiro nó da lista
            LinkedListNode<string> node = meses.First;

            Console.WriteLine(node.Value);

            //Em seguida itera sobre cada um dos nós
            while (node.Next != null)
            {
                node = node.Next;
                Console.WriteLine(node.Value);
            }
        }
        
       

    }
}

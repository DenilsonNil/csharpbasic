namespace CSharpBasic
{
    class FilasPilhas
    {
    public void TestFilasEPilhas()
    {
        Queue<char> queue = new Queue<char>();
        Stack<char> stack = new Stack<char>();

        while (true)
        {
            Console.Write("Elemento: ");
            string s = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(s))
            {
                break;
            }

            char c = s[0];

            //Enqueue armarzena um ítem na fila
            queue.Enqueue(c);

            //Push armarzena um Ítem na pilha
            stack.Push(c);
        }

        while (true)
        {   
            //Dequeue remove ítem da fila
            char fila = queue.Dequeue();

            // Pop remove ítem da pilha
            char pilha = stack.Pop();

            Console.WriteLine("=> " + fila);

            // Count armarzena quantos elementos existem na fila ou na pilha
            if (queue.Count == 0) 
            if (stack.Count == 0)
            {
                break;
            }
        }
    }
}
}

namespace CSharpBasic
{   
    public class Ordenacao
    {
        public void TesteOrdenacao()
        {
            List<Tarefa> tarefas = new List<Tarefa>();

            tarefas.Add(new Tarefa() { Descricao = "Lavar louça", Prioridade = Tarefa.Nivel.BAIXA});
            tarefas.Add(new Tarefa() { Descricao = "Limpar chão", Prioridade = Tarefa.Nivel.MEDIA});
            tarefas.Add(new Tarefa() { Descricao = "Fazer Compras", Prioridade = Tarefa.Nivel.MEDIA});
            tarefas.Add(new Tarefa() { Descricao = "Lavar roupa", Prioridade = Tarefa.Nivel.ALTA});
            tarefas.Add(new Tarefa() { Descricao = "Varrer calçada", Prioridade = Tarefa.Nivel.BAIXA});

            tarefas.Sort();
            foreach (Tarefa tarefa in tarefas)
            {
                Console.WriteLine(tarefa);
            }

            //Usando a classe que implementa IComparer, passar como parâmetro do método Sort um objeto que implemente Icomparer
            ComparadorAlfabetico c = new ComparadorAlfabetico();
            tarefas.Sort(c);
        }
    }

    /** Para ordenar objetos de uma classe criada por mim mesmo
     * Temos dois caminhos, ou implementa a interface Icomparable ou cria uma classe a parte que implementa Icomparer  e utliza na hora de fazer a ordenação **/
    public class Tarefa : IComparable<Tarefa>
    {
        public enum Nivel
        {
            ALTA = 10, MEDIA = 5, BAIXA = 0
        }

        public string Descricao { get; set; }

        public Nivel Prioridade { get; set; }

        public override string ToString()
        {
            return string.Format("{0} ({1})", Descricao, Prioridade);
        }
        //Neste caso o int retornado está vindo diretamente da implementação de CompareTo do Enum e CompareTo de String 
        public int CompareTo(Tarefa? other)
        {
            int c = this.Prioridade.CompareTo(other.Prioridade);

            if (c == 0)
            {
                return this.Descricao.CompareTo(other.Descricao);
            }

            return c;
        }
    }
    public class ComparadorAlfabetico : IComparer<Tarefa>
    {
        public int Compare(Tarefa x, Tarefa y)
        {
            return x.Descricao.CompareTo(y.Descricao);
        }
    }
}

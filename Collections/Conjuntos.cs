namespace CSharpBasic
{
    class Conjuntos
    {
        public void TestConjuntos()
        {
            //Usando um hashSet os elementos são armarzenados no conjunto de acordo com um algoritmo de hash.
            HashSet<string> dias = new HashSet<string>();
            dias.Add("Segunda");
            dias.Add("Terça");
            dias.Add("Quarta");
            dias.Add("Quinta");
            dias.Add("Sexta");
            dias.Add("Sábado");
            dias.Add("Domingo");

            foreach (var item in dias) 
            {
                Console.WriteLine(item);
            }
            //Removendo um elemento
            dias.Remove("Terça");

            //SortedSet - É um tipo de conjunto que a medida que vão sendo adicionados os elementos na lista ele já ordena.
            //Neste caso recomenda-se o uso de um Icomparable ou Icomparer para fazer a ordenação e passar este Icomparer no construtor de SortedSet
            SortedSet<string> dias2 = new SortedSet<string>();
            dias2.Add("Segunda");
            dias2.Add("Terça");
            dias2.Add("Quarta");
            dias2.Add("Quinta");
            dias2.Add("Sexta");
            dias2.Add("Sábado");
            dias2.Add("Domingo");
        }
    }

    /**Não esquecer de implementar o algoritmo de hashing para que o compilador possa saber em qual posição da coleção vai ficar cada ítem.
    * Sempre que sobrescrever o método equals sobrescreva o método HashCode pois se for necessário adicionar um objeto desta classe em um conjunto ele possa ser 
    * adicionado corretamente.
    * 
    * Sempre que for trabalhar com HashSet o objeto que vai ser colocado no HashSet tem que implementar Iequatable e HashCode
    * **/
    public class Conta : IEquatable<Conta>
    {
        public int Numero { get; set; }
        public Conta(int numero)
        {
            this.Numero = numero;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Conta);
        }

        public bool Equals(Conta? other)
        {
            if(other == null) throw new ArgumentException();

            return Numero == other.Numero;
        }

        //Se dois objetos são iguais eles tem que retornar o mesmo número inteiro
        public override int GetHashCode()
        {
           int hash = 27;
           hash = (13 * hash) + Numero.GetHashCode();

            return hash;
        }


    }
}

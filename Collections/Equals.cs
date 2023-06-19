namespace CSharpBasic
{
    public class Aluno
    {
        public string Name { get; set; }

        public Aluno(string name)
        { 
            this.Name = name;    
        }

        public override bool Equals(object? obj)
        {
            Aluno aluno = obj as Aluno;

            if (aluno == null) throw new ArgumentException("Objeto deve ser um aluno");

            return this.Name.Equals(aluno.Name);
        }
    }

    //Evitando boxing e unboxing.
    /**Se ao chamar o método equals for enviado um value type, o compilador vai ter que fazer o boxing
     * Ou seja, criar um objeto no managed heap, e colocar este value type dentro deste objeto criado. Para resolver
     * usamos a interface IEquatable que usa genérics.
     * Neste caso vamos ter que implementar o método equals da interface**/
    public class AlunoOtimizado : IEquatable<AlunoOtimizado>
    { 
        public string Name { get; set; }

        public AlunoOtimizado(string name)
        {
            this.Name = name;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) throw new ArgumentException("Objeto deve ser um aluno");
            return Equals(obj as AlunoOtimizado);
        }
        public bool Equals(AlunoOtimizado? other)
        {
            return this.Name.Equals(other.Name);
        }
    }
}



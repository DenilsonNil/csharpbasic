namespace CSharpBasic
{
    class Salario
    {
        public double valor;
        public int mes;

        /**Encadeando construtores, antes de este construtor com 3 parametros ser executado ele chama o construtor com 2 parametros
         * Para isso basta depois dos parametros adicionar dois pontos + this + parametros do construtor que quero encadear**/
        public Salario(double valor, double bonus, int mes) : this(valor, bonus)
        {
            this.mes = mes;
        }

        public Salario(double valor, double bonus) 
        { 
            this.valor = valor * bonus;
        }

        
        public Salario()
        {
            
        }
    }
}

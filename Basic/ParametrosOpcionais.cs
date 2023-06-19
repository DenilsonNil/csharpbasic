namespace CSharpBasic
{
    public class ParametrosOpcionais
    {
        /** 
         * Quando temos um parametro na aplicação que é muito comum que ele seja o mesmo podemos informar que ele é opcional
         * Assim se não passar o parametro ele vai assumir um valor padrao**/
        public void TestParametrosOpcionais()
        {
            Matematica2 math = new Matematica2();
            math.Elevar(2);
        }
    }

    class Matematica2
    {
        public double Elevar(double n, double potencia = 2)
        {
            return Math.Pow(n, potencia);
        }
    }
}

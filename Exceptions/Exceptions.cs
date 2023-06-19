namespace CSharpBasic
{
    class Exceptions
    {
        public void TestExceptions()
        {
            try
            {
                object o = null;
                o.ToString();


                Matematica3.dividir(12.5, 5.6);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    class Matematica3
    {
        public static double dividir(double d1, double d2)
        {
            if (d2 == 0)
                throw new ArgumentOutOfRangeException("Não é possível fazer divisão por 0");
            return d1 / d2;
        }
    }
}

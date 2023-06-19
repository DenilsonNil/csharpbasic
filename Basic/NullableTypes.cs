namespace CSharpBasic
{
    internal class NullableTypes
    {
        /** 
         * O operador ? (nullable) serve para tornar possível um tipo de dado que originalmente não recebe nulo poder receber nulo como valor
         * No exemplo abaixo, originalmente int é um tipo de dado que não recebe nulo,  usando o operador nullable podemos tonar isso possível**/
        public void TestNullableTypes()
        {
            int? n = null;

            if(n == null)
            {
                Console.WriteLine("n é null");
            }

            if(!n.HasValue) //Ao usar n.HasValue vai retornar se o valor não for nulo, negando retorna se o valor é null.
            {
                Console.WriteLine("n é null");
            }

            /** Se o valor de n for null atribua a x o valor 0 [Null-coalescing operator]. Usado em situações em que queremos atribuir em uma variável
             * que não aceita null [por exemplo x não pode aceitar null] o valor de uma variável que aceita null.
             * **/
            int x = n ?? 0;
        }
    }
}

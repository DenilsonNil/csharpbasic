namespace CSharpBasic
{
    class PassagemReferencia


         /**
         * Serão criados na stack x e y, y vai receber a referencia para a área de memória x tem o seu valor armarzenado .
         * Quando y é alterada x também é afetada já que ambas apontam pro mesmo lugar.
         * **/
    {
        public void TestPassagemReferencia()
        {
            Operations mClass = new Operations();
            int x = 20;

            mClass.Increese(ref x);

            Console.WriteLine(x);
        }
    }
       
    class Operations
    {
        public void Increese(ref int y) 
        {
            y = 40;
        }
    }
}

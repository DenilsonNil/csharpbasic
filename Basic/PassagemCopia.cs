namespace CSharpBasic
{
    class PassagemCopia

        /*
         * Serão criados na stack x e y, y vai receber a cópia do valor de x.
         * Quando y é alterada x não é afetada já que o valor de y é uma cópia do valor de x.
         * **/

    {
        public void TestPassagemCopia()
        {
            MyClass mClass = new MyClass();
            int x = 15;

            mClass.Increese(x);

            Console.WriteLine(x);
        }
    }


    class MyClass
    {
        public void Increese(int y) 
        {
            y = 40;
        }
    }
}


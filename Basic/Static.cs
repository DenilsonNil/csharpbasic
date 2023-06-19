namespace   CSharpBasic
{
    class Static
    {
        public void TestStatic()
        {
            Bola b1 = new Bola();
            Bola b2 = new Bola();
            Bola b3 = new Bola();

            Bola.showNumBolas();


        }

    }

    class Bola
    {
        public static int numBolas;

        public Bola()
        {
            numBolas++;
        }

        public static void showNumBolas()
        {
            Console.WriteLine(numBolas);
        }
    }
}

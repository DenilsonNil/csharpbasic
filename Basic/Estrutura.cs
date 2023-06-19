namespace CSharpBasic
{
    class Estrutura
    {
        /** 
         * A decisão entre uma classe e uma estrutura se dá por meio da passagem por parametro.
         * Estruturas são muito semelhantes a classes, podem conter membros internos como fields e metodos.
        A diferença principal é que Estruturas são value types e classes reference types, na prática
        os valores de estruturas são armarzenadas na Stack enquanto o conteúdo de uma classe é armarzenado no Managed Heap da memória
        Por serem armarzenados na stack ao passar uma estrutura como parametro de método ele é passado como valor e não como referencia, 
        Ou seja, se a estrutura for muito grande podemos ter problemas de performance da aplicação já que cada vez que ela é passada como parametro toda 
        a estrutura é copiada e isso pode não ser viável.
        No caso abaixo uma estrutura serviu bem já que é simples.
        
         Em uma estrutura SEMPRE um construtor padrão é gerado pelo compilador, ele serve para inicializar os fiels da estrutura com valor padrão e
         não pode ser redefinido.

        Ao definir construtores com parâmetros é preciso inicializar TODOS os fields manualmente
         **/
       static void TesteEstrutura()
        {
            Ponto p = new Ponto();
            p.x = 10;
            p.y = 20;

            p.MostrarCoordenadas();
        }
    }

    struct Ponto
    {
        public int x, y;

        public void MostrarCoordenadas()
        {
            Console.WriteLine("x = " + x + " y = " + y );
        }
    }
}

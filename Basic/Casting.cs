namespace CSharpBasic
{
    class Casting
    {
        
        public void ExemploCasting()
        {
            //Implícito
            int i = 10;
            double d = i;

            Console.WriteLine(d);

            short s = 5;
            long l = s;
            Console.WriteLine(l);

            //Explícito
            double d2 = 3.5;
            int i2 = (int) d2;
            Console.WriteLine(i2);  

            long l2 = 123456789654321687;
            int i4 = (int) l2; 
            
            Console.WriteLine(i4);
        }
        
    }
}

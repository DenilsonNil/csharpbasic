namespace CSharpBasic
{
    class Date
    {
            public void TestDate()
            {
                /** DateTime é uma structure, ou seja, não é criado no Managed Heap e sim na stack**/

                //Construtor passando ano mes e dia
                DateTime d = new DateTime(1987, 04, 04);
                Console.WriteLine(d.ToString()); // => 04/04/1987 00:00:00

                //Construtor passando ano, mes, dia, hora minuto e segundo
                DateTime d2 = new DateTime(1987, 04, 04, 10, 15, 05);
                Console.WriteLine(d2.ToString()); //=> 04/04/1987 10:15:05

                DayOfWeek dow = d.DayOfWeek; //O tipo DayOfWeek é um enum. Todo DateTime possui essa property
                Console.WriteLine(dow.ToString()); // => Saturday

                //Obtendo a data e hora atual do sistema
                DateTime now = DateTime.Now;
                Console.WriteLine(now.ToString());

                //Now traz a data e hora já o today só se preocupa com a data
                DateTime today = DateTime.Today;
                Console.WriteLine(today.ToString());

                //Operações com datas e horas - Retorna um novo
                Console.WriteLine(d2.AddMonths(1));

                //Para subtrair passe um número negativo
                Console.WriteLine(d2.AddMonths(-5));

                /**TimeSpan representa um intervalo de tempo que depois posso adicionar ou subtrair em uma data, neste caso o construtor é hora minuto e segundo
                    Para adicioar use o método Add
                **/
                TimeSpan intervalo = new TimeSpan(3, 25, 10);
                DateTime newDate = now.Add(intervalo);
                Console.WriteLine(newDate.ToString());

                //Também temos o método subtract que serve para subtrair um timeSpan
                DateTime subtractedDate = now.Subtract(intervalo);
                Console.WriteLine(subtractedDate.ToString());
            }
    }
}

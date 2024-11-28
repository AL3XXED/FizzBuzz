namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Erstellen Sie einen Algorithmus der das Spiel FizzBuzz bis zur 100 durchführt.
            //Regeln siehe https://de.wikipedia.org/wiki/Fizz_buzz.

            //Modulo gibt uns den Rest einer Division als Ganzzahl zurück. Das Zeichen für den Operanten ist %
            //Beispiel: 4 % 2 = 0

            for ( int i = 1; i <= 100;  i++ ) 
            {
                Thread.Sleep( 500 );

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"{i}-FizzBuzz");
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i}-Buzz");
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine($"{i}-Fizz");
                }

                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

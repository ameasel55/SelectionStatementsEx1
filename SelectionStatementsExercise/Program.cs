namespace SelectionStatementsExercise;
class Program
{
    static void Main(string[] args)
    {
        
        var r = new Random();
        var favNumber = r.Next(1,1000);

        while (true)
        {



            Console.WriteLine("Try to guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("Nope,too low");
                
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Nope,too high");
                
            }
            else
            {
                Console.WriteLine("OMG you got it!!!! " +
                    "That IS my favorite number");
                break;
            }

        }
    }
}


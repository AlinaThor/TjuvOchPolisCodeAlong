namespace CodeAloneTjuvOchPolis
{
    internal class Program
    {
        static List<Person> persons = new List<Person>()
        {
            new Person(), new Person(), new Person(), new Person(),
        };
        static void Main(string[] args)
        {
            RenderGameBoard();

           



            Console.ReadLine();
        }

        private static void RenderGameBoard()
        {
            
            for (int y = 0; y <= 27; y++)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                for (int x = 0; x <= 102; x++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    if (y == 0 || y == 27)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        if (x == 0 || x == 102)
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            foreach(Person p in persons)
                            {
                                if (p.PositionX == x && p.PositionY == y)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write("C");
                                }
                               
                            }
                           
                                
                        }

                    }

                }
                Console.WriteLine();
                
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

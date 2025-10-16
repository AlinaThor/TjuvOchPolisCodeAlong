namespace CodeAloneTjuvOchPolis
{
    internal class Program
    {
        static List<Person> persons = new List<Person>()
        {
            new Person(), new Person(), new Person(){PositionX = 5, PositionY = 5}, new Person(){PositionX = 5, PositionY = 5},
        };

        static List<Person> thiefs = new List<Person>()
        {
            new Person(), new Person(), new Person(){PositionX = 5, PositionY = 5}, new Person(){PositionX = 5, PositionY = 5},
        };

        static List<Person> cops = new List<Person>()
        {
            new Person(), new Person(), new Person(){PositionX = 5, PositionY = 5}, new Person(){PositionX = 5, PositionY = 5},
        };

        static List<string> events = new List<string>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                //events = new List<string>();
                events.Clear();
                RenderGameBoard();

                foreach (string eventText in events)
                {
                    Console.WriteLine(eventText);
                }

                Thread.Sleep(1000);


                //Hitta nya positioner
                foreach (Person p in persons)
                {

                    p.SetNewLocation();

                }

                foreach (Person p in thiefs)
                {
                    p.SetNewLocation();

                }

                foreach (Person p in cops)
                {
                    p.SetNewLocation();

                }
            }

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
                            int foundCharacters = 0;
                            bool foundOnePerson =  false;
                            bool foundOneTheif = false;
                            bool foundOneCop = false;
                            foreach(Person p in persons)
                            {
                                if (p.PositionX == x && p.PositionY == y)
                                {
                                    foundOnePerson = true;
                                    foundCharacters++;
                                    
                                    //Console.Write(" ");
                                }
                               
                            }

                            foreach (Person p in thiefs)
                            {
                                if (p.PositionX == x && p.PositionY == y)
                                {
                                    foundOneTheif = true;
                                    foundCharacters++;

                                    //Console.Write(" ");
                                }

                            }

                            foreach (Person p in cops)
                            {
                                if (p.PositionX == x && p.PositionY == y)
                                {
                                    foundOneCop = true;
                                    foundCharacters++;

                                    //Console.Write(" ");
                                }

                            }

                            if (foundCharacters == 0)
                            {
                                Console.Write(" ");
                            }
                            else
                            {
                                
                                if (foundCharacters > 1)
                                {
                                    //här har vi flera karraktärer på samma plats - Explotion
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("¤");
                                    
                                    events.Add($"¤ = {foundCharacters} karaktärer är på samma plats");
                                }
                                else
                                {
                                    if (foundOnePerson)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.Write("C");
                                    }
                                    else if (foundOneTheif)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Magenta;
                                        Console.Write("T");
                                    }
                                    else if(foundOneCop)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.Write("P");
                                    }
                                    
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

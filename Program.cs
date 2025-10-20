﻿using System.Security.Cryptography.X509Certificates;

namespace CodeAloneTjuvOchPolis
{
    internal class Program
    {
        static List<Citizen> citizens = new List<Citizen>();

        static List<Thief> thiefs = new List<Thief>();

        static List<Cop> Cops = new List<Cop>();
        

        static List<string> events = new List<string>();
        static void Main(string[] args)
        {
           //Text - välkommen till tjuv och polis
            Console.WriteLine("Welcome to Thief and Cop");

            

           var numberOfCharacters = int.Parse(Console.ReadLine());

            for (var i = 0; i < numberOfCharacters; i++)
            {
                citizens.Add(new Citizen());
                thiefs.Add(new Thief());
                Cops.Add(new Cop());
            }

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
                foreach (Citizen p in citizens)
                {
                    
                    p.SetNewLocation();

                }

                foreach (Thief thief in thiefs)
                {
                    if (!thief.Arrested)
                    {
                        thief.SetNewLocation();
                    }
                   

                }

                foreach (Cop cop in Cops)
                {
                    cop.SetNewLocation();

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
                            foreach(var citizen in citizens)
                            {
                                if (citizen.PositionX == x && citizen.PositionY == y)
                                {
                                    foundOnePerson = true;
                                    foundCharacters++;
                                    
                                }
                               
                            }

                            foreach (var thief in thiefs.Where(t => ! t.Arrested))
                            {
                                if (thief.PositionX == x && thief.PositionY == y)
                                {
                                    foundOneTheif = true;
                                    foundCharacters++;

                                    //Console.Write(" ");
                                }

                            }

                            foreach (var cop in Cops)
                            {
                                if (cop.PositionX == x && cop.PositionY == y)
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

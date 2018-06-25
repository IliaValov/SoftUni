using System;

namespace ConsoleGame
{
    class Program
    {
        private static string playerName1;
        private static string playerName2;
        //Health and Energy
        private static double player1Health = 10;
        private static double player1MaxHealth = 10;
        private static double player1Energy = 10;
        private static double player1MaxEnergy = 10;
        
         
        private static double player2Health = 10;
        private static double player2MaxHealth = 10;
        private static double player2Energy = 10;
        private static double player2MaxEnergy = 10;

        private static string weapon1;
        private static string weapon2;

        static void Main()
        {
            //Names
            Console.WriteLine("Player1 pick name: ");
            playerName1 = Console.ReadLine();
            Console.WriteLine("Player2 pick name: ");
            playerName2 = Console.ReadLine();


            //Weapons
            Console.WriteLine("Pick up weapon: \r\n Sword, Spear, Bow");
            Console.WriteLine($"Player1:{playerName1}");
            weapon1 = Console.ReadLine();


            Console.WriteLine($"Player2:{playerName2}");
            weapon2 = Console.ReadLine();

            double sword = 2;
            double swordEnergyCost = 2;

            double spear = 1;
            double spearEnergyCost = 1;

            double Bow = 0;

            double weaponDmgForPlayer1 = 0;
            double weaponEnergyCostForPlayer1 = 0;

            double weaponEnergyCostForPlayer2 = 0;
            double weaponDmgForPlayer2 = 0;


            //WeaponDmgForPlayer1
            if (weapon1.Equals("Sword", StringComparison.InvariantCultureIgnoreCase))
            {
                weaponDmgForPlayer1 = sword;
                weaponEnergyCostForPlayer1 = swordEnergyCost;

            }
            else if (weapon1.Equals("Spear",StringComparison.InvariantCultureIgnoreCase))
            {
                weaponDmgForPlayer1 = spear;
                weaponEnergyCostForPlayer1 = spearEnergyCost;
            }



            //WeaponDmgForPlayer2
            if (weapon2.Equals("Sword", StringComparison.InvariantCultureIgnoreCase))
            {
                weaponDmgForPlayer2 = sword;
                weaponEnergyCostForPlayer2 = swordEnergyCost;

            }
            else if (weapon2.Equals("Spear", StringComparison.InvariantCultureIgnoreCase))
            {
                weaponDmgForPlayer2 = spear;
                weaponEnergyCostForPlayer2 = spearEnergyCost;
            }

            //Fighting
            bool winner = true;
            while (winner)
            {
               
                //FightStuff
                Console.WriteLine("Player1: Atack or Defend");
                string choiceForMove = Console.ReadLine();
                if (choiceForMove.Equals("Atack",StringComparison.InvariantCultureIgnoreCase))
                {

                    player2Health -= weaponDmgForPlayer1;
                    player1Energy -= weaponEnergyCostForPlayer1;

                    RunAttack();
                    
                    if (player1Energy <= 0)
                    {
                        Console.WriteLine("Sorry not enough energy");
                        player2Health += weaponDmgForPlayer1;
                        player1Energy += weaponEnergyCostForPlayer1;
                        RunAttack();
                    }
                   
                }
                else if (choiceForMove.Equals("Defend",StringComparison.InvariantCultureIgnoreCase))
                {
                    if (player1Health < 10)
                    {
                        player1Health++;
                        RunAttack();

                    }
                    else if (player1Health >= 10)
                    {
                        Console.WriteLine("You reach your maximum health point do another choice:");
                        bool forChoicesBellow = true;
                        while (forChoicesBellow)
                        {
                            string choiceForAtack = Console.ReadLine();
                            if (choiceForMove.Equals("Atack", StringComparison.InvariantCultureIgnoreCase))
                            {

                                player2Health -= weaponDmgForPlayer1;
                                player1Energy -= weaponEnergyCostForPlayer2;

                                RunAttack();

                                if (player1Energy <= 0)
                                {
                                    Console.WriteLine("Sorry not enough energy");
                                    player2Health += weaponDmgForPlayer1;
                                    player1Energy += weaponEnergyCostForPlayer1;

                                    RunAttack();
                                }

                                
                                forChoicesBellow = false;
                            }
                            else
                            {

                            }
                        }
                    }
                }


                //Player2
                Console.WriteLine("Player2: Atack or Defend");
                string choiceForMove2 = Console.ReadLine();
                if (choiceForMove.Equals("Atack", StringComparison.InvariantCultureIgnoreCase))
                {

                    player1Health -= weaponDmgForPlayer2;
                    player2Energy -= weaponEnergyCostForPlayer2;
                    RunAttack();


                    if (player2Energy <= 0)
                    {
                        Console.WriteLine("Sorry not enough energy");
                        player1Health += weaponDmgForPlayer2;
                        player2Energy += weaponEnergyCostForPlayer2;
                        RunAttack();
                    }
                    
                }
                else if (choiceForMove2.Equals("Defend",StringComparison.InvariantCultureIgnoreCase))
                {
                    if (player2Health < 10)
                    {
                        player2Health++;
                        Console.WriteLine($"{player1Health},{player2Health}");
                        RunAttack();
                    }
                    else if (player2Health >= 10)
                    {
                        Console.WriteLine("You reach your maximum health point do another choice:");
                        bool forChoicesBellow2 = true;
                        while (forChoicesBellow2)
                        {
                            string choiceForAtack3 = Console.ReadLine();
                            if (choiceForMove.Equals("Atack", StringComparison.InvariantCultureIgnoreCase))
                            {

                                player1Health -= weaponDmgForPlayer2;
                                player2Energy -= weaponEnergyCostForPlayer2;
                                RunAttack();

                                if (player2Energy <= 0)
                                {
                                    Console.WriteLine("Sorry not enough energy");
                                    player1Health += weaponDmgForPlayer2;
                                    player2Energy += weaponEnergyCostForPlayer2;
                                    RunAttack();
                                }
                                
                                forChoicesBellow2 = false;
                            }
                            else
                            {

                            }
                        }
                    }
                }



                if (player1Health == 0 || player2Health == 0)
                    {
                        if (player1Health == 0)
                        {
                            Console.WriteLine("Player2 Wins");
                            winner = false;
                        }
                        else if (player2Health == 0)
                        {
                            Console.WriteLine("Player1 Wins");
                            winner = false;
                        }
                }
                    Console.WriteLine();
                
            }
        }

        private static void RunAttack()
        {
            //Player1 Health 
            Console.Write($"Player1:{playerName1} Health Points: |" + new string('|', (int)player1Health) +
                new string('.', (int)player1MaxHealth - (int)player1Health) + "|" + new string(' ', 5));

            //Player2 Health
            Console.WriteLine($"Player2:{playerName2} Health Points: |" + new string('|', (int)player2Health) +
                new string('.', (int)player2MaxHealth - (int)player2Health) + "|");

            //Energy
            //Player1 Energy
            Console.Write($"Player1:{playerName1} Energy Points: |" + new string('|', (int)player1Energy) +
                new string('.', (int)player1MaxEnergy - (int)player1Energy) + "|" + new string(' ', 5));


            //Play2 energy
            Console.WriteLine($"Player2:{playerName2} Energy Points: |" + new string('|', (int)player2Energy) +
                new string('.', (int)player2MaxEnergy - (int)player2Energy) + "|");

            Console.WriteLine($"Player1 weapon {weapon1}");
            Console.WriteLine($"Player2 weapon {weapon2}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }

}

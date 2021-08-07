using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2

    {
        class Program
        {
            static void Main(string[] args)
            {
                //Start the fight
                StartFight();
                //Wait for user input to end program
                Console.ReadLine();
            }

            //game start method
            public static void StartFight()
            {
                //instantiate player and dragon
                Player player = new Player(100, new Sword(15), new Bow(8));
                Dragon dragon = new Dragon(100, 10);

                //start the fight
                bool playerTurn = true;
                int playerChoice;
                //show options to user if player and dragon are alive
                while (player.Health > 0 && dragon.Health > 0)
                {
                    //player's turn
                    if (playerTurn)
                    {
                        //show your health
                        Console.WriteLine("Your Health: " + player.Health);
                        //show dragon's health
                        Console.WriteLine("Dragon's Health: " + dragon.Health);
                        //show options
                        Console.WriteLine("\nWhat will you do?");
                        Console.WriteLine("1 - Attack with Sword");
                        Console.WriteLine("2 - Attack with Bow");
                        //get the player's choice
                        playerChoice = Convert.ToInt32(Console.ReadLine());
                        if (playerChoice == 1)
                        {
                            //attack with sword, target dragon
                            player.AttackWith(player.Sword, dragon);
                            //end the player's turn
                            playerTurn = EndTurn(playerTurn);
                        }
                        else if (playerChoice == 2)
                        {
                            //attack with bow, target dragon
                            player.AttackWith(player.Bow, dragon);
                            //end the player's turn
                            playerTurn = EndTurn(playerTurn);
                        }
                    }
                    //dragon's turn
                    if (!playerTurn)
                    {
                        if (dragon.Health > 0)
                        {
                            //attack player
                            dragon.Attack(dragon, player);
                            playerTurn = BeginTurn(playerTurn);
                        }
                    }
                }
                //if player is still alive, display winning message
                if (player.Health > 0 || player.Health > 0 && dragon.Health > 0)
                {
                    Console.WriteLine("\nCongratulations! You have defeated the dragon!");
                }
                //else if dragon is alive display losing message
                else if (dragon.Health > 0)
                {
                    Console.WriteLine("\nGame over. You have been defeated by the dragon!");
                }
            }

            //utility methods
            public static bool EndTurn(bool playerTurn)
            {
                return playerTurn = false;
            }
            public static bool BeginTurn(bool playerTurn)
            {
                return playerTurn = true;
            }
        }
        //characters
        class Player
        {
            public int Health { get; set; }
            public Sword Sword { get; set; }
            public Bow Bow { get; set; }

            public Player(int health, Sword sword, Bow bow)
            {
                this.Health = health;
                this.Sword = sword;
                this.Bow = bow;
            }

            public void AttackWith(Sword sword, Dragon dragon)
            {
                Console.WriteLine("\nYou Attack The Dragon!\nYou swing your sword at the dragon and inflict " + sword.Attack + " points of damage!\n");
                dragon.Health -= sword.Attack;

            }

            public void AttackWith(Bow bow, Dragon dragon)
            {
                Console.WriteLine("\nYou Attack The Dragon!\nYou shoot an arrow at the dragon and inflict " + bow.Attack + " points of damage!\n");
                dragon.Health -= bow.Attack;
            }
        }
        class Dragon
        {
            public int Health { get; set; }
            public int AttackPower { get; set; }

            public Dragon(int health, int attackPower)
            {
                this.Health = health;
                this.AttackPower = attackPower;
            }

            public void Attack(Dragon dragon, Player player)
            {
                Console.WriteLine("\nThe Dragon Attacks You!\nThe Dragon swings its claw at you and inflicts " + dragon.AttackPower + " points of damage!\n");
                player.Health -= dragon.AttackPower;
            }

        }
        //items
        class Sword
        {
            public int Attack { get; set; }

            public Sword(int attack)
            {
                this.Attack = attack;
            }

            public void ShowStats()
            {
                Console.WriteLine("Your sword's base attack power is: " + this.Attack);
            }
        }
        class Bow
        {
            public int Attack { get; set; }

            public Bow(int attack)
            {
                this.Attack = attack;
            }

            public void ShowStats()
            {
                Console.WriteLine("Your bow's base attack power is: " + this.Attack);
            }
        }
    }

    


using System;

namespace Ls10
{
    class Field 
    {
        public int[,] WarField { get; set; }
    }
    class Ship{
        public int ShipLength { get; set; }
        public int ShipPartsAlive { get; set; }
        public bool IsShipAlive { get; set; }
    }

    class Player {
        public string PlayerName { get; set; }
        public Field PlayerField { get; set; }
        public Field EnemyField { get; set; }
        public Ship[] Ships { get; set; }

        public Player(int n)
        {
            this.PlayerField = new Field();
            this.PlayerField.WarField = new int[n, n];
            this.EnemyField = new Field();
            this.EnemyField.WarField = new int[n, n];
        }

        public void ShowMyField(){}
        public void EnemyMyField() { }

        public void PlaceShips() {
            for (int i = 0; i < this.Ships.Length; i++)
            {
                int choseDirection = 0;
                bool choseCheck = true;
                if (Ships[i].ShipLength > 1)
                {
                    do
                    {
                        Console.Clear();
                        if (!choseCheck) { }
                        Console.WriteLine("Chose ship orientation vertical(1) or horyzontal(2)");
                        choseCheck = int.TryParse(Console.ReadLine(), out choseDirection);
                        if (choseDirection < 1 || choseDirection > 2) 
                        {
                            choseCheck = false;
                        }
                    } while (!choseCheck);
                }
                int pointX = 0;
                int pointY = 0;

                bool placeChk = false;
                do {
                    Console.Clear();
                    if (!choseCheck) { }
                    Console.WriteLine("Chose ship orientation vertical(1) or horyzontal(2)");
                    choseCheck = int.TryParse(Console.ReadLine(), out choseDirection);
                    if (choseDirection < 1 || choseDirection > 2)
                    {
                        choseCheck = false;
                    }
                } while (!placeChk);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

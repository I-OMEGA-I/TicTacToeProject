using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.Abstraction.Player;

namespace TicTacToe.Implementation.Player
{
    class PlayerTwo : IPlayer
    {
        public char Character { get; } = 'O';

        public bool NextStep { get; set; } = false;

        private PlayerTwo()
        {

        }
        private static PlayerTwo Instance = null; 

        private static object root = new object();

        public static PlayerTwo GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    lock (root)
                    {
                        if (Instance == null)
                        {
                            Instance = new PlayerTwo();
                        }
                    }
                }
                return Instance;

            }
        }
    }
}

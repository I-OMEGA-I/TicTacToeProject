using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.Abstraction.Player;

namespace TicTacToe.Implementation.Player
{
    class PlayerOne : IPlayer
    {
        public char Character { get; } = 'X';
        public bool NextStep { get; set; } = true;

        private PlayerOne()
        {

        }

        private static PlayerOne Instance = null;

        private static object root = new object();

        public static PlayerOne GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    lock (root)
                    {
                        if (Instance == null)
                        {
                            Instance = new PlayerOne();
                        }
                    }
                }
                return Instance;

            }
        }

        
    }
}

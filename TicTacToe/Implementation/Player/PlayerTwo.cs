using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.Abstraction.Player;

namespace TicTacToe.Implementation.Player
{
    class PlayerTwo : IPlayer
    {
        public char Character { get; } = 'O';
    }
}

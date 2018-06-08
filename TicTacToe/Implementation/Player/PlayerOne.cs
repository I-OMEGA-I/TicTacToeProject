using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.Abstraction.Player;

namespace TicTacToe.Implementation.Player
{
    class PlayerOne : IPlayer
    {
        public char Character { get; } = 'X';
    }
}

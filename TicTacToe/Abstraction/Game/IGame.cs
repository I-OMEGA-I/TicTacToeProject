using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.Abstraction.Player;

namespace TicTacToe.Abstraction.Game
{
    interface IGame
    {
        IPlayer Winner { get; set; }
        IPlayer Loser { get; set; }
    }
}

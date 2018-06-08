using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.Abstraction.Player;

namespace TicTacToe.Abstraction.Logic
{
    interface IGameLogic
    {
        void StartGame(IPlayer PlayerOne, IPlayer PlayerTwo);
        IPlayer ChooseWinner();

        void MakeStep(IPlayer Player, int Pos);
    }
}

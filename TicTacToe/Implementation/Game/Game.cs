using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.Abstraction.Game;
using TicTacToe.Abstraction.Logic;
using TicTacToe.Abstraction.Player;

namespace TicTacToe.Implementation.Game
{
    class Game : IGame, IGameLogic
    {

        Dictionary<int, char> Board = new Dictionary<int, char>();

        public IPlayer Winner { get; set; }
        public IPlayer Loser { get; set; }
        

        public IPlayer ChooseWinner()
        {
            return null;
        }

        public void MakeStep(IPlayer Player)
        {
            
        }

        public void StartGame(IPlayer PlayerOne, IPlayer PlayerTwo)
        {
            
        }
        private void StepPermission(IPlayer player)
        {


        }

    }

    
}

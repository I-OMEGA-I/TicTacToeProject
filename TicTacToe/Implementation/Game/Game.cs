using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TicTacToe.Abstraction.Game;
using TicTacToe.Abstraction.Logic;
using TicTacToe.Abstraction.Player;

namespace TicTacToe.Implementation.Game
{
    class Game : IGame, IGameLogic
    {

        Dictionary<int, char> Board = new Dictionary<int, char>();

        private Game()
        {
            PlayerStepPermission = StepPermission;
        }

        private static Game Instance = null;
        private static object root = new object();

        public IPlayer Winner { get; set; }
        public IPlayer Loser { get; set; }

        private Action<IPlayer> PlayerStepPermission;
        
        public static Game GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    lock (root)
                    {
                        if (Instance == null)
                        {
                            Instance = new Game();
                        }
                    }
                }

                return Instance;
            }
        }

        private static int stepCount { get; set; } = 0;

        public IPlayer ChooseWinner()
        {
            return null;
        }

        public void MakeStep(IPlayer Player, int Pos)
        {
            if (!(Board.ContainsKey(Pos)) && Player.NextStep == true)
                Board.Add(Pos, Player.Character);
            else
                throw new Exception($"You can't place {Player.Character} in this place.");

            PlayerStepPermission.Invoke(Player);
            stepCount++;
        }

        public void StartGame(IPlayer PlayerOne, IPlayer PlayerTwo)
        {
            
        }
        private void StepPermission(IPlayer player)
        {
            if (player.NextStep == true)
                player.NextStep = false;
        }

        private void CheckCombo(IPlayer player)
        {
            var playerList = Board.Where(o => o.Value == player.Character).ToDictionary(p => p.Key, c => c.Value);

        }

    }

    
}

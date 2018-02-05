using MathGame.Game;
using MathGame.Model;
using MathGame.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Game
{
    class ChooseGameViewModel : BaseViewModel
    {
        public RelayCommand<string> ChooseGameCommand { get; private set; }

        public event Action<string> StartGameRequested = delegate { };
        public event Action ExitGameRequested = delegate { };

        /// <summary>
        /// Constructor
        /// </summary>
        public ChooseGameViewModel()
        {
            ChooseGameCommand = new RelayCommand<string>(OnChooseGame);
        }

        private void OnChooseGame(string game)
        {
            switch (game)
            {
                case "+":
                    StartGameRequested("+");
                    break;
                case "-":
                    StartGameRequested("-");
                    break;
                case "*":
                    StartGameRequested("*");
                    break;
                case "/":
                    StartGameRequested("/");
                    break;

            }
        }
    }
}

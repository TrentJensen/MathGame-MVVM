using MathGame.Game;
using MathGame.Model;
using MathGame.Players;
<<<<<<< HEAD
using MathGame.Scores;
=======
>>>>>>> 80ce56c67b33c8237d3d9cd8796ffabd6214e0f4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace MathGame
{
    class MainWindowViewModel : BaseViewModel
    {
        private GameViewModel _gameViewModel;
        private PlayerListViewModel _playerListViewModel;
        private AddEditViewModel _addEditViewModel;
        private ChooseGameViewModel _chooseGameViewModel = new ChooseGameViewModel();
<<<<<<< HEAD
        private ScoreViewModel _scoreViewModel;
=======
>>>>>>> 80ce56c67b33c8237d3d9cd8796ffabd6214e0f4

        private BaseViewModel _CurrentViewModel;

        public BaseViewModel CurrentViewModel
        {
            get { return _CurrentViewModel; }
            set { SetProperty(ref _CurrentViewModel, value); }
        }

        private string _playerName;

        public string PlayerName
        {
            get { return _playerName; }
            set { SetProperty(ref _playerName, value); }
        }

        public RelayCommand<string> NavCommand { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public MainWindowViewModel()
        {
<<<<<<< HEAD
            NavCommand = new RelayCommand<string>(OnNav, CanOnNav);
=======
            NavCommand = new RelayCommand<string>(OnNav);
>>>>>>> 80ce56c67b33c8237d3d9cd8796ffabd6214e0f4

            _playerListViewModel = ContainerHelper.Container.Resolve<PlayerListViewModel>();
            _addEditViewModel = ContainerHelper.Container.Resolve<AddEditViewModel>();
            _gameViewModel = ContainerHelper.Container.Resolve<GameViewModel>();
<<<<<<< HEAD
            _scoreViewModel = ContainerHelper.Container.Resolve<ScoreViewModel>();
=======
>>>>>>> 80ce56c67b33c8237d3d9cd8796ffabd6214e0f4

            _playerListViewModel.AddPlayerRequested += AddPlayer;
            _playerListViewModel.EditPlayerRequested += EditPlayer;
            _playerListViewModel.ReturnSelectedPlayer += CreateCurrentPlayer;
            _addEditViewModel.Done += NavToPlayerList;
            _chooseGameViewModel.StartGameRequested += StartGame;
        }

        private void CreateCurrentPlayer(Player player)
        {
            _gameViewModel.SetCurrentPlayer(player);
            PlayerName = player.FirstName;
            CurrentViewModel = null;
        }

        private void StartGame(string operation)
        {
            _gameViewModel.SetOperation(operation);
            CurrentViewModel = _gameViewModel;
        }

        private void NavToPlayerList()
        {
            CurrentViewModel = _playerListViewModel;
        }

        private void AddPlayer(Player player)
        {
            _addEditViewModel.EditMode = false;
            _addEditViewModel.SetPlayer(player);
            CurrentViewModel = _addEditViewModel;
        }

        private void EditPlayer(Player player)
        {
            _addEditViewModel.EditMode = true;
            _addEditViewModel.SetPlayer(player);
            CurrentViewModel = _addEditViewModel;
        }

        private void OnNav(string destination)
        {
            switch (destination)
            {
                case "game":
                    CurrentViewModel = _chooseGameViewModel;
                    break;
                case "player":
                    CurrentViewModel = _playerListViewModel;
                    break;
<<<<<<< HEAD
                case "score":
                    CurrentViewModel = _scoreViewModel;
                    break;
            }
        }

        private bool CanOnNav(string arg)
        {
            return true;
        }
=======
            }
        }
>>>>>>> 80ce56c67b33c8237d3d9cd8796ffabd6214e0f4
    }
}

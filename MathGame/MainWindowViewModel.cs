using MathGame.Game;
using MathGame.Model;
using MathGame.Players;
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
            NavCommand = new RelayCommand<string>(OnNav);

            _playerListViewModel = ContainerHelper.Container.Resolve<PlayerListViewModel>();
            _addEditViewModel = ContainerHelper.Container.Resolve<AddEditViewModel>();
            _gameViewModel = ContainerHelper.Container.Resolve<GameViewModel>();

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
            }
        }
    }
}

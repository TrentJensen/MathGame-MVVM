using MathGame.Model;
using MathGame.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Players
{
    public class PlayerListViewModel : BaseViewModel
    {
        private IPlayerRepository _repo;
        public RelayCommand<Player> EditPlayerCommand { get; private set; }
        public RelayCommand AddPlayerCommand { get; private set; }
        public RelayCommand ContinueCommand { get; private set; }

        public event Action<Player> EditPlayerRequested = delegate { };
        public event Action<Player> AddPlayerRequested = delegate { };
        public event Action<Player> ReturnSelectedPlayer = delegate { };

        private ObservableCollection<Player> _players;

        public ObservableCollection<Player> Players
        {
            get { return _players; }
            set { SetProperty(ref _players, value); }
        }

        private Player _selectedPlayer;

        public Player SelectedPlayer
        {
            get { return _selectedPlayer; }
<<<<<<< HEAD
            set
            {
                SetProperty(ref _selectedPlayer, value);

            }
=======
            set { SetProperty(ref _selectedPlayer, value); }
>>>>>>> 80ce56c67b33c8237d3d9cd8796ffabd6214e0f4
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public PlayerListViewModel(IPlayerRepository repo)
        {
            _repo = repo;
            EditPlayerCommand = new RelayCommand<Player>(OnEditPlayer);
            AddPlayerCommand = new RelayCommand(OnAddPlayer);
            ContinueCommand = new RelayCommand(OnContinue, CanContinue);
        }

        private void OnContinue()
        {
            ReturnSelectedPlayer(SelectedPlayer);
        }

        private bool CanContinue()
        {
            if (SelectedPlayer != null)
                return true;
            return false;
        }

<<<<<<< HEAD
        public void CheckCanContinue()
        {
            CanContinue();
        }

=======
>>>>>>> 80ce56c67b33c8237d3d9cd8796ffabd6214e0f4
        private void OnAddPlayer()
        {
            AddPlayerRequested(new Player { });
            //AddPlayerRequestes(new Player {Id = Guid.NewGuid() });

        }

        private void OnEditPlayer(Player player)
        {
            EditPlayerRequested(player);
        }

        public async void LoadPlayers()
        {
            Players = new ObservableCollection<Player>(
                await _repo.GetAllAsync());
        }
    }
}

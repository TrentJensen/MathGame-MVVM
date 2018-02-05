using MathGame.Model;
using MathGame.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Scores
{
    class ScoreViewModel : BaseViewModel
    {
        private IPlayerRepository _repo;

        private ObservableCollection<Player> _players;

        public ObservableCollection<Player> Players
        {
            get { return _players; }
            set { SetProperty(ref _players, value); }
        }

        public ScoreViewModel(IPlayerRepository repo)
        {
            _repo = repo;
        }

        public async void LoadPlayers()
        {
            Players = new ObservableCollection<Player>(
                await _repo.GetAllAsync());
        }
    }
}

using MathGame.Model;
using MathGame.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Players
{
    public class AddEditViewModel : BaseViewModel
    {
        private bool _EditMode;
        private IPlayerRepository _repo;

        public RelayCommand SavePlayerCommand { get; private set; }
        public RelayCommand CancelPlayerCommand { get; private set; }

        public event Action Done = delegate { };

        private Player _editingPlayer = null;

        public AddEditViewModel(IPlayerRepository repo)
        {
            _repo = repo;
            SavePlayerCommand = new RelayCommand(OnSave, CanSave);
            CancelPlayerCommand = new RelayCommand(OnCancel);
        }

        private async void OnSave()
        {
            UpdatePlayer(Player, _editingPlayer);
            if (EditMode)
                await _repo.UpdatePlayerAsync(_editingPlayer);
            else
                await _repo.AddPlayerAsync(_editingPlayer);
            Done();
        }

        private void UpdatePlayer(SimplePlayer source, Player target)
        {
            target.FirstName = source.FirstName;
            target.LastName = source.LastName;
        }

        private bool CanSave()
        {
            return !Player.HasErrors;
        }

        private void OnCancel()
        {
            Done();
        }

        public bool EditMode
        {
            get { return _EditMode; }
            set { SetProperty(ref _EditMode, value); }
        }

        private SimplePlayer _player;

        public SimplePlayer Player
        {
            get { return _player; }
            set { _player = value; }
        }



        public void SetPlayer(Player player)
        {
            _editingPlayer = player;
            if (Player != null) Player.ErrorsChanged -= RaiseCanExecuteChanged;
            Player = new SimplePlayer();
            Player.ErrorsChanged += RaiseCanExecuteChanged;
            CopyPlayer(player, Player);
        }

        private void RaiseCanExecuteChanged(object sender, DataErrorsChangedEventArgs e)
        {
            SavePlayerCommand.RaiseCanExecuteChanged();
        }

        private void CopyPlayer(Player source, SimplePlayer target)
        {
            target.Id = source.Id;
            if (EditMode)
            {
                target.FirstName = source.FirstName;
                target.LastName = source.LastName;
            }
        }
    }
}

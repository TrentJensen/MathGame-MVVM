using System.Collections.Generic;
using System.Threading.Tasks;
using MathGame.Model;

namespace MathGame.Services
{
    public interface IPlayerRepository
    {
        Task<List<Player>> GetAllAsync();
        Task<Player> AddPlayerAsync(Player Player);
        Task<Player> UpdatePlayerAsync(Player Player);
    }
}
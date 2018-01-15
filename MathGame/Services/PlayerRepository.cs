using MathGame.Data;
using MathGame.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MathGame.Services
{
    public class PlayerRepository : IPlayerRepository
    {
        MathGameDbContext _context = new MathGameDbContext();

        public Task<List<Player>> GetAllAsync()
        {
            return _context.Players.ToListAsync();
        }

        public async Task<Player> AddPlayerAsync(Player Player)
        {
            _context.Players.Add(Player);
            await _context.SaveChangesAsync();
            return Player;
        }

        public async Task<Player> UpdatePlayerAsync(Player Player)
        {
            if (!_context.Players.Local.Any(c => c.Id == Player.Id))
            {
                _context.Players.Attach(Player);
            }
            _context.Entry(Player).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Player;

        }
    }
}

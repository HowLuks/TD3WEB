using Microsoft.EntityFrameworkCore;
using GameManagementAPI.Models;

namespace GameManagementAPI.Data
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; } = null!;
    }
}

